CREATE OR REPLACE PROCEDURE GetBranchID
(branch_id VARCHAR2,  emp_id OUT sys_refcursor)
AS
BEGIN
OPEN  emp_id   FOR
SELECT  E.SSN
FROM  Employee E ,Branch B
WHERE E.BID = B.BID AND branch_id = B.BID;
END;