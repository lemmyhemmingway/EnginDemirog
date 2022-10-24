FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BankProjectHomework/BankProjectHomework.csproj", "BankProjectHomework/"]
RUN dotnet restore "BankProjectHomework/BankProjectHomework.csproj"
COPY . .
WORKDIR "/src/BankProjectHomework"
RUN dotnet build "BankProjectHomework.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BankProjectHomework.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BankProjectHomework.dll"]
