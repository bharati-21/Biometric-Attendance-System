SET IDENTITY_INSERT [dbo].[Attendance] ON
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (1, 100, N'Bharati                                                                                             ', 7, N'4                   ', 2020, N'19:31:21  ', N'A         ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (2, 100, N'Bharati                                                                                             ', 6, N'4                   ', 2020, N'09:45:32  ', N'P         ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (3, 101, N'Sharada                                                                                             ', 7, N'4                   ', 2020, N'10:00:14  ', N'P         ')
SET IDENTITY_INSERT [dbo].[Attendance] OFF
SELECT Month, Year, count(distinct([DayOfMonth])) as TOTALDAYS FROM [Attendance] where [ID]=100 and STATUS='A' GROUP BY  MONTH, YEAR


SELECT SUM(totalAtt)  from
    (SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance] where [ID]=100 and STATUS='p' GROUP BY  MONTH, YEAR)  Attendance

select status, VerTime from [dbo].[Attendance] where [Name] = @name and [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date

SELECT count(distinct([DayOfMonth])) FROM [Attendance] GROUP BY  MONTH, YEAR
SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance] where [ID]=100 and STATUS='Full Day' OR STATUS='Half Day' GROUP BY  MONTH, YEAR



SELECT count(distinct([DayOfMonth])) FROM Attendance  GROUP BY  MONTH, YEAR;

	