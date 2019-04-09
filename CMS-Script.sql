DROP TABLE Branch CASCADE CONSTRAINTS;
DROP TABLE Volunteer CASCADE CONSTRAINTS;
DROP TABLE Donor CASCADE CONSTRAINTS;
DROP TABLE Campaign CASCADE CONSTRAINTS;
DROP TABLE Employee CASCADE CONSTRAINTS;
DROP TABLE Activity CASCADE CONSTRAINTS;
DROP TABLE WorksOn CASCADE CONSTRAINTS;
DROP TABLE Manages CASCADE CONSTRAINTS;
DROP TABLE DonatesFor CASCADE CONSTRAINTS;
DROP TABLE BranchPhones CASCADE CONSTRAINTS;

CREATE TABLE Branch
(BID NUMBER(3) PRIMARY KEY,
Address VARCHAR2(50) NOT NULL);

CREATE TABLE Volunteer 
(EMAIL VARCHAR2(40) PRIMARY KEY,
FNAME VARCHAR2(10) NOT NULL, 
LNAME VARCHAR2(10) NOT NULL,  
BIRTHDATE DATE NOT NULL,
MOBILENUMBER VARCHAR2(13) NOT NULL, 
ADDRESS VARCHAR2(50));

CREATE TABLE Donor 
(EMAIL VARCHAR2(40) PRIMARY KEY,
FNAME VARCHAR2(10) NOT NULL, 
LNAME VARCHAR2(10) NOT NULL,  
MOBILENUMBER VARCHAR2(13) NOT NULL, 
ADDRESS VARCHAR2(50));

CREATE TABLE Campaign
(CampName VARCHAR2(30),
CampDate DATE,
CampLocation VARCHAR2(50) NOT NULL,
NumOfReqVolunteer NUMBER(7) NOT NULL,
CONSTRAINTS pkCampaign PRIMARY KEY(CampName, CampDate));
                               
CREATE TABLE Employee
(SSN NUMBER(15) PRIMARY KEY, 
FNAME VARCHAR2(10) NOT NULL, 
LNAME VARCHAR2(10) NOT NULL, 
EMAIL VARCHAR2(40), 
MOBILENUMBER VARCHAR2(13) NOT NULL, 
ADDRESS VARCHAR2(50),
BID NUMBER(3) REFERENCES Branch(BID));

CREATE TABLE Activity
(ActName VARCHAR2(30) NOT NULL,
CampName VARCHAR2(30),
CampDate DATE,
CONSTRAINTS pkActivity PRIMARY KEY(ActName, CampName, CampDate),
CONSTRAINTS fkActivity FOREIGN KEY(CampName, CampDate) REFERENCES Campaign(CampName, CampDate));

CREATE TABLE WorksOn
(VolunteerEmail VARCHAR2(40) REFERENCES Volunteer(Email),
CampName VARCHAR2(30),
CampDate DATE,
CONSTRAINTS pkWorksOn PRIMARY KEY(VolunteerEmail, CampName, CampDate),
CONSTRAINTS fkWorksOn FOREIGN KEY(CampName, CampDate) REFERENCES Campaign(CampName, CampDate));

CREATE TABLE Manages
(BID NUMBER(3) REFERENCES Branch(BID),
CampName VARCHAR2(30),
CampDate DATE,
CONSTRAINTS pkManages PRIMARY KEY(BID, CampName, CampDate),
CONSTRAINTS fkManages FOREIGN KEY(CampName, CampDate) REFERENCES Campaign(CampName, CampDate));

CREATE TABLE DonatesFor
(DonorEmail VARCHAR2(40) REFERENCES Donor(Email),
CampName VARCHAR2(30),
CampDate DATE,
ReceiptNumber NUMBER(10) NOT NULL,
DonationDate Date NOT NULL,
DonationType VARCHAR2(20) NOT NULL,
Amount NUMBER(10) NOT NULL,
CONSTRAINTS pkDonatesFor PRIMARY KEY(DonorEmail, CampName, CampDate),
CONSTRAINTS fkDonatesFor FOREIGN KEY(CampName, CampDate) REFERENCES Campaign(CampName, CampDate));
   
CREATE TABLE BranchPhones
(BID NUMBER(3) REFERENCES Branch(BID),
MOBILENUMBER VARCHAR2(13) NOT NULL, 
CONSTRAINTS pkBranchPhones PRIMARY KEY (BID, MOBILENUMBER));



INSERT INTO Branch VALUES (1, '4 Zaki Rostom St. - Nasr City - Cairo');
INSERT INTO Branch VALUES (2, '11 Ahmed Abd ElKhaleq St. - Masr El Gedida - Cairo');
INSERT INTO Branch VALUES (3, '16a Youssef Zaki St. - Helwan - Cairo');
INSERT INTO Branch VALUES (4, '44 Tout Angh Amoun St. - Semoha - Alexandria');
INSERT INTO BranchPhones VALUES (1, '19450');
INSERT INTO BranchPhones VALUES (2, '19450');
INSERT INTO BranchPhones VALUES (3, '19450');
INSERT INTO BranchPhones VALUES (4, '+2034193501');
INSERT INTO BranchPhones VALUES (4, '+2034193500');
INSERT INTO BranchPhones VALUES (4, '+2034193599');
INSERT INTO Volunteer VALUES ('polamikhail@gmail.com', 'Pola', 'Mikhail', '1-jan-1999', '0122212554', NULL);
INSERT INTO Volunteer VALUES ('tonynasr@gmail.com', 'Tony', 'Nasr', '22-jan-1998', '0122445665', NULL);
INSERT INTO Volunteer VALUES ('safwanmohamed@gmail.com', 'Safwan', 'Mohamed', '4-jan-1990', '0124488997', NULL);
INSERT INTO Volunteer VALUES ('ahmedkamel@gmail.com', 'Ahmed', 'Kamel', '10-jan-2000', '0111155897', NULL);
INSERT INTO Volunteer VALUES ('asmaahassan@hotmail.com', 'Asmaa', 'Hassan', '9-jan-1997', '0115548978', NULL);
INSERT INTO Volunteer VALUES ('nourahmed@gmail.com', 'Nour', 'Ahmed', '2-jan-1995', '0102224568', NULL);
INSERT INTO Volunteer VALUES ('yaraali@hotmail.com', 'Yara', 'Ali', '15-jan-2000', '0157777552', NULL);
INSERT INTO Donor VALUES ('polamikhail@gmail.com', 'Pola', 'Mikhail', '0122212554', NULL);
INSERT INTO Donor VALUES ('tonynasr@gmail.com', 'Tony', 'Nasr', '0122445665', NULL);
INSERT INTO Donor VALUES ('youmnamohamed@hotmail.com', 'Youmna', 'Mohamed', '0155498778', NULL);
INSERT INTO Employee VALUES (1111111111, 'Aya', 'Ahmed', 'ayaahmed@hotmail.com', '01154489884', NULL, 1);
INSERT INTO Employee VALUES (2222222222, 'Mai', 'Sherif', 'maisherif@gmail.com', '01055411123', NULL, 2);
INSERT INTO Employee VALUES (3333333333, 'Mina', 'Reda', 'minareda@gmail.com', '01223448978', NULL, 3);
INSERT INTO Employee VALUES (4444444444, 'Mahmoud', 'Mohsen', 'mahomudmohsen@hotmail.com', '0102224565', NULL, 4);
INSERT INTO Campaign VALUES ('We hope for them', '5-Apr-2019', 'Queen Land Village', 100);
INSERT INTO Campaign VALUES ('Al-Duha convoy', '29-Mar-2019', 'El Fayoum', 200);
INSERT INTO Campaign VALUES ('The beginning of life', '1-Apr-2019', 'El Abassia - Cairo', 50);
INSERT INTO Activity VALUES ('Orphan sponsorship', 'We hope for them', '5-Apr-2019');
INSERT INTO Activity VALUES ('Feeding the poor', 'Al-Duha convoy', '29-Mar-2019');
INSERT INTO Activity VALUES ('Internal convoys', 'Al-Duha convoy', '29-Mar-2019');
INSERT INTO Activity VALUES ('Blood Donation', 'The beginning of life', '1-Apr-2019');
INSERT INTO WorksOn VALUES ('tonynasr@gmail.com', 'We hope for them', '5-Apr-2019');
INSERT INTO WorksOn VALUES ('yaraali@hotmail.com', 'We hope for them', '5-Apr-2019');
INSERT INTO WorksOn VALUES ('asmaahassan@hotmail.com', 'The beginning of life', '1-Apr-2019');
INSERT INTO Manages VALUES (1, 'We hope for them', '5-Apr-2019');
INSERT INTO Manages VALUES (2, 'The beginning of life', '1-Apr-2019');
INSERT INTO Manages VALUES (2, 'Al-Duha convoy', '29-Mar-2019');
INSERT INTO DonatesFor VALUES ('polamikhail@gmail.com', 'We hope for them', '5-Apr-2019', 1234567890, '10-Mar-2019', 'Money', 3000);
INSERT INTO DonatesFor VALUES ('youmnamohamed@hotmail.com', 'We hope for them', '5-Apr-2019', 9876543210, '15-Mar-2019', 'Clothes', 5);
INSERT INTO DonatesFor VALUES ('tonynasr@gmail.com', 'Al-Duha convoy', '29-Mar-2019', 4567891230, '20-Feb-2019', 'Money', 5000);

COMMIT;