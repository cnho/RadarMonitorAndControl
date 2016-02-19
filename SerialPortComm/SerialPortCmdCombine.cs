using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SerialPortComm
{
    public static class SerialPortCmdCombine
    {
        /// <summary>
        /// 根据字符串设置采集器指令
        /// </summary>
        /// <param name="address">地址.</param>
        /// <param name="instruction">指令.</param>
        /// <returns></returns>
        public static byte[] SetBaseCommand(string address, string instruction)
        {
            List<byte> cmdbyteList = new List<byte>
            {
                Convert.ToByte("7E", 16),
                Convert.ToByte("F1", 16),
                Convert.ToByte(address, 16)
            };
            string[] cmds = instruction.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] instructionbyte = cmds.Select(s => Convert.ToByte(s, 16)).ToArray();
            cmdbyteList.Add(Convert.ToByte((instructionbyte.Length + 2).ToString(CultureInfo.InvariantCulture), 16));
            cmdbyteList.AddRange(instructionbyte);
            byte[] cmdBytes = new byte[cmdbyteList.Count - 1];
            for (int i = 0; i < cmdBytes.Length; i++)
            {
                cmdBytes[i] = cmdbyteList[i + 1];
            }
            //byte[] crc = new Crc16Ccitt(InitialCrcValue.Zeros).ComputeChecksumBytes(cmdBytes);
            byte[] crc = new Crc16CcittKermit(Crc16Mode.CcittKermit).ComputeChecksumBytes(cmdBytes);
            cmdbyteList.AddRange(crc);
            return cmdbyteList.ToArray();
        }

        /// <summary>
        /// 根据字节数组设置采集器指令
        /// </summary>
        /// <param name="address">地址.</param>
        /// <param name="instruction">指令.</param>
        /// <returns></returns>
        public static byte[] SetBaseCommand(string address, byte[] instruction)
        {
            List<byte> cmdbyteList = new List<byte>
            {
                Convert.ToByte("7E", 16),
                Convert.ToByte("F1", 16),
                Convert.ToByte(address, 16),
                Convert.ToByte((instruction.Length + 2).ToString(CultureInfo.InvariantCulture), 10)
            };
            cmdbyteList.AddRange(instruction);
            byte[] cmdBytes = new byte[cmdbyteList.Count - 1];
            for (int i = 0; i < cmdBytes.Length; i++)
            {
                cmdBytes[i] = cmdbyteList[i + 1];
            }
            //byte[] crc = new Crc16Ccitt(InitialCrcValue.Zeros).ComputeChecksumBytes(cmdBytes);
            byte[] crc = new Crc16CcittKermit(Crc16Mode.CcittKermit).ComputeChecksumBytes(cmdBytes);
            cmdbyteList.AddRange(crc);
            return cmdbyteList.ToArray();
        }

        /// <summary>
        /// 根据字符串设置采集器带密码指令
        /// </summary>
        /// <param name="address">地址.</param>
        /// <param name="pwds">密码</param>
        /// <param name="instruction">指令.</param>
        /// <param name="controlcmd">控制指令</param>
        /// <returns></returns>
        public static byte[] SetBaseCommand(string address, string pwds, string instruction, string controlcmd)
        {
            List<byte> cmdbyteList = new List<byte>
            {
                Convert.ToByte("7E", 16),
                Convert.ToByte("F1", 16),
                Convert.ToByte(address, 16)
            };
            string[] cmds = instruction.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] instructionbyte = cmds.Select(s => Convert.ToByte(s, 16)).ToArray();
            string[] controlcmds = controlcmd.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] controlcmdbyte = controlcmds.Select(s => Convert.ToByte(s, 16)).ToArray();
            string[] pwdcmds = pwds.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] pwdsbyte = pwdcmds.Select(s => Convert.ToByte(s, 16)).ToArray();
            cmdbyteList.Add(Convert.ToByte((instructionbyte.Length + 2 + pwdsbyte.Length + controlcmdbyte.Length).ToString(CultureInfo.InvariantCulture), 10));

            cmdbyteList.AddRange(instructionbyte);
            cmdbyteList.AddRange(pwdsbyte);
            cmdbyteList.AddRange(controlcmdbyte);

            byte[] cmdBytes = new byte[cmdbyteList.Count - 1];
            cmdbyteList.CopyTo(1, cmdBytes, 0, cmdbyteList.Count - 1);
            for (int i = 0; i < cmdBytes.Length; i++)
            {
                cmdBytes[i] = cmdbyteList[i + 1];
            }
            //byte[] crc = new Crc16Ccitt(InitialCrcValue.Zeros).ComputeChecksumBytes(cmdBytes);
            byte[] crc = new Crc16CcittKermit(Crc16Mode.CcittKermit).ComputeChecksumBytes(cmdBytes);
            cmdbyteList.AddRange(crc);
            return cmdbyteList.ToArray();
        }

        /// <summary>
        /// 根据字节数组设置采集器带密码指令
        /// </summary>
        /// <param name="address">地址.</param>
        /// <param name="pwds">密码</param>
        /// <param name="instruction">指令.</param>
        /// <param name="controlcmd">控制指令</param>
        /// <returns></returns>
        public static byte[] SetBaseCommand(string address, byte[] pwds, byte[] instruction, byte[] controlcmd)
        {
            List<byte> cmdbyteList = new List<byte>
            {
                Convert.ToByte("7E", 16),
                Convert.ToByte("F1", 16),
                Convert.ToByte(address, 16),
                Convert.ToByte((instruction.Length + 2 + pwds.Length + controlcmd.Length).ToString(CultureInfo.InvariantCulture), 10)
            };
            cmdbyteList.AddRange(instruction);
            cmdbyteList.AddRange(pwds);
            cmdbyteList.AddRange(controlcmd);
            byte[] cmdBytes = new byte[cmdbyteList.Count - 1];
            for (int i = 0; i < cmdBytes.Length; i++)
            {
                cmdBytes[i] = cmdbyteList[i + 1];
            }
            //byte[] crc = new Crc16Ccitt(InitialCrcValue.Zeros).ComputeChecksumBytes(cmdBytes);
            byte[] crc = new Crc16CcittKermit(Crc16Mode.CcittKermit).ComputeChecksumBytes(cmdBytes);
            cmdbyteList.AddRange(crc);
            return cmdbyteList.ToArray();
        }
    }
}