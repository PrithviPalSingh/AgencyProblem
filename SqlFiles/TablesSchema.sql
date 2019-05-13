-- =========================================
-- Create table template Windows Azure SQL Database 
-- =========================================
IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
  DROP TABLE dbo.Users
GO

CREATE TABLE dbo.Users
(
	UserID varchar(20),
	UserName varchar(50)	
)
GO

IF OBJECT_ID('dbo.InsuranceMaster', 'U') IS NOT NULL
  DROP TABLE dbo.InsuranceMaster
GO

Create TABLE dbo.InsuranceMaster
(
	Code varchar(20),
	Name varchar(20),
	[Description] varchar(max),
	[InsuranceType] varchar(8),
	Duration int,
	Price decimal(10,2)
)
GO

IF OBJECT_ID('dbo.MemberInsurance', 'U') IS NOT NULL
  DROP TABLE dbo.MemberInsurance
GO
CREATE TABLE dbo.MemberInsurance
(
	InsuranceID Identity(1,1),
	UserID varchar(20),
	InsuranceCode varchar(8),
	TotalAmount decimal(10,2),
	ToTalInstallments int,
	SumAssured decimal(10,2),
	MaturityDate datetime,
	CreationDate datetime,
	ModifyDate datetime,
	EMI decimal(10,2),
	AmountDue decimal(10,2),
	NextInstallmentAmout decimal(10,2),
	NextInstallmentDate datetime
)
GO

IF OBJECT_ID('dbo.MemberInsuranceInstallments', 'U') IS NOT NULL
  DROP TABLE dbo.MemberInsuranceInstallments
GO
CREATE TABLE dbo.MemberInsuranceInstallments
(
	MemberInsuranceInstallmentID Identity(1,1),
	InsuranceID varchar(100),
	InstallmentDate datetime,
	InstallmentAmout decimal(10,2)
)
GO
