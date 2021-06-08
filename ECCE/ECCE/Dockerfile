FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ECCE.csproj", "."]
RUN dotnet restore "ECCE.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "ECCE.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ECCE.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN useradd -m ecceope2
USER ecceope2

CMD ASPNETCORE_URLS="http://*:$PORT" dotnet ECCE.dll