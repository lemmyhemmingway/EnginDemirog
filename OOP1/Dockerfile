FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["OOP1/OOP1.csproj", "OOP1/"]
RUN dotnet restore "OOP1/OOP1.csproj"
COPY . .
WORKDIR "/src/OOP1"
RUN dotnet build "OOP1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OOP1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OOP1.dll"]
