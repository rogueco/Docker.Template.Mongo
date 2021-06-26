#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Docker.Template.Mongo/Docker.Template.Mongo.csproj", "Docker.Template.Mongo/"]
RUN dotnet restore "Docker.Template.Mongo/Docker.Template.Mongo.csproj"
COPY . .
WORKDIR "/src/Docker.Template.Mongo"
RUN dotnet build "Docker.Template.Mongo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Docker.Template.Mongo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Docker.Template.Mongo.dll"]