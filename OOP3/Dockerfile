FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OOP3/OOP3.csproj", "OOP3/"]
RUN dotnet restore "OOP3/OOP3.csproj"
COPY . .
WORKDIR "/src/OOP3"
RUN dotnet build "OOP3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OOP3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOP3.dll"]
