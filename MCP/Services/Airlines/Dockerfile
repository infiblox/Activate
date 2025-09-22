# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy only the necessary project files first for efficient caching
COPY ["AirlinesAPI/AirlinesAPI.csproj", "AirlinesAPI/"]
RUN dotnet restore "AirlinesAPI/AirlinesAPI.csproj"

# Copy the rest of the files after restore to build
COPY . .

# Set the WORKDIR to the project folder
WORKDIR "/src/AirlinesAPI"
RUN dotnet build "AirlinesAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "AirlinesAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app

# Copy the published app from the previous stage to the final image
COPY --from=publish /app/publish .

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "AirlinesAPI.dll"]
