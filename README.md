# WebApi
.NET WebApi Demo demonstrating a simple .NET Core API to take data from a CSV, validate it and insert it into a SQL Database.

## /Data/
This is the Data Access Layer, using a .NET Core Library with Entity Framework. The database I used for testing is hosted in Azure.

## /SQL/
This contains the SQL scripts used to create the 2 tables and insert the test data.

## /WebApi/
This is the API itself, using .NET Core with the one **endpoint** `/api/meter-reading`

## Consuming the API
The API could be consumed in multiple ways:

* **[Postman](https://www.postman.com/)** to call the endpoint passing the CSV file contents in the raw body - _this method was used for testing_
* **React/Angular app** to take the CSV file and pass the contents of it to the endpoint using HTTP POST
* **Console Application** to read the CSV file from disc and HTTP POST the data to the endpoint
* **.NET Framework Web Forms** page to provide a fileupload control, which then reads the CSV and HTTP POST the data to the endpoint
* **.NET Framework/Core MVC** page to provide file upload and then HTTP POST to the endpoint
* **[.NET Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)** app
