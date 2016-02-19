USE [RadarStatusPowerData]
GO

/****** Object:  Table [dbo].[PowerDataTable]    Script Date: 2015/9/20 23:52:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PowerDataTable](
	[ID] [uniqueidentifier] NOT NULL CONSTRAINT [DF_PowerDataTable_ID]  DEFAULT (newid()),
	[StationID] [nvarchar](10) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Vol5] [decimal](6, 2) NULL,
	[Vol15] [decimal](6, 2) NULL,
	[VolNeg15] [decimal](6, 2) NULL,
	[Vol28] [decimal](6, 2) NULL,
	[Vol45] [decimal](6, 2) NULL,
	[Vol510] [decimal](6, 2) NULL,
	[VolFilaInve] [decimal](6, 2) NULL,
	[VolFilament] [decimal](6, 2) NULL,
	[VolField] [decimal](6, 2) NULL,
	[VolTitPump] [decimal](6, 2) NULL,
	[VolEleBeam] [decimal](6, 2) NULL,
	[VolArtifLine] [decimal](6, 2) NULL,
	[CurCatho] [decimal](6, 2) NULL,
	[CurReversePeak] [decimal](6, 2) NULL,
	[CurFilament] [decimal](6, 2) NULL,
	[CurFocusCoil] [decimal](6, 2) NULL,
	[CurTitPump] [decimal](6, 2) NULL,
	[CurLeveling] [decimal](6, 2) NULL,
	[CurArtifLine] [decimal](6, 2) NULL,
 CONSTRAINT [PK_PowerDataTable] PRIMARY KEY CLUSTERED 
(
	[DateTime] DESC,
	[StationID] DESC,
	[ID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [CK_PowerDataTable] UNIQUE NONCLUSTERED 
(
	[StationID] DESC,
	[DateTime] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'站号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'StationID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'DateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'5V电源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'Vol5'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'15V电源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'Vol15'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'-15V电源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'VolNeg15'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'28V电源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'Vol28'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'45V电源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'Vol45'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'510V电源' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'Vol510'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'灯丝逆变电压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'VolFilaInve'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'灯丝电压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'VolFilament'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'磁场电压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'VolField'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钛泵电压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'VolTitPump'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电子注电压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'VolEleBeam'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人工线充电电压' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'VolArtifLine'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'阴极电流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'CurCatho'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'反峰电流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'CurReversePeak'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'灯丝电流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'CurFilament'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'聚焦线圈电流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'CurFocusCoil'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'钛泵电流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'CurTitPump'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'校平电流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'CurLeveling'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'人工线充电电流' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PowerDataTable', @level2type=N'COLUMN',@level2name=N'CurArtifLine'
GO

