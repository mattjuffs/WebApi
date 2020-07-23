Create Table dbo.tbl_MeterReading
(
	MeterReadingID int IDENTITY,
	AccountID int,
	MeterReadingDateTime datetime2(7),
	MeterReadValue int
)

Create Table dbo.tbl_Account
(
	AccountID int,
	FirstName nvarchar(50),
	LastName nvarchar(50)
)