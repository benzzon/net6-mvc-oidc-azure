# net6-mvc-oidc-azure
.Net6 MVC application for testing OIDC with Azure.

Steps for using/testing:

Make sure you have a free Windows Live or Azure-account. Login to https://portal.azure.com/

1. Navigate to "Microsoft Entra ID" and click "App registrations".

2. Start registration of a new app, i chose the option "Accounts in any organizational directory (Any Microsoft Entra ID tenant - Multitenant)" Set the value for "Redirect URIs" to "https://localhost:7024/signin-oidc" Tick the checkbox "ID tokens (used for implicit and hybrid flows)".

3. Navigate to "Certificates & secrets" and create a new "client secret". Set a description that you remember, this value should be set in "appsettings.json" for the solution (the key-name in appsettings.json is "ClientSecret").

4. Find the values for "Tenant" and "ClientId" and enter these values into "appsettings.json". (Tenant ID and ClientID is found in the settings for the app that was created.)


Run the solution and try the "login-link", followed by the link to show "Claims"

NOTE: If error "Could not find a part of the path .. roslyn\csc.exe" is appearing when started from Visual Studio, try to do a clean project from Visual Studio, close VS and try again.
