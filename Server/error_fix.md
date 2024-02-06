1. 
```error
A connection was successfully established with the server, but then an error occurred during the login process. (provider: SSL Provider, error: 0 - The certificate chain was issued by an authority that is not trusted.) 
```
- in ssms: Option > Connect Properties -> Trust server certificate
![img1](/imgs/log_sql1.png "login")
![img2](/imgs/log_sql2.png "login")

- in connection string add: ```"TrustServerCertificate=True;"```

2. 
```error
System.Globalization.CultureNotFoundException: Only the invariant culture is supported in globalization-invariant mode.
```

- in file ```Server.csproj``` (set "InvariantGlobalization" to false): 

```sh
    <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
        <Nullable>enable</Nullable>
        <ImplicitUsings>enable</ImplicitUsings>
        <InvariantGlobalization>false</InvariantGlobalization>
    </PropertyGroup>
```