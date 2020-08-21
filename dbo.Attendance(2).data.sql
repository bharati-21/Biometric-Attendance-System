SET IDENTITY_INSERT [dbo].[Attendance] ON
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (7, 101, N'Sharada                                                                                             ', 10, N'June                ', 2020, N'17:18:58  ', N'Half Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (8, 102, N'Shanthi                                                                                             ', 10, N'June                ', 2020, N'17:19:18  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (9, 104, N'Dev                                                                                                 ', 10, N'June                ', 2020, N'17:19:42  ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (10, 103, N'Sona                                                                                                ', 10, N'June                ', 2020, N'12:00:00  ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (11, 100, N'Bharati                                                                                             ', 10, N'June                ', 2020, N'17:46:42  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (16, 101, N'Sharada                                                                                             ', 9, N'June                ', 2020, N'09:45:25  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (17, 102, N'Shanthi                                                                                             ', 9, N'June                ', 2020, N'10:02:15  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (18, 103, N'Sona                                                                                                ', 9, N'June                ', 2020, N'09:30:51  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (19, 104, N'Dev                                                                                                 ', 9, N'June                ', 2020, N'12:00:00  ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (22, 100, N'Bharati                                                                                             ', 9, N'June                ', 2020, N'12:00:00  ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (23, 100, N'Bharati                                                                                             ', 8, N'June                ', 2020, N'12:00:00  ', N'Half Day                      ')
SET IDENTITY_INSERT [dbo].[Attendance] OFF


SELECT SUM(totalAtt)  from
    (SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance] where [ID]=100 and STATUS='p' GROUP BY  MONTH, YEAR)  Attendance

select status, VerTime from [dbo].[Attendance] where [Name] = @name and [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date

SELECT count(distinct([DayOfMonth])) FROM [Attendance] GROUP BY  MONTH, YEAR
SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance] where [ID]=100 and STATUS='Full Day' OR STATUS='Half Day' GROUP BY  MONTH, YEAR



SELECT count(distinct([DayOfMonth])) FROM Attendance  GROUP BY  MONTH, YEAR;
