using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;

namespace Common
{
    public static class Parameter
    {
        private static readonly string Configfile = AppDomain.CurrentDomain.BaseDirectory + "SysSetting.xml";

        #region 初始化配置文件

        public static void GenerateCfg()
        {
            XmlTextWriter writer = new XmlTextWriter(Configfile, Encoding.UTF8)
            {
                Formatting = Formatting.Indented
            };
            writer.WriteStartDocument(true);
            writer.WriteStartElement("Setting");

            writer.WriteStartElement("Common");
            writer.WriteElementString("StationGrade", "台站采集");
            writer.WriteElementString("UpdateDataTime", "1");
            writer.WriteEndElement();

            writer.WriteStartElement("SerialPort");
            writer.WriteElementString("PortName", "COM1");
            writer.WriteElementString("BaudRate", "9600");
            writer.WriteElementString("DataBits", "8");
            writer.WriteElementString("StopBits", "1");
            writer.WriteElementString("CheckBit", "NONE");
            writer.WriteEndElement();

            writer.WriteStartElement("SqlServer");
            writer.WriteElementString("Ip", "127.0.0.1");
            writer.WriteElementString("DataBase", "RadarStatusPowerData");
            writer.WriteElementString("User", "ro");
            writer.WriteElementString("Password", "123456");
            writer.WriteEndElement();

            writer.WriteStartElement("StationInfo");
            writer.WriteElementString("StationId", "Z9574");
            writer.WriteElementString("StationName", "宁波站");
            writer.WriteElementString("Slong", "1213030");
            writer.WriteElementString("Slat", "293030");
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        #endregion 初始化配置文件

        #region 读取配置文件

        public static CommonPara ReadCfg()
        {
            CommonPara commonPara = new CommonPara();
            if (!File.Exists(Configfile))
            {
                GenerateCfg();
            }
            DataSet xmlset = new DataSet();
            xmlset.ReadXml(Configfile);

            commonPara.StationGrade = xmlset.Tables["Common"].Rows[0]["StationGrade"].ToString();
            commonPara.UpdateDataIntl = int.Parse(xmlset.Tables["Common"].Rows[0]["UpdateDataTime"].ToString());

            SerialPara serialPara = new SerialPara
            {
                PortName = xmlset.Tables["SerialPort"].Rows[0]["PortName"].ToString(),
                BaudRate = int.Parse(xmlset.Tables["SerialPort"].Rows[0]["BaudRate"].ToString()),
                DataBits = int.Parse(xmlset.Tables["SerialPort"].Rows[0]["DataBits"].ToString()),
                StopBits = xmlset.Tables["SerialPort"].Rows[0]["StopBits"].ToString(),
                CheckBit = xmlset.Tables["SerialPort"].Rows[0]["CheckBit"].ToString()
            };

            SqlServerPara sqlPara = new SqlServerPara
            {
                SqlIp = xmlset.Tables["SqlServer"].Rows[0]["Ip"].ToString(),
                SqlDb = xmlset.Tables["SqlServer"].Rows[0]["DataBase"].ToString(),
                SqlUser = xmlset.Tables["SqlServer"].Rows[0]["User"].ToString(),
                SqlPwd = xmlset.Tables["SqlServer"].Rows[0]["Password"].ToString(),
            };
            StationPara stationParaPara = new StationPara();

            if (xmlset.Tables.Contains("StationInfo"))
            {
                stationParaPara = new StationPara
                {
                    StationId = xmlset.Tables["StationInfo"].Rows[0]["StationId"].ToString(),
                    StationName = xmlset.Tables["StationInfo"].Rows[0]["StationName"].ToString(),
                    Slong = xmlset.Tables["StationInfo"].Rows[0]["Slong"].ToString(),
                    Slat = xmlset.Tables["StationInfo"].Rows[0]["Slat"].ToString(),
                };
            }

            //x List<StationPara> lstStationPara = new List<StationPara>();
            //x if (commonPara.StationGrade.Contains("省级"))
            //x {
            //x     string conn =
            //x                $"Data Source={sqlPara.SqlIp};Initial Catalog={sqlPara.SqlDb};User ID={sqlPara.SqlUser};Password={sqlPara.SqlPwd};";
            //x     RadarDataClassesDataContext radarDataContext = new RadarDataClassesDataContext(conn);
            //x     var stations = (from s in radarDataContext.StationPara
            //x                     select s).Distinct().ToList();
            //x     for (int i = 0; i < xmlset.Tables["StationInfo"].Rows.Count; i++)
            //x     {
            //x         StationPara stationPara = new StationPara
            //x         {
            //x             StationId = xmlset.Tables["StationInfo"].Rows[i]["StationId"].ToString(),
            //x             StationName = xmlset.Tables["StationInfo"].Rows[i]["StationName"].ToString(),
            //x             Slong = xmlset.Tables["StationInfo"].Rows[i]["Slong"].ToString(),
            //x             Slat = xmlset.Tables["StationInfo"].Rows[i]["Slat"].ToString(),
            //x         };
            //x         lstStationPara.Add(stationPara);
            //x     }
            //x }

            commonPara.SerialPortPara = serialPara;
            commonPara.SqlServerPara = sqlPara;
            commonPara.StationInfo = stationParaPara;
            //commonPara.StationList = lstStationPara;
            return commonPara;
        }

        #endregion 读取配置文件

        #region 写入配置文件

        public static bool WriteCfg(CommonPara commonPara)
        {
            if (!File.Exists(Configfile))
            {
                GenerateCfg();
            }

            DataSet xmlset = new DataSet();
            xmlset.ReadXml(Configfile);

            xmlset.Tables["Common"].Rows.RemoveAt(0);
            xmlset.Tables["SerialPort"].Rows.RemoveAt(0);
            xmlset.Tables["SqlServer"].Rows.RemoveAt(0);

            DataRow rowcommon = xmlset.Tables["Common"].NewRow();
            rowcommon["StationGrade"] = commonPara.StationGrade;
            rowcommon["UpdateDataTime"] = commonPara.UpdateDataIntl.ToString(CultureInfo.InvariantCulture);
            xmlset.Tables["Common"].Rows.Add(rowcommon);

            DataRow rowserial = xmlset.Tables["SerialPort"].NewRow();
            rowserial["PortName"] = commonPara.SerialPortPara.PortName;
            rowserial["BaudRate"] = commonPara.SerialPortPara.BaudRate.ToString(CultureInfo.InvariantCulture);
            rowserial["DataBits"] = commonPara.SerialPortPara.DataBits.ToString(CultureInfo.InvariantCulture);
            rowserial["StopBits"] = commonPara.SerialPortPara.StopBits.ToString(CultureInfo.InvariantCulture);
            rowserial["CheckBit"] = commonPara.SerialPortPara.CheckBit;
            xmlset.Tables["SerialPort"].Rows.Add(rowserial);

            DataRow rowserver = xmlset.Tables["SqlServer"].NewRow();
            rowserver["Ip"] = commonPara.SqlServerPara.SqlIp;
            rowserver["DataBase"] = commonPara.SqlServerPara.SqlDb;
            rowserver["User"] = commonPara.SqlServerPara.SqlUser;
            rowserver["Password"] = commonPara.SqlServerPara.SqlPwd;
            xmlset.Tables["SqlServer"].Rows.Add(rowserver);

            if (commonPara.StationGrade.Contains("台站"))
            {
                if (xmlset.Tables.Contains("StationInfo"))
                {
                    xmlset.Tables["StationInfo"].Rows.RemoveAt(0);
                }
                DataRow rowstationinfo = xmlset.Tables["StationInfo"].NewRow();
                rowstationinfo["StationId"] = commonPara.StationInfo.StationId;
                rowstationinfo["StationName"] = commonPara.StationInfo.StationName;
                rowstationinfo["Slong"] = commonPara.StationInfo.Slong;
                rowstationinfo["Slat"] = commonPara.StationInfo.Slat;
                xmlset.Tables["StationInfo"].Rows.Add(rowstationinfo);
            }

            xmlset.WriteXml(Configfile);

            return true;
        }

        #endregion 写入配置文件
    }
}