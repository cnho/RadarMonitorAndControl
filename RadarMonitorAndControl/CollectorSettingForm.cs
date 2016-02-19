using Common;
using SerialPortComm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace RadarMonitorAndControl
{
    public partial class CollectorSettingForm : Form
    {
        private readonly SynchronizationContext _synchContext;

        public CollectorSettingForm()
        {
            InitializeComponent();
            _synchContext = SynchronizationContext.Current;
        }

        public SerialPortOperate SerilPortOp { get; set; }

        private void btnRest_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(@"确实要复位采集器？", @"警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", "01");
                SerilPortOp.SendCommand(cmd);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"复位采集器失败！出错信息：" + Environment.NewLine + exception);
            }
        }

        private void btnSetAddress_Click(object sender, EventArgs e)
        {
        }

        private void btnSetPwd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOldPwd.Text.Length < 8 || tbNewPwd.Text.Length < 8 || tbNewPwdConfirm.Text.Length < 8)
                {
                    MessageBox.Show(@"密码均要输入8位！");
                    return;
                }
                List<byte> cmdBytes = new List<byte>
                {
                    Convert.ToByte("83",16)
                };
                byte[] oldpwds = HexBinDecOct.StringToBytes(tbOldPwd.Text);
                byte[] newpwds = HexBinDecOct.StringToBytes(tbNewPwd.Text);
                cmdBytes.AddRange(oldpwds);
                cmdBytes.AddRange(newpwds);
                byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", cmdBytes.ToArray());
                SerilPortOp.SendCommand(cmd);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"设置密码失败！出错信息：" + Environment.NewLine + exception);
            }
        }

        private void cmbCommNum_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
            {
                return;
            }
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(((ComboBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.X, e.Bounds.Y + 3);
        }

        private void CollectorSettingForm_Load(object sender, EventArgs e)
        {
            SerilPortOp.ReturnCollectorRecData += RecDataProcessing;
            byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", "02");
            try
            {
                SerilPortOp.SendCommand(cmd);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"获取采集器基本信息失败！出错信息：" + Environment.NewLine + exception);
            }
        }

        private void RecDataProcessing(byte[] message)
        {
            if (message[0] != Convert.ToByte("7E", 16) || message[1] != Convert.ToByte("D1", 16))
            {
                return;
            }
            _synchContext.Post(a =>
            {
                if (message[4] == Convert.ToByte("01", 16))
                {
                    MessageBox.Show(@"采集器复位成功！");
                }
                try
                {
                    if (message[4] == Convert.ToByte("02", 16))
                    {
                        List<string> verList = new List<string>();
                        for (int i = 5; i < 16; i++)
                        {
                            verList.Add(HexBinDecOct.HexStringToDec(message[i]).ToString(CultureInfo.InvariantCulture));
                        }
                        List<string> equipList = new List<string>();
                        for (int i = 21; i < 37; i++)
                        {
                            equipList.Add(HexBinDecOct.HexStringToDec(message[i]).ToString(CultureInfo.InvariantCulture));
                        }
                        tbSoftVer.Text = string.Join(" ", verList.ToArray());
                        tbEquipId.Text = string.Join(" ", equipList.ToArray());
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(@"采集器基本信息显示失败！出错信息：" + Environment.NewLine + e);
                }
                if (message[4] == Convert.ToByte("83", 16))
                {
                    MessageBox.Show(@"设置新密码成功");
                }
            }, null);
        }

        private void tbNewPwdConfirm_Leave(object sender, EventArgs e)
        {
            if (tbNewPwd.Text != tbNewPwdConfirm.Text)
            {
                MessageBox.Show(@"新密码和确认密码不一致！");
            }
        }

        private void btnSetEquipId_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEquipId.Text.Length < 16)
                {
                    MessageBox.Show(@"请输入16位设备编号！");
                    return;
                }
                List<byte> cmdBytes = new List<byte>
                {
                    Convert.ToByte("82",16)
                };
                byte[] newid = HexBinDecOct.StringToBytes(tbEquipId.Text);
                cmdBytes.AddRange(newid);
                byte[] cmd = SerialPortCmdCombine.SetBaseCommand("FF", cmdBytes.ToArray());
                SerilPortOp.SendCommand(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"设置采集器设备编号失败！出错信息：" + Environment.NewLine + ex);
            }
        }
    }
}