# sqlclient-akv-example
Working examples with Microsoft.Data.SqlClient and Azure Key Vault Provider.
This example demonstrates usage of Managed Identity with Microsoft.Data.SqlClient's [Azure Key Vault provider v1.2.0](https://www.nuget.org/packages/Microsoft.Data.SqlClient.AlwaysEncrypted.AzureKeyVaultProvider)

## Frameworks tested and supported in this example:
- .NET 5.0 (`net5.0`)
- .NET Core 3.1 (`netcoreapp3.1`)
- .NET Framework 4.8 (`net48`)

## Steps:
- Provide AKV URL along with Connection String in `Constants.cs` file.
- Run `dotnet run -f %s` to run the test application on desired target framework
