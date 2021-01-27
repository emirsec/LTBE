#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Lockthreat.Migrator/Lockthreat.Migrator.csproj", "src/Lockthreat.Migrator/"]
COPY ["src/Lockthreat.EntityFrameworkCore/Lockthreat.EntityFrameworkCore.csproj", "src/Lockthreat.EntityFrameworkCore/"]
COPY ["src/Lockthreat.Core/Lockthreat.Core.csproj", "src/Lockthreat.Core/"]
COPY ["src/Lockthreat.Core.Shared/Lockthreat.Core.Shared.csproj", "src/Lockthreat.Core.Shared/"]
RUN dotnet restore "src/Lockthreat.Migrator/Lockthreat.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Lockthreat.Migrator"
RUN dotnet build "Lockthreat.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lockthreat.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lockthreat.Migrator.dll"]
