CREATE DATABASE QuanLySpa
GO

USE QuanLySpa
GO

-- Service
-- Table
-- ServiceCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableService -- table
(
	id INT IDENTITY PRIMARY KEY ,
	name NVARCHAR(100) NOT NULL DEFAULT N'Unkonwn',
	status NVARCHAR(100) NOT NULL  DEFAULT N'Trống'-- Trống || Có người
)
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'KTool',	
	PassWord NVARCHAR(100) NOT NULL DEFAULT 0,
	Type INT  NOT NULL DEFAULT 0 --1: Admin || 0 : Staff
)
GO

CREATE TABLE ServiceCategory -- FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Unknown',
)
GO

CREATE TABLE Service -- Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N' Unknown',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.ServiceCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn Datetime NOT NULL DEFAULT GETDATE(),
	DateCheckOut Datetime,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0-- 1: Đã thanh toán && 0 chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableService(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idService INT NOT NULL,
	count INT NOT NULL DEFAULT 0,

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idService) REFERENCES dbo.Service(id)
)
GO

INSERT INTO dbo.Account
			(UserName ,
			DisplayName ,
			PassWord ,
			Type
			)
VALUES (N'admin' , -- UserName - nvarchar(100)
		N'Quang KTool' ,-- DisplayName - nvarchar(100)
		N'1' ,-- Password - nvarchar(1000)
		1  -- Type - int
		)

INSERT INTO dbo.Account
			(UserName ,
			DisplayName ,
			PassWord ,
			Type
			)
VALUES (N'staff' , -- UserName - nvarchar(100)
		N'Tori Rin' ,-- DisplayName - nvarchar(100)
		N'1' ,-- Password - nvarchar(1000)
		0  -- Type - int
		)

select * from Account

Create proc USP_GetAccountByUserName
@userName nvarchar(100)
As
Begin
	Select * From Account where UserName = @userName
End
Go

Exec dbo.USP_GetAccountByUserName @userName = N'admin'

select * from Service

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
begin 
	Select * from Account where UserName = @userName AND PassWord = @passWord
End
Go 



Select * from Account where UserName = '' And PassWord = N''  OR 1=1--'

Declare @i INT = 0 
While @i <= 10 
Begin
	Insert TableService (name)
	Values (N'Bàn ' + CAST(@i As nvarchar(100)))
	Set @i = @i + 1
End

Select * from TableService

Create Proc USP_GetTableList
As Select id, name, status From TableService
go 



Exec dbo.USP_GetTableList


Insert Bill (   DateCheckIn,
				DateCheckOut,
				idTable,
				status
			)
Values (		GETDATE() , 
				NULL,	-- chưa check out
				1 ,   -- idTable
				0		-- chưa check out
		)

Insert Bill (   DateCheckIn,
				DateCheckOut,
				idTable,
				status
			)
Values (		GETDATE() , 
				NULL,	-- chưa check out
				2 ,   -- idTable
				0		-- chưa check out
		)

Insert Bill (   DateCheckIn,
				DateCheckOut,
				idTable,
				status
			)
Values (		GETDATE() , 
				GETDATE() ,	-- chưa check out
				2 ,   -- idTable
				1		-- đã check out
		)


Select * from Bill where idTable = 1 and status = 0				


select * from BillInfo where idBill = 3


select s.name, bi.count,s.price, s.price*bi.count as totalPrice from BillInfo AS bi, Bill AS b, Service AS s 
where bi.idBill = b.id And bi.idService = s.id
And b.idTable = 2


select * from BillInfo
select * from Bill
select * from Service

create Proc USP_InsertBill
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
go

Create Proc USP_InsertBillInfo
@idBill INT, @idService INT, @count INT
AS
Begin

	Declare @isExitsBillInfo INT
	Declare @serviceCount INT = 1
	Select @isExitsBillInfo = id, 
	@serviceCount = b.count 
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
Go

Select MAX(id) from Bill

Update Bill set status = 1 where id = 1

Alter Trigger UTG_UpdateBillInfo
On BillInfo For Insert, Update
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
Go

Delete BillInfo
Delete Bill

Create Trigger UTG_UpdateBill
On Bill For Update
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
Go


Alter Table Bill
Add discount INT

Update Bill set discount = 0
go


Alter Proc USP_SwitchTable
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
go 


 --- Update TableService set status = N'Trống'


Select * from Bill 

Alter Table Bill Add totalPrice float


Delete BillInfo
Delete Bill
go

 
Create Proc USP_GetListBillByDate
 @checkIn date, @checkOut date
 As
 Begin
	Select t.name As [Tên bàn], DateCheckIn As [Ngày Vào], DateCheckOut As [Ngày ra], discount as [Giảm giá], b.totalPrice as [Tổng tiền]
	from Bill as b, TableService as t
	where DateCheckIn > = @checkIn And DateCheckOut <= @checkOut  -- yy/mm/dd
	And b.status = 1 And t.id = b.idTable 
End
go



CREATE PROC USP_UpdateAccount
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


select s.id as [Mã dịch vụ], s.name as [Tên dịch vụ], s.price as [Giá]  from Service as s


Create Trigger UTG_DeleteBillInfo
ON BillInfo For Delete
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
Go

select id as [Mã dịch vụ], name as [Tên dịch vụ], price as [giá]  from Service


-- Hàm convert co dấu
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

Select * from Service Where dbo.fuConvertToUnsign1(name) like N'%' + dbo.fuConvertToUnsign1(N'iet') + '%'


select * from Account