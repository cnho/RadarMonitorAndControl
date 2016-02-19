USE [RadarStatusPowerData]
GO

/****** Object:  Table [dbo].[StationParaTable]    Script Date: 2015/11/3 21:47:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StationParaTable](
	[ID] [uniqueidentifier] NOT NULL,
	[StationID] [nvarchar](5) NOT NULL,
	[StationName] [nvarchar](50) NOT NULL,
	[Slong] [nvarchar](7) NULL,
	[Slat] [nvarchar](6) NULL,
	[Address] [nvarchar](255) NULL,
 CONSTRAINT [PK_StationParaTable] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[StationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[StationParaTable] ADD  CONSTRAINT [DF_StationParaTable_ID]  DEFAULT (newid()) FOR [ID]
GO

