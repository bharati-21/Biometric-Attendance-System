SET IDENTITY_INSERT [dbo].[Attendance] ON
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (7, 101, N'Sharada                                                                                             ', 10, N'June                ', 2020, N'17:18:58  ', N'Half Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (8, 102, N'Shanthi                                                                                             ', 10, N'June                ', 2020, N'17:19:18  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (9, 104, N'Dev                                                                                                 ', 10, N'June                ', 2020, N'17:19:42  ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (10, 103, N'Sona                                                                                                ', 10, N'June                ', 2020, N'17:35:42  ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (11, 100, N'Bharati                                                                                             ', 10, N'June                ', 2020, N'17:46:42  ', N'Full Day                      ')
SET IDENTITY_INSERT [dbo].[Attendance] OFF

SELECT SUM(totalAtt)  from
    (SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance] where [ID]=100 and STATUS='Full Day' GROUP BY  MONTH, YEAR)  Attendance

	declare @mytotal int;
	declare @total int;
	set @total = (SELECT count(distinct([DayOfMonth])) FROM [Attendance] GROUP BY  MONTH, YEAR)
set @mytotal =( SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance] where [ID]=100 and STATUS='Full Day' OR STATUS='Half Day' GROUP BY  MONTH, YEAR);
print @mytotal*1.0 /  @total


SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance]  GROUP BY  MONTH, YEAR;




SELECT distinct(A.DayOfMonth) FROM  Attendance AS A INNER JOIN
         dbo.[User] AS u
         ON A.ID = U.ID
		 AND A.Id = 103
         
		 AND A.DayOfMonth >= U.enrollDate
GROUP BY A.MONTH, A.YEAR


select status, VerTime from [dbo].[Attendance] where [Name] = @name and [Id] = @id and [Month]= @month and [Year] = @year and [DayOfMonth] = @date

SELECT count(distinct([DayOfMonth])) FROM [Attendance]   GROUP BY  MONTH, YEAR  
SELECT count(distinct([DayOfMonth])) as totalAtt FROM [Attendance] where [ID]=100 and STATUS='Full Day' GROUP BY  MONTH, YEAR;
