#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
#EXPOSE 80
#EXPOSE 443
EXPOSE 8090
ENV ASPNETCORE_URLS=http://*:8090

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OpenshiftDotNetSqlServerMvc/OpenshiftDotNetSqlServerMvc.csproj", "OpenshiftDotNetSqlServerMvc/"]
RUN dotnet restore "OpenshiftDotNetSqlServerMvc/OpenshiftDotNetSqlServerMvc.csproj"
COPY . .
WORKDIR "/src/OpenshiftDotNetSqlServerMvc"
RUN dotnet build "OpenshiftDotNetSqlServerMvc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenshiftDotNetSqlServerMvc.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenshiftDotNetSqlServerMvc.dll"]