public static class Constants
{
    public static readonly string s_algorithm = "RSA_OAEP";

    // ********* Provide details here ***********
    public static readonly string s_akvUrl = "https://{KeyVaultName}.vault.azure.net/keys/{Key}/{KeyIdentifier}";
    public static readonly string s_clientId = "{Application_Client_ID}";
    public static readonly string s_clientSecret = "{Application_Client_Secret}";

    /** ********* Provide connection string here, examples: ***********
     * Server=localhost; Integrated Security=true; Column Encryption Setting=Enabled;
     * Server={azureserver}.database.windows.net; Authentication= Active Directory MSI; Column Encryption Setting=Enabled;
     * Server={azureserver}.database.windows.net; Authentication= Active Directory Interactive; Column Encryption Setting=Enabled;"
     **/
    public static readonly string s_connectionString = "Server=localhost; Integrated Security=true; Column Encryption Setting=Enabled;";
    // ******************************************

}
