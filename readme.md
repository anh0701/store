## setup .net for linux
- [mint linux/ubuntu](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu-install?tabs=dotnet9&pivots=os-linux-ubuntu-2404)
- [debian](https://learn.microsoft.com/en-us/dotnet/core/install/linux-debian?tabs=dotnet9)
- [fedora](https://learn.microsoft.com/en-us/dotnet/core/install/linux-fedora?tabs=dotnet9)

## hot reload 
```sh
    dotnet watch run
```

## migrations
```sh
    dotnet ef migrations add " "
    dotnet ef migrations remove
    dotnet ef database update
```

## install package
```sh
    dotnet add package Microsoft.EntityFrameworkCore --version 8.0.1
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.1
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.1
```