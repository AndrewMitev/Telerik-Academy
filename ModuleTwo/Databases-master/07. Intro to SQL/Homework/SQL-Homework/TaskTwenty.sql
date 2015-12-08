SELECT e.FirstName + ' ' + e.LastName 
AS Employee, e.ManagerID, m.Firstname + ' ' + m.LastName 
AS Manager 
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID;
