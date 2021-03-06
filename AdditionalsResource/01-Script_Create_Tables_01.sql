USE [DB_A1FE94_BdHumanResources]
GO


/****** Object:  Table [dbo].[tblCities]    Script Date: 03/09/2018 3:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCities](
	[Cit_CityId] [int] IDENTITY(1,1) NOT NULL,
	[Cit_Name] [nvarchar](100) NOT NULL,
	[Pro_ProvinceId] [int] NOT NULL,
 CONSTRAINT [PK_tblCities] PRIMARY KEY CLUSTERED 
(
	[Cit_CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCountries]    Script Date: 03/09/2018 3:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCountries](
	[Cuo_CountryId] [int] IDENTITY(1,1) NOT NULL,
	[Cuo_Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblCountries] PRIMARY KEY CLUSTERED 
(
	[Cuo_CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDepartments]    Script Date: 03/09/2018 3:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartments](
	[Dep_DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[Dep_Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblDepartments] PRIMARY KEY CLUSTERED 
(
	[Dep_DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEmployees]    Script Date: 03/09/2018 3:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployees](
	[Emp_EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Tit_TitleId] [int] NOT NULL,
	[Emp_FirstName] [nvarchar](100) NOT NULL,
	[Emp_LastName] [nvarchar](100) NOT NULL,
	[Emp_SurName] [nvarchar](100) NULL,
	[Emp_OtherName] [nvarchar](100) NULL,
	[Emp_KnownAs] [nvarchar](100) NULL,
	[Emp_Gender] [nvarchar](1) NOT NULL,
	[Emp_Address] [nvarchar](100) NOT NULL,
	[Emp_BirthOfDate] [datetime] NOT NULL,
	[Emp_StartDate] [datetime] NOT NULL,
	[Emp_TerminationDate] [datetime] NOT NULL,
	[Cit_CityId] [int] NOT NULL,
	[Emp_PostalCode] [nvarchar](10) NOT NULL,
	[Pos_PositionId] [int] NOT NULL,
	[Emp_Email] [nvarchar](100) NULL,
	[Emp_Phone] [nvarchar](30) NULL,
	[Emp_CellPhone] [nvarchar](30) NULL,
	[Emp_AnualSalary] [decimal](18, 6) NULL,
	[Emp_HourlyRate] [decimal](18, 6) NULL,
	[Dep_DepartmentId] [int] NOT NULL,
	[Emp_Photo] [image] NULL,
 CONSTRAINT [PK_tblEmployees] PRIMARY KEY CLUSTERED 
(
	[Emp_EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPositions]    Script Date: 03/09/2018 3:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPositions](
	[Pos_PositionId] [int] IDENTITY(1,1) NOT NULL,
	[Pos_Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblPositions] PRIMARY KEY CLUSTERED 
(
	[Pos_PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblProvinces]    Script Date: 03/09/2018 3:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProvinces](
	[Pro_ProvinceId] [int] IDENTITY(1,1) NOT NULL,
	[Pro_Name] [nvarchar](100) NOT NULL,
	[Cou_Countryid] [int] NOT NULL,
 CONSTRAINT [PK_tblProvinces] PRIMARY KEY CLUSTERED 
(
	[Pro_ProvinceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTitles]    Script Date: 03/09/2018 3:11:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTitles](
	[Tit_TitleId] [int] IDENTITY(1,1) NOT NULL,
	[Tit_Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblTitles] PRIMARY KEY CLUSTERED 
(
	[Tit_TitleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblCountries]  WITH CHECK ADD  CONSTRAINT [FK_tblCountries_tblCountries] FOREIGN KEY([Cuo_CountryId])
REFERENCES [dbo].[tblCountries] ([Cuo_CountryId])
GO
ALTER TABLE [dbo].[tblCountries] CHECK CONSTRAINT [FK_tblCountries_tblCountries]
GO
ALTER TABLE [dbo].[tblEmployees]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployees_tblDepartments] FOREIGN KEY([Dep_DepartmentId])
REFERENCES [dbo].[tblDepartments] ([Dep_DepartmentId])
GO
ALTER TABLE [dbo].[tblEmployees] CHECK CONSTRAINT [FK_tblEmployees_tblDepartments]
GO
ALTER TABLE [dbo].[tblEmployees]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployees_tblPositions] FOREIGN KEY([Pos_PositionId])
REFERENCES [dbo].[tblPositions] ([Pos_PositionId])
GO
ALTER TABLE [dbo].[tblEmployees] CHECK CONSTRAINT [FK_tblEmployees_tblPositions]
GO
ALTER TABLE [dbo].[tblEmployees]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployees_tblTitles] FOREIGN KEY([Tit_TitleId])
REFERENCES [dbo].[tblTitles] ([Tit_TitleId])
GO
ALTER TABLE [dbo].[tblEmployees] CHECK CONSTRAINT [FK_tblEmployees_tblTitles]
GO
ALTER TABLE [dbo].[tblProvinces]  WITH CHECK ADD  CONSTRAINT [FK_tblProvinces_tblCountries] FOREIGN KEY([Cou_Countryid])
REFERENCES [dbo].[tblCountries] ([Cuo_CountryId])
GO
ALTER TABLE [dbo].[tblProvinces] CHECK CONSTRAINT [FK_tblProvinces_tblCountries]
GO
