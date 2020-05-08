USE [LMS]
GO
/****** Object:  Table [dbo].[books_info]    Script Date: 5/8/2020 4:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books_info](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[books_name] [nvarchar](50) NULL,
	[books_author_name] [nvarchar](50) NULL,
	[books_publication_name] [nvarchar](50) NULL,
	[books_purchase_date] [date] NULL,
	[books_price] [int] NULL,
	[books_quantity] [int] NULL,
	[available_book] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[issue_books]    Script Date: 5/8/2020 4:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[issue_books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[student_enrollment_no] [nvarchar](50) NULL,
	[student_name] [nvarchar](50) NULL,
	[student_department] [nvarchar](50) NULL,
	[student_sem] [nvarchar](50) NULL,
	[student_contact] [nvarchar](50) NULL,
	[student_email] [nvarchar](50) NULL,
	[books_name] [nvarchar](50) NULL,
	[books_issue_date] [nvarchar](50) NULL,
	[books_return_date] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[library_person]    Script Date: 5/8/2020 4:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[library_person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[contact] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[student_info]    Script Date: 5/8/2020 4:01:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student_info](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[student_name] [nvarchar](50) NULL,
	[student_image] [nvarchar](50) NULL,
	[student_enrollment_no] [nvarchar](50) NULL,
	[student_department] [nvarchar](50) NULL,
	[student_sem] [nvarchar](50) NULL,
	[student_contact] [nvarchar](50) NULL,
	[student_email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[books_info]  WITH CHECK ADD CHECK  (([books_price]>=(0)))
GO
ALTER TABLE [dbo].[books_info]  WITH CHECK ADD CHECK  (([books_quantity]>=(0)))
GO
ALTER TABLE [dbo].[books_info]  WITH CHECK ADD CHECK  (([available_book]>=(0) AND [available_book]<=[books_quantity]))
GO
