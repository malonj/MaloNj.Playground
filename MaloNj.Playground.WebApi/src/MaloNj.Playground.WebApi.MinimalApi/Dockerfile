#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MaloNj.Playground.WebApi.MinimalApi/MaloNj.Playground.WebApi.MinimalApi.csproj", "MaloNj.Playground.WebApi.MinimalApi/"]
RUN dotnet restore "MaloNj.Playground.WebApi.MinimalApi/MaloNj.Playground.WebApi.MinimalApi.csproj"
COPY . .
WORKDIR "/src/MaloNj.Playground.WebApi.MinimalApi"
RUN dotnet build "MaloNj.Playground.WebApi.MinimalApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MaloNj.Playground.WebApi.MinimalApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MaloNj.Playground.WebApi.MinimalApi.dll"]