using System.Collections.Generic;

namespace Common
{
    public struct CommonPara
    {
        public string StationGrade;
        public int UpdateDataIntl;
        public SerialPara SerialPortPara;
        public SqlServerPara SqlServerPara;
        public StationPara StationInfo;
        public List<StationPara> StationProList;
    }

    public struct StationPara
    {
        public string StationId;
        public string StationName;
        public string Slong;
        public string Slat;
    }

    public struct SqlServerPara
    {
        public string SqlIp;
        public string SqlDb;
        public string SqlUser;
        public string SqlPwd;
    }

    public struct SerialPara
    {
        public string PortName;
        public int BaudRate;
        public int DataBits;
        public string StopBits;
        public string CheckBit;
    }
}