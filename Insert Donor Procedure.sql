CREATE OR REPLACE PROCEDURE Insert_Donor(D_Email VARCHAR2, D_FName VARCHAR2,D_LName VARCHAR2,
    D_MobileNum VARCHAR2, D_Address VARCHAR2)
AS
BEGIN
INSERT INTO donor
VALUES ( D_email, D_fname, D_lname, D_mobilenum, D_address);
End;
