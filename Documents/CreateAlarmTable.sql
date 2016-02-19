USE [RadarStatusPowerData]
GO

/****** Object:  Table [dbo].[AlarmStatusTable]    Script Date: 2015/9/20 23:53:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AlarmStatusTable](
	[ID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_AlarmStatusTable_ID]  DEFAULT (newid()),
	[StationID] [nvarchar](10) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[PowerGridUnderVolOnce] [bit] NULL,
	[PowerGridUnderVolQuintic] [bit] NULL,
	[LowPowerFailureOnce] [bit] NULL,
	[LowPowerFailureQuintic] [bit] NULL,
	[FilaVolFailureOnce] [bit] NULL,
	[FilaVolFailureQuintic] [bit] NULL,
	[TitPumpFailureOnce] [bit] NULL,
	[TitPumpFailureQuintic] [bit] NULL,
	[FocusCoilVolFailureOnce] [bit] NULL,
	[FocusCoilVolFailureQuintic] [bit] NULL,
	[TransmitOverVolOnce] [bit] NULL,
	[TransmitOverVolQuintic] [bit] NULL,
	[TransmitOverCurOnce] [bit] NULL,
	[TransmitOverCurQuintic] [bit] NULL,
	[FocusCoilCurFailureOnce] [bit] NULL,
	[FocusCoilCurFailureQuintic] [bit] NULL,
	[FocusCoilAirFlowFailureOnce] [bit] NULL,
	[FocusCoilAirFlowFailureQuintic] [bit] NULL,
	[TriggerFailureOnce] [bit] NULL,
	[TriggerFailureQuintic] [bit] NULL,
	[ChargingFeedbackFlowRectifierUnderVolOnce] [bit] NULL,
	[ChargingFeedbackFlowRectifierUnderVolQuintic] [bit] NULL,
	[ChargingFailureOnce] [bit] NULL,
	[ChargingFailureQuintic] [bit] NULL,
	[ModulatorOverOnce] [bit] NULL,
	[ModulatorOverQuintic] [bit] NULL,
	[ModulatorNegPeakOverOnce] [bit] NULL,
	[ModulatorNegPeakOverQuintic] [bit] NULL,
	[ModulatorSwitchFailureOnce] [bit] NULL,
	[ModulatorSwitchFailureQuintic] [bit] NULL,
	[KlystronOverCurOnce] [bit] NULL,
	[KlystronOverCurQuintic] [bit] NULL,
	[KlystronFilaFailureOnce] [bit] NULL,
	[KlystronFilaFailureQuintic] [bit] NULL,
	[KlystronTitPumpFailureOnce] [bit] NULL,
	[KlystronTitPumpFailureQuintic] [bit] NULL,
	[KlystronAirTempAlarmOnce] [bit] NULL,
	[KlystronAirTempAlarmQuintic] [bit] NULL,
	[KlystronAirFlowAlarmOnce] [bit] NULL,
	[KlystronAirFlowAlarmQuintic] [bit] NULL,
	[WaveGuidPressAlarmOnce] [bit] NULL,
	[WaveGuidPressAlarmQuintic] [bit] NULL,
	[WaveGuidArcAlarmOnce] [bit] NULL,
	[WaveGuidArcAlarmQuintic] [bit] NULL,
	[TankLevelAlarmOnce] [bit] NULL,
	[TankLevelAlarmQuintic] [bit] NULL,
	[TankTempAlarmOnce] [bit] NULL,
	[TankTempAlarmQuintic] [bit] NULL,
	[AntennaWaveGuidChain] [bit] NULL,
	[AntennaCirculatorOverHeat] [bit] NULL,
	[RackDoorChainOnce] [bit] NULL,
	[RackDoorChainQuintic] [bit] NULL,
	[RackAirTempAlarmOnce] [bit] NULL,
	[RackAirTempAlarmQuintic] [bit] NULL,
	[RackAirFlowAlarmOnce] [bit] NULL,
	[RackAirFlowAlarmQuintic] [bit] NULL,
	[DutyCycleOverOnce] [bit] NULL,
	[DutyCycleOverQuintic] [bit] NULL,
	[WaveGuidPressHumidityReq] [bit] NULL,
	[ModulatorSwitchReq] [bit] NULL,
	[AfterChargingFair] [bit] NULL,
	[510VFailureOnce] [bit] NULL,
	[510VFailureQuintic] [bit] NULL,
	[BackupOnce] [bit] NULL,	
	[BackupQuintic] [bit] NULL,
 CONSTRAINT [PK_AlarmStatusTable] PRIMARY KEY CLUSTERED 
(
	[DateTime] DESC,
	[StationID] DESC,
	[ID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [CK_AlarmStatusTable] UNIQUE NONCLUSTERED 
(
	[StationID] DESC,
	[DateTime] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO