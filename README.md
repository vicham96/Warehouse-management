# Warehouse-management
Prerequisite:
1. Entity core framework
2. SQL Server Management
3. Visual Studio


## Set up database

1. Run a local, dockerized version of a sql server by typing the following command:
`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=MyPass@word" -e "MSSQL_PID=Express" -p 1433:1433 -d --name=sql mcr.microsoft.com/mssql/server:latest`
2. After the dockerized container has run, clone and open the project
3. Delete the migration files in the solution and run `Add-Migrations <name_of_migration>` followed with `Update-Database` in the Package Manager Console from Visual Studio. Alternatively, run the dotnet command in the terminal inside the project
4. Now, you have to seed the database in order to see any data upon start. This can be done using SQL Server Management. Connect to the string "localhost, 1433" and use the following credentials: 
`username = sa`
`password = MyPass@word`
5. Now run the application from Visual Studio
6. It is possible to test the APIs from the browser now
