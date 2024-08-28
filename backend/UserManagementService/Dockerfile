# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Ensure the path matches your actual directory structure
COPY ["UserManagementService.csproj", "."]
RUN dotnet restore "UserManagementService.csproj"

# Copy the entire project and build it
COPY . .
WORKDIR "/src"
RUN dotnet build "UserManagementService.csproj" -c Release -o /app/build

# Publish the app to a folder
FROM build AS publish
RUN dotnet publish "UserManagementService.csproj" -c Release -o /app/publish

# Use the official ASP.NET Core runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UserManagementService.dll"]
