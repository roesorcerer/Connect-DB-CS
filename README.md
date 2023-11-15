# Module4B Readme

## Introduction

This readme file provides an overview of the code contained in the Module4B project. The code is a C# console application that connects to a SQL Server database and performs a read operation on a table called `[SalesLT].[Customer]`.

## Prerequisites

Before running this code, you need to ensure that you have the following prerequisites in place:

1. **SQL Server Connection Details**: You need to update the following connection details in the code to match your SQL Server configuration:
   - `builder.DataSource`: The server name or IP address of your SQL Server.
   - `builder.UserID`: Your SQL Server login username.
   - `builder.Password`: Your SQL Server login password.
   - `builder.InitialCatalog`: The initial database/catalog you want to connect to.

## Code Overview

### Main Method

The `Main` method is the entry point of the program. Here's an overview of what the code does:

1. It establishes a connection to the SQL Server using the provided connection details.

2. It performs a read operation on the `[SalesLT].[Customer]` table using a SELECT statement.

3. It retrieves and prints data from the SQL query to the console.

4. It handles any potential SQL exceptions that may occur during the execution.

### SQL Queries

The code contains two SQL query strings:
- `sql`: This query is set to "USE [SalesLT].[Customer];" but is later overwritten with a SELECT statement.
- `sql2`: This query is also set to "USE [SalesLT].[Customer];" but is later overwritten with a different SELECT statement.

The code executes `sql2`, which selects the top 5 records from the `[SalesLT].[Customer]` table and prints their first and last names to the console.

## Running the Code

To run the code, follow these steps:

1. Make sure you have updated the SQL Server connection details in the code as mentioned in the "Prerequisites" section.

2. Build and run the application.

3. The program will connect to the SQL Server, execute the SQL query, and display the results in the console.

4. After completion, you will be prompted to press any key to finish.

## Error Handling

The code includes error handling for SQL exceptions. Any SQL exceptions that occur during execution will be caught, and the error details will be displayed in the console.

## Conclusion

This code demonstrates how to connect to a SQL Server database and perform a read operation on a specific table. It is a simple example and can serve as a starting point for more complex database operations in C# applications.
