create database AddressBook_service

use AddressBook_service

create table AddressBook
(
	SNR int identity primary key,
	FirstName varchar(20),
	LastName varchar(20),
	Address varchar(100),
	City varchar(20),
	State varchar(20),
	ZipCode varchar(6),
	PhoneNumber varchar(10),
	EmailId varchar(30)
);

create procedure [dbo].[SpAddContacts]
(
	@FirstName varchar(20),
	@LastName varchar(20),
	@Address varchar(100),
	@City varchar(20),
	@State varchar(20),
	@ZipCode varchar(6),
	@PhoneNumber varchar(10),
	@EmailId varchar(30)
)
as
begin
insert into AddressBook values
(@FirstName,@LastName,@Address,@City,@State,@ZipCode,@PhoneNumber,@EmailId)
end
Go

select * from AddressBook