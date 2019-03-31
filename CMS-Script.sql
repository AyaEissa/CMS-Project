DROP TABLE Branch cascade constraints;
DROP TABLE Volunteer cascade constraints;
DROP TABLE Donor cascade constraints;
DROP TABLE Activity cascade constraints;

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
("Name" VARCHAR(50) PRIMARY KEY,
"BID" NUMBER(3) references Branch(BID));