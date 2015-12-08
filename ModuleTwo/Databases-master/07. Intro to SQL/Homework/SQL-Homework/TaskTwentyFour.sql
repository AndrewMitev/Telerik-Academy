SELECT e.FirstName + ' ' + e.LastName AS [Employee Name],
d.Name, e.HireDate FROM Employees e
INNER JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE (d.Name = 'Sales' OR d.Name = 'Finance')
AND (e.HireDate > 1995 OR e.HireDate < 2005);