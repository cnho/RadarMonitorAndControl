using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace SerialPortComm
{
    /// <summary>
    /// 串口操作类
    /// </summary>
    public sealed class SerialPortOperate
    {
        /// <summary>
        /// 返回接收到的数据委托
        /// </summary>
        /// <param name="message">The message.</param>
        public delegate void ReturnMessage(byte[] message);

        /// <summary>
        /// The _buffer
        /// </summary>
        private readonly List<byte> _buffer = new List<byte>();

        /// <summary>
        /// The _serial port
        /// </summary>
        private readonly SerialPort _serialPort = new SerialPort();

        /// <summary>
        /// The _closing
        /// </summary>
        private bool _closing;

        /// <summary>
        /// The _isopen
        /// </summary>
        private bool _isopen;

        /// <summary>
        /// The _listening
        /// </summary>
        private bool _listening;

        public bool IsReading { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerialPortOperate" /> class.
        /// </summary>
        /// <param name="portName">Name of the port.</param>
        /// <param name="baudRate">The baud rate.</param>
        /// <param name="dataBits">The data bits.</param>
        /// <param name="stopBits">The stop bits.</param>
        /// <param name="parity">The parity.</param>
        public SerialPortOperate(string portName, int baudRate, int dataBits, string stopBits, string parity)
        {
            _serialPort.PortName = portName;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.DataBits = dataBits;
            switch (stopBits)
            {
                case "0":
                    _serialPort.StopBits = StopBits.None; break;
                case "1":
                    _serialPort.StopBits = StopBits.One; break;
                case "1.5":
                    _serialPort.StopBits = StopBits.OnePointFive; break;
                case "2":
                    _serialPort.StopBits = StopBits.Two; break;
                default:
                    _serialPort.StopBits = StopBits.One; break;
            }
            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parity, true);
            _serialPort.NewLine = "\r\n";
            _serialPort.Encoding = Encoding.GetEncoding("GB18030");
            //_serialPort.DataReceived += _serialPort_DataReceived;
            //_serialPort.ErrorReceived += _serialPort_ErrorReceived;
        }

        /// <summary>
        /// 返回接收到的数据事件.
        /// </summary>
        public event ReturnMessage ReturnCollectorRecData;

        /// <summary>
        /// 关闭串口.
        /// </summary>
        public void ClosePort()
        {
            //根据当前串口对象，来判断操作
            if (!_isopen) return;
            _closing = true;
            while (_listening)
            {
                SpinWait.SpinUntil(() => !_listening, 1);
            }
            _serialPort.Close();
            _closing = false;
            _buffer.Clear();
            _isopen = _serialPort.IsOpen;
        }

        /// <summary>
        /// 打开串口.
        /// </summary>
        public void OpenPort()
        {
            _serialPort.Open();
            _isopen = _serialPort.IsOpen;
        }

        /// <summary>
        /// S发送指令.
        /// </summary>
        /// <param name="cmdString">The command string.</param>
        public void SendCommand(string cmdString)
        {
            try
            {
                if (!_isopen)
                {
                    throw new Exception(string.Format("串口{0}未打开", _serialPort.PortName));
                }
                if (IsReading)
                {
                    throw new Exception("正在处理上一条数据，请稍后发送命令");
                }
                string[] cmdStrings = cmdString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                byte[] buf = cmdStrings.Select(s1 => Convert.ToByte(s1, 16)).ToArray();
                _serialPort.Write(buf, 0, buf.Length);
                IsReading = true;
                _serialPort_DataReceived();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 发送指令.
        /// </summary>
        /// <param name="cmdBytes">The command bytes.</param>
        public void SendCommand(byte[] cmdBytes)
        {
            try
            {
                if (!_isopen)
                {
                    throw new Exception(string.Format("串口{0}未打开", _serialPort.PortName));
                }
                if (IsReading)
                {
                    throw new Exception("正在处理上一条数据，请稍后发送命令");
                }
                _serialPort.Write(cmdBytes.ToArray(), 0, cmdBytes.Length);
                IsReading = true;
                _serialPort_DataReceived();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the DataReceived event of the _serialPort control.
        /// </summary>
        private void _serialPort_DataReceived()//object sender, SerialDataReceivedEventArgs e
        {
            if (_closing) return; //如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环
            try
            {
                int nStartTime = Environment.TickCount;
                while (IsReading)
                {
                    int nNowTime = Environment.TickCount;
                    int s = nNowTime - nStartTime;
                    if (s > 1000) //等待1000ms
                    {
                        //_serialPort.DiscardInBuffer();
                        //_serialPort.DiscardOutBuffer();
                        IsReading = false;
                        throw new Exception("等待接收数据超时");
                    }
                    _listening = true;
                    int n = _serialPort.BytesToRead;
                    if (n > 0)
                    {
                        byte[] buf = new byte[n];
                        _serialPort.Read(buf, 0, n);

                        if (buf[0] == Convert.ToByte("7E", 16))
                        {
                            _buffer.Clear();
                        }

                        _buffer.AddRange(buf);

                        if (_buffer.Count > 4)
                        {
                            if (_buffer[0] == Convert.ToByte("7E", 16))
                            {
                                byte[] arrayBytes = _buffer.ToArray();
                                if (!new Crc16CcittKermit(Crc16Mode.CcittKermit).ChecksumBytesResult(arrayBytes))
                                {
                                    return;
                                }
                                _buffer.Clear();
                                IsReading = false;
                                //_serialPort.DiscardInBuffer();
                                //_serialPort.DiscardOutBuffer();
                                ReturnCollectorRecData?.Invoke(arrayBytes);

                                //string[] array = arrayBytes.Select(b => b.ToString("X2")).ToArray();
                                //ReturnRecData(string.Join(" ", array));
                            }
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                //串口使用完毕可以关闭串口了
                _listening = false;
                IsReading = false;
            }
        }

        //x / <summary>
        //x / Handles the ErrorReceived event of the _serialPort control.
        //x / </summary>
        //x / <param name="sender">The source of the event.</param>
        //x / <param name="e">The <see cref="SerialErrorReceivedEventArgs"/> instance containing the event data.</param>
        //x private void _serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        //x {
        //x }
    }
}