DROP TABLE Branch cascade constraints;
DROP TABLE Volunteer cascade constraints;
DROP TABLE Donor cascade constraints;
DROP TABLE Activity cascade constraints;
DROP TABLE Donates cascade constraints;
DROP TABLE Campaign cascade constraints;
DROP TABLE Employee cascade constraints;
DROP TABLE BranchPhones cascade constraints;
DROP TABLE WorksON cascade constraints;

CREATE TABLE Branch
(BID number(3) primary key,
Address varchar2(50) not null);

CREATE TABLE Volunteer 
(SSN NUMBER(10,0) primary key, 
FNAME VARCHAR2(10) NOT NULL, 
LNAME VARCHAR2(10) NOT NULL, 
SEX CHAR(1), 
EMAIL VARCHAR2(20), 
MOBILENUMBER NUMBER(12,0) NOT NULL, 
ADDRESS VARCHAR2(50));

CREATE TABLE Donor 
(SSN NUMBER(10,0) primary key, 
FNAME VARCHAR2(10) NOT NULL, 
LNAME VARCHAR2(10) NOT NULL, 
SEX CHAR(1), 
EMAIL VARCHAR2(20), 
MOBILENUMBER NUMBER(12,0) NOT NULL, 
ADDRESS VARCHAR2(50));

CREATE TABLE Activity
(ActName VARCHAR(50) PRIMARY KEY,
BID NUMBER(3) references Branch(BID));

CREATE TABLE Donates
(DONSSN NUMBER(10,0) references Donor(SSN),
ActivityName VARCHAR(50) references Activity(ActName),
constraint pkDonates PRIMARY KEY(DONSSN, ActivityName),
Code VARCHAR(25),
DonDate DATE NOT NULL,
DonTime DATE NOT NULL,
Amount Number(10) NOT NULL);

CREATE TABLE Campaign
(CampName varchar2(30),
CampDate date,
BID number(3) references Branch(BID),
ActivityName varchar2(50) references Activity(ActName),
constraint pkCamp primary key (CampDate, BID, ActivityName));
                               
CREATE TABLE Employee
(SSN NUMBER(10,0) primary key, 
FNAME VARCHAR2(10) NOT NULL, 
LNAME VARCHAR2(10) NOT NULL, 
SEX CHAR(1), 
EMAIL VARCHAR2(20), 
MOBILENUMBER NUMBER(12,0) NOT NULL, 
ADDRESS VARCHAR2(50),
BID NUMBER(3) references Branch(BID));

CREATE TABLE WorksOn
(VOLSSN NUMBER(10) references Volunteer(SSN),
ActivityName varchar2(50) references Activity(ActName),
Start_date DATE not NULL,
constraint pkWorksOn primary key (VOLSSN, ActivityName));
   
   
CREATE TABLE BranchPhones
(BID NUMBER(3) references Branch(BID),
MOBILENUMBER NUMBER(12,0),
constraint pkBranchPhones primary key (BID, MOBILENUMBER));
