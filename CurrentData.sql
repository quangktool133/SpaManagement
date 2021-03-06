USE [QuanLySpa]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' 
RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' 
+NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + 
SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,
LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [date] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBill] [int] NOT NULL,
	[idService] [int] NOT NULL,
	[count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
	[UserName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceCategory]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableService]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableService](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'admin', N'Quang KTool ', N'1', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'staff', N'Tori Rin', N'1', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'test1', N'QSBB', N'123', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'test2', N'BBSQ', N'0', 0)
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (23, CAST(N'2021-03-18' AS Date), CAST(N'2021-03-18' AS Date), 1, 1, 10, 468)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (24, CAST(N'2021-03-18' AS Date), CAST(N'2021-03-18' AS Date), 2, 1, 20, 504)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (25, CAST(N'2021-03-18' AS Date), CAST(N'2021-03-18' AS Date), 3, 1, 50, 2.1)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (26, CAST(N'2021-03-20' AS Date), CAST(N'2021-03-20' AS Date), 1, 1, 0, 220)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (27, CAST(N'2021-03-20' AS Date), CAST(N'2021-03-20' AS Date), 1, 1, 0, 0)
INSERT [dbo].[Bill] ([id], [DateCheckIn], [DateCheckOut], [idTable], [status], [discount], [totalPrice]) VALUES (28, CAST(N'2021-03-20' AS Date), CAST(N'2021-03-20' AS Date), 1, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[BillInfo] ON 

INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (30, 23, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (31, 23, 6, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (32, 23, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (33, 24, 6, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (34, 24, 7, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (35, 24, 8, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (36, 25, 3, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (37, 25, 4, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (38, 25, 5, 2)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (39, 26, 1, 1)
INSERT [dbo].[BillInfo] ([id], [idBill], [idService], [count]) VALUES (40, 26, 2, 2)
SET IDENTITY_INSERT [dbo].[BillInfo] OFF
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (1, N'Nặn mụn', 1, 100, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (2, N'Đắp mặt nạ', 1, 60, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (3, N'Triệt lông tay', 2, 400, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (4, N'Triệt lông nách', 2, 200, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (5, N'Triệt lông toàn thân', 2, 1500, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (6, N'Massage 30p', 3, 120, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (7, N'Massage 60p', 3, 210, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (8, N'Xông hơi', 4, 300, NULL)
INSERT [dbo].[Service] ([id], [name], [idCategory], [price], [UserName]) VALUES (12, N'New', 1, 9696, NULL)
SET IDENTITY_INSERT [dbo].[Service] OFF
SET IDENTITY_INSERT [dbo].[ServiceCategory] ON 

INSERT [dbo].[ServiceCategory] ([id], [name]) VALUES (1, N'Mặt')
INSERT [dbo].[ServiceCategory] ([id], [name]) VALUES (2, N'Triệt lông')
INSERT [dbo].[ServiceCategory] ([id], [name]) VALUES (3, N'Massage')
INSERT [dbo].[ServiceCategory] ([id], [name]) VALUES (4, N'Xông hơi')
SET IDENTITY_INSERT [dbo].[ServiceCategory] OFF
SET IDENTITY_INSERT [dbo].[TableService] ON 

INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (1, N'Bàn 1', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (2, N'Bàn 2', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (3, N'Bàn 3', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (4, N'Bàn 4', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (5, N'Bàn 5', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (6, N'Bàn 6', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (7, N'Bàn 7', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (8, N'Bàn 8', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (9, N'Bàn 9', N'Trống')
INSERT [dbo].[TableService] ([id], [name], [status]) VALUES (10, N'Bàn 10', N'Trống')
SET IDENTITY_INSERT [dbo].[TableService] OFF
ALTER TABLE [dbo].[Account] ADD  DEFAULT (N'KTool') FOR [DisplayName]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [PassWord]
GO
ALTER TABLE [dbo].[Account] ADD  DEFAULT ((0)) FOR [Type]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[BillInfo] ADD  DEFAULT ((0)) FOR [count]
GO
ALTER TABLE [dbo].[Service] ADD  DEFAULT (N' Unknown') FOR [name]
GO
ALTER TABLE [dbo].[Service] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[ServiceCategory] ADD  DEFAULT (N'Unknown') FOR [name]
GO
ALTER TABLE [dbo].[TableService] ADD  DEFAULT (N'Unkonwn') FOR [name]
GO
ALTER TABLE [dbo].[TableService] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableService] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD  CONSTRAINT [FK__BillInfo__idServ__3B75D760] FOREIGN KEY([idService])
REFERENCES [dbo].[Service] ([id])
GO
ALTER TABLE [dbo].[BillInfo] CHECK CONSTRAINT [FK__BillInfo__idServ__3B75D760]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK__Service__price__31EC6D26] FOREIGN KEY([idCategory])
REFERENCES [dbo].[ServiceCategory] ([id])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK__Service__price__31EC6D26]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Account] FOREIGN KEY([UserName])
REFERENCES [dbo].[Account] ([UserName])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Account]
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
As
Begin
	Select * From Account where UserName = @userName
End
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_GetListBillByDate]
 @checkIn date, @checkOut date
 As
 Begin
	Select t.name As [Tên bàn], DateCheckIn As [Ngày Vào], DateCheckOut As [Ngày ra], discount as [Giảm giá], b.totalPrice as [Tổng tiền]
	from Bill as b, TableService as t
	where DateCheckIn > = @checkIn And DateCheckOut <= @checkOut  -- yy/mm/dd
	And b.status = 1 And t.id = b.idTable 
End
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[USP_GetTableList]
As Select id, name, status From TableService
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBill]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_InsertBill]
@idTable INT
AS
begin
	Insert Bill 
	(			DateCheckIn,
				DateCheckOut,
				idTable,
				status,
				discount

			)
Values (		GETDATE() , 
				NULL ,	-- DateCheckIn -date
				@idTable ,   -- idTable - int
				0,		-- status - int 
				0
		)
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[USP_InsertBillInfo]
@idBill INT, @idService INT, @count INT
AS
Begin

	Declare @isExitsBillInfo INT
	Declare @serviceCount INT = 1
	Select @isExitsBillInfo = id, @serviceCount = b.count 
	from BillInfo as b
	where idBill = @idBill 
	And idService = @idService
	If (@isExitsBillInfo > 0)
	Begin
		Declare @newCount INT =  @serviceCount + @count
		If (@newCount > 0)
			Update BillInfo Set count = @serviceCount + @count where idService = @idService
		Else
			Delete BillInfo where idBill = @idBill And idService = @idService
	End
	Else
	Begin
		Insert BillInfo(idBill, idService, count)
	Values (@idBill, -- idBill - int
			@idService, -- idService - int
			@count -- count - int
			)
	End	
End
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
begin 
	Select * from Account where UserName = @userName AND PassWord = @passWord
End
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Proc [dbo].[USP_SwitchTable]
@idTable1 INT, @idTable2 INT
As Begin

Declare @idFirstBill INT
Declare @idSecondBill INT

Declare @isFirstTableEmty INT = 1
Declare @isSecondTableEmty INT = 1

Select @idSecondBill = id from Bill where idTable = @idTable2 and status = 0
Select @idFirstBill = id from Bill where idTable = @idTable1 and status = 0


if (@idFirstBill  IS NULL)
Begin
	Insert Bill
	(
		DateCheckIn,
		DateCheckOut,
		idTable,
		status
	)
	Values (
		GETDATE() ,
		NULL,
		@idTable1,
		0
	)	
	Select @idFirstBill = MAX(id) from Bill where idTable = @idTable1 and status = 0

End

Select @isFirstTableEmty = COUNT(*) From BillInfo where idBill = @idFirstBill

if (@idSecondBill  IS NULL)
Begin
	Insert Bill
	(
		DateCheckIn,
		DateCheckOut,
		idTable,
		status
	)
	Values (
		GETDATE() ,
		NULL,
		@idTable2,
		0
	)

	Select @idSecondBill = MAX(id) from Bill where idTable = @idTable2 and status = 0

End

Select @isSecondTableEmty = COUNT(*) From BillInfo Where idBill = @idSecondBill


Select id into IDBillInfoTable from BillInfo where idBill =@idSecondBIll

update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill

update BillInfo set idBill = @idFirstBill where id IN (Select * From IDBillInfoTable)

drop table IDBillInfoTable

If (@isFirstTableEmty = 0)
	Update TableService Set status = N'Trống' where id = @idTable2

If (@isSecondTableEmty = 0)
	Update TableService Set status = N'Trống' where id = @idTable1


End
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO
/****** Object:  Trigger [dbo].[UTG_UpdateBill]    Script Date: 3/21/2021 1:45:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[UTG_UpdateBill]
On [dbo].[Bill] For Update
As
Begin
	Declare @idBill INT

	Select @idBill = id From Inserted

	Declare @idTable INT

	Select @idTable = idTable From Bill where id = @idBill 

	Declare @count INT = 0

	Select @count = COUNT(*) From Bill Where idTable = @idTable And status = 0

	IF (@count = 0)
		Update TableService Set status = N'Trống' Where id = @idTable
End
GO
ALTER TABLE [dbo].[Bill] ENABLE TRIGGER [UTG_UpdateBill]
GO
/****** Object:  Trigger [dbo].[UTG_DeleteBillInfo]    Script Date: 3/21/2021 1:45:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[UTG_DeleteBillInfo]
ON [dbo].[BillInfo] For Delete
As
Begin
	Declare @idBillInfo INT
	Declare @idBill INT
	Select @idBillInfo = id, @idBill = Deleted.idBill From Deleted

	Declare @idTable INT
	Select @idTable = idTable from Bill where id = @idBill

	Declare @count INT = 0
	Select @count = COUNT(*) from BillInfo as bi , Bill as b where b.id = bi.idBill And b.id = @idBill and b.status = 0

	if(@count > 0)
		Update TableService Set status = N'Trống' Where id = @idTable
End
GO
ALTER TABLE [dbo].[BillInfo] ENABLE TRIGGER [UTG_DeleteBillInfo]
GO
/****** Object:  Trigger [dbo].[UTG_UpdateBillInfo]    Script Date: 3/21/2021 1:45:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[UTG_UpdateBillInfo]
On [dbo].[BillInfo] For Insert, Update
As
Begin
	Declare @idBill INT

	Select @idBill = idBill from Inserted

	Declare @idTable INT

	Select @idTable = idTable from Bill where id = @idBill And status = 0

	Declare @count INT
	Select @count = COUNT(*) from BillInfo where idBill = @idBill


	If(@count > 0)
	Update TableService Set status = N'Có người' Where id = @idTable 	
	Else
	Update TableService Set status = N'Trống' Where id = @idTable 	
End
GO
ALTER TABLE [dbo].[BillInfo] ENABLE TRIGGER [UTG_UpdateBillInfo]
GO
