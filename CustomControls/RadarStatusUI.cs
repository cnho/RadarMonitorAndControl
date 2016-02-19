using Common;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class RadarStatusUi : UserControl
    {
        public RadarStatusUi()
        {
            InitializeComponent();
        }

        public void SetAlarmStatus(AlarmData alarmData)
        {
            LedPowerGridUnderVol.SetFaultLed(alarmData.PowerGridUnderVolOnce, alarmData.PowerGridUnderVolQuintic);
            LedLowPowerFailure.SetFaultLed(alarmData.LowPowerFailureOnce, alarmData.LowPowerFailureQuintic);
            LedFilaVolFailure.SetFaultLed(alarmData.FilaVolFailureOnce, alarmData.FilaVolFailureQuintic);
            LedTitPumpFailure.SetFaultLed(alarmData.TitPumpFailureOnce, alarmData.TitPumpFailureQuintic);
            LedFocusCoilVolFailure.SetFaultLed(alarmData.FocusCoilVolFailureOnce, alarmData.FocusCoilVolFailureQuintic);
            LedTransmitOverVol.SetFaultLed(alarmData.TransmitOverVolOnce, alarmData.TransmitOverVolQuintic);
            LedTransmitOverCur.SetFaultLed(alarmData.TransmitOverCurOnce, alarmData.TransmitOverCurQuintic);
            LedFocusCoilCurFailure.SetFaultLed(alarmData.FocusCoilCurFailureOnce, alarmData.FocusCoilCurFailureQuintic);
            LedFocusCoilAirFlowFailure.SetFaultLed(alarmData.FocusCoilAirFlowFailureOnce, alarmData.FocusCoilAirFlowFailureQuintic);
            LedTriggerFailure.SetFaultLed(alarmData.TriggerFailureOnce, alarmData.TriggerFailureQuintic);
            LedChargingFeedbackFlowRectifierUnderVol.SetFaultLed(alarmData.ChargingFeedbackFlowRectifierUnderVolOnce, alarmData.ChargingFeedbackFlowRectifierUnderVolQuintic);
            LedChargingFailure.SetFaultLed(alarmData.ChargingFailureOnce, alarmData.ChargingFailureQuintic);
            LedModulatorOver.SetFaultLed(alarmData.ModulatorOverOnce, alarmData.ModulatorOverQuintic);
            LedModulatorNegPeakOver.SetFaultLed(alarmData.ModulatorNegPeakOverOnce, alarmData.ModulatorNegPeakOverQuintic);
            LedModulatorSwitchFailure.SetFaultLed(alarmData.ModulatorSwitchFailureOnce, alarmData.ModulatorSwitchFailureQuintic);
            LedKlystronOverCur.SetFaultLed(alarmData.KlystronOverCurOnce, alarmData.KlystronOverCurQuintic);
            LedKlystronFilaFailure.SetFaultLed(alarmData.KlystronFilaFailureOnce, alarmData.KlystronFilaFailureQuintic);
            LedKlystronTitPumpFailure.SetFaultLed(alarmData.KlystronTitPumpFailureOnce, alarmData.KlystronTitPumpFailureQuintic);
            LedKlystronAirTempAlarm.SetFaultLed(alarmData.KlystronAirTempAlarmOnce, alarmData.KlystronAirTempAlarmQuintic);
            LedKlystronAirFlowAlarm.SetFaultLed(alarmData.KlystronAirFlowAlarmOnce, alarmData.KlystronAirFlowAlarmQuintic);
            LedWaveGuidPressAlarm.SetFaultLed(alarmData.WaveGuidPressAlarmOnce, alarmData.WaveGuidPressAlarmQuintic);
            LedWaveGuidArcAlarm.SetFaultLed(alarmData.WaveGuidArcAlarmOnce, alarmData.WaveGuidArcAlarmQuintic);
            LedTankLevelAlarm.SetFaultLed(alarmData.TankLevelAlarmOnce, alarmData.TankLevelAlarmQuintic);
            LedTankTempAlarm.SetFaultLed(alarmData.TankTempAlarmOnce, alarmData.TankTempAlarmQuintic);
            LedAntennaWaveGuidChain.SetFaultLed(alarmData.AntennaWaveGuidChain);
            LedAntennaCirculatorOverHeat.SetFaultLed(alarmData.AntennaCirculatorOverHeat);
            LedRackDoorChain.SetFaultLed(alarmData.RackDoorChainOnce, alarmData.RackDoorChainQuintic);
            LedRackAirTempAlarm.SetFaultLed(alarmData.RackAirTempAlarmOnce, alarmData.RackAirTempAlarmQuintic);
            LedRackAirFlowAlarm.SetFaultLed(alarmData.RackAirFlowAlarmOnce, alarmData.RackAirFlowAlarmQuintic);
            LedDutyCycleOver.SetFaultLed(alarmData.DutyCycleOverOnce, alarmData.DutyCycleOverQuintic);
            LedWaveGuidPressHumidityReq.SetFaultLed(alarmData.WaveGuidPressHumidityReq);
            LedModulatorSwitchReq.SetFaultLed(alarmData.ModulatorSwitchReq);
            LedAfterChargingFair.SetFaultLed(alarmData.AfterChargingFair);
            Led510VFailure.SetFaultLed(alarmData._510VFailureOnce, alarmData._510VFailureQuintic);
            LedBackup.SetFaultLed(alarmData.BackupOnce, alarmData.BackupQuintic);
        }
    }
}