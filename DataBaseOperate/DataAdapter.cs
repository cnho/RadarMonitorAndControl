using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using Lrdm = LocalRadarDataModels;

namespace DataBaseOperate
{
    public class DataAdapter 
    {
        public DataAdapter()
        { }

        /// <summary>
        /// 初始化数据适配器
        /// </summary>
        /// <param name="stationId">台站号</param>
        /// <param name="dt">时间</param>
        public DataAdapter(string stationId, DateTime dt)
        {
            StationId = stationId;
            Dt = dt;
        }

        /// <summary>
        /// 报警信息数据，适配界面
        /// </summary>
        public AlarmData AlarmStatusData { get; set; }

        /// <summary>
        /// 状态信息数据，适配界面
        /// </summary>
        public StatusData ControlStatusData { get; set; }

        /// <summary>
        /// 采集数据的时间
        /// </summary>
        public DateTime Dt { get; set; }

        /// <summary>
        /// 电源信息数据，适配界面
        /// </summary>
        public RadarPower RadarPowerData { get; set; }

        /// <summary>
        /// 台站号
        /// </summary>
        public string StationId { get; set; }

        /// <summary>
        /// 将串口数据解析为适合界面的数据
        /// </summary>
        public void DataResolve(byte[] message)
        {
            List<string> powerMsgList = new List<string>();
            List<string> statusMsgList = new List<string>();
            List<string> controlMsgList = new List<string>();

            for (int i = 5; i < 53; i = i + 2)
            {
                string msgtemp = message[i + 1].ToString("X2") + message[i].ToString("X2");
                powerMsgList.Add(msgtemp);
            }

            for (int i = 53; i < 61; i++)
            {
                statusMsgList.Add(HexBinDecOct.ByteToBinString(message[i]));
            }

            for (int i = 61; i < 63; i++)
            {
                controlMsgList.Add(HexBinDecOct.ByteToBinString(message[i]));
            }
            decimal? volField = HexBinDecOct.HexStringToDec(powerMsgList[9]) / 10.0m;
            RadarPowerData = new RadarPower
            {
                VolArtifLine = HexBinDecOct.HexStringToDec(powerMsgList[0]) / 10.0m,
                CurFilament = HexBinDecOct.HexStringToDec(powerMsgList[1]) / 10.0m,
                CurFocusCoil = HexBinDecOct.HexStringToDec(powerMsgList[2]) / 10.0m,
                Vol5 = HexBinDecOct.HexStringToDec(powerMsgList[3]) / 10.0m,
                Vol15 = HexBinDecOct.HexStringToDec(powerMsgList[4]) / 10.0m,
                Vol28 = HexBinDecOct.HexStringToDec(powerMsgList[5]) / 10.0m,
                Vol45 = HexBinDecOct.HexStringToDec(powerMsgList[6]) / 10.0m,
                Vol510 = HexBinDecOct.HexStringToDec(powerMsgList[7]) / 10.0m,
                VolFilaInve = HexBinDecOct.HexStringToDec(powerMsgList[8]) / 10.0m,
                VolField = volField,
                CurLeveling = HexBinDecOct.HexStringToDec(powerMsgList[10]) / 10.0m,
                CurReversePeak = HexBinDecOct.HexStringToDec(powerMsgList[11]) / 10.0m,
                CurArtifLine = HexBinDecOct.HexStringToDec(powerMsgList[12]) / 10.0m,
                CurCatho = HexBinDecOct.HexStringToDec(powerMsgList[13]) / 10.0m,
                VolEleBeam = volField == 0 ? 0 : HexBinDecOct.HexStringToDec(powerMsgList[14]) / 10.0m,
                VolFilament = HexBinDecOct.HexStringToDec(powerMsgList[15]) / 10.0m,
                CurTitPump = HexBinDecOct.HexStringToDec(powerMsgList[17]) / 10.0m,
                VolNeg15 = HexBinDecOct.HexStringToDec(powerMsgList[20]) / 10.0m,
                VolTitPump = HexBinDecOct.HexStringToDec(powerMsgList[21]) / 10.0m,
            };

            AlarmStatusData = ReturnAlarmData(string.Join("", statusMsgList.ToArray()));
            ControlStatusData = ReturnControlData(AlarmControlResolve(string.Join("", controlMsgList.ToArray()).ToCharArray()));
        }

        /// <summary>
        /// 将数据库中的数据解析为适合界面的数据
        /// </summary>
        public void DataResolve(RadarDataClassesDataContext radarDataContext)
        {
            var alarm = (from p in radarDataContext.AlarmStatusTable
                         where p.DateTime == Dt && p.StationID == StationId
                         select p).Distinct().ToList();
            var control = (from p in radarDataContext.ControlStatusTable
                           where p.DateTime == Dt && p.StationID == StationId
                           select p).Distinct().ToList();
            var power = (from p in radarDataContext.PowerDataTable
                         where p.DateTime == Dt && p.StationID == StationId
                         select p).Distinct().ToList();

            if (alarm.Count > 0)
            {
                AlarmStatusData = new AlarmData
                {
                    AfterChargingFair = alarm[0].AfterChargingFair,
                    AntennaCirculatorOverHeat = alarm[0].AntennaCirculatorOverHeat,
                    AntennaWaveGuidChain = alarm[0].AntennaWaveGuidChain,
                    ModulatorSwitchReq = alarm[0].ModulatorSwitchReq,
                    WaveGuidPressHumidityReq = alarm[0].WaveGuidPressHumidityReq,

                    _510VFailureOnce = alarm[0]._510VFailureOnce,
                    BackupOnce = alarm[0].BackupOnce,
                    ChargingFailureOnce = alarm[0].ChargingFailureOnce,
                    ChargingFeedbackFlowRectifierUnderVolOnce = alarm[0].ChargingFeedbackFlowRectifierUnderVolOnce,
                    DutyCycleOverOnce = alarm[0].DutyCycleOverOnce,
                    FilaVolFailureOnce = alarm[0].FilaVolFailureOnce,
                    FocusCoilAirFlowFailureOnce = alarm[0].FocusCoilAirFlowFailureOnce,
                    FocusCoilCurFailureOnce = alarm[0].FocusCoilCurFailureOnce,
                    FocusCoilVolFailureOnce = alarm[0].FocusCoilVolFailureOnce,
                    KlystronAirFlowAlarmOnce = alarm[0].KlystronAirFlowAlarmOnce,
                    KlystronAirTempAlarmOnce = alarm[0].KlystronAirTempAlarmOnce,
                    KlystronFilaFailureOnce = alarm[0].KlystronFilaFailureOnce,
                    KlystronOverCurOnce = alarm[0].KlystronOverCurOnce,
                    KlystronTitPumpFailureOnce = alarm[0].KlystronTitPumpFailureOnce,
                    LowPowerFailureOnce = alarm[0].LowPowerFailureOnce,
                    ModulatorNegPeakOverOnce = alarm[0].ModulatorNegPeakOverOnce,
                    ModulatorOverOnce = alarm[0].ModulatorOverOnce,
                    ModulatorSwitchFailureOnce = alarm[0].ModulatorSwitchFailureOnce,
                    PowerGridUnderVolOnce = alarm[0].PowerGridUnderVolOnce,
                    RackAirFlowAlarmOnce = alarm[0].RackAirFlowAlarmOnce,
                    RackAirTempAlarmOnce = alarm[0].RackAirTempAlarmOnce,
                    RackDoorChainOnce = alarm[0].RackDoorChainOnce,
                    TankLevelAlarmOnce = alarm[0].TankLevelAlarmOnce,
                    TankTempAlarmOnce = alarm[0].TankTempAlarmOnce,
                    TitPumpFailureOnce = alarm[0].TitPumpFailureOnce,
                    TransmitOverCurOnce = alarm[0].TransmitOverCurOnce,
                    TransmitOverVolOnce = alarm[0].TransmitOverVolOnce,
                    TriggerFailureOnce = alarm[0].TriggerFailureOnce,
                    WaveGuidArcAlarmOnce = alarm[0].WaveGuidArcAlarmOnce,
                    WaveGuidPressAlarmOnce = alarm[0].WaveGuidPressAlarmOnce,

                    _510VFailureQuintic = alarm[0]._510VFailureQuintic,
                    BackupQuintic = alarm[0].BackupQuintic,
                    ChargingFailureQuintic = alarm[0].ChargingFailureQuintic,
                    ChargingFeedbackFlowRectifierUnderVolQuintic = alarm[0].ChargingFeedbackFlowRectifierUnderVolQuintic,
                    DutyCycleOverQuintic = alarm[0].DutyCycleOverQuintic,
                    FilaVolFailureQuintic = alarm[0].FilaVolFailureQuintic,
                    FocusCoilAirFlowFailureQuintic = alarm[0].FocusCoilAirFlowFailureQuintic,
                    FocusCoilCurFailureQuintic = alarm[0].FocusCoilCurFailureQuintic,
                    FocusCoilVolFailureQuintic = alarm[0].FocusCoilVolFailureQuintic,
                    KlystronAirFlowAlarmQuintic = alarm[0].KlystronAirFlowAlarmQuintic,
                    KlystronAirTempAlarmQuintic = alarm[0].KlystronAirTempAlarmQuintic,
                    KlystronFilaFailureQuintic = alarm[0].KlystronFilaFailureQuintic,
                    KlystronOverCurQuintic = alarm[0].KlystronOverCurQuintic,
                    KlystronTitPumpFailureQuintic = alarm[0].KlystronTitPumpFailureQuintic,
                    LowPowerFailureQuintic = alarm[0].LowPowerFailureQuintic,
                    ModulatorNegPeakOverQuintic = alarm[0].ModulatorNegPeakOverQuintic,
                    ModulatorOverQuintic = alarm[0].ModulatorOverQuintic,
                    ModulatorSwitchFailureQuintic = alarm[0].ModulatorSwitchFailureQuintic,
                    PowerGridUnderVolQuintic = alarm[0].PowerGridUnderVolQuintic,
                    RackAirFlowAlarmQuintic = alarm[0].RackAirFlowAlarmQuintic,
                    RackAirTempAlarmQuintic = alarm[0].RackAirTempAlarmQuintic,
                    RackDoorChainQuintic = alarm[0].RackDoorChainQuintic,
                    TankLevelAlarmQuintic = alarm[0].TankLevelAlarmQuintic,
                    TankTempAlarmQuintic = alarm[0].TankTempAlarmQuintic,
                    TitPumpFailureQuintic = alarm[0].TitPumpFailureQuintic,
                    TransmitOverCurQuintic = alarm[0].TransmitOverCurQuintic,
                    TransmitOverVolQuintic = alarm[0].TransmitOverVolQuintic,
                    TriggerFailureQuintic = alarm[0].TriggerFailureQuintic,
                    WaveGuidArcAlarmQuintic = alarm[0].WaveGuidArcAlarmQuintic,
                    WaveGuidPressAlarmQuintic = alarm[0].WaveGuidPressAlarmQuintic,
                };
            }
            if (control.Count > 0)
            {
                ControlStatusData = new StatusData
                {
                    AllowOn = control[0].AllowOn,
                    Antenna = control[0].Antenna,
                    Auto = control[0].Auto,
                    Backup = control[0].Backup,
                    BroadPulse = control[0].BroadPulse,
                    Fault = control[0].Fault,
                    FilaSup = control[0].FilaSupply,
                    HVoff = control[0].HighVoloff,
                    HVon = control[0].HighVolon,
                    Load = control[0].Load,
                    LocalCtrl = control[0].LocalCtrl,
                    Manual = control[0].Manual,
                    Preheat = control[0].Preheat,
                    RemoteCtrl = control[0].RemoteCtrl,
                    RepeatCycle = control[0].RepeatCycle,
                    SpikePulse = control[0].SpikePulse,
                };
            }
            if (power.Count > 0)
            {
                RadarPowerData = new RadarPower
                {
                    CurArtifLine = power[0].CurArtifLine,
                    CurCatho = power[0].CurCatho,
                    CurFilament = power[0].CurFilament,
                    CurFocusCoil = power[0].CurFocusCoil,
                    CurLeveling = power[0].CurLeveling,
                    CurReversePeak = power[0].CurReversePeak,
                    CurTitPump = power[0].CurTitPump,
                    Vol15 = power[0].Vol15,
                    Vol28 = power[0].Vol28,
                    Vol45 = power[0].Vol45,
                    Vol5 = power[0].Vol5,
                    Vol510 = power[0].Vol510,
                    VolArtifLine = power[0].VolArtifLine,
                    VolEleBeam = power[0].VolEleBeam,
                    VolField = power[0].VolField,
                    VolFilaInve = power[0].VolFilaInve,
                    VolFilament = power[0].VolFilament,
                    VolNeg15 = power[0].VolNeg15,
                    VolTitPump = power[0].VolTitPump,
                };
            }
        }

        /// <summary>
        /// 将数据库电源数据类型解析为适合界面的电源数据
        /// </summary>
        public RadarPower DataResolve(PowerDataTable powerdata)
        {
            RadarPower volCurData = new RadarPower
            {
                CurArtifLine = powerdata.CurArtifLine,
                CurCatho = powerdata.CurCatho,
                CurFilament = powerdata.CurFilament,
                CurFocusCoil = powerdata.CurFocusCoil,
                CurLeveling = powerdata.CurLeveling,
                CurReversePeak = powerdata.CurReversePeak,
                CurTitPump = powerdata.CurTitPump,
                Vol15 = powerdata.Vol15,
                Vol28 = powerdata.Vol28,
                Vol45 = powerdata.Vol45,
                Vol5 = powerdata.Vol5,
                Vol510 = powerdata.Vol510,
                VolArtifLine = powerdata.VolArtifLine,
                VolEleBeam = powerdata.VolEleBeam,
                VolField = powerdata.VolField,
                VolFilaInve = powerdata.VolFilaInve,
                VolFilament = powerdata.VolFilament,
                VolNeg15 = powerdata.VolNeg15,
                VolTitPump = powerdata.VolTitPump,
            };
            return volCurData;
        }

        /// <summary>
        /// 将界面报警数据类型解析为数据库报警数据类型
        /// </summary>
        public AlarmStatusTable DataResolve(AlarmData alarmdata)
        {
            AlarmStatusTable alarmStatus = new AlarmStatusTable
            {
                ID = Guid.NewGuid(),
                StationID = StationId,
                DateTime = Dt,

                AfterChargingFair = alarmdata.AfterChargingFair,
                AntennaCirculatorOverHeat = alarmdata.AntennaCirculatorOverHeat,
                AntennaWaveGuidChain = alarmdata.AntennaWaveGuidChain,
                ModulatorSwitchReq = alarmdata.ModulatorSwitchReq,
                WaveGuidPressHumidityReq = alarmdata.WaveGuidPressHumidityReq,

                _510VFailureOnce = alarmdata._510VFailureOnce,
                BackupOnce = alarmdata.BackupOnce,
                ChargingFailureOnce = alarmdata.ChargingFailureOnce,
                ChargingFeedbackFlowRectifierUnderVolOnce = alarmdata.ChargingFeedbackFlowRectifierUnderVolOnce,
                DutyCycleOverOnce = alarmdata.DutyCycleOverOnce,
                FilaVolFailureOnce = alarmdata.FilaVolFailureOnce,
                FocusCoilAirFlowFailureOnce = alarmdata.FocusCoilAirFlowFailureOnce,
                FocusCoilCurFailureOnce = alarmdata.FocusCoilCurFailureOnce,
                FocusCoilVolFailureOnce = alarmdata.FocusCoilVolFailureOnce,
                KlystronAirFlowAlarmOnce = alarmdata.KlystronAirFlowAlarmOnce,
                KlystronAirTempAlarmOnce = alarmdata.KlystronAirTempAlarmOnce,
                KlystronFilaFailureOnce = alarmdata.KlystronFilaFailureOnce,
                KlystronOverCurOnce = alarmdata.KlystronOverCurOnce,
                KlystronTitPumpFailureOnce = alarmdata.KlystronTitPumpFailureOnce,
                LowPowerFailureOnce = alarmdata.LowPowerFailureOnce,
                ModulatorNegPeakOverOnce = alarmdata.ModulatorNegPeakOverOnce,
                ModulatorOverOnce = alarmdata.ModulatorOverOnce,
                ModulatorSwitchFailureOnce = alarmdata.ModulatorSwitchFailureOnce,
                PowerGridUnderVolOnce = alarmdata.PowerGridUnderVolOnce,
                RackAirFlowAlarmOnce = alarmdata.RackAirFlowAlarmOnce,
                RackAirTempAlarmOnce = alarmdata.RackAirTempAlarmOnce,
                RackDoorChainOnce = alarmdata.RackDoorChainOnce,
                TankLevelAlarmOnce = alarmdata.TankLevelAlarmOnce,
                TankTempAlarmOnce = alarmdata.TankTempAlarmOnce,
                TitPumpFailureOnce = alarmdata.TitPumpFailureOnce,
                TransmitOverCurOnce = alarmdata.TransmitOverCurOnce,
                TransmitOverVolOnce = alarmdata.TransmitOverVolOnce,
                TriggerFailureOnce = alarmdata.TriggerFailureOnce,
                WaveGuidArcAlarmOnce = alarmdata.WaveGuidArcAlarmOnce,
                WaveGuidPressAlarmOnce = alarmdata.WaveGuidPressAlarmOnce,

                _510VFailureQuintic = alarmdata._510VFailureQuintic,
                BackupQuintic = alarmdata.BackupQuintic,
                ChargingFailureQuintic = alarmdata.ChargingFailureQuintic,
                ChargingFeedbackFlowRectifierUnderVolQuintic = alarmdata.ChargingFeedbackFlowRectifierUnderVolQuintic,
                DutyCycleOverQuintic = alarmdata.DutyCycleOverQuintic,
                FilaVolFailureQuintic = alarmdata.FilaVolFailureQuintic,
                FocusCoilAirFlowFailureQuintic = alarmdata.FocusCoilAirFlowFailureQuintic,
                FocusCoilCurFailureQuintic = alarmdata.FocusCoilCurFailureQuintic,
                FocusCoilVolFailureQuintic = alarmdata.FocusCoilVolFailureQuintic,
                KlystronAirFlowAlarmQuintic = alarmdata.KlystronAirFlowAlarmQuintic,
                KlystronAirTempAlarmQuintic = alarmdata.KlystronAirTempAlarmQuintic,
                KlystronFilaFailureQuintic = alarmdata.KlystronFilaFailureQuintic,
                KlystronOverCurQuintic = alarmdata.KlystronOverCurQuintic,
                KlystronTitPumpFailureQuintic = alarmdata.KlystronTitPumpFailureQuintic,
                LowPowerFailureQuintic = alarmdata.LowPowerFailureQuintic,
                ModulatorNegPeakOverQuintic = alarmdata.ModulatorNegPeakOverQuintic,
                ModulatorOverQuintic = alarmdata.ModulatorOverQuintic,
                ModulatorSwitchFailureQuintic = alarmdata.ModulatorSwitchFailureQuintic,
                PowerGridUnderVolQuintic = alarmdata.PowerGridUnderVolQuintic,
                RackAirFlowAlarmQuintic = alarmdata.RackAirFlowAlarmQuintic,
                RackAirTempAlarmQuintic = alarmdata.RackAirTempAlarmQuintic,
                RackDoorChainQuintic = alarmdata.RackDoorChainQuintic,
                TankLevelAlarmQuintic = alarmdata.TankLevelAlarmQuintic,
                TankTempAlarmQuintic = alarmdata.TankTempAlarmQuintic,
                TitPumpFailureQuintic = alarmdata.TitPumpFailureQuintic,
                TransmitOverCurQuintic = alarmdata.TransmitOverCurQuintic,
                TransmitOverVolQuintic = alarmdata.TransmitOverVolQuintic,
                TriggerFailureQuintic = alarmdata.TriggerFailureQuintic,
                WaveGuidArcAlarmQuintic = alarmdata.WaveGuidArcAlarmQuintic,
                WaveGuidPressAlarmQuintic = alarmdata.WaveGuidPressAlarmQuintic,
            };
            return alarmStatus;
        }

        /// <summary>
        /// 将界面状态数据类型解析为数据库状态数据类型
        /// </summary>
        public ControlStatusTable DataResolve(StatusData statusdata)
        {
            ControlStatusTable controlStatus = new ControlStatusTable
            {
                ID = Guid.NewGuid(),
                StationID = StationId,
                DateTime = Dt,
                AllowOn = statusdata.AllowOn,
                Antenna = statusdata.Antenna,
                Auto = statusdata.Auto,
                Backup = statusdata.Backup,
                BroadPulse = statusdata.BroadPulse,
                Fault = statusdata.Fault,
                FilaSupply = statusdata.FilaSup,
                HighVoloff = statusdata.HVoff,
                HighVolon = statusdata.HVon,
                Load = statusdata.Load,
                LocalCtrl = statusdata.LocalCtrl,
                Manual = statusdata.Manual,
                Preheat = statusdata.Preheat,
                RemoteCtrl = statusdata.RemoteCtrl,
                RepeatCycle = statusdata.RepeatCycle,
                SpikePulse = statusdata.SpikePulse,
            };
            return controlStatus;
        }

        /// <summary>
        /// 将界面电源数据类型解析为数据库电源数据类型
        /// </summary>
        public PowerDataTable DataResolve(RadarPower powerdata)
        {
            PowerDataTable powerData = new PowerDataTable
            {
                ID = Guid.NewGuid(),
                StationID = StationId,
                DateTime = Dt,
                CurArtifLine = powerdata.CurArtifLine,
                CurCatho = powerdata.CurCatho,
                CurFilament = powerdata.CurFilament,
                CurFocusCoil = powerdata.CurFocusCoil,
                CurLeveling = powerdata.CurLeveling,
                CurReversePeak = powerdata.CurReversePeak,
                CurTitPump = powerdata.CurTitPump,
                Vol15 = powerdata.Vol15,
                Vol28 = powerdata.Vol28,
                Vol45 = powerdata.Vol45,
                Vol5 = powerdata.Vol5,
                Vol510 = powerdata.Vol510,
                VolArtifLine = powerdata.VolArtifLine,
                VolEleBeam = powerdata.VolEleBeam,
                VolField = powerdata.VolField,
                VolFilaInve = powerdata.VolFilaInve,
                VolFilament = powerdata.VolFilament,
                VolNeg15 = powerdata.VolNeg15,
                VolTitPump = powerdata.VolTitPump,
            };
            return powerData;
        }

        /// <summary>
        /// 将本地SQLite报警数据类型解析为数据库报警数据类型
        /// </summary>
        public List<AlarmStatusTable> DataResolve(List<Lrdm.AlarmStatusModels> lstalarmdata)
        {
            List<AlarmStatusTable> lstAlarmStatuses = new List<AlarmStatusTable>();
            if (lstalarmdata.Any())
            {
                lstAlarmStatuses.AddRange(lstalarmdata.Select(alarmdata =>
                new AlarmStatusTable
                {
                    ID = Guid.NewGuid(),
                    StationID = alarmdata.StationID,
                    DateTime = alarmdata.DateTime,

                    AfterChargingFair = alarmdata.AfterChargingFair,
                    AntennaCirculatorOverHeat = alarmdata.AntennaCirculatorOverHeat,
                    AntennaWaveGuidChain = alarmdata.AntennaWaveGuidChain,
                    ModulatorSwitchReq = alarmdata.ModulatorSwitchReq,
                    WaveGuidPressHumidityReq = alarmdata.WaveGuidPressHumidityReq,

                    _510VFailureOnce = alarmdata._510VFailureOnce,
                    BackupOnce = alarmdata.BackupOnce,
                    ChargingFailureOnce = alarmdata.ChargingFailureOnce,
                    ChargingFeedbackFlowRectifierUnderVolOnce = alarmdata.ChargingFeedbackFlowRectifierUnderVolOnce,
                    DutyCycleOverOnce = alarmdata.DutyCycleOverOnce,
                    FilaVolFailureOnce = alarmdata.FilaVolFailureOnce,
                    FocusCoilAirFlowFailureOnce = alarmdata.FocusCoilAirFlowFailureOnce,
                    FocusCoilCurFailureOnce = alarmdata.FocusCoilCurFailureOnce,
                    FocusCoilVolFailureOnce = alarmdata.FocusCoilVolFailureOnce,
                    KlystronAirFlowAlarmOnce = alarmdata.KlystronAirFlowAlarmOnce,
                    KlystronAirTempAlarmOnce = alarmdata.KlystronAirTempAlarmOnce,
                    KlystronFilaFailureOnce = alarmdata.KlystronFilaFailureOnce,
                    KlystronOverCurOnce = alarmdata.KlystronOverCurOnce,
                    KlystronTitPumpFailureOnce = alarmdata.KlystronTitPumpFailureOnce,
                    LowPowerFailureOnce = alarmdata.LowPowerFailureOnce,
                    ModulatorNegPeakOverOnce = alarmdata.ModulatorNegPeakOverOnce,
                    ModulatorOverOnce = alarmdata.ModulatorOverOnce,
                    ModulatorSwitchFailureOnce = alarmdata.ModulatorSwitchFailureOnce,
                    PowerGridUnderVolOnce = alarmdata.PowerGridUnderVolOnce,
                    RackAirFlowAlarmOnce = alarmdata.RackAirFlowAlarmOnce,
                    RackAirTempAlarmOnce = alarmdata.RackAirTempAlarmOnce,
                    RackDoorChainOnce = alarmdata.RackDoorChainOnce,
                    TankLevelAlarmOnce = alarmdata.TankLevelAlarmOnce,
                    TankTempAlarmOnce = alarmdata.TankTempAlarmOnce,
                    TitPumpFailureOnce = alarmdata.TitPumpFailureOnce,
                    TransmitOverCurOnce = alarmdata.TransmitOverCurOnce,
                    TransmitOverVolOnce = alarmdata.TransmitOverVolOnce,
                    TriggerFailureOnce = alarmdata.TriggerFailureOnce,
                    WaveGuidArcAlarmOnce = alarmdata.WaveGuidArcAlarmOnce,
                    WaveGuidPressAlarmOnce = alarmdata.WaveGuidPressAlarmOnce,

                    _510VFailureQuintic = alarmdata._510VFailureQuintic,
                    BackupQuintic = alarmdata.BackupQuintic,
                    ChargingFailureQuintic = alarmdata.ChargingFailureQuintic,
                    ChargingFeedbackFlowRectifierUnderVolQuintic = alarmdata.ChargingFeedbackFlowRectifierUnderVolQuintic,
                    DutyCycleOverQuintic = alarmdata.DutyCycleOverQuintic,
                    FilaVolFailureQuintic = alarmdata.FilaVolFailureQuintic,
                    FocusCoilAirFlowFailureQuintic = alarmdata.FocusCoilAirFlowFailureQuintic,
                    FocusCoilCurFailureQuintic = alarmdata.FocusCoilCurFailureQuintic,
                    FocusCoilVolFailureQuintic = alarmdata.FocusCoilVolFailureQuintic,
                    KlystronAirFlowAlarmQuintic = alarmdata.KlystronAirFlowAlarmQuintic,
                    KlystronAirTempAlarmQuintic = alarmdata.KlystronAirTempAlarmQuintic,
                    KlystronFilaFailureQuintic = alarmdata.KlystronFilaFailureQuintic,
                    KlystronOverCurQuintic = alarmdata.KlystronOverCurQuintic,
                    KlystronTitPumpFailureQuintic = alarmdata.KlystronTitPumpFailureQuintic,
                    LowPowerFailureQuintic = alarmdata.LowPowerFailureQuintic,
                    ModulatorNegPeakOverQuintic = alarmdata.ModulatorNegPeakOverQuintic,
                    ModulatorOverQuintic = alarmdata.ModulatorOverQuintic,
                    ModulatorSwitchFailureQuintic = alarmdata.ModulatorSwitchFailureQuintic,
                    PowerGridUnderVolQuintic = alarmdata.PowerGridUnderVolQuintic,
                    RackAirFlowAlarmQuintic = alarmdata.RackAirFlowAlarmQuintic,
                    RackAirTempAlarmQuintic = alarmdata.RackAirTempAlarmQuintic,
                    RackDoorChainQuintic = alarmdata.RackDoorChainQuintic,
                    TankLevelAlarmQuintic = alarmdata.TankLevelAlarmQuintic,
                    TankTempAlarmQuintic = alarmdata.TankTempAlarmQuintic,
                    TitPumpFailureQuintic = alarmdata.TitPumpFailureQuintic,
                    TransmitOverCurQuintic = alarmdata.TransmitOverCurQuintic,
                    TransmitOverVolQuintic = alarmdata.TransmitOverVolQuintic,
                    TriggerFailureQuintic = alarmdata.TriggerFailureQuintic,
                    WaveGuidArcAlarmQuintic = alarmdata.WaveGuidArcAlarmQuintic,
                    WaveGuidPressAlarmQuintic = alarmdata.WaveGuidPressAlarmQuintic,
                }));
            }
            return lstAlarmStatuses;
        }

        /// <summary>
        /// 将本地SQLite状态数据类型解析为数据库状态数据类型
        /// </summary>
        public List<ControlStatusTable> DataResolve(List<Lrdm.ControlStatusModels> lststatusdata)
        {
            List<ControlStatusTable> lstControlStatus = new List<ControlStatusTable>();
            if (lststatusdata.Any())
            {
                lstControlStatus.AddRange(lststatusdata.Select(statusdata =>
                new ControlStatusTable
                {
                    ID = Guid.NewGuid(),
                    StationID = statusdata.StationID,
                    DateTime = statusdata.DateTime,
                    AllowOn = statusdata.AllowOn,
                    Antenna = statusdata.Antenna,
                    Auto = statusdata.Auto,
                    Backup = statusdata.Backup,
                    BroadPulse = statusdata.BroadPulse,
                    Fault = statusdata.Fault,
                    FilaSupply = statusdata.FilaSupply,
                    HighVoloff = statusdata.HighVoloff,
                    HighVolon = statusdata.HighVolon,
                    Load = statusdata.Load,
                    LocalCtrl = statusdata.LocalCtrl,
                    Manual = statusdata.Manual,
                    Preheat = statusdata.Preheat,
                    RemoteCtrl = statusdata.RemoteCtrl,
                    RepeatCycle = statusdata.RepeatCycle,
                    SpikePulse = statusdata.SpikePulse,
                }));
            }
            return lstControlStatus;
        }

        /// <summary>
        /// 将本地SQLite电源数据类型解析为数据库电源数据类型
        /// </summary>
        public List<PowerDataTable> DataResolve(List<Lrdm.PowerDataModels> lstpowerdata)
        {
            List<PowerDataTable> lstPowerData = new List<PowerDataTable>();
            if (lstpowerdata.Any())
            {
                lstPowerData.AddRange(lstpowerdata.Select(powerdata =>
                new PowerDataTable
                {
                    ID = Guid.NewGuid(),
                    StationID = powerdata.StationID,
                    DateTime = powerdata.DateTime,
                    CurArtifLine = powerdata.CurArtifLine,
                    CurCatho = powerdata.CurCatho,
                    CurFilament = powerdata.CurFilament,
                    CurFocusCoil = powerdata.CurFocusCoil,
                    CurLeveling = powerdata.CurLeveling,
                    CurReversePeak = powerdata.CurReversePeak,
                    CurTitPump = powerdata.CurTitPump,
                    Vol15 = powerdata.Vol15,
                    Vol28 = powerdata.Vol28,
                    Vol45 = powerdata.Vol45,
                    Vol5 = powerdata.Vol5,
                    Vol510 = powerdata.Vol510,
                    VolArtifLine = powerdata.VolArtifLine,
                    VolEleBeam = powerdata.VolEleBeam,
                    VolField = powerdata.VolField,
                    VolFilaInve = powerdata.VolFilaInve,
                    VolFilament = powerdata.VolFilament,
                    VolNeg15 = powerdata.VolNeg15,
                    VolTitPump = powerdata.VolTitPump,
                }));
            }
            return lstPowerData;
        }

        /// <summary>
        /// 将界面报警数据类型解析为本地SQLite数据库报警数据类型
        /// </summary>
        public Lrdm.AlarmStatusModels LocalDataResolve(AlarmData alarmdata)
        {
            Lrdm.AlarmStatusModels alarmStatus = new Lrdm.AlarmStatusModels
            {
                StationID = StationId,
                DateTime = Dt,

                AfterChargingFair = alarmdata.AfterChargingFair,
                AntennaCirculatorOverHeat = alarmdata.AntennaCirculatorOverHeat,
                AntennaWaveGuidChain = alarmdata.AntennaWaveGuidChain,
                ModulatorSwitchReq = alarmdata.ModulatorSwitchReq,
                WaveGuidPressHumidityReq = alarmdata.WaveGuidPressHumidityReq,

                _510VFailureOnce = alarmdata._510VFailureOnce,
                BackupOnce = alarmdata.BackupOnce,
                ChargingFailureOnce = alarmdata.ChargingFailureOnce,
                ChargingFeedbackFlowRectifierUnderVolOnce = alarmdata.ChargingFeedbackFlowRectifierUnderVolOnce,
                DutyCycleOverOnce = alarmdata.DutyCycleOverOnce,
                FilaVolFailureOnce = alarmdata.FilaVolFailureOnce,
                FocusCoilAirFlowFailureOnce = alarmdata.FocusCoilAirFlowFailureOnce,
                FocusCoilCurFailureOnce = alarmdata.FocusCoilCurFailureOnce,
                FocusCoilVolFailureOnce = alarmdata.FocusCoilVolFailureOnce,
                KlystronAirFlowAlarmOnce = alarmdata.KlystronAirFlowAlarmOnce,
                KlystronAirTempAlarmOnce = alarmdata.KlystronAirTempAlarmOnce,
                KlystronFilaFailureOnce = alarmdata.KlystronFilaFailureOnce,
                KlystronOverCurOnce = alarmdata.KlystronOverCurOnce,
                KlystronTitPumpFailureOnce = alarmdata.KlystronTitPumpFailureOnce,
                LowPowerFailureOnce = alarmdata.LowPowerFailureOnce,
                ModulatorNegPeakOverOnce = alarmdata.ModulatorNegPeakOverOnce,
                ModulatorOverOnce = alarmdata.ModulatorOverOnce,
                ModulatorSwitchFailureOnce = alarmdata.ModulatorSwitchFailureOnce,
                PowerGridUnderVolOnce = alarmdata.PowerGridUnderVolOnce,
                RackAirFlowAlarmOnce = alarmdata.RackAirFlowAlarmOnce,
                RackAirTempAlarmOnce = alarmdata.RackAirTempAlarmOnce,
                RackDoorChainOnce = alarmdata.RackDoorChainOnce,
                TankLevelAlarmOnce = alarmdata.TankLevelAlarmOnce,
                TankTempAlarmOnce = alarmdata.TankTempAlarmOnce,
                TitPumpFailureOnce = alarmdata.TitPumpFailureOnce,
                TransmitOverCurOnce = alarmdata.TransmitOverCurOnce,
                TransmitOverVolOnce = alarmdata.TransmitOverVolOnce,
                TriggerFailureOnce = alarmdata.TriggerFailureOnce,
                WaveGuidArcAlarmOnce = alarmdata.WaveGuidArcAlarmOnce,
                WaveGuidPressAlarmOnce = alarmdata.WaveGuidPressAlarmOnce,

                _510VFailureQuintic = alarmdata._510VFailureQuintic,
                BackupQuintic = alarmdata.BackupQuintic,
                ChargingFailureQuintic = alarmdata.ChargingFailureQuintic,
                ChargingFeedbackFlowRectifierUnderVolQuintic = alarmdata.ChargingFeedbackFlowRectifierUnderVolQuintic,
                DutyCycleOverQuintic = alarmdata.DutyCycleOverQuintic,
                FilaVolFailureQuintic = alarmdata.FilaVolFailureQuintic,
                FocusCoilAirFlowFailureQuintic = alarmdata.FocusCoilAirFlowFailureQuintic,
                FocusCoilCurFailureQuintic = alarmdata.FocusCoilCurFailureQuintic,
                FocusCoilVolFailureQuintic = alarmdata.FocusCoilVolFailureQuintic,
                KlystronAirFlowAlarmQuintic = alarmdata.KlystronAirFlowAlarmQuintic,
                KlystronAirTempAlarmQuintic = alarmdata.KlystronAirTempAlarmQuintic,
                KlystronFilaFailureQuintic = alarmdata.KlystronFilaFailureQuintic,
                KlystronOverCurQuintic = alarmdata.KlystronOverCurQuintic,
                KlystronTitPumpFailureQuintic = alarmdata.KlystronTitPumpFailureQuintic,
                LowPowerFailureQuintic = alarmdata.LowPowerFailureQuintic,
                ModulatorNegPeakOverQuintic = alarmdata.ModulatorNegPeakOverQuintic,
                ModulatorOverQuintic = alarmdata.ModulatorOverQuintic,
                ModulatorSwitchFailureQuintic = alarmdata.ModulatorSwitchFailureQuintic,
                PowerGridUnderVolQuintic = alarmdata.PowerGridUnderVolQuintic,
                RackAirFlowAlarmQuintic = alarmdata.RackAirFlowAlarmQuintic,
                RackAirTempAlarmQuintic = alarmdata.RackAirTempAlarmQuintic,
                RackDoorChainQuintic = alarmdata.RackDoorChainQuintic,
                TankLevelAlarmQuintic = alarmdata.TankLevelAlarmQuintic,
                TankTempAlarmQuintic = alarmdata.TankTempAlarmQuintic,
                TitPumpFailureQuintic = alarmdata.TitPumpFailureQuintic,
                TransmitOverCurQuintic = alarmdata.TransmitOverCurQuintic,
                TransmitOverVolQuintic = alarmdata.TransmitOverVolQuintic,
                TriggerFailureQuintic = alarmdata.TriggerFailureQuintic,
                WaveGuidArcAlarmQuintic = alarmdata.WaveGuidArcAlarmQuintic,
                WaveGuidPressAlarmQuintic = alarmdata.WaveGuidPressAlarmQuintic,
            };
            return alarmStatus;
        }

        /// <summary>
        /// 将界面状态数据类型解析为本地SQLite数据库状态数据类型
        /// </summary>
        public Lrdm.ControlStatusModels LocalDataResolve(StatusData statusdata)
        {
            Lrdm.ControlStatusModels controlStatus = new Lrdm.ControlStatusModels
            {
                StationID = StationId,
                DateTime = Dt,
                AllowOn = statusdata.AllowOn,
                Antenna = statusdata.Antenna,
                Auto = statusdata.Auto,
                Backup = statusdata.Backup,
                BroadPulse = statusdata.BroadPulse,
                Fault = statusdata.Fault,
                FilaSupply = statusdata.FilaSup,
                HighVoloff = statusdata.HVoff,
                HighVolon = statusdata.HVon,
                Load = statusdata.Load,
                LocalCtrl = statusdata.LocalCtrl,
                Manual = statusdata.Manual,
                Preheat = statusdata.Preheat,
                RemoteCtrl = statusdata.RemoteCtrl,
                RepeatCycle = statusdata.RepeatCycle,
                SpikePulse = statusdata.SpikePulse,
            };
            return controlStatus;
        }

        /// <summary>
        /// 将界面电源数据类型解析为本地SQLite数据库电源数据类型
        /// </summary>
        public Lrdm.PowerDataModels LocalDataResolve(RadarPower powerdata)
        {
            Lrdm.PowerDataModels powerData = new Lrdm.PowerDataModels
            {
                StationID = StationId,
                DateTime = Dt,
                CurArtifLine = powerdata.CurArtifLine,
                CurCatho = powerdata.CurCatho,
                CurFilament = powerdata.CurFilament,
                CurFocusCoil = powerdata.CurFocusCoil,
                CurLeveling = powerdata.CurLeveling,
                CurReversePeak = powerdata.CurReversePeak,
                CurTitPump = powerdata.CurTitPump,
                Vol15 = powerdata.Vol15,
                Vol28 = powerdata.Vol28,
                Vol45 = powerdata.Vol45,
                Vol5 = powerdata.Vol5,
                Vol510 = powerdata.Vol510,
                VolArtifLine = powerdata.VolArtifLine,
                VolEleBeam = powerdata.VolEleBeam,
                VolField = powerdata.VolField,
                VolFilaInve = powerdata.VolFilaInve,
                VolFilament = powerdata.VolFilament,
                VolNeg15 = powerdata.VolNeg15,
                VolTitPump = powerdata.VolTitPump,
            };
            return powerData;
        }

        /// <summary>
        /// 获取串口二进制数据中的报警信息中为0的索引
        /// </summary>
        private static IEnumerable<int> AlarmControlResolve(char[] charArray)
        {
            List<int> indexList = new List<int>();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '0')
                {
                    indexList.Add(i);
                }
            }
            return indexList;
        }

        //private static AlarmStatusLed ConvertStingAndEnum(string s)
        //{
        //    switch (s)
        //    {
        //        case "11":
        //            return AlarmStatusLed.Nolight;
        //        case "10":
        //            return AlarmStatusLed.Leftlight;
        //        case "01":
        //            return AlarmStatusLed.Rightlight;
        //        case "00":
        //            return AlarmStatusLed.Alllight;
        //        default:
        //            return AlarmStatusLed.Nolight;
        //    }
        //}

        //private static string ConvertStingAndEnum(AlarmStatusLed s)
        //{
        //    switch (s)
        //    {
        //        case AlarmStatusLed.Nolight:
        //            return "11";
        //        case AlarmStatusLed.Leftlight:
        //            return "10";
        //        case AlarmStatusLed.Rightlight:
        //            return "01";
        //        case AlarmStatusLed.Alllight:
        //            return "00";
        //        default:
        //            return "11";
        //    }
        //}

        /// <summary>
        /// 将为0的索引转为实际界面上的报警信息
        /// </summary>
        private static AlarmData ReturnAlarmData(string strAlarmMsg)
        {
            AlarmData alarmStatusDataTemp = new AlarmData
            {
                PowerGridUnderVolOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[7].ToString())),
                PowerGridUnderVolQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[6].ToString())),
                LowPowerFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[5].ToString())),
                LowPowerFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[4].ToString())),
                FilaVolFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[3].ToString())),
                FilaVolFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[2].ToString())),
                TitPumpFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[1].ToString())),
                TitPumpFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[0].ToString())),

                FocusCoilVolFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[15].ToString())),
                FocusCoilVolFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[14].ToString())),
                TransmitOverVolOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[13].ToString())),
                TransmitOverVolQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[12].ToString())),
                TransmitOverCurOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[11].ToString())),
                TransmitOverCurQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[10].ToString())),
                FocusCoilCurFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[9].ToString())),
                FocusCoilCurFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[8].ToString())),

                FocusCoilAirFlowFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[23].ToString())),
                FocusCoilAirFlowFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[22].ToString())),
                TriggerFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[21].ToString())),
                TriggerFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[20].ToString())),
                ChargingFeedbackFlowRectifierUnderVolOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[19].ToString())),
                ChargingFeedbackFlowRectifierUnderVolQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[18].ToString())),
                ChargingFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[17].ToString())),
                ChargingFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[16].ToString())),

                ModulatorOverOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[31].ToString())),
                ModulatorOverQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[30].ToString())),
                ModulatorNegPeakOverOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[29].ToString())),
                ModulatorNegPeakOverQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[28].ToString())),
                ModulatorSwitchFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[27].ToString())),
                ModulatorSwitchFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[26].ToString())),
                KlystronOverCurOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[25].ToString())),
                KlystronOverCurQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[24].ToString())),

                KlystronFilaFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[39].ToString())),
                KlystronFilaFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[38].ToString())),
                KlystronTitPumpFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[37].ToString())),
                KlystronTitPumpFailureQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[36].ToString())),
                KlystronAirTempAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[35].ToString())),
                KlystronAirTempAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[34].ToString())),
                KlystronAirFlowAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[33].ToString())),
                KlystronAirFlowAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[32].ToString())),

                WaveGuidPressAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[47].ToString())),
                WaveGuidPressAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[46].ToString())),
                WaveGuidArcAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[45].ToString())),
                WaveGuidArcAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[44].ToString())),
                TankLevelAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[43].ToString())),
                TankLevelAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[42].ToString())),
                TankTempAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[41].ToString())),
                TankTempAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[40].ToString())),

                AntennaWaveGuidChain = Convert.ToBoolean(int.Parse(strAlarmMsg[55].ToString())),
                AntennaCirculatorOverHeat = Convert.ToBoolean(int.Parse(strAlarmMsg[54].ToString())),
                RackDoorChainOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[53].ToString())),
                RackDoorChainQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[52].ToString())),
                RackAirTempAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[51].ToString())),
                RackAirTempAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[50].ToString())),
                RackAirFlowAlarmOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[49].ToString())),
                RackAirFlowAlarmQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[48].ToString())),

                DutyCycleOverOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[63].ToString())),
                DutyCycleOverQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[62].ToString())),
                WaveGuidPressHumidityReq = Convert.ToBoolean(int.Parse(strAlarmMsg[61].ToString())),
                ModulatorSwitchReq = Convert.ToBoolean(int.Parse(strAlarmMsg[60].ToString())),
                AfterChargingFair = Convert.ToBoolean(int.Parse(strAlarmMsg[59].ToString())),
                BackupOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[58].ToString())),
                BackupQuintic = Convert.ToBoolean(int.Parse(strAlarmMsg[57].ToString())),
                _510VFailureOnce = Convert.ToBoolean(int.Parse(strAlarmMsg[56].ToString())),
                _510VFailureQuintic = true,
            };
            return alarmStatusDataTemp;
        }

        /// <summary>
        /// 将为0的索引转为实际界面上的状态信息
        /// </summary>
        private static StatusData ReturnControlData(IEnumerable<int> indexList)
        {
            StatusData controlStatusDataTemp = new StatusData();
            foreach (int i in indexList)
            {
                switch (i)
                {
                    case 0:
                        controlStatusDataTemp.AllowOn = true;
                        break;

                    case 1:
                        controlStatusDataTemp.Load = true;
                        break;

                    case 2:
                        controlStatusDataTemp.Antenna = true;
                        break;

                    case 3:
                        controlStatusDataTemp.RepeatCycle = true;
                        break;

                    case 4:
                        controlStatusDataTemp.Preheat = true;
                        break;

                    case 5:
                        controlStatusDataTemp.FilaSup = true;
                        break;

                    case 6:
                        controlStatusDataTemp.RemoteCtrl = true;
                        break;

                    case 7:
                        controlStatusDataTemp.LocalCtrl = true;
                        break;

                    case 8:
                        controlStatusDataTemp.Backup = true;
                        break;

                    case 9:
                        controlStatusDataTemp.Fault = true;
                        break;

                    case 10:
                        controlStatusDataTemp.HVoff = true;
                        break;

                    case 11:
                        controlStatusDataTemp.HVon = true;
                        break;

                    case 12:
                        controlStatusDataTemp.Manual = true;
                        break;

                    case 13:
                        controlStatusDataTemp.Auto = true;
                        break;

                    case 14:
                        controlStatusDataTemp.SpikePulse = true;
                        break;

                    case 15:
                        controlStatusDataTemp.BroadPulse = true;
                        break;
                }
            }
            return controlStatusDataTemp;
        }
    }
}