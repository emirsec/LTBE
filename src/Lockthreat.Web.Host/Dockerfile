#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Lockthreat.Web.Host/Lockthreat.Web.Host.csproj", "src/Lockthreat.Web.Host/"]
COPY ["src/Lockthreat.Web.Core/Lockthreat.Web.Core.csproj", "src/Lockthreat.Web.Core/"]
COPY ["src/Lockthreat.Application/Lockthreat.Application.csproj", "src/Lockthreat.Application/"]
COPY ["src/Lockthreat.Application.Shared/Lockthreat.Application.Shared.csproj", "src/Lockthreat.Application.Shared/"]
COPY ["src/Lockthreat.Core.Shared/Lockthreat.Core.Shared.csproj", "src/Lockthreat.Core.Shared/"]
COPY ["src/Lockthreat.Core/Lockthreat.Core.csproj", "src/Lockthreat.Core/"]
COPY ["src/Lockthreat.EntityFrameworkCore/Lockthreat.EntityFrameworkCore.csproj", "src/Lockthreat.EntityFrameworkCore/"]
COPY ["src/Lockthreat.GraphQL/Lockthreat.GraphQL.csproj", "src/Lockthreat.GraphQL/"]
RUN dotnet restore "src/Lockthreat.Web.Host/Lockthreat.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/Lockthreat.Web.Host"
RUN dotnet build "Lockthreat.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lockthreat.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lockthreat.Web.Host.dll"]
