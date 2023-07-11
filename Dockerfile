#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 443
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Friable_mongo.csproj", "."]
RUN dotnet restore "./Friable_mongo.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Friable_mongo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Friable_mongo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY https/dockerdemo.pfx dockerdemo.pfx
ENTRYPOINT ["dotnet", "Friable_mongo.dll"]