FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 63333
EXPOSE 44367

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY QuickstartIdentityServer/QuickstartIdentityServer.csproj QuickstartIdentityServer/
RUN dotnet restore QuickstartIdentityServer/QuickstartIdentityServer.csproj
COPY . .
WORKDIR /src/QuickstartIdentityServer
RUN dotnet build QuickstartIdentityServer.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish QuickstartIdentityServer.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "QuickstartIdentityServer.dll"]
