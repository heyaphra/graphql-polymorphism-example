FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GraphqlPolymorphismExample/GraphqlPolymorphismExample.csproj", "GraphqlPolymorphismExample/"]
RUN dotnet restore "GraphqlPolymorphismExample/GraphqlPolymorphismExample.csproj"
COPY . .
WORKDIR "/src/GraphqlPolymorphismExample"
RUN dotnet build "GraphqlPolymorphismExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GraphqlPolymorphismExample.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GraphqlPolymorphismExample.dll"]
