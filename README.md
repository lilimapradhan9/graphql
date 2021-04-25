# graphql

To run the application:

* Install the EntityFramework global tool dotnet-ef using the following command:
  * dotnet new tool-manifest 
  * dotnet tool install dotnet-ef --version 5.0.5 --local
* Open a command prompt and navigate to the project directory. (The directory containing the Startup.cs file).

* Run the following commands in the command prompt:
  * dotnet build GraphQL
  * dotnet ef migrations add Initial --project GraphQL
  * dotnet ef database update --project GraphQL

* dotnet run --project GraphQL