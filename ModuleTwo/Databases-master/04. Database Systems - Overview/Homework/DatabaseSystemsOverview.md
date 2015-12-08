# Database Systems - Overview Homework

----
## 1. What database models do you know?

**Hierarchical model**: there is a tree structure of the files like the file system. The root node has no parent.

** Network/graph model**: each entity is connected diffrenetly with other entities in a more complex way.

**Relational model**: each row in a table has specific rules of representation of data and is connected to the same row in another table in the database.

**Object-oriented model**: Each table represents an object which can be modified using object-oriented programming language.



----
## 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?

The main functions of RDBMS is to create, delete, alter tables and create relations between them. Also it can collect data, change it, delete it and so on. 

---- 


----
## 3. Define what is "table" in database terms.

Rows of data and columns which define the data in the rows below the column. All rows in relational databases have the same structure. Columns have name and type so that we can access them properly.

----

----
## 4. Explain the difference between a primary and a foreign key

Primary key is a column or group of columns that is unqie for the column and is used to intercat with exact row of one table, whereas foreign key is used to address primary key of another row in another table to show that these two rows of different tables are connected logically. In that way duplication of data is avoided. The database is normalized.

----

----
## 5. Explain the different kinds of relationships between tables in relational databases.

*one-to-many*: one entity is connect to many other entities. For example: president-people, all people in one country have exactly one president and the president is president of all the people in his country. This is the most common relationship between tables.

*many-to-many*: entities are intraconnected. For example many students can be assigned in one course, on the opposite: many course can be assigned to one student.

*one-to-one*: one entity is connected exactly to another one entity. 

----

----
## 6. When is a certain database schema normalized?
 * What are the advantages of normalized databases?

The database schema is normalized when every table has primary key, tables are connected through foreign keys.
The main advantages are that duplicated data is avoided and strings are replaced by numbers which takes less space. Memmory is saved. Data is easily corrected.

----

----
## 7. What are database integrity constraints and when are they used?

These are sets of rules that are enforced by the relational database. If those rules are violated the user is not permitted to do any operation on the database. Such constraints are:

* Primary key: the database ensures that this field has unique value, user cannot enter duplicated values.

* Unique key: constraint that ensures that values in the column are unique, but it is not supposed to be used as key.

* Foreign Key Constraint: Ensures that we link keys that exist in some other table.

* Check Contsraint: Ensures that entered value in a cell follow the rules of custom constraints

----

----
## 8. Point out the pros and cons of using indexes in a database.

Pros: We can search and extract data through indexes very fast. The search is implement with B-Tree. 
Cons: Adding and Removing new elements is relative slow so the indexes should be used when using really large tables.

----

----
## 9. What's the main purpose of the SQL language?

It is a language for manipulation of relational databases. It can manipulate the definition of the data or the data itself (DDL and DML)

----

----
## 10. What are transactions used for? Give an example.

Transactions are used when user performs queries on the database. The data is locked and cannot be accessed by other queries that are outside of the transaction.

An example is shared bank account. if one user performs operations on the money in the account it is called transaction and other users of the account cannot access it untill the transaction is over so to ensure all data is properly handled.

----

----

## 11. What is a NoSQL database?
Database that has no constraints. Has no structure. Data is inconsistent. There are no primary or foreign keys. Uses document-base models. Has great performance and scalability.

----

----
## 12. Explain the classical non-relational data models

Document - model: Set of documents: e.g. json strings

Key-value model: sets of data in the form key-value.

Hierarchical key-value: hierarchy of key-value pairs.

OOP-model: set of OOP-style objects.

----

----
## 13. Give few examples of NoSQL databases and their pros and cons.

MongoDB - easy to use with JavaScript, because data can be saved as Javascript Objects. Fast search.
There are no constraints at all. Error prone.

Redis - Provides extremely fast operations because it uses RAM. Also has no constraints and is error prone.

----