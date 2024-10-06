FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY /src/api/TrustedBroker.sln .
COPY /src/api/TrustedBroker.ExternalCloud.Api/*.csproj ./TrustedBroker.ExternalCloud.Api/
RUN dotnet restore

COPY . .
RUN dotnet publish /src/api/TrustedBroker.sln -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app
COPY --from=build /app .

ENTRYPOINT ["dotnet", "TrustedBroker.ExternalCloud.Api.dll"]