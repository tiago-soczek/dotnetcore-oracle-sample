# Sample .NET Core with Oracle

## How was this example created?

```powershell
dotnet new console -n OracleCore -o OracleCore

cd .\OracleCore\

dotnet add package Oracle.ManagedDataAccess.Core --version 2.12.0-beta2

# Edit with VSCode
code .
```

### Connection String
``
Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=system;Password=oracle;
``

## How to run an Oracle XE instance with Docker

```
docker run -d -p 8080:8080 -p 1521:1521 sath89/oracle-xe-11g
```