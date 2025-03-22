FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Api/Eshop.Api/Eshop.Api.csproj", "Api/Eshop.Api/"]
COPY ["Modules/Basket/Eshop.Basket/Eshop.Basket.csproj", "Modules/Basket/Eshop.Basket/"]
COPY ["Shared/Eshop.Shared/Eshop.Shared.csproj", "Shared/Eshop.Shared/"]
COPY ["Modules/Catalog/Eshop.Catalog/Eshop.Catalog.csproj", "Modules/Catalog/Eshop.Catalog/"]
COPY ["Modules/Ordering/Eshop.Ordering/Eshop.Ordering.csproj", "Modules/Ordering/Eshop.Ordering/"]
RUN dotnet restore "Api/Eshop.Api/Eshop.Api.csproj"
COPY . .
WORKDIR "/src/Api/Eshop.Api"
RUN dotnet build "./Eshop.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Eshop.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Eshop.Api.dll"]
