# PickTrace Sync

PickTrace is an ASP.NET 6 application that imports PickTrace payroll data into the Prima Wawona data warehouse.

This application is currently in development.

## Get Started

1. Restore nuget packages. 
1. Add required app secrets using `dotnet user-secrets set "<Key>" "<Value>" --project PickTraceSync`

## Deployment

The application is intended to be deployed as a command line application with a configuration file ("appsettings.json") that contains 
the application secrets.  The structure of the file is:

```json
{
	"PickTrace": {
		"Username": "...",
		"Password": "...",
		"OrgId": "..."
	},
	"ConnectionStrings": {
		"DWConnection" : "..."
	}
}
```
### Build Instructions
### Migrations
Database migration scripts can be generated using Entity Framework migrations from a developer console: `dotnet ef migrations script <FromMigrationName> --project PickTraceSync.Data --startup-project PickTraceSync --idempotent --output <FilePath>`

### Configuration
### Execution

## Secrets
| Key | Description |
|-----|-------------|
| PickTrace:Username | The username of the account with access to PickTrace. |
| PickTrace:Password | The password associated with username. |
| PickTrace:OrgId | The organizational ID provided by PickTrace. |
| ConnectionStrings:DWConnection | The connection string the application will use to connect the Data Warehouse database (e.g., "Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = PRIMADW") |