# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/ProjectName.csproj", "./"]
RUN dotnet restore "ProjectName.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "ProjectName.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectName.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectName.dll"]
