SET IDENTITY_INSERT [dbo].[Attendance] ON
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (35, 101, N'Sharada                                                                                             ', 7, N'July                ', 2020, N'NA        ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (36, 102, N'Shanthi                                                                                             ', 7, N'July                ', 2020, N'12:24:21  ', N'Half Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (39, 100, N'Bharati                                                                                             ', 7, N'July                ', 2020, N'09:47:40  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (41, 104, N'Keerthana C                                                                                         ', 8, N'July                ', 2020, N'10:27:49  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (42, 100, N'Bharati                                                                                             ', 8, N'July                ', 2020, N'10:31:36  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (43, 101, N'Sharada                                                                                             ', 8, N'July                ', 2020, N'12:31:52  ', N'Half Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (44, 102, N'Shanthi                                                                                             ', 8, N'July                ', 2020, N'12:32:4   ', N'Half Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (46, 100, N'Bharati                                                                                             ', 1, N'June                ', 2020, N'09:45:16  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (48, 100, N'Bharati                                                                                             ', 2, N'June                ', 2020, N'NA        ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (49, 101, N'Sharada                                                                                             ', 1, N'June                ', 2020, N'09:28:19  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (50, 102, N'Shanthi                                                                                             ', 1, N'June                ', 2020, N'09:18:20  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (51, 104, N'Keerthana C                                                                                         ', 1, N'June                ', 2020, N'NA        ', N'Absent                        ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (52, 101, N'Sharada                                                                                             ', 2, N'June                ', 2020, N'10:09:48  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (53, 102, N'Sharada                                                                                             ', 2, N'June                ', 2020, N'09:52:37  ', N'Full Day                      ')
INSERT INTO [dbo].[Attendance] ([Sl], [Id], [Name], [DayOfMonth], [Month], [Year], [VerTime], [Status]) VALUES (54, 104, N'Keerthana C                                                                                         ', 2, N'June                ', 2020, N'09:03:17  ', N'Full Day                      ')
SET IDENTITY_INSERT [dbo].[Attendance] OFF


SELECT sum(working) from (

SELECT count(distinct([Attendance].DayOfMonth))  as working

FROM [Attendance], [User]

WHERE [Attendance].id = [User].id
and [User].id = 100
and CAST(cast(Attendance.[DayOfMonth] as varchar) + Attendance.[Month] +  cast(Attendance.[Year] as varchar) AS date)  >= cast([User].enrollDate as date)
Group by [Attendance].month, [Attendance].year
) T1

select sum (total) from (SELECT count(distinct([DayOfMonth])) as total FROM [Attendance] where[ID] = 100 and STATUS = 'Full Day' GROUP BY  [Month], [Year]) T1


SELECT SUM(rate) FROM (SELECT MAX(rate) AS rate FROM records GROUP BY last_name, first_name) T1


select sum (total) from (SELECT count(distinct([DayOfMonth])) as total FROM [Attendance] where[ID] = 103 and STATUS = 'Half Day' GROUP BY  [Month], [Year]) T1

SELECT count(distinct(A.DayOfMonth)) FROM  Attendance AS A INNER JOIN
         dbo.[User] AS U
         ON A.ID = U.ID
		 where A.Id = 103 AND
         

		 CAST(cast(A.[DayOfMonth] as varchar) + A.[Month] +  cast(A.[Year] as varchar) AS date)  >= cast(U.enrollDate as date)
		 
		
		 
		 
SELECT DATEPART(DAY, [enrollDate]) from [User] where id= 104
SELECT DATEPART(MONTH, [enrollDate]) from [User] 

select datename(month, enrollDate)

SELECT 
		 CAST(cast([DayOfMonth] as varchar) + [Month] +  cast([Year] as varchar) AS datetime) from Attendance



SELECT sum(working) from (SELECT count(distinct([Attendance].DayOfMonth)) as working FROM [Attendance] Group by [Attendance].month, [Attendance].year) T1

WHERE [Attendance].id = [User].id
and [User].id = 100
and CAST(cast(Attendance.[DayOfMonth] as varchar) + Attendance.[Month] +  cast(Attendance.[Year] as varchar) AS date)  >= cast([User].enrollDate as date)



select sum(total) as total from (select count(distinct(DayOfMonth)) as total FROM [Attendance]  where  CAST(cast(Attendance.[DayOfMonth] as varchar) + Attendance.[Month] +  cast(Attendance.[Year] as varchar) AS date) >= (select cast(enrollDate as date) from [User] where id = 103)  Group by month, year ) T1

select sum (total) as fullday from (SELECT count([DayOfMonth]) as total FROM [Attendance] where[ID] = 102 and STATUS = 'Full Day' GROUP BY  [Month], [Year]) T1

select sum (total) as halfday from (SELECT count(distinct([DayOfMonth])) as total FROM [Attendance] where[ID] = 100 and STATUS = 'Half Day' GROUP BY  [Month], [Year]) T1