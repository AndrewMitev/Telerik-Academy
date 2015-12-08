SELECT e.FirstName + ' ' + e.LastName AS Employee,
e.ManagerID,
m.Firstname + ' ' + m.LastName AS Manager
FROM Employees e
LEFT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID;

/*
SELECT e.FirstName + ' ' + e.LastName AS Employee,
e.ManagerID,
m.Firstname + ' ' + m.LastName AS Manager
FROM Employees e
RIGHT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID;
*/