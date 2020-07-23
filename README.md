# WebApi
.NET WebApi Demo demonstrating a simple .NET Core API to take data from a CSV, validate it and insert it into a SQL Database.

## /Data/
This is the Data Access Layer, using a .NET Core Library with Entity Framework. The database I used for testing is hosted in Azure.

## /SQL/
This contains the SQL scripts used to create the 2 tables and insert the test data.

## /WebApi/
This is the API itself, using .NET Core with the one endpoint `/api/meter-reading`
