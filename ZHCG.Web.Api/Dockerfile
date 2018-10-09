FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 63298
EXPOSE 44370

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY QuickstartIdentityServer.Api/QuickstartIdentityServer.Api.csproj QuickstartIdentityServer.Api/
RUN dotnet restore QuickstartIdentityServer.Api/QuickstartIdentityServer.Api.csproj
COPY . .
WORKDIR /src/QuickstartIdentityServer.Api
RUN dotnet build QuickstartIdentityServer.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish QuickstartIdentityServer.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "QuickstartIdentityServer.Api.dll"]
