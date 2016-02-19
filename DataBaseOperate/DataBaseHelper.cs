using LinqToDB;
using LinqToDB.DataProvider.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using Lrdm = LocalRadarDataModels;

namespace DataBaseOperate
{
    public class DataBaseHelper : IDisposable
    {
        private readonly RadarDataClassesDataContext _radarDataContext;

        private readonly Lrdm.LocalRadarDataDb _localRadarDataDb;

        public DataBaseHelper(string connstr)
        {
            _radarDataContext = new RadarDataClassesDataContext(connstr);
        }

        public void AlarmStatusInsert(AlarmStatusTable alarmdata)
        {
            _radarDataContext.AlarmStatusTable.InsertOnSubmit(alarmdata);
        }

        public void AlarmStatusInsert(IEnumerable<AlarmStatusTable> lstAlarmData)
        {
            _radarDataContext.AlarmStatusTable.InsertAllOnSubmit(lstAlarmData);
        }

        public void ControlStatusInsert(ControlStatusTable ctrldata)
        {
            _radarDataContext.ControlStatusTable.InsertOnSubmit(ctrldata);
        }

        public void ControlStatusInsert(IEnumerable<ControlStatusTable> lstControlData)
        {
            _radarDataContext.ControlStatusTable.InsertAllOnSubmit(lstControlData);
        }

        public void PowerDataInsert(PowerDataTable powerdata)
        {
            _radarDataContext.PowerDataTable.InsertOnSubmit(powerdata);
        }

        public void PowerDataInsert(IEnumerable<PowerDataTable> lstPowerdata)
        {
            _radarDataContext.PowerDataTable.InsertAllOnSubmit(lstPowerdata);
        }

        public void StationParaInsertorUpdate(StationParaTable stationInfo)
        {
            var stations = from s in _radarDataContext.StationParaTable
                           where s.StationID == stationInfo.StationID
                           select s;
            if (stations.Any())
            {
                var station = stations.First();
                station.StationName = stationInfo.StationName;
                station.Slong = stationInfo.Slong;
                station.Slat = stationInfo.Slat;
                station.Address = stationInfo.Address;
            }
            else
            {
                _radarDataContext.StationParaTable.InsertOnSubmit(stationInfo);
            }
        }

        public void SaveChanges()
        {
            _radarDataContext.SubmitChanges();
        }

        public DataBaseHelper()
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + @"LocalRadarData.db";
            string connstr = $"Data Source={filename};";
            _localRadarDataDb = new Lrdm.LocalRadarDataDb(new SQLiteDataProvider(), connstr);
        }

        public void DeleteAllSqLiteData()
        {
            _localRadarDataDb.AlarmStatus.Delete();
            _localRadarDataDb.ControlStatus.Delete();
            _localRadarDataDb.PowerData.Delete();
        }

        public void AlarmStatusInsert(Lrdm.AlarmStatusModels alarmdata)
        {
            _localRadarDataDb.Insert(alarmdata);
        }

        public void ControlStatusInsert(Lrdm.ControlStatusModels ctrldata)
        {
            _localRadarDataDb.Insert(ctrldata);
        }

        public void PowerDataInsert(Lrdm.PowerDataModels powerdata)
        {
            _localRadarDataDb.Insert(powerdata);
        }

        public List<Lrdm.AlarmStatusModels> AlarmStatusSelect()
        {
            var alarmstatus = (from a in _localRadarDataDb.AlarmStatus
                               select a).Distinct().ToList();
            return alarmstatus;
        }

        public List<Lrdm.ControlStatusModels> ControlStatusSelect()
        {
            var controlstatus = (from a in _localRadarDataDb.ControlStatus
                                 select a).Distinct().ToList();
            return controlstatus;
        }

        public List<Lrdm.PowerDataModels> PowerDataSelect()
        {
            var powerdata = (from a in _localRadarDataDb.PowerData
                             select a).Distinct().ToList();
            return powerdata;
        }

        ~DataBaseHelper()
        {
            // 为了保持代码的可读性性和可维护性,千万不要在这里写释放非托管资源的代码 
            // 必须以Dispose(false)方式调用,以false告诉Dispose(bool disposing)函数是从垃圾回收器在调用 析构函数 时调用的 
            Dispose(false);
        }

        // 无法被客户直接调用 
        // 如果 disposing 是 true, 那么这个方法是被客户直接调用的,那么托管的,和非托管的资源都可以释放 
        // 如果 disposing 是 false, 那么函数是从垃圾回收器在调用Finalize时调用的,此时不应当引用其他托管对象所以,只能释放非托管资源 
        protected virtual void Dispose(bool disposing)
        {
            // 那么这个方法是被客户直接调用的,那么托管的,和非托管的资源都可以释放 
            if (disposing)
            {
                // 释放托管资源 
                if (_radarDataContext != null)
                {
                    _radarDataContext.Connection.Close();
                    _radarDataContext.Dispose();
                }
                if (_localRadarDataDb != null)
                {
                    _localRadarDataDb.Connection.Close();
                    _localRadarDataDb.Dispose();
                }
            }
            _radarDataContext?.Dispose();
            _localRadarDataDb?.Dispose();
            //释放非托管资源 
            // 那么这个方法是被客户直接调用的,告诉垃圾回收器从Finalization队列中清除自己,从而阻止垃圾回收器调用 析构函数 方法. 
            if (disposing)
                GC.SuppressFinalize(this);
        }

        //可以被客户直接调用 
        public void Dispose()
        {
            //必须以Dispose(true)方式调用,以true告诉Dispose(bool disposing)函数是被客户直接调用的 
            Dispose(true);
        }
    }
}