# Use the official .NET image as a base image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["MyApp/MyApp.csproj", "MyApp/"]
COPY ["MyApp.Tests/MyApp.Tests.csproj", "MyApp.Tests/"]
RUN dotnet restore "MyApp/MyApp.csproj"
COPY . .
WORKDIR "/src/MyApp"
RUN dotnet build --no-restore -c Release -o /app/build

# Publish the app
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish --no-restore

# Create the final image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyApp.dll"]