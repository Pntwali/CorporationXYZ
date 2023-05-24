## Installation and Setup

### Requirements
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Git](https://git-scm.com/) (Version Control System)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Make sure it's installed and running)
- [Redis](https://redis.io/download) (Make sure it's installed and running)

### Clone the Repository
```shell
https://github.com/Pntwali/CorporationXYZ.git
```

### Navigate to the Project Directory

```shell

cd src/CorporationXYZ.Api
```
### Set up Connection Strings

Open the `appsettings.json` file.
Replace the `xxx` value for database in the ConnectionStrings section of `"sqlConnection": "server=.; database=xxx; Integrated Security=true"` with your desired database name eg: NOTIFICATIONS.
Save the file.

### Set Environment Variable
Open a command prompt or terminal.
Set the SECRET environment variable with a secure secret key:

``` export SECRET=uy8B&5m6@3c^!2p9C$1j*0q#7k176FC253B9A943C7B65008CF5CBFCB53 ```

### Install Dependencies

```dotnet restore```

### Build the Project

```dotnet build```

### Run Migrations

```dotnet ef database update```

### Configure Hangfire

Open the `appsettings.json` file.
Replace the `xxx` value for database in the ConnectionStrings section of `HangFiresqlConnection": "server=.; database=xxx; Integrated Security=true` with your desired database name eg: JOBMONITOR_DB.
Save the file.

### Run the Applicatio

```dotnet run``

### To verify the correctness of the endpoints, you can execute the following command in PowerShell or your preferred shell:

 ```curl --location 'https://localhost:5001/api/authentication' \```
```--header 'Content-Type: application/json' \```
```--data-raw '{```
  ```"firstname": "Jane",```
  ```"lastname": "Doe",```
  ```"username": "JaneDoe4",```
  ```"password": "Password2000",```
  ```"email": "janedoe4@mail.com",```
  ```"phonenumber": "583-653",```
  ```"roles": [```
    ```"Administrator"```
  ```]```
```}' ```

### finally run the project automated 

``` cd CorporationXYZ/tests/CorporationXYZ.IntTests```
``` dotnet test CorporationXYZ.IntTests.csproj ```

This command will run the tests specified in the `CorporationXYZ.IntTests.csproj` project file and provide the test results in the console.

