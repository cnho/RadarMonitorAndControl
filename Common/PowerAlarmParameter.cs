using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Common
{
    /// <summary>
    /// 电源报警启用参数数据结构
    /// </summary>
    public class AlarmEnablePara
    {
        public bool CurArtifLine;
        public bool CurCatho;
        public bool CurFilament;
        public bool CurFocusCoil;
        public bool CurLeveling;
        public bool CurReversePeak;
        public bool CurTitPump;
        public bool Vol15;
        public bool Vol28;
        public bool Vol45;
        public bool Vol5;
        public bool Vol510;
        public bool VolArtifLine;
        public bool VolEleBeam;
        public bool VolField;
        public bool VolFilaInve;
        public bool VolFilament;
        public bool VolNeg15;
        public bool VolTitPump;

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerAlarmPara"/> struct.
        /// </summary>
        public AlarmEnablePara()
        {
            Vol5 = false;
            Vol15 = false;
            Vol28 = false;
            VolNeg15 = false;
            Vol45 = false;
            Vol510 = false;
            VolFilaInve = false;
            VolFilament = false;
            VolField = false;
            VolTitPump = false;
            VolEleBeam = false;
            VolArtifLine = false;
            CurCatho = false;
            CurReversePeak = false;
            CurFilament = false;
            CurFocusCoil = false;
            CurTitPump = false;
            CurLeveling = false;
            CurArtifLine = false;
        }
    }

    /// <summary>
    /// 电源报警参数数据结构
    /// </summary>
    public class PowerAlarmPara
    {
        public decimal CurArtifLine;
        public decimal CurCatho;
        public decimal CurFilament;
        public decimal CurFocusCoil;
        public decimal CurLeveling;
        public decimal CurReversePeak;
        public decimal CurTitPump;
        public decimal Vol15;
        public decimal Vol28;
        public decimal Vol45;
        public decimal Vol5;
        public decimal Vol510;
        public decimal VolArtifLine;
        public decimal VolEleBeam;
        public decimal VolField;
        public decimal VolFilaInve;
        public decimal VolFilament;
        public decimal VolNeg15;
        public decimal VolTitPump;

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerAlarmPara"/> struct.
        /// </summary>
        public PowerAlarmPara()
        {
            Vol5 = 9999;
            Vol15 = 9999;
            Vol28 = 9999;
            VolNeg15 = 9999;
            Vol45 = 9999;
            Vol510 = 9999;
            VolFilaInve = 9999;
            VolFilament = 9999;
            VolField = 9999;
            VolTitPump = 9999;
            VolEleBeam = 9999;
            VolArtifLine = 9999;
            CurCatho = 9999;
            CurReversePeak = 9999;
            CurFilament = 9999;
            CurFocusCoil = 9999;
            CurTitPump = 9999;
            CurLeveling = 9999;
            CurArtifLine = 9999;
        }
    }

    /// <summary>
    /// 电源报警参数操作类
    /// </summary>
    public class PowerAlarmParameter
    {
        public static readonly string PowerConfigPath = AppDomain.CurrentDomain.BaseDirectory + "PowerAlarmSetting.xml";

        /// <summary>
        /// The _QC para
        /// </summary>
        private PowerAlarmPara _powerAlarm = new PowerAlarmPara();

        /// <summary>
        /// The _QC en para
        /// </summary>
        private AlarmEnablePara _powerEnable = new AlarmEnablePara();

        /// <summary>
        /// Gets or sets the qc para.
        /// </summary>
        /// <value>
        /// The qc para.
        /// </value>
        public PowerAlarmPara PowerAlarm
        {
            get { return _powerAlarm; }
            set { _powerAlarm = value; }
        }

        /// <summary>
        /// Gets or sets the qc en para.
        /// </summary>
        /// <value>
        /// The qc en para.
        /// </value>
        public AlarmEnablePara PowerEnable
        {
            get { return _powerEnable; }
            set { _powerEnable = value; }
        }

        /// <summary>
        /// Generates the XML file.
        /// </summary>
        public static void GenerateXmlFile()
        {
            try
            {
                PowerAlarmPara powerAlarm = new PowerAlarmPara();
                List<string> powerAlamList = (from fieldinfo in powerAlarm.GetType().GetFields()
                                              select fieldinfo.Name).ToList();
                XElement xele = new XElement("PowerAlarm");
                foreach (string powerxele in powerAlamList)
                {
                    xele.Add(new XElement(powerxele, new XAttribute("Enable", "False")));
                }
                XDocument myXDoc = new XDocument(xele);
                myXDoc.Save(PowerConfigPath);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Operates the XML node information.
        /// </summary>
        /// <param name="powerEnable">The qc enable para.</param>
        /// <param name="powerPara">The qc control para.</param>
        public static void OperateXmlNodeInfo(AlarmEnablePara powerEnable, PowerAlarmPara powerPara)
        {
            List<string> qcParaFields = (from fieldinfo in powerPara.GetType().GetFields() select fieldinfo.Name).ToList();
            XElement rootNode = XElement.Load(PowerConfigPath);
            foreach (string qcname in qcParaFields)
            {
                XElement xElement = rootNode.Element(qcname);
                string str1 =
                    powerEnable.GetType().GetField(qcname).GetValue(powerEnable).ToString();
                string str2 =
                    powerPara.GetType().GetField(qcname).GetValue(powerPara).ToString().Equals("false")
                        ? string.Empty
                        : powerPara.GetType().GetField(qcname).GetValue(powerPara).ToString();
                if (xElement != null)
                {
                    xElement.SetAttributeValue("Enable", str1);
                    xElement.SetValue(str2);
                }
                else
                {
                    XElement newNode = new XElement(qcname, new XAttribute("Enable", str1));
                    newNode.SetValue(str2);
                    rootNode.Add(newNode);
                }
            }
            rootNode.Save(PowerConfigPath);
        }

        /// <summary>
        /// Gets the XML node information.
        /// </summary>
        public void GetXmlNodeInfo()
        {
            try
            {
                Object objqcPara = _powerAlarm;
                Object objqcEnablePara = _powerEnable;
                List<string> qcParaFields = (from fieldinfo in _powerAlarm.GetType().GetFields() select fieldinfo.Name).ToList();
                XElement rootNode = XElement.Load(PowerConfigPath);
                foreach (string qcname in qcParaFields)
                {
                    XElement xElement = rootNode.Element(qcname);
                    _powerAlarm.GetType().GetField(qcname).SetValue(objqcPara, (xElement == null || string.IsNullOrEmpty(xElement.Value)) ? 9999 : decimal.Parse(xElement.Value));
                    _powerEnable.GetType().GetField(qcname).SetValue(objqcEnablePara, xElement != null && !string.IsNullOrEmpty(xElement.Attribute("Enable").Value) && bool.Parse(xElement.Attribute("Enable").Value));
                }
                _powerAlarm = (PowerAlarmPara)objqcPara;
                _powerEnable = (AlarmEnablePara)objqcEnablePara;
            }
            catch
            {
                throw;
            }
        }

        /*
                /// <summary>
                /// Adds the XML node information.
                /// </summary>
                /// <param name="xmlPath">The XML path.</param>
                /// <param name="newNodeList">The new node list.</param>
                private static void AddXmlNodeInfo(string xmlPath, IEnumerable<XElement> newNodeList)
                {
                    try
                    {
                        XElement rootNode = XElement.Load(xmlPath);
                        foreach (XElement newNode in newNodeList)
                        {
                            rootNode.Add(newNode);
                        }
                        rootNode.Save(xmlPath);
                    }
                    catch
                    {
                        throw;
                    }
                }
        */
    }
}