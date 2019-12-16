INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8ab6608c-e6bd-4348-a649-0cfcd6d69300', N'admin@mvbookings.com', N'ADMIN@MVBOOKINGS.COM', N'admin@mvbookings.com', N'ADMIN@MVBOOKINGS.COM', 1, N'AQAAAAEAACcQAAAAEFUBi63O4pNTOA7GUIElrJalq4JpX5xURzZUT7CHUWe13OxbtNlSV8TIuEFICESm0A==', N'TOXSIH5VENS5XF27FZVGBPF4UO2TASXN', N'240665cd-61d9-47b7-998a-69fea62265b0', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Movie] ON
INSERT INTO [dbo].[Movie] ([Id], [Name], [TicketPrice]) VALUES (1, N'Mission Impossible : Fallout', CAST(35.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Movie] ([Id], [Name], [TicketPrice]) VALUES (2, N'The Conjuring', CAST(30.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Movie] ([Id], [Name], [TicketPrice]) VALUES (3, N'Terminator Genesis', CAST(40.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Movie] OFF
SET IDENTITY_INSERT [dbo].[ShowTime] ON
INSERT INTO [dbo].[ShowTime] ([Id], [ShowDate], [StartTime], [Duration]) VALUES (1, N'2019-12-26 00:00:00', N'2019-12-11 11:00:00', 2)
INSERT INTO [dbo].[ShowTime] ([Id], [ShowDate], [StartTime], [Duration]) VALUES (2, N'2019-12-16 00:00:00', N'2019-12-11 19:00:00', 2)
INSERT INTO [dbo].[ShowTime] ([Id], [ShowDate], [StartTime], [Duration]) VALUES (3, N'2019-12-21 00:00:00', N'2019-12-11 21:00:00', 2)
SET IDENTITY_INSERT [dbo].[ShowTime] OFF
SET IDENTITY_INSERT [dbo].[Booking] ON
INSERT INTO [dbo].[Booking] ([Id], [MovieId], [ShowTimeId]) VALUES (1, 1, 1)
INSERT INTO [dbo].[Booking] ([Id], [MovieId], [ShowTimeId]) VALUES (2, 2, 1)
INSERT INTO [dbo].[Booking] ([Id], [MovieId], [ShowTimeId]) VALUES (3, 3, 2)
SET IDENTITY_INSERT [dbo].[Booking] OFF
