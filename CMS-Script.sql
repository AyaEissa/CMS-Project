DROP TABLE Branch cascade constraints;
DROP TABLE Volunteer cascade constraints;
DROP TABLE Donor cascade constraints;
DROP TABLE Activity cascade constraints;
DROP TABLE Donates cascade constraints;

CREATE TABLE Branch
(BID number(3) primary key,
Address varchar2(50) not null);

CREATE TABLE Volunteer 
("SSN" NUMBER(10,0) primary key, 
"FNAME" VARCHAR2(10) NOT NULL, 
"LNAME" VARCHAR2(10) NOT NULL, 
"SEX" CHAR(1), 
"EMAIL" VARCHAR2(20), 
"MOBILE_NUMBER" NUMBER(12,0) NOT NULL, 
"ADDRESS" VARCHAR2(50));

CREATE TABLE Donor 
("SSN" NUMBER(10,0) primary key, 
"FNAME" VARCHAR2(10) NOT NULL, 
"LNAME" VARCHAR2(10) NOT NULL, 
"SEX" CHAR(1), 
"EMAIL" VARCHAR2(20), 
"MOBILE_NUMBER" NUMBER(12,0) NOT NULL, 
"ADDRESS" VARCHAR2(50));

CREATE TABLE Activity
("ANAME" VARCHAR(50) PRIMARY KEY,
"BID" NUMBER(3) references Branch(BID));

CREATE TABLE Donates
("DON_SSN" NUMBER(10,0) references Donor(SSN),
"Activity_Name" VARCHAR(50) references Activity(ANAME),
"Code" VARCHAR(25),
"Date" DATE NOT NULL,
"Time" DATE NOT NULL,
"Amount" Number(10) NOT NULL);

CREATE TABLE Branch_Phones
   (	BID NUMBER(3) NOT NULL references Branch(BID),
	  MOBILE_NUMBER NUMBER(12,0) NOT NULl primary key
   );