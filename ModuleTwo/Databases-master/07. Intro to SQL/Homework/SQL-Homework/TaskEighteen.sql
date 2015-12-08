SELECT e.FirstName, e.LastName, a.AddressText AS Address FROM Employees e
INNER JOIN Addresses a 
ON e.AddressID = a.AddressID;