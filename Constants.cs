public static class Constants
{
    public static readonly string s_algorithm = "RSA_OAEP";

    // ********* Provide details here ***********
    public static readonly string s_akvUrl = "https://{KeyVaultName}.vault.azure.net/keys/{Key}/{KeyIdentifier}";

    /** ********* Provide connection string here, examples: ***********
     * Server=localhost; Database={database}; Integrated Security=true; Column Encryption Setting=Enabled;
     * Server={azureserver}.database.windows.net; Database={database}; Authentication= Active Directory MSI; Column Encryption Setting=Enabled;
     * Server={azureserver}.database.windows.net; Database={database}; Authentication= Active Directory Interactive; Column Encryption Setting=Enabled;"
     *
     * When using MSI Authentication, ensure Managed Identity has been granted permissions to access database and create/delete resources,
     * e.g. running below scripts will fast-track process:
     * 
     * CREATE USER [<IdentityName>] FROM EXTERNAL PROVIDER
     * exec sp_addrolemember 'db_owner', '<IdentityName>';
     */
    public static readonly string s_connectionString = "Server={azureserver}.database.windows.net; Database={database}; Authentication = Active Directory MSI; Column Encryption Setting=Enabled;";
    // ******************************************

}
