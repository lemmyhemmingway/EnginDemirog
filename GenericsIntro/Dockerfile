FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GenericsIntro/GenericsIntro.csproj", "GenericsIntro/"]
RUN dotnet restore "GenericsIntro/GenericsIntro.csproj"
COPY . .
WORKDIR "/src/GenericsIntro"
RUN dotnet build "GenericsIntro.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GenericsIntro.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GenericsIntro.dll"]
