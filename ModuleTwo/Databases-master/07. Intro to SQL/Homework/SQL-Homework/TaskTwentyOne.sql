SELECT e.FirstName + ' ' + e.LastName AS Employee,
 e.ManagerID, m.Firstname + ' ' + m.LastName AS Manager,
 a.Addresstext AS [Address Of Employee]
FROM Employees e
INNER JOIN Employees m
ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses a
ON e.AddressID = a.AddressID;