# SQL Server Sample Code ReadMe

## Overview

This repository contains a simple C# program that demonstrates how to connect to a SQL Server database and perform a read operation using the SQL Server .NET Data Provider. The code establishes a connection to a SQL Server database hosted on Microsoft Azure and retrieves data from a specific table.

## Prerequisites

Before running the code in this repository, ensure that you have the following prerequisites in place:

1. **Visual Studio or Visual Studio Code:** You will need an integrated development environment (IDE) to compile and run the C# code. You can download Visual Studio from the [official website](https://visualstudio.microsoft.com/).

2. **Microsoft Azure SQL Database:** You should have access to a SQL Server database hosted on Microsoft Azure or any other SQL Server instance that you want to connect to.

3. **Azure SQL Database Credentials:** You should have the necessary credentials to connect to the database, including the server name, username, and password.

## Getting Started

Follow these steps to get started with the code:

1. Clone or download this repository to your local machine.

2. Open the project in your preferred IDE (Visual Studio or Visual Studio Code).

3. Open the `Program.cs` file in the project.

4. Locate the `builder` object and update the following properties with your Azure SQL Database information:

   - `builder.DataSource`: Set this to the server name or IP address of your SQL Server.
   - `builder.UserID`: Set this to your SQL Server username.
   - `builder.Password`: Set this to your SQL Server password.
   - `builder.InitialCatalog`: Set this to the name of your database.

5. Save your changes.

6. Build and run the program. You can do this by pressing F5 (Visual Studio) or using the appropriate command in Visual Studio Code.

7. The program will connect to the SQL Server, execute a SELECT statement against the "Customer" table in the "SalesLT" schema, and print "Hello World!" to the console.

## Customizing the Query

If you want to retrieve different data from the database, you can customize the SQL query in the code. Modify the `sql` variable to contain your desired SQL SELECT statement.

## Troubleshooting

If you encounter any issues while running the code or connecting to the database, you can refer to the error messages displayed in the console for troubleshooting. Common issues may include incorrect connection strings, firewall rules, or database access permissions.

## Conclusion

This repository provides a simple example of connecting to a SQL Server database using C# and the SQL Server .NET Data Provider. You can use this code as a starting point for more complex database interactions in your own projects.

If you have any questions or encounter any difficulties, please feel free to reach out for assistance.

Thank you for using this SQL Server sample code!
