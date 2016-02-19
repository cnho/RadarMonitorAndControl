USE [RadarStatusPowerData]
GO

/****** Object:  Table [dbo].[AlarmStatus]    Script Date: 2015/9/20 23:53:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AlarmStatus](
	[ID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_AlarmStatus_ID]  DEFAULT (newid()),
	[StationID] [nvarchar](10) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[PowerGridUnderVol] [nvarchar](2) NULL,
	[LowPowerFailure] [nvarchar](2) NULL,
	[FilaVolFailure] [nvarchar](2) NULL,
	[TitPumpFailure] [nvarchar](2) NULL,
	[FocusCoilVolFailure] [nvarchar](2) NULL,
	[TransmitOverVol] [nvarchar](2) NULL,
	[TransmitOverCur] [nvarchar](2) NULL,
	[FocusCoilCurFailure] [nvarchar](2) NULL,
	[FocusCoilAirFlowFailure] [nvarchar](2) NULL,
	[TriggerFailure] [nvarchar](2) NULL,
	[ChargingFeedbackFlowRectifierUnderVol] [nvarchar](2) NULL,
	[ChargingFailure] [nvarchar](2) NULL,
	[ModulatorOver] [nvarchar](2) NULL,
	[ModulatorNegPeakOver] [nvarchar](2) NULL,
	[ModulatorSwitchFailure] [nvarchar](2) NULL,
	[KlystronOverCur] [nvarchar](2) NULL,
	[KlystronFilaFailure] [nvarchar](2) NULL,
	[KlystronTitPumpFailure] [nvarchar](2) NULL,
	[KlystronAirTempAlarm] [nvarchar](2) NULL,
	[KlystronAirFlowAlarm] [nvarchar](2) NULL,
	[WaveGuidPressAlarm] [nvarchar](2) NULL,
	[WaveGuidArcAlarm] [nvarchar](2) NULL,
	[TankLevelAlarm] [nvarchar](2) NULL,
	[TankTempAlarm] [nvarchar](2) NULL,
	[AntennaWaveGuidChain] [nvarchar](2) NULL,
	[AntennaCirculatorOverHeat] [nvarchar](2) NULL,
	[RackDoorChain] [nvarchar](2) NULL,
	[RackAirTempAlarm] [nvarchar](2) NULL,
	[RackAirFlowAlarm] [nvarchar](2) NULL,
	[DutyCycleOver] [nvarchar](2) NULL,
	[WaveGuidPressHumidityReq] [nvarchar](2) NULL,
	[ModulatorSwitchReq] [nvarchar](2) NULL,
	[AfterChargingFair] [nvarchar](2) NULL,
	[510VFailure] [nvarchar](2) NULL,
	[Backup] [nvarchar](2) NULL,
 CONSTRAINT [PK_AlarmStatus] PRIMARY KEY CLUSTERED 
(
	[DateTime] DESC,
	[StationID] DESC,
	[ID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [CK_AlarmStatus] UNIQUE NONCLUSTERED 
(
	[StationID] DESC,
	[DateTime] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'StationID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'DateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电网低压故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'PowerGridUnderVol'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'低压综合故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'LowPowerFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'低压电源灯丝电压故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'FilaVolFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'低压电源钛泵电压故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'TitPumpFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'低压电源聚焦线圈故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'FocusCoilVolFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发射机过压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'TransmitOverVol'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发射机过流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'TransmitOverCur'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'聚焦线圈电流故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'FocusCoilCurFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'聚焦线圈风流量报警' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'FocusCoilAirFlowFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'触发器故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'TriggerFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充电系统回授过流/整流欠压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'ChargingFeedbackFlowRectifierUnderVol'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'充电系统充电故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'ChargingFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'调制器过流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'ModulatorOver'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'调制器反峰过流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'ModulatorNegPeakOver'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'调制器开关故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'ModulatorSwitchFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'速调管过流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'KlystronOverCur'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'速调管灯丝电流故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'KlystronFilaFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'速调管钛泵电流故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'KlystronTitPumpFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'速调管风温报警' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'KlystronAirTempAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'速调管风流量报警' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'KlystronAirFlowAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'波导压力故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'WaveGuidPressAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'波导电弧故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'WaveGuidArcAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'油箱油液面报警' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'TankLevelAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'油箱油温报警' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'TankTempAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'天线波导连锁' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'AntennaWaveGuidChain'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'机柜门连锁' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'RackDoorChain'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'机柜风温报警' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'RackAirTempAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'机柜风流量报警' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'RackAirFlowAlarm'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'占空比超限' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'DutyCycleOver'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'维修请求波导压力/湿度' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'WaveGuidPressHumidityReq'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'维修请求调制开关' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'ModulatorSwitchReq'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'后充电校平' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'AfterChargingFair'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'510V电源故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'510VFailure'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备份' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'AlarmStatus', @level2type=N'COLUMN',@level2name=N'Backup'
GO

