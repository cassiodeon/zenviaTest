FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
MAINTAINER Cassio Deon
COPY ZenviaTest/ConsoleApp/bin/Release/netcoreapp3.1/publish app/

ENTRYPOINT ["dotnet", "app/ConsoleApp.dll"]