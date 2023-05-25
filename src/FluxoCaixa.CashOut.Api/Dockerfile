#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FluxoCaixa.CashOut.Api/FluxoCaixa.CashOut.Api.csproj", "FluxoCaixa.CashOut.Api/"]
RUN dotnet restore "FluxoCaixa.CashOut.Api/FluxoCaixa.CashOut.Api.csproj"
COPY . .
WORKDIR "/src/FluxoCaixa.CashOut.Api"
RUN dotnet build "FluxoCaixa.CashOut.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FluxoCaixa.CashOut.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FluxoCaixa.CashOut.Api.dll"]