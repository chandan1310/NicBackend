# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["NicBackend.csproj", "./"]
RUN dotnet restore "./NicBackend.csproj"

COPY . .
RUN dotnet publish "NicBackend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "NicBackend.dll"]
