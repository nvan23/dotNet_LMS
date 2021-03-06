USE [LMS]
GO
/****** Object:  Table [dbo].[books_info]    Script Date: 5/17/2020 12:41:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books_info](
	[books_Id] [int] IDENTITY(1,1) NOT NULL,
	[books_name] [nvarchar](50) NULL,
	[books_author_name] [nvarchar](50) NULL,
	[books_publication_name] [nvarchar](50) NULL,
	[books_purchase_date] [date] NULL,
	[books_price] [int] NULL,
	[books_quantity] [int] NULL,
	[available_book] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[books_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[issue_books]    Script Date: 5/17/2020 12:41:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issue_books](
	[Issue_Id] [int] IDENTITY(1,1) NOT NULL,
	[UID] [int] NULL,
	[books_Id] [int] NULL,
	[books_issue_date] [date] NULL,
	[books_return_date] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Issue_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[permission]    Script Date: 5/17/2020 12:41:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permission](
	[per_Id] [int] IDENTITY(1,1) NOT NULL,
	[per_Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[per_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[status_account]    Script Date: 5/17/2020 12:41:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status_account](
	[status_Id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[status_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_details]    Script Date: 5/17/2020 12:41:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_details](
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[user_account_name] [nvarchar](50) NOT NULL,
	[user_full_name] [nvarchar](50) NULL,
	[user_image] [nvarchar](50) NULL,
	[user_Id_card] [nvarchar](50) NOT NULL,
	[user_department] [nvarchar](50) NULL,
	[user_contact] [numeric](18, 0) NOT NULL,
	[user_email] [nvarchar](50) NOT NULL,
	[user_password] [nvarchar](50) NULL,
	[user_gender] [nvarchar](50) NULL,
	[user_date_create] [date] NULL,
	[user_date_update] [nvarchar](50) NULL,
	[per_Id] [int] NULL,
	[status_Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [only_account_user] UNIQUE NONCLUSTERED 
(
	[user_account_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [only_contact_user] UNIQUE NONCLUSTERED 
(
	[user_contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [only_Id_card_user] UNIQUE NONCLUSTERED 
(
	[user_Id_card] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[issue_books]  WITH CHECK ADD  CONSTRAINT [FK_issues_books] FOREIGN KEY([books_Id])
REFERENCES [dbo].[books_info] ([books_Id])
GO
ALTER TABLE [dbo].[issue_books] CHECK CONSTRAINT [FK_issues_books]
GO
ALTER TABLE [dbo].[issue_books]  WITH CHECK ADD  CONSTRAINT [FK_issues_user] FOREIGN KEY([UID])
REFERENCES [dbo].[user_details] ([UID])
GO
ALTER TABLE [dbo].[issue_books] CHECK CONSTRAINT [FK_issues_user]
GO
ALTER TABLE [dbo].[user_details]  WITH CHECK ADD  CONSTRAINT [FK_relationship_permission] FOREIGN KEY([per_Id])
REFERENCES [dbo].[permission] ([per_Id])
GO
ALTER TABLE [dbo].[user_details] CHECK CONSTRAINT [FK_relationship_permission]
GO
ALTER TABLE [dbo].[user_details]  WITH CHECK ADD  CONSTRAINT [FK_relationship_status] FOREIGN KEY([status_Id])
REFERENCES [dbo].[status_account] ([status_Id])
GO
ALTER TABLE [dbo].[user_details] CHECK CONSTRAINT [FK_relationship_status]
GO
ALTER TABLE [dbo].[books_info]  WITH CHECK ADD CHECK  (([available_book]>=(0)))
GO
ALTER TABLE [dbo].[books_info]  WITH CHECK ADD CHECK  (([books_price]>=(0)))
GO
ALTER TABLE [dbo].[books_info]  WITH CHECK ADD CHECK  (([books_quantity]>=(0)))
GO
