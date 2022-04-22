# PMBI 
## (Product Management Business Intelligence)
PMBI is a MVC .NetCore 5  Web Application, which build in linux and it is cross platform.

## Software Requirement
- MSSQL Server Express Edition or any Edition
- .Netcore 5 Framework

## Development Requirement
- Visual Studio Code or Visual Studio IDE
- Dotnet CLI or Nugest Package Manager

## Development
Download the Source Code from Github . Public Repository 



Open your favorite Terminal and run these commands.

First Step:

```sh
git clone https://github.com/SamimAzimi/PMBI.git
```

Second setp: change directory to PMBI  and RUN

```sh
### Dotnet CLI 
dotnet restore
### Nuget Package Manager 
nuget restore
```
Third Step : (Database) Connection String & Migration:
open appsetting.json and modifiy connection string accordingly
```sh
Server=.;Database=PMBI;User ID=sa;Password=your_SA_password;
```
Fourth Step : (Database) Migration:

```sh
### Dotnet CLI
dotnet ef migrations add initalCreate
```
OR 
```sh
### Open Package Manager from Visual Studio and RUN
Add-Migration initalCreate
```

Add Admin User to Mysql , Open Mysql and insert admin user to users tables

```sql 
use PMBI 
insert into users values ("admin","password")
```

#### Development 
Open Visual studio and import Project and RUN 
#### Deployment to ISS 7


    On the IIS server, create a folder to contain the app's published folders and files. In a following step, the folder's path is provided to IIS as the physical path to the app. For more information on an app's deployment folder and file layout, see ASP.NET Core directory structure.

    In IIS Manager, open the server's node in the Connections panel. Right-click the Sites folder. Select Add Website from the contextual menu.

    Provide a Site name and set the Physical path to the app's deployment folder that you created. Provide the Binding configuration and create the website by selecting OK.

    Warning

    Top-level wildcard bindings (http://*:80/ and http://+:80) should not be used. Top-level wildcard bindings can open up your app to security vulnerabilities. This applies to both strong and weak wildcards. Use explicit host names rather than wildcards. Subdomain wildcard binding (for example, *.mysub.com) doesn't have this security risk if you control the entire parent domain (as opposed to *.com, which is vulnerable). See rfc7230 section-5.4 for more information.

    Confirm the process model identity has the proper permissions.

    If the default identity of the app pool (Process Model > Identity) is changed from ApplicationPoolIdentity to another identity, verify that the new identity has the required permissions to access the app's folder, database, and other required resources. For example, the app pool requires read and write access to folders where the app reads and writes files.

## License
MIT 

