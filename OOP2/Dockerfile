FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OOP2/OOP2.csproj", "OOP2/"]
RUN dotnet restore "OOP2/OOP2.csproj"
COPY . .
WORKDIR "/src/OOP2"
RUN dotnet build "OOP2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OOP2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOP2.dll"]
