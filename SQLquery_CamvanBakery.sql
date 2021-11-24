CREATE DATABASE StoreManagement
GO

USE StoreManagement
GO

--
--
-- COMBO NGƯỜI
--
--
-- 1/Giới tính
CREATE TABLE Gender
(
    GenderId      INT             IDENTITY(0,1)   PRIMARY KEY,
    GenderName    NVARCHAR(50)    NOT NULL
)
INSERT INTO dbo.Gender (GenderName)
VALUES  (N'Khác')

INSERT INTO dbo.Gender (GenderName)
VALUES  (N'Nam')

INSERT INTO dbo.Gender (GenderName)
VALUES  (N'Nữ')
GO
-- 2/Giao diện giới tính
CREATE VIEW VW_ShowGenderList
AS
SELECT * FROM Gender
GO

--
--
-- COMBO NHÂN VIÊN
--
--
-- 1/Vai trò
CREATE TABLE Roles
(
    RoleId      INT             IDENTITY(0,1)   PRIMARY KEY,
    RoleName    NVARCHAR(50)    NOT NULL
)
INSERT INTO dbo.Roles (RoleName)
VALUES  (N'Admin')

INSERT INTO dbo.Roles (RoleName)
VALUES  (N'Quản lý')

INSERT INTO dbo.Roles (RoleName)
VALUES  (N'Nhân viên quầy')

INSERT INTO dbo.Roles (RoleName)
VALUES  (N'Thủ kho')
GO
-- 2/Giao diện vai trò
CREATE VIEW VW_ShowRoleList
AS
SELECT * FROM Roles
GO

-- 3/Nhân viên
CREATE FUNCTION AutoIncrementEmployeeId()
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(EmployeeId) FROM Employees) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(EmployeeId, 6)) FROM Employees
		SELECT @ID = CASE
			WHEN @ID >= 0 AND @ID< 9 THEN 'NV00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 AND @ID < 99 THEN 'NV0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 AND @ID < 999 THEN 'NV000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 AND @ID < 9999 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999 AND @ID < 99999 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99999 AND @ID < 999999 THEN 'NV' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE Employees
(
    EmployeeId			CHAR(8)         PRIMARY KEY     CONSTRAINT AutoEmployeeId DEFAULT dbo.AutoIncrementEmployeeId(),
    EmployeeName		NVARCHAR(100)   NOT NULL,
    EmployeeGender		INT             DEFAULT 0,
    EmployeeBirth		DATE            NOT NULL,
    EmployeeCIC			NVARCHAR(20)    NOT NULL,
    EmployeeAddress		NVARCHAR(1000)  NOT NULL,
    EmployeeTel			NVARCHAR(20)    NOT NULL,
	EmployeeDescription	NVARCHAR(1000)	DEFAULT N'Tấm chiếu mới chưa từng trải',
    [Role]				INT             DEFAULT 0,
    Salary				FLOAT           DEFAULT 0,
    WorkedTime			FLOAT           DEFAULT 0,
	DayStarted			DATE			DEFAULT GETDATE(),
	CONSTRAINT FK_Employee_Role FOREIGN KEY ([Role]) REFERENCES dbo.Roles(RoleId)
)
INSERT INTO dbo.Employees (EmployeeName, EmployeeGender, EmployeeBirth, EmployeeCIC, EmployeeAddress, EmployeeTel, [Role])
VALUES  (N'Đồng Quốc Huy', '1', '1996-07-31', '008096007295', N'Tuyên Quang', '0985805096', '1')

INSERT INTO dbo.Employees (EmployeeName, EmployeeGender, EmployeeBirth, EmployeeCIC, EmployeeAddress, EmployeeTel, [Role])
VALUES  (N'Nguyễn Thị Hoài', '2', '2001-08-21', '006007008009', N'Bắc Giang', '0909090909', '2')

INSERT INTO dbo.Employees (EmployeeName, EmployeeGender, EmployeeBirth, EmployeeCIC, EmployeeAddress, EmployeeTel, [Role])
VALUES  (N'Vũ Khánh Lâm', '3', '2000-10-30', '003005007009', N'Thái Nguyên', '0980980908', '3')
GO

-- 4/Giao diện nhân viên
CREATE VIEW VW_ShowEmployeeList
AS
SELECT	e.EmployeeId, r.RoleName, e.EmployeeName, g.GenderName, e.EmployeeBirth, e.EmployeeCIC, e.EmployeeTel, e.EmployeeAddress, e.DayStarted, e.EmployeeDescription, e.Salary, e.WorkedTime
FROM	dbo.Employees AS e, dbo.Gender AS g, dbo.Roles AS r
WHERE	e.[Role] = r.RoleId
AND		e.EmployeeGender = g.GenderId
GO

--
--
-- COMBO Tài khoản
--
--
-- 1/Tài khoản
CREATE TABLE Accounts
(
    Username    NVARCHAR(100)   PRIMARY KEY,
    Password    NVARCHAR(1000)  NOT NULL,
    TypeAccount INT             NOT NULL,
    EmployeeId  CHAR(8),					-- không cần khoá ngoài vì không phải nhân viên nào cũng có tài khoản, và có thể là tài khoản admin
	Avatar		IMAGE
)
INSERT INTO dbo.Accounts (Username, [Password], TypeAccount, EmployeeId)
VALUES  ('admin', '8888', '0', 'Admin')

INSERT INTO dbo.Accounts (Username, [Password], TypeAccount, EmployeeId)
VALUES  ('huy', '7749', '1', 'NV000001')

INSERT INTO dbo.Accounts (Username, [Password], TypeAccount, EmployeeId)
VALUES  ('hoai', '12345', '2', 'NV000002')

INSERT INTO dbo.Accounts (Username, [Password], TypeAccount, EmployeeId)
VALUES  ('lam', '2000', '3', 'NV000003')
GO
-- 2/Giao diện tài khoản
CREATE VIEW VW_ShowAccountList
AS
SELECT	a.Username, a.TypeAccount, e.EmployeeId, e.EmployeeName
FROM	Accounts AS a, Employees AS e
WHERE	a.EmployeeId = e.EmployeeId
GO
-- 3/Xử lý và cấp quyền đăng nhập máy chủ
CREATE PROCEDURE USP_Authetication
@username NVARCHAR(100),
@password NVARCHAR(1000)
WITH ENCRYPTION
AS
BEGIN
	SELECT	* 
	FROM	dbo.Accounts
	WHERE	[Username] = @username
	AND		[Password] = @password
END
GO

--
--
-- COMBO KHÁCH HÀNG
--
--
-- 1/Khách hàng
CREATE FUNCTION AutoIncrementCustomerId()
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(CustomerId) FROM Customers) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(CustomerId, 6)) FROM Customers
		SELECT @ID = CASE
			WHEN @ID >= 0 AND @ID< 9 THEN 'KH00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 AND @ID < 99 THEN 'KH0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 AND @ID < 999 THEN 'KH000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 AND @ID < 9999 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999 AND @ID < 99999 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99999 AND @ID < 999999 THEN 'KH' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE Customers
(
    CustomerId      	CHAR(8)         PRIMARY KEY     CONSTRAINT AutoCustomerId DEFAULT dbo.AutoIncrementCustomerId(),
    CustomerName    	NVARCHAR(100)   NOT NULL,		
    CustomerGender  	INT             NOT NULL,		
    CustomerBirth   	DATE            DEFAULT '2001-01-01',
    CustomerCIC     	NVARCHAR(20)    DEFAULT '006007008009',
    CustomerAddress 	NVARCHAR(1000),
    CustomerTel     	NVARCHAR(20)    NOT NULL,
	CustomerLevel		NVARCHAR(20)	DEFAULT N'Đồng',
	CustomerPoint		INT				DEFAULT 0,
	CustomerDescription	NVARCHAR(1000)  DEFAULT N'Khách hàng mới',
	CONSTRAINT FK_Gender FOREIGN KEY (CustomerGender) REFERENCES Gender(GenderId)
)
GO
-- 2/Giao diện khách hàng
CREATE VIEW VW_ShowCustomerList
AS
SELECT 	c.CustomerId, c.CustomerName, g.GenderName, c.CustomerCIC, c.CustomerTel, c.CustomerBirth, c.CustomerAddress, c.CustomerLevel, c.CustomerPoint, c.CustomerDescription
FROM 	dbo.Customers AS c, dbo.Gender AS g
WHERE	c.CustomerGender = g.GenderId
GO

--
--
-- COMBO PRODUCT
--
--
-- 1/Danh mục mặt hàng
CREATE TABLE Categories
(
    CategoryId      INT             IDENTITY(0,1)   PRIMARY KEY,
    CategoryName    NVARCHAR(50)    NOT NULL
)
INSERT INTO dbo.Categories (CategoryName)
VALUES  (N'Khác')

INSERT INTO dbo.Categories (CategoryName)
VALUES  (N'Bánh sinh nhật')

INSERT INTO dbo.Categories (CategoryName)
VALUES  (N'Bánh mỳ')

INSERT INTO dbo.Categories (CategoryName)
VALUES  (N'Bánh ngọt')

INSERT INTO dbo.Categories (CategoryName)
VALUES  (N'Đồ uống')

INSERT INTO dbo.Categories (CategoryName)
VALUES  (N'Đồ ăn nhanh')
GO
-- 2/Giao diện Categorys
CREATE VIEW VW_ShowCategoryList
AS
SELECT * FROM dbo.Categories
GO
-- 3/Mặt hàng
CREATE FUNCTION AutoIncrementProductId()
RETURNS VARCHAR(8)
AS
BEGIN
	DECLARE @ID VARCHAR(8)
	IF (SELECT COUNT(ProductId) FROM Products) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(ProductId, 6)) FROM Products
		SELECT @ID = CASE
			WHEN @ID >= 0 AND @ID< 9 THEN 'SP00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 AND @ID < 99 THEN 'SP0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 AND @ID < 999 THEN 'SP000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 AND @ID < 9999 THEN 'SP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999 AND @ID < 99999 THEN 'SP0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99999 AND @ID < 999999 THEN 'SP' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE Products
(
    ProductId               CHAR(8)         PRIMARY KEY     CONSTRAINT AutoProductId DEFAULT dbo.AutoIncrementProductId(),
    ProductName             NVARCHAR(100)   NOT NULL,
    ProductImage            IMAGE,
    ProductUnit             NVARCHAR(50),
    ProductPrice            FLOAT           DEFAULT 0,
    ProductTotalQuantity    FLOAT           DEFAULT 0,
    CategoryId              INT             DEFAULT 0,
	ProductDescription		NVARCHAR(1000),
    CONSTRAINT  FK_ProductCategory FOREIGN KEY (CategoryId) REFERENCES Categorys(CategoryId)
)
GO
-- 4/Giao diện sản phẩm
CREATE VIEW VW_ShowProductList
AS
SELECT p.ProductId, p.ProductName, c.CategoryName,p.ProductImage, p.ProductUnit, p.ProductPrice, p.ProductTotalQuantity, p.ProductDescription
FROM dbo.Products AS p, dbo.Categories AS c
WHERE p.CategoryId = c.CategoryId
GO
--
--
-- COMBO ĐƠN HÀNG
--
--
-- 1/Trạng thái
CREATE TABLE [Status]
(
    StatusId      INT             IDENTITY(-1,1)   PRIMARY KEY,
    StatusName    NVARCHAR(50)    NOT NULL
)
INSERT INTO dbo.Status (StatusName)
VALUES  (N'Đã huỷ')

INSERT INTO dbo.Status (StatusName)
VALUES  (N'Chưa hoàn thành')

INSERT INTO dbo.Status (StatusName)
VALUES  (N'Đã hoàn thành')
GO
CREATE VIEW VW_ShowStatusList
AS
SELECT * FROM [Status]
GO
-- 2/Đơn hàng
CREATE FUNCTION AutoIncrementOrderId()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	IF (SELECT COUNT(OrderId) FROM Orders) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(OrderId, 8)) FROM Orders
		SELECT @ID = CASE
			WHEN @ID >= 0 AND @ID< 9 THEN 'DH0000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 AND @ID < 99 THEN 'DH000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 AND @ID < 999 THEN 'DH00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 AND @ID < 9999 THEN 'DH0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999 AND @ID < 99999 THEN 'DH000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99999 AND @ID < 999999 THEN 'DH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999999 AND @ID < 9999999 THEN 'DH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999999 AND @ID < 99999999 THEN 'DH' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE Orders
(
    OrderId             CHAR(10)        PRIMARY KEY     CONSTRAINT AutoOrderId DEFAULT dbo.AutoIncrementOrderId(),
    CustomerId          CHAR(8)         NOT NULL,
    EmployeeId          CHAR(8)         NOT NULL,
    OrderTimeStamp      DATETIME        NOT NULL	DEFAULT GETDATE(),
    OrderStatus         INT             DEFAULT 0,
    OrderDescription    NVARCHAR(1000),
    CONSTRAINT FK_Order_Customer FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    CONSTRAINT FK_Order_Employee FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId),
    CONSTRAINT FK_Order_Status FOREIGN KEY (OrderStatus) REFERENCES [Status](StatusId),
)
GO
-- 3/Chi tiết đơn hàng
CREATE TABLE OrderDetail
(
	OrderId				CHAR(10)		NOT NULL,
	ProductId			CHAR(8)			NOT NULL,
	ProductQuantity		INT				DEFAULT 1,
	CONSTRAINT PK_OrderDetail PRIMARY KEY (OrderId, ProductId),
	CONSTRAINT FK_OrderDetail_Order FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
	CONSTRAINT FK_OrderDetail_Product FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
)
GO
-- 4/Giao diện hiển thị đơn hàng
CREATE VIEW VW_ShowOrderList
AS
SELECT 	o.OrderId,o.CustomerId, c.CustomerName,o.EmployeeId, e.EmployeeName, o.OrderTimeStamp, s.StatusName, o.OrderDescription
FROM 	Orders AS o, Customers AS c, Employees AS e, [Status] AS s
WHERE	o.CustomerId = c.CustomerId
AND 	o.EmployeeId = e.EmployeeId
AND 	o.OrderStatus = s.StatusId
GO
-- 5/Giao diện hiển thị chi tiết đơn hàng
CREATE PROCEDURE USP_ShowOrderDetail
@OrderId CHAR(10)
AS
SELECT od.OrderId, od.ProductQuantity, p.ProductId, p.ProductName, p.ProductUnit, p.ProductPrice , od.ProductQuantity*p.ProductPrice AS SubTotal
FROM dbo.OrderDetail AS od, dbo.Products AS p
WHERE od.ProductId = p.ProductId
AND od.OrderId = @OrderId;
GO
-- 6/Lấy ra đơn hàng vừa thêm
CREATE PROCEDURE USP_GetLastestOrder
AS
SELECT TOP 1 [OrderId] FROM dbo.Orders ORDER BY OrderId DESC
GO
--
--
-- HOÁ ĐƠN
--
--
-- 1/Khuyến mãi
CREATE TABLE Discount
(
	DiscountId		INT		IDENTITY(1,1) PRIMARY KEY,
	DiscountPercent	FLOAT	DEFAULT 0
)
-- 2/Hoá đơn
CREATE FUNCTION AutoIncrementBillId()
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @ID VARCHAR(10)
	IF (SELECT COUNT(BillId) FROM Bills) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(BillId, 8)) FROM Bills
		SELECT @ID = CASE
			WHEN @ID >= 0 AND @ID< 9 THEN 'HD0000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 AND @ID < 99 THEN 'HD000000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99 AND @ID < 999 THEN 'HD00000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999 AND @ID < 9999 THEN 'HD0000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999 AND @ID < 99999 THEN 'HD000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 99999 AND @ID < 999999 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 999999 AND @ID < 9999999 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9999999 AND @ID < 99999999 THEN 'HD' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
GO
CREATE TABLE Bills
(
    BillId             	CHAR(10)        PRIMARY KEY     CONSTRAINT AutoBillId DEFAULT dbo.AutoIncrementBillId(),
    OrderId         	CHAR(10)        NOT NULL,
    BillTimeStamp      	DATETIME		DEFAULT GETDATE(),
	Tax					FLOAT			DEFAULT 0,
	Discount			INT				DEFAULT 1,
	TotalPayment		FLOAT			DEFAULT 0,
    BillStatus         	INT             DEFAULT 0,
    BillDescription    	NVARCHAR(1000),
    CONSTRAINT FK_Bill_Order FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    CONSTRAINT FK_Bill_Discount FOREIGN KEY (Discount) REFERENCES Discount(DiscountId),
    CONSTRAINT FK_Bill_Status FOREIGN KEY (BillStatus) REFERENCES [Status](StatusId)
)
GO
-- 3/Giao diện hoá đơn
CREATE VIEW VW_ShowBillList
AS
SELECT	b.BillId, b.BillTimeStamp, b.OrderId, c.CustomerName, e.EmployeeName, d.DiscountPercent, b.Tax, b.TotalPayment, s.StatusName
FROM 	dbo.Customers AS c, dbo.Employees AS e, dbo.Bills AS b, dbo.Orders AS o, dbo.Status AS s, dbo.Discount AS d
WHERE	o.EmployeeId = e.EmployeeId
AND		o.CustomerId = c.CustomerId
AND		b.OrderId = o.OrderId
AND		b.BillStatus = s.StatusId
AND		b.Discount = d.DiscountId
GO

-- Tìm hiểu cách tính tiền tự động nhé. Công thức: Tổng tiền = (( Đơn giá * Số lượng ) * (1 - Giảm giá / 100)) * (1 + Thuế / 100)

--
--
-- Nguyên vật liệu

--
--
-- Nhà cung cấp

--
--
-- Phiếu nhập kho

--
--
-- Phiếu xuất kho