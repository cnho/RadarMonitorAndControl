using System.ComponentModel;

namespace Common
{
    /// <summary>
    /// 报警状态数据结构
    /// </summary>
    public class AlarmData
    {
        /// <summary>
        /// The  Voltage
        /// </summary>
        [Description("510V电源故障一次报警")]
        public bool? _510VFailureOnce;

        /// <summary>
        /// The houchongdianjiaoping
        /// </summary>
        [Description("后充电校平故障报警")]
        public bool? AfterChargingFair;

        /// <summary>
        /// The tianxianhuanliuqiguoren
        /// </summary>
        [Description("天线环流器过热故障报警")]
        public bool? AntennaCirculatorOverHeat;

        /// <summary>
        /// The tianxianbodaoliansuo
        /// </summary>
        [Description("天线波导连锁故障报警")]
        public bool? AntennaWaveGuidChain;

        /// <summary>
        /// The backup
        /// </summary>
        [Description("备份一次报警")]
        public bool? BackupOnce;

        /// <summary>
        /// The chongdianguzhang
        /// </summary>
        [Description("充电故障一次报警")]
        public bool? ChargingFailureOnce;

        /// <summary>
        /// The chongdianxitongguoliu
        /// </summary>
        [Description("充电回授过流或整流欠压故障一次报警")]
        public bool? ChargingFeedbackFlowRectifierUnderVolOnce;

        /// <summary>
        /// The zhankongbichaoxian
        /// </summary>
        [Description("占空比超限故障一次报警")]
        public bool? DutyCycleOverOnce;

        /// <summary>
        /// The dengsidianya
        /// </summary>
        [Description("灯丝电压故障一次报警")]
        public bool? FilaVolFailureOnce;

        /// <summary>
        /// The jujiaoxianquanfengliuliang
        /// </summary>
        [Description("聚焦线圈风流量故障一次报警")]
        public bool? FocusCoilAirFlowFailureOnce;

        /// <summary>
        /// The jujiaoxianquandianliu
        /// </summary>
        [Description("聚焦线圈电流故障一次报警")]
        public bool? FocusCoilCurFailureOnce;

        /// <summary>
        /// The jujiaoxianquandianya
        /// </summary>
        [Description("聚焦线圈电压故障一次报警")]
        public bool? FocusCoilVolFailureOnce;

        /// <summary>
        /// The sutiaoguanfengliuliang
        /// </summary>
        [Description("速调管风流量故障一次报警")]
        public bool? KlystronAirFlowAlarmOnce;

        /// <summary>
        /// The sutiaoguanfengwen
        /// </summary>
        [Description("速调管风温故障一次报警")]
        public bool? KlystronAirTempAlarmOnce;

        /// <summary>
        /// The sutiaoguandengsidianliu
        /// </summary>
        [Description("速调管灯丝电流故障一次报警")]
        public bool? KlystronFilaFailureOnce;

        /// <summary>
        /// The sutiaoguanguoliu
        /// </summary>
        [Description("速调管过流故障一次报警")]
        public bool? KlystronOverCurOnce;

        /// <summary>
        /// The sutiaoguantaibengdianliu
        /// </summary>
        [Description("速调管钛泵电流故障一次报警")]
        public bool? KlystronTitPumpFailureOnce;

        /// <summary>
        /// The diyazonghe
        /// </summary>
        [Description("低压电源综合故障一次报警")]
        public bool? LowPowerFailureOnce;

        /// <summary>
        /// The tiaozhiqifanfengguoliu
        /// </summary>
        [Description("调制器反峰过流故障一次报警")]
        public bool? ModulatorNegPeakOverOnce;

        /// <summary>
        /// The tiaozhiqiguoliu
        /// </summary>
        [Description("调制器过流故障一次报警")]
        public bool? ModulatorOverOnce;

        /// <summary>
        /// The tiaozhiqikaiguanguzhang
        /// </summary>
        [Description("调制器开关故障一次报警")]
        public bool? ModulatorSwitchFailureOnce;

        /// <summary>
        /// The tiaozhikaiguan
        /// </summary>
        [Description("调制器开关维修请求报警")]
        public bool? ModulatorSwitchReq;

        /// <summary>
        /// The dianwangqianya
        /// </summary>
        [Description("电网电源欠压一次报警")]
        public bool? PowerGridUnderVolOnce;

        /// <summary>
        /// The jiguifengliuliang
        /// </summary>
        [Description("机柜风流量故障一次报警")]
        public bool? RackAirFlowAlarmOnce;

        /// <summary>
        /// The jiguifengwen
        /// </summary>
        [Description("机柜风温故障一次报警")]
        public bool? RackAirTempAlarmOnce;

        /// <summary>
        /// The jiguimenliansuo
        /// </summary>
        [Description("机柜门连锁一次报警")]
        public bool? RackDoorChainOnce;

        /// <summary>
        /// The youxiangyouyemian
        /// </summary>
        [Description("油箱油液面故障一次报警")]
        public bool? TankLevelAlarmOnce;

        /// <summary>
        /// The youxiangyouwen
        /// </summary>
        [Description("油箱油温故障一次报警")]
        public bool? TankTempAlarmOnce;

        /// <summary>
        /// The taibengdianya
        /// </summary>
        [Description("钛泵电压故障一次报警")]
        public bool? TitPumpFailureOnce;

        /// <summary>
        /// The fashejiguoliu
        /// </summary>
        [Description("发射机过流故障一次报警")]
        public bool? TransmitOverCurOnce;

        /// <summary>
        /// The fashejiguoya
        /// </summary>
        [Description("发射机过压故障一次报警")]
        public bool? TransmitOverVolOnce;

        /// <summary>
        /// The chufaqiguzhang
        /// </summary>
        [Description("触发器故障一次报警")]
        public bool? TriggerFailureOnce;

        /// <summary>
        /// The bodaodianhu
        /// </summary>
        [Description("波导电弧故障一次报警")]
        public bool? WaveGuidArcAlarmOnce;

        /// <summary>
        /// The bodaoyali
        /// </summary>
        [Description("波导压力故障一次报警")]
        public bool? WaveGuidPressAlarmOnce;

        /// <summary>
        /// The bodaoyalishidu
        /// </summary>
        [Description("波导压力湿度维修请求报警")]
        public bool? WaveGuidPressHumidityReq;

        /// <summary>
        /// The  Voltage
        /// </summary>
        [Description("510V电源故障五次报警")]
        public bool? _510VFailureQuintic;

        /// <summary>
        /// The backup
        /// </summary>
        [Description("备份五次报警")]
        public bool? BackupQuintic;

        /// <summary>
        /// The chongdianguzhang
        /// </summary>
        [Description("充电故障五次报警")]
        public bool? ChargingFailureQuintic;

        /// <summary>
        /// The chongdianxitongguoliu
        /// </summary>
        [Description("充电回授过流或整流欠压故障五次报警")]
        public bool? ChargingFeedbackFlowRectifierUnderVolQuintic;

        /// <summary>
        /// The zhankongbichaoxian
        /// </summary>
        [Description("占空比超限故障五次报警")]
        public bool? DutyCycleOverQuintic;

        /// <summary>
        /// The dengsidianya
        /// </summary>
        [Description("灯丝电压故障五次报警")]
        public bool? FilaVolFailureQuintic;

        /// <summary>
        /// The jujiaoxianquanfengliuliang
        /// </summary>
        [Description("聚焦线圈风流量故障五次报警")]
        public bool? FocusCoilAirFlowFailureQuintic;

        /// <summary>
        /// The jujiaoxianquandianliu
        /// </summary>
        [Description("聚焦线圈电流故障五次报警")]
        public bool? FocusCoilCurFailureQuintic;

        /// <summary>
        /// The jujiaoxianquandianya
        /// </summary>
        [Description("聚焦线圈电压故障五次报警")]
        public bool? FocusCoilVolFailureQuintic;

        /// <summary>
        /// The sutiaoguanfengliuliang
        /// </summary>
        [Description("速调管风流量故障五次报警")]
        public bool? KlystronAirFlowAlarmQuintic;

        /// <summary>
        /// The sutiaoguanfengwen
        /// </summary>
        [Description("速调管风温故障五次报警")]
        public bool? KlystronAirTempAlarmQuintic;

        /// <summary>
        /// The sutiaoguandengsidianliu
        /// </summary>
        [Description("速调管灯丝电流故障五次报警")]
        public bool? KlystronFilaFailureQuintic;

        /// <summary>
        /// The sutiaoguanguoliu
        /// </summary>
        [Description("速调管过流故障五次报警")]
        public bool? KlystronOverCurQuintic;

        /// <summary>
        /// The sutiaoguantaibengdianliu
        /// </summary>
        [Description("速调管钛泵电流故障五次报警")]
        public bool? KlystronTitPumpFailureQuintic;

        /// <summary>
        /// The diyazonghe
        /// </summary>
        [Description("低压电源综合故障五次报警")]
        public bool? LowPowerFailureQuintic;

        /// <summary>
        /// The tiaozhiqifanfengguoliu
        /// </summary>
        [Description("调制器反峰过流故障五次报警")]
        public bool? ModulatorNegPeakOverQuintic;

        /// <summary>
        /// The tiaozhiqiguoliu
        /// </summary>
        [Description("调制器过流故障五次报警")]
        public bool? ModulatorOverQuintic;

        /// <summary>
        /// The tiaozhiqikaiguanguzhang
        /// </summary>
        [Description("调制器开关故障五次报警")]
        public bool? ModulatorSwitchFailureQuintic;

        /// <summary>
        /// The dianwangqianya
        /// </summary>
        [Description("电网电源欠压五次报警")]
        public bool? PowerGridUnderVolQuintic;

        /// <summary>
        /// The jiguifengliuliang
        /// </summary>
        [Description("机柜风流量故障五次报警")]
        public bool? RackAirFlowAlarmQuintic;

        /// <summary>
        /// The jiguifengwen
        /// </summary>
        [Description("机柜风温故障五次报警")]
        public bool? RackAirTempAlarmQuintic;

        /// <summary>
        /// The jiguimenliansuo
        /// </summary>
        [Description("机柜门连锁五次报警")]
        public bool? RackDoorChainQuintic;

        /// <summary>
        /// The youxiangyouyemian
        /// </summary>
        [Description("油箱油液面故障五次报警")]
        public bool? TankLevelAlarmQuintic;

        /// <summary>
        /// The youxiangyouwen
        /// </summary>
        [Description("油箱油温故障五次报警")]
        public bool? TankTempAlarmQuintic;

        /// <summary>
        /// The taibengdianya
        /// </summary>
        [Description("钛泵电压故障五次报警")]
        public bool? TitPumpFailureQuintic;

        /// <summary>
        /// The fashejiguoliu
        /// </summary>
        [Description("发射机过流故障五次报警")]
        public bool? TransmitOverCurQuintic;

        /// <summary>
        /// The fashejiguoya
        /// </summary>
        [Description("发射机过压故障五次报警")]
        public bool? TransmitOverVolQuintic;

        /// <summary>
        /// The chufaqiguzhang
        /// </summary>
        [Description("触发器故障五次报警")]
        public bool? TriggerFailureQuintic;

        /// <summary>
        /// The bodaodianhu
        /// </summary>
        [Description("波导电弧故障五次报警")]
        public bool? WaveGuidArcAlarmQuintic;

        /// <summary>
        /// The bodaoyali
        /// </summary>
        [Description("波导压力故障五次报警")]
        public bool? WaveGuidPressAlarmQuintic;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlarmData"/> struct.
        /// </summary>
        public AlarmData()
        {
            PowerGridUnderVolOnce = true;
            LowPowerFailureOnce = true;
            FilaVolFailureOnce = true;
            TitPumpFailureOnce = true;
            FocusCoilVolFailureOnce = true;
            TransmitOverVolOnce = true;
            TransmitOverCurOnce = true;
            FocusCoilCurFailureOnce = true;
            FocusCoilAirFlowFailureOnce = true;
            TriggerFailureOnce = true;
            ChargingFeedbackFlowRectifierUnderVolOnce = true;
            ChargingFailureOnce = true;
            ModulatorOverOnce = true;
            ModulatorNegPeakOverOnce = true;
            ModulatorSwitchFailureOnce = true;
            KlystronOverCurOnce = true;
            KlystronFilaFailureOnce = true;
            KlystronTitPumpFailureOnce = true;
            KlystronAirTempAlarmOnce = true;
            KlystronAirFlowAlarmOnce = true;
            WaveGuidPressAlarmOnce = true;
            WaveGuidArcAlarmOnce = true;
            TankLevelAlarmOnce = true;
            TankTempAlarmOnce = true;
            AntennaWaveGuidChain = true;
            AntennaCirculatorOverHeat = true;
            RackDoorChainOnce = true;
            RackAirTempAlarmOnce = true;
            RackAirFlowAlarmOnce = true;
            DutyCycleOverOnce = true;
            WaveGuidPressHumidityReq = true;
            ModulatorSwitchReq = true;
            AfterChargingFair = true;
            _510VFailureOnce = true;
            BackupOnce = true;
            PowerGridUnderVolQuintic = true;
            LowPowerFailureQuintic = true;
            FilaVolFailureQuintic = true;
            TitPumpFailureQuintic = true;
            FocusCoilVolFailureQuintic = true;
            TransmitOverVolQuintic = true;
            TransmitOverCurQuintic = true;
            FocusCoilCurFailureQuintic = true;
            FocusCoilAirFlowFailureQuintic = true;
            TriggerFailureQuintic = true;
            ChargingFeedbackFlowRectifierUnderVolQuintic = true;
            ChargingFailureQuintic = true;
            ModulatorOverQuintic = true;
            ModulatorNegPeakOverQuintic = true;
            ModulatorSwitchFailureQuintic = true;
            KlystronOverCurQuintic = true;
            KlystronFilaFailureQuintic = true;
            KlystronTitPumpFailureQuintic = true;
            KlystronAirTempAlarmQuintic = true;
            KlystronAirFlowAlarmQuintic = true;
            WaveGuidPressAlarmQuintic = true;
            WaveGuidArcAlarmQuintic = true;
            TankLevelAlarmQuintic = true;
            TankTempAlarmQuintic = true;
            RackDoorChainQuintic = true;
            RackAirTempAlarmQuintic = true;
            RackAirFlowAlarmQuintic = true;
            DutyCycleOverQuintic = true;
            _510VFailureQuintic = true;
            BackupQuintic = true;
        }
    }

    /// <summary>
    /// 状态指示数据结构
    /// </summary>
    public class StatusData
    {
        /// <summary>
        /// The allow on
        /// </summary>
        [Description("准加")]
        public bool? AllowOn;

        /// <summary>
        /// The antenna
        /// </summary>
        [Description("天线")]
        public bool? Antenna;

        /// <summary>
        /// The automatic
        /// </summary>
        [Description("自动")]
        public bool? Auto;

        /// <summary>
        /// The backup
        /// </summary>
        [Description("备份")]
        public bool? Backup;

        /// <summary>
        /// The broad pulse
        /// </summary>
        [Description("宽脉冲")]
        public bool? BroadPulse;

        /// <summary>
        /// The fault
        /// </summary>
        [Description("故障")]
        public bool? Fault;

        /// <summary>
        /// The fila sup
        /// </summary>
        [Description("灯丝供电")]
        public bool? FilaSup;

        /// <summary>
        /// The h voff
        /// </summary>
        [Description("高压断")]
        public bool? HVoff;

        /// <summary>
        /// The h von
        /// </summary>
        [Description("高压通")]
        public bool? HVon;

        /// <summary>
        /// The load
        /// </summary>
        [Description("负载")]
        public bool? Load;

        /// <summary>
        /// The local control
        /// </summary>
        [Description("本控")]
        public bool? LocalCtrl;

        /// <summary>
        /// The manual
        /// </summary>
        [Description("手动")]
        public bool? Manual;

        /// <summary>
        /// The preheat
        /// </summary>
        [Description("预热")]
        public bool? Preheat;

        /// <summary>
        /// The remote control
        /// </summary>
        [Description("遥控")]
        public bool? RemoteCtrl;

        /// <summary>
        /// The repeat cycle
        /// </summary>
        [Description("重复循环")]
        public bool? RepeatCycle;

        /// <summary>
        /// The spike pulse
        /// </summary>
        [Description("窄脉冲")]
        public bool? SpikePulse;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusData"/> struct.
        /// </summary>
        public StatusData()
        {
            LocalCtrl = false;
            RemoteCtrl = false;
            FilaSup = false;
            Preheat = false;
            RepeatCycle = false;
            Antenna = false;
            Load = false;
            AllowOn = false;
            BroadPulse = false;
            SpikePulse = false;
            Auto = false;
            Manual = false;
            HVon = false;
            HVoff = false;
            Fault = false;
            Backup = false;
        }
    }

    /// <summary>
    /// 电压电流数据结构
    /// </summary>
    public class RadarPower
    {
        /// <summary>
        /// The current artif line
        /// </summary>
        [Description("人工线电流")]
        public decimal? CurArtifLine;

        /// <summary>
        /// The current catho
        /// </summary>
        [Description("阴极电流")]
        public decimal? CurCatho;

        /// <summary>
        /// The current filament
        /// </summary>
        [Description("灯丝电流")]
        public decimal? CurFilament;

        /// <summary>
        /// The current focus coil
        /// </summary>
        [Description("聚焦线圈电流")]
        public decimal? CurFocusCoil;

        /// <summary>
        /// The current leveling
        /// </summary>
        [Description("校平电流")]
        public decimal? CurLeveling;

        /// <summary>
        /// The current reverse peak
        /// </summary>
        [Description("反峰电流")]
        public decimal? CurReversePeak;

        /// <summary>
        /// The current tit pump
        /// </summary>
        [Description("钛泵电流")]
        public decimal? CurTitPump;

        /// <summary>
        /// The vol15
        /// </summary>
        [Description("15V电压")]
        public decimal? Vol15;

        /// <summary>
        /// The vol28
        /// </summary>
        [Description("28V电压")]
        public decimal? Vol28;

        /// <summary>
        /// The vol45
        /// </summary>
        [Description("45V电压")]
        public decimal? Vol45;

        /// <summary>
        /// The vol5
        /// </summary>
        [Description("5V电压")]
        public decimal? Vol5;

        /// <summary>
        /// The vol510
        /// </summary>
        [Description("510V电压")]
        public decimal? Vol510;

        /// <summary>
        /// The vol artif line
        /// </summary>
        [Description("人工线电压")]
        public decimal? VolArtifLine;

        /// <summary>
        /// The vol ele beam
        /// </summary>
        [Description("电子注电压")]
        public decimal? VolEleBeam;

        /// <summary>
        /// The vol field
        /// </summary>
        [Description("磁场电压")]
        public decimal? VolField;

        /// <summary>
        /// The vol fila inve
        /// </summary>
        [Description("灯丝逆变电压")]
        public decimal? VolFilaInve;

        /// <summary>
        /// The vol filament
        /// </summary>
        [Description("灯丝电压")]
        public decimal? VolFilament;

        /// <summary>
        /// The vol neg15
        /// </summary>
        [Description("-15V电压")]
        public decimal? VolNeg15;

        /// <summary>
        /// The vol tit pump
        /// </summary>
        [Description("钛泵电压")]
        public decimal? VolTitPump;
    }
}