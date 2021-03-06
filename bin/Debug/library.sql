USE [master]
GO

CREATE DATABASE [testing]
Go

USE [testing]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adminpass](
	[username] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
	) ON [PRIMARY] 

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brwbooks](
	[brw_id] [varchar](20) NOT NULL,
	[contact_no] [varchar](20) NOT NULL,
	[brw_name] [varchar](50) NOT NULL,
	[bookid] [varchar](20) NOT NULL,
	[booktle] [varchar](50) NOT NULL,
	[author_name] [varchar](20) NOT NULL,
	[dateissue] [varchar](max) NOT NULL,
	[datereturn] [varchar](max) NOT NULL,
	[no_copies] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[category]    Script Date: 26-07-2017 10:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] NOT NULL,
	[category] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[penalty]    Script Date: 26-07-2017 10:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[penalty](
	[penalty] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[reserve]    Script Date: 26-07-2017 10:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reserve](
	[reserve_id] [varchar](50) NOT NULL,
	[contact_no] [varchar](50) NOT NULL,
	[reserve_name] [varchar](50) NOT NULL,
	[bookid] [varchar](50) NOT NULL,
	[booktle] [varchar](50) NOT NULL,
	[author_name] [varchar](50) NOT NULL,
	[pickup] [date] NOT NULL,
	[no_copies] [varchar](50) NOT NULL,
	[returndate] [date] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblbooks]    Script Date: 26-07-2017 10:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblbooks](
	[id] [int] NULL,
	[book_id] [varchar](20) NOT NULL,
	[bk_name] [varchar](50) NOT NULL,
	[author_name] [varchar](50) NOT NULL,
	[bk_ctry] [varchar](50) NOT NULL,
	[bk_qty] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 26-07-2017 10:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[userinfo](
	[id] [int] NOT NULL,
	[lname] [varchar](50) NOT NULL,
	[fname] [varchar](50) NOT NULL,
	[mname] [varchar](50) NOT NULL,
	[uname] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[yr] [varchar](50) NOT NULL,
	[section] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 26-07-2017 10:46:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] NOT NULL,
	[stud_no] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[action] [varchar](50) NOT NULL,
	[log] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[adminpass] ([username], [password]) VALUES (N'azhar', N'123')
INSERT [dbo].[brwbooks] ([brw_id], [contact_no], [brw_name], [bookid], [booktle], [author_name], [dateissue], [datereturn], [no_copies]) VALUES (N'12', N'3456', N'md', N'00003', N'Panting way sakang', N'azhar', N'2016-05-12 00:00:00.0000000 +00:00', N'2016-10-12', 2)
INSERT [dbo].[brwbooks] ([brw_id], [contact_no], [brw_name], [bookid], [booktle], [author_name], [dateissue], [datereturn], [no_copies]) VALUES (N'12', N'2345678', N'md', N'00003', N'Panting way sakang', N'azhar', N'1900-01-01 00:00:00.0000000 +00:00', N'2017-07-27', 2)
INSERT [dbo].[brwbooks] ([brw_id], [contact_no], [brw_name], [bookid], [booktle], [author_name], [dateissue], [datereturn], [no_copies]) VALUES (N'12', N'2345678', N'md', N'00003', N'Panting way sakang', N'azhar', N'2017-07-19 16:21:15.0000000 +00:00', N'2017-07-27', 2)
INSERT [dbo].[brwbooks] ([brw_id], [contact_no], [brw_name], [bookid], [booktle], [author_name], [dateissue], [datereturn], [no_copies]) VALUES (N'12', N'2345678', N'md', N'00003', N'Panting way sakang', N'azhar', N'2017-07-19 16:21:15.0000000 +00:00', N'2017-07-27', 2)
INSERT [dbo].[brwbooks] ([brw_id], [contact_no], [brw_name], [bookid], [booktle], [author_name], [dateissue], [datereturn], [no_copies]) VALUES (N'12', N'2345678', N'md', N'00003', N'Panting way sakang', N'azhar', N'19-07-2017 16:21:15', N'2017-07-27', 2)
INSERT [dbo].[brwbooks] ([brw_id], [contact_no], [brw_name], [bookid], [booktle], [author_name], [dateissue], [datereturn], [no_copies]) VALUES (N'12', N'2345678', N'md', N'00003', N'Panting way sakang', N'azhar', N'19-07-2017 16:21:15', N'2017-07-27', 2)
INSERT [dbo].[brwbooks] ([brw_id], [contact_no], [brw_name], [bookid], [booktle], [author_name], [dateissue], [datereturn], [no_copies]) VALUES (N'123', N'720070421', N'sasi', N'00008', N'Program Development', N'azhar', N'19-07-2017', N'19-07-2017', 1)
INSERT [dbo].[category] ([id], [category]) VALUES (11, N'Bulad')
INSERT [dbo].[category] ([id], [category]) VALUES (9, N'Computer')
INSERT [dbo].[category] ([id], [category]) VALUES (4, N'Health')
INSERT [dbo].[category] ([id], [category]) VALUES (6, N'History')
INSERT [dbo].[category] ([id], [category]) VALUES (3, N'Math')
INSERT [dbo].[category] ([id], [category]) VALUES (10, N'Networking')
INSERT [dbo].[category] ([id], [category]) VALUES (12, N'Pagkaon')
INSERT [dbo].[category] ([id], [category]) VALUES (2, N'Programming')
INSERT [dbo].[category] ([id], [category]) VALUES (5, N'Science')
INSERT [dbo].[category] ([id], [category]) VALUES (8, N'Sports')
INSERT [dbo].[reserve] ([reserve_id], [contact_no], [reserve_name], [bookid], [booktle], [author_name], [pickup], [no_copies], [returndate]) VALUES (N'12', N'12345', N'md', N'00009', N'Computer Basic', N'azhar', CAST(0x103D0B00 AS Date), N'1', CAST(0x103D0B00 AS Date))
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (10, N'00001', N'Jquery Programming', N'azhar', N'Programming', 33)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (11, N'00004', N'Hardware Servicing', N'azhar', N'Computer', 7)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (12, N'00005', N'Bulad nga sapsap', N'azhar', N'Health', 19)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (13, N'00006', N'Sapatos nga buslot', N'azhar', N'Sports', 5)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (14, N'00007', N'Standard Cabling', N'azhar', N'Computer', 3)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (15, N'00008', N'Program Development', N'azhar', N'Computer', 62)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (16, N'00009', N'Computer Basic', N'azhar', N'Computer', 3)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (18, N'00011', N'Jose Rizal', N'azhar', N'History', 22)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (19, N'00012', N'Andress Bonifacio', N'azhar', N'History', 5)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (21, N'00013', N'HTML Basic', N'azhar', N'Programming', 6)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (22, N'00014', N'Boxing', N'azhar', N'Health', 5)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (23, N'00015', N'Swimming', N'azhar', N'Health', 20)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (24, N'00016', N'History of America', N'azhar', N'History', 5)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (25, N'00017', N'UTP Cable', N'azhar', N'Computer', -5)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (NULL, N'001', N'ar', N'azh', N'Computer', 0)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (NULL, N'1', N'bn', N'bn', N'Computer', 11)
INSERT [dbo].[tblbooks] ([id], [book_id], [bk_name], [author_name], [bk_ctry], [bk_qty]) VALUES (NULL, N'1', N'ghjk', N'vbn', N'Bulad', 22)
INSERT [dbo].[userinfo] ([id], [lname], [fname], [mname], [uname], [pass], [yr], [section]) VALUES (1, N'ahar', N'md', N'no', N'12', N'123', N'1st yr', N'b')
INSERT [dbo].[userinfo] ([id], [lname], [fname], [mname], [uname], [pass], [yr], [section]) VALUES (3, N'ameen', N'fghj', N'fgjk', N'13', N'123', N'2nd yr', N'a')
INSERT [dbo].[userinfo] ([id], [lname], [fname], [mname], [uname], [pass], [yr], [section]) VALUES (4, N's', N'sasi', N'asc', N'123', N'123', N'3rd yr', N'c')
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'', N'', N'Login', CAST(0x00000000003F2E38 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000003F2E38 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000404778 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000404778 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000040D418 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000446628 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000533B08 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000545448 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'13', N'123', N'Login', CAST(0x0000000000BF7354 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000003CFCE4 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'13', N'123', N'Login', CAST(0x00000000005B7994 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'13', N'123', N'Login', CAST(0x00000000005D65C4 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000B54AF0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000B5D790 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000B9AFF0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000BF7480 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000D2F4B0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000107F70 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000002EB5D0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000002EFC20 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000002F88C0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000002FCF10 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000031BB40 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000005037F0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000005037F0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000005037F0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000057A260 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000005901F0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000006E6E50 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000C3DAAC AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000D3E294 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000D3E294 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000043A724 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x000000000043ED74 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'123', N'123', N'Logout', CAST(0x000000000045D9A4 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000046AC94 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000492564 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000004B1194 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000041A708 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000441FD8 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000044AC78 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000499E18 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000004ED608 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000004F62A8 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000503598 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000005221C8 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000526818 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x000000000052F4B8 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000552738 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'13', N'123', N'Logout', CAST(0x0000000000BFB9A4 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000003CFCE4 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'13', N'123', N'Logout', CAST(0x00000000005F0BA4 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000B504A0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000B66430 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000B9F640 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000BF2E30 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000D2F4B0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000107F70 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000002F88C0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000301560 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x000000000031BB40 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000005037F0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x000000000057A260 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x0000000000594840 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x00000000006E2800 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000C3DAAC AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x00000000004B57E4 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Login', CAST(0x0000000000515130 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'12', N'123', N'Logout', CAST(0x000000000051DDD0 AS DateTime))
INSERT [dbo].[users] ([id], [stud_no], [password], [action], [log]) VALUES (0, N'123', N'123', N'Login', CAST(0x0000000000459354 AS DateTime))
USE [master]
GO
ALTER DATABASE [testing] SET  READ_WRITE 
GO
