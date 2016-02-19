USE [RadarStatusPowerData]
GO

/****** Object:  Table [dbo].[ControlStatusTable]    Script Date: 2015/9/20 23:53:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ControlStatusTable](
	[ID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_ControlStatusTable_ID]  DEFAULT (newid()),
	[StationID] [nvarchar](10) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[LocalCtrl] [bit] NULL,
	[RemoteCtrl] [bit] NULL,
	[FilaSupply] [bit] NULL,
	[Preheat] [bit] NULL,
	[RepeatCycle] [bit] NULL,
	[Antenna] [bit] NULL,
	[Load] [bit] NULL,
	[AllowOn] [bit] NULL,
	[BroadPulse] [bit] NULL,
	[SpikePulse] [bit] NULL,
	[Auto] [bit] NULL,
	[Manual] [bit] NULL,
	[HighVolon] [bit] NULL,
	[HighVoloff] [bit] NULL,
	[Fault] [bit] NULL,
	[Backup] [bit] NULL,
 CONSTRAINT [PK_ControlStatusTable] PRIMARY KEY CLUSTERED 
(
	[DateTime] DESC,
	[StationID] DESC,
	[ID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [CK_ControlStatusTable] UNIQUE NONCLUSTERED 
(
	[StationID] DESC,
	[DateTime] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'StationID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'DateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'本控' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'LocalCtrl'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'遥控' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'RemoteCtrl'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'灯丝供电' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'FilaSupply'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预热' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'Preheat'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'重复循环' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'RepeatCycle'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'天线' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'Antenna'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'负载' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'Load'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'准加' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'AllowOn'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'宽脉冲' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'BroadPulse'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'窄脉冲' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'SpikePulse'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'自动' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'Auto'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手动' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'Manual'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'高压开' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'HighVolon'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'高压关' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'HighVoloff'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'故障' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'Fault'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备份' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ControlStatusTable', @level2type=N'COLUMN',@level2name=N'Backup'
GO

