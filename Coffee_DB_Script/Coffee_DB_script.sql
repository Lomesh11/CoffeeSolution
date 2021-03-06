USE [Coffee_DB]
GO
/****** Object:  Table [dbo].[tbl_Inventory]    Script Date: 12-09-2021 16:32:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Inventory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[inventoryType] [varchar](50) NULL,
	[initialQty] [int] NULL,
	[remainingQty] [int] NULL,
	[createdDate] [datetime] NULL,
	[modifyDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_Inventory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Inventory] ON 

INSERT [dbo].[tbl_Inventory] ([id], [inventoryType], [initialQty], [remainingQty], [createdDate], [modifyDate]) VALUES (1, N'Beans', 25, 20, CAST(N'2021-03-11 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[tbl_Inventory] ([id], [inventoryType], [initialQty], [remainingQty], [createdDate], [modifyDate]) VALUES (2, N'Milk', 20, 17, CAST(N'2021-09-11 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[tbl_Inventory] ([id], [inventoryType], [initialQty], [remainingQty], [createdDate], [modifyDate]) VALUES (3, N'Sugar', 25, 25, CAST(N'2021-09-11 00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[tbl_Inventory] OFF
