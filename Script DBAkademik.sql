USE [master]
GO
/****** Object:  Database [DBAkademik]    Script Date: 6/23/2022 3:41:28 PM ******/
CREATE DATABASE [DBAkademik]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBAkademik', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBAkademik.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBAkademik_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DBAkademik_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBAkademik] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBAkademik].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBAkademik] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBAkademik] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBAkademik] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBAkademik] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBAkademik] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBAkademik] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBAkademik] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBAkademik] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBAkademik] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBAkademik] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBAkademik] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBAkademik] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBAkademik] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBAkademik] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBAkademik] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBAkademik] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBAkademik] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBAkademik] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBAkademik] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBAkademik] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBAkademik] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBAkademik] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBAkademik] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBAkademik] SET  MULTI_USER 
GO
ALTER DATABASE [DBAkademik] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBAkademik] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBAkademik] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBAkademik] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DBAkademik] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DBAkademik]
GO
/****** Object:  Table [dbo].[m_guru]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[m_guru](
	[guru_id] [varchar](10) NOT NULL,
	[matpel_id] [varchar](10) NULL,
	[GURU_ALAMAT] [varchar](200) NULL,
	[GURU_TGLLAHIR] [datetime] NULL,
	[GURU_PHONE] [varchar](200) NULL,
	[GURU_WORKINGTIME] [numeric](25, 2) NULL,
	[guru_nama] [varchar](200) NULL,
 CONSTRAINT [PK_m_guru] PRIMARY KEY CLUSTERED 
(
	[guru_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[m_hari]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[m_hari](
	[hari_id] [varchar](10) NULL,
	[hari_nama] [varchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[m_kelas]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[m_kelas](
	[Kelas_id] [varchar](10) NOT NULL,
	[Remarks] [varchar](300) NULL,
	[Location] [varchar](300) NULL,
 CONSTRAINT [PK_m_kelas] PRIMARY KEY CLUSTERED 
(
	[Kelas_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[m_pelajaran]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[m_pelajaran](
	[matpel_id] [varchar](10) NOT NULL,
	[matpel_nama] [varchar](100) NULL,
	[matpel_hour] [numeric](25, 2) NULL,
 CONSTRAINT [PK_m_pelajaran] PRIMARY KEY CLUSTERED 
(
	[matpel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_jadwal]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_jadwal](
	[hari_id] [varchar](10) NULL,
	[Kelas_id] [varchar](10) NULL,
	[guru_id] [varchar](10) NULL,
	[id_jadwal] [varchar](10) NULL,
	[JamPelajaran] [numeric](25, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[m_guru] ([guru_id], [matpel_id], [GURU_ALAMAT], [GURU_TGLLAHIR], [GURU_PHONE], [GURU_WORKINGTIME], [guru_nama]) VALUES (N'G000000001', N'M000000002', N'BANDAR LAMPUNG', CAST(N'1991-11-24 16:45:19.000' AS DateTime), N'082186822997', CAST(12.00 AS Numeric(25, 2)), N'BOY RAKASIWI')
INSERT [dbo].[m_guru] ([guru_id], [matpel_id], [GURU_ALAMAT], [GURU_TGLLAHIR], [GURU_PHONE], [GURU_WORKINGTIME], [guru_nama]) VALUES (N'G000000002', N'M000000004', N'', CAST(N'2022-06-23 06:40:14.000' AS DateTime), N'', CAST(15.00 AS Numeric(25, 2)), N'SHKA')
INSERT [dbo].[m_guru] ([guru_id], [matpel_id], [GURU_ALAMAT], [GURU_TGLLAHIR], [GURU_PHONE], [GURU_WORKINGTIME], [guru_nama]) VALUES (N'G000000003', N'M000000005', N'', CAST(N'2022-06-23 06:40:14.000' AS DateTime), N'', CAST(9.00 AS Numeric(25, 2)), N'VERO')
INSERT [dbo].[m_hari] ([hari_id], [hari_nama]) VALUES (N'01', N'Senin')
INSERT [dbo].[m_hari] ([hari_id], [hari_nama]) VALUES (N'02', N'Selasa')
INSERT [dbo].[m_hari] ([hari_id], [hari_nama]) VALUES (N'03', N'Rabu')
INSERT [dbo].[m_hari] ([hari_id], [hari_nama]) VALUES (N'04', N'Kamis')
INSERT [dbo].[m_hari] ([hari_id], [hari_nama]) VALUES (N'05', N'Jumat')
INSERT [dbo].[m_kelas] ([Kelas_id], [Remarks], [Location]) VALUES (N'K000000001', N'LAB ICT', N'GEDUNG A')
INSERT [dbo].[m_kelas] ([Kelas_id], [Remarks], [Location]) VALUES (N'K000000002', N'RUANG 202', N'GEDUNG B')
INSERT [dbo].[m_kelas] ([Kelas_id], [Remarks], [Location]) VALUES (N'K000000003', N'AULA', N'GEDUNG C')
INSERT [dbo].[m_pelajaran] ([matpel_id], [matpel_nama], [matpel_hour]) VALUES (N'M000000002', N'VISUAL BASIC', CAST(2.00 AS Numeric(25, 2)))
INSERT [dbo].[m_pelajaran] ([matpel_id], [matpel_nama], [matpel_hour]) VALUES (N'M000000003', N'MATEMATIKA', CAST(3.00 AS Numeric(25, 2)))
INSERT [dbo].[m_pelajaran] ([matpel_id], [matpel_nama], [matpel_hour]) VALUES (N'M000000004', N'KALKULUS', CAST(2.00 AS Numeric(25, 2)))
INSERT [dbo].[m_pelajaran] ([matpel_id], [matpel_nama], [matpel_hour]) VALUES (N'M000000005', N'LOGIKA DASAR', CAST(4.00 AS Numeric(25, 2)))
INSERT [dbo].[t_jadwal] ([hari_id], [Kelas_id], [guru_id], [id_jadwal], [JamPelajaran]) VALUES (N'01', N'K000000001', N'G000000001', N'J000000001', CAST(7.00 AS Numeric(25, 2)))
INSERT [dbo].[t_jadwal] ([hari_id], [Kelas_id], [guru_id], [id_jadwal], [JamPelajaran]) VALUES (N'01', N'K000000001', N'G000000001', N'J000000002', CAST(9.01 AS Numeric(25, 2)))
INSERT [dbo].[t_jadwal] ([hari_id], [Kelas_id], [guru_id], [id_jadwal], [JamPelajaran]) VALUES (N'01', N'K000000003', N'G000000002', N'J000000003', CAST(9.00 AS Numeric(25, 2)))
INSERT [dbo].[t_jadwal] ([hari_id], [Kelas_id], [guru_id], [id_jadwal], [JamPelajaran]) VALUES (N'01', N'K000000003', N'G000000003', N'J000000004', CAST(12.00 AS Numeric(25, 2)))
/****** Object:  StoredProcedure [dbo].[hapus_jadwal]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[hapus_jadwal]
@id_jadwal varchar(10)
as
begin
delete from t_jadwal where id_jadwal=@id_jadwal
end
GO
/****** Object:  StoredProcedure [dbo].[simpan_jadwal]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[simpan_jadwal]
@hari_id varchar(10),@kelas_id varchar(10),
@guru_id varchar(10),@id_jadwal varchar(10),
@jampelajaran numeric(25,2),@OUTPUTMESSAGE varchar(50) output
as
begin
declare @RowCount int=0
declare @jadwalkelas int=0
declare @cek_idkelas int=0

set @RowCount=(SELECT COUNT(1)
FROM 
(SELECT Kelas_id,COUNT(Kelas_id) x
FROM t_jadwal 
GROUP BY Kelas_id) xx)

set @cek_idkelas =(select COUNT(1) from t_jadwal 
where Kelas_id=@kelas_id)


set @jadwalkelas=(select COUNT(1) from t_jadwal a  inner join m_guru b on a.guru_id=b.guru_id
inner join m_pelajaran c on b.matpel_id=c.matpel_id
where (JamPelajaran +c.matpel_hour between @jampelajaran and @jampelajaran+c.matpel_hour)
and a.Kelas_id=@kelas_id and hari_id=@hari_id)

begin try
	begin tran
	if(@cek_idkelas=0)
	begin
		if ( (@RowCount <2 or @RowCount is null) )
		begin
			if(@jadwalkelas=0)
			begin
				insert into t_jadwal(hari_id,Kelas_id,guru_id,id_jadwal,JamPelajaran) 
				values (@hari_id,@kelas_id,@guru_id,@id_jadwal,@jampelajaran)
				set @OUTPUTMESSAGE='Produk berhasil disimpan'
			end
			else
			begin
				set @OUTPUTMESSAGE='Gagal simpan! jadwal bentrok'
			end
		end
		else
		begin
		set @OUTPUTMESSAGE='Gagal simpan, hanya boleh 2 kelas'
		end
	end
	else
	begin
		if(@jadwalkelas=0)
		begin
			insert into t_jadwal(hari_id,Kelas_id,guru_id,id_jadwal,JamPelajaran) 
			values (@hari_id,@kelas_id,@guru_id,@id_jadwal,@jampelajaran)
			set @OUTPUTMESSAGE='Produk berhasil disimpan'
		end
		else
		begin
			set @OUTPUTMESSAGE='Gagal simpan! jadwal bentrok'
		end
	end
	commit  tran
end try
begin catch
rollback tran
select @OUTPUTMESSAGE=ERROR_MESSAGE()
end catch
end
GO
/****** Object:  StoredProcedure [dbo].[tampil_all]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[tampil_all]
as
begin
select a.id_jadwal,e.hari_nama,b.guru_id,b.guru_nama,b.matpel_id,c.matpel_nama,
d.Remarks,'Pukul '+ cast(a.JamPelajaran as varchar(50)) + ' WIB' as  JamPelajaran
from t_jadwal a inner join m_guru b on a.guru_id=b.guru_id
inner join m_pelajaran c on b.matpel_id=c.matpel_id
inner join m_kelas d on a.Kelas_id=d.Kelas_id
inner join m_hari e on a.hari_id=e.hari_id
group by e.hari_nama,b.guru_id,b.guru_nama,
b.matpel_id,c.matpel_nama,d.Remarks,JamPelajaran,
a.id_jadwal
end
GO
/****** Object:  StoredProcedure [dbo].[ubah_jadwal]    Script Date: 6/23/2022 3:41:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ubah_jadwal]
@hari_id varchar(10),@kelas_id varchar(10),
@guru_id varchar(10),@id_jadwal varchar(10),
@jampelajaran numeric(25,2)
as
begin
update t_jadwal set hari_id=@hari_id,Kelas_id=@kelas_id,guru_id=@guru_id,
JamPelajaran=@jampelajaran
where id_jadwal=@id_jadwal
end
GO
USE [master]
GO
ALTER DATABASE [DBAkademik] SET  READ_WRITE 
GO
