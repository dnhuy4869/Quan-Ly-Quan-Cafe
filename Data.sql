CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

CREATE TABLE TableFood
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	Status NVARCHAR(100) NOT NULL DEFAULT N'Empty'  -- Trong || Co Nguoi
)
GO

CREATE TABLE Account
(
	Id INT IDENTITY PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL,
	UserName NVARCHAR(100) NOT NULL,
	Password NVARCHAR(1000) NOT NULL,
	Type INT NOT NULL DEFAULT 0    -- 1:Admin || 0: User
)
GO

CREATE TABLE FoodCategory
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Food
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	IdCategory INT NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (IdCategory) REFERENCES dbo.FoodCategory(Id)
)
GO

CREATE TABLE Bill
(
	Id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	IdTable INT NOT NULL,
	Status INT NOT NULL DEFAULT 0,    -- 1:Da thanh toan || 0: Chua thanh toan
	Discount INT NOT NULL DEFAULT 0

	FOREIGN KEY (IdTable) REFERENCES dbo.TableFood(Id)
)
GO

CREATE TABLE BillInfo
(
	Id INT IDENTITY PRIMARY KEY,
	IdBill INT NOT NULL,
	IdFood INT NOT NULL,
	Count INT NOT NULL DEFAULT 0

	FOREIGN KEY (IdBill) REFERENCES dbo.Bill(Id),
	FOREIGN KEY (IdFood) REFERENCES dbo.Food(Id)
)
GO

INSERT dbo.Account (DisplayName, UserName, Password, Type)
VALUES (N'Huy', N'1', N'1', 1),
		(N'HuyVer2', N'2', N'1', 0)
GO

CREATE PROCEDURE sp_Login 
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username AND Password = @password
END
GO

DECLARE @i INT = 1
WHILE @i <= 12
BEGIN
	INSERT dbo.TableFood (Name)
	VALUES (N'Table ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END
GO

CREATE PROCEDURE sp_GetListTable
AS
BEGIN
	SELECT * FROM dbo.TableFood
END
GO

UPDATE dbo.TableFood SET Status = N'Using' WHERE Id = 6
GO

INSERT dbo.FoodCategory (Name)
VALUES (N'Sky'),
		(N'Earth'),
		(N'Sea')
GO

INSERT dbo.Food (Name, IdCategory, Price)
VALUES (N'Chim', 1, 10000),
		(N'Hai Au', 1, 300000),
		(N'Bo', 2, 80000),
		(N'Lon', 2, 150000),
		(N'Ga', 2, 200000),
		(N'Ca', 3, 45000),
		(N'tom', 3, 160000),
		(N'Cua', 3, 400000)
GO

INSERT dbo.Bill (DateCheckIn, DateCheckOut, IdTable, Status)
VALUES (GETDATE(), NULL, 1, 0),
		(GETDATE(), NULL, 2, 0),
		(GETDATE(), GETDATE(), 2, 1)
GO

INSERT dbo.BillInfo (IdBill, IdFood, Count)
VALUES (1, 2, 2),
		(1, 4, 1),
		(2, 3, 4)
GO

CREATE PROC sp_InsertBill
@idtable INT
AS
BEGIN
	INSERT dbo.Bill (DateCheckIn, DateCheckOut, IdTable, Status, Discount)
	VALUES (GETDATE(), null, @idtable, 0, 0)
END
GO 

CREATE PROC sp_InsertBillInfo
@idbill INT, @idfood INT, @count INT
AS
BEGIN
	INSERT dbo.BillInfo (IdBill, IdFood, Count)
	VALUES (@idbill, @idfood, @count)
END
GO 

ALTER PROC sp_InsertBillInfo
@idbill INT, @idfood INT, @count INT
AS
BEGIN
	DECLARE @IsExistBillInfo INT
	DECLARE @FoodCount INT 

	SELECT @IsExistBillInfo = COUNT(*) FROM dbo.BillInfo WHERE IdBill = @idbill AND IdFood = @idfood
	SELECT @FoodCount = Count FROM dbo.BillInfo WHERE IdBill = @idbill AND IdFood = @idfood

	DECLARE @NewCount INT = @FoodCount + @count

	IF @IsExistBillInfo > 0
	BEGIN
		IF @NewCount > 0
			UPDATE dbo.BillInfo SET Count = @FoodCount + @count WHERE IdFood = @idfood
		ELSE
		BEGIN
			DELETE dbo.BillInfo WHERE IdBill = @idbill AND IdFood = @idfood
		END	
	END
	ELSE IF @count != 0
		BEGIN
			INSERT dbo.BillInfo (IdBill, IdFood, Count)
			VALUES (@idbill, @idfood, @count)
		END
END
GO 

CREATE TRIGGER tg_UpdateBillInfo ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @IdBill INT
	DECLARE @IdTable INT

	SELECT @IdBill = IdBill FROM Inserted
	SELECT @IdTable = IdTable FROM dbo.Bill WHERE Id = @IdBill AND Status = 0

	UPDATE dbo.TableFood SET Status = N'Using' WHERE Id = @IdTable
END
GO 

CREATE TRIGGER tg_UpdateBill ON dbo.Bill FOR INSERT, UPDATE
AS 
BEGIN
	DECLARE @IdBill INT 
	DECLARE @IdTable INT 
	DECLARE @Count INT

	SELECT @IdBill = Id FROM Inserted
	SELECT @IdTable = IdTable FROM dbo.Bill WHERE Id = @IdBill
	SELECT @Count = COUNT(*) FROM dbo.Bill WHERE IdTable = @IdTable AND Status = 0

	IF @Count = 0
		UPDATE dbo.TableFood SET Status = N'Empty' WHERE Id = @IdTable
END
GO

CREATE PROC sp_SwitchTable
@IdTable1 INT, @IdTable2 INT  
AS
BEGIN
	DECLARE @IdFirstBill INT
	DECLARE @IdSecondBill INT
	DECLARE @StatusTable1 NVARCHAR(100)
	DECLARE @StatusTable2 NVARCHAR(100)

	SELECT @IdFirstBill = Id FROM dbo.Bill WHERE IdTable = @IdTable1 AND Status = 0
	SELECT @IdSecondBill = Id FROM dbo.Bill WHERE IdTable = @IdTable2 AND Status = 0

	SELECT @StatusTable1 = Status FROM dbo.TableFood WHERE Id = @IdTable1
	SELECT @StatusTable2 = Status FROM dbo.TableFood WHERE Id = @IdTable2

	IF @IdFirstBill IS NULL
	BEGIN
		INSERT dbo.Bill (DateCheckIn, DateCheckOut, IdTable, Status, Discount)
		VALUES (GETDATE(), NULL, @IdTable1, 0, 0)
		SELECT @IdFirstBill = MAX(Id) FROM dbo.Bill WHERE IdTable = @IdTable1 AND Status = 0
	END

	IF @IdSecondBill IS NULL
	BEGIN
		INSERT dbo.Bill (DateCheckIn, DateCheckOut, IdTable, Status, Discount)
		VALUES (GETDATE(), NULL, @IdTable2, 0, 0)
		SELECT @IdSecondBill = MAX(Id) FROM dbo.Bill WHERE IdTable = @IdTable2 AND Status = 0
	END

	UPDATE dbo.BillInfo SET IdBill = @IdSecondBill WHERE IdBill = @IdFirstBill
	UPDATE dbo.BillInfo SET IdBill = @IdFirstBill WHERE IdBill = @IdSecondBill

	UPDATE dbo.Bill SET IdTable = @IdTable2 WHERE Id = @IdFirstBill
	UPDATE dbo.Bill SET IdTable = @IdTable1 WHERE Id = @IdSecondBill

	UPDATE dbo.TableFood SET Status = @StatusTable2 WHERE Id = @IdTable1
	UPDATE dbo.TableFood SET Status = @StatusTable1 WHERE Id = @IdTable2
END
GO

ALTER TABLE dbo.Bill ADD TotalPrice FLOAT
GO

CREATE PROC sp_GetListBillByDate
@datecheckin DATE, @datecheckout DATE
AS
BEGIN
	SELECT Bill.Id, Name, DateCheckIn, DateCheckOut, dbo.Bill.TotalPrice FROM dbo.Bill, dbo.TableFood
WHERE DateCheckIn >= '20201102' AND DateCheckOut <= N'20201102' AND dbo.Bill.Status = 1 AND IdTable = TableFood.Id
END
GO

CREATE PROC sp_UpdateAccount
@displayname NVARCHAR(100), @password NCHAR(1000), @username NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Account SET DisplayName = @displayname, Password = @password WHERE UserName = @username
END
GO 

CREATE PROC sp_UpdateAccountNoPass
@displayname NVARCHAR(100), @username NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Account SET DisplayName = @displayname WHERE UserName = @username
END
GO





















