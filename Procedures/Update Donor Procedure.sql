CREATE OR REPLACE PROCEDURE Update_Donor
  (D_Email VARCHAR2, D_FName VARCHAR2,D_LName VARCHAR2,
   D_MobileNum VARCHAR2, D_Address VARCHAR2)
AS
BEGIN
	UPDATE donor 
	SET fname = D_Fname, lname = D_Lname, mobilenumber = D_Mobilenum,
    address = D_Address
	WHERE email = D_Email;
END;