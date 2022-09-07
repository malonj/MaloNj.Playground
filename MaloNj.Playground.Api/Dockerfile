#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MaloNj.Playground.Api/MaloNj.Playground.Api.csproj", "MaloNj.Playground.Api/"]
RUN dotnet restore "MaloNj.Playground.Api/MaloNj.Playground.Api.csproj"
COPY . .
WORKDIR "/src/MaloNj.Playground.Api"
RUN dotnet build "MaloNj.Playground.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MaloNj.Playground.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MaloNj.Playground.Api.dll"]