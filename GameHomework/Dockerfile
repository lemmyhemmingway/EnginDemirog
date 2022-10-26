FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GameHomework/GameHomework.csproj", "GameHomework/"]
RUN dotnet restore "GameHomework/GameHomework.csproj"
COPY . .
WORKDIR "/src/GameHomework"
RUN dotnet build "GameHomework.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GameHomework.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GameHomework.dll"]
