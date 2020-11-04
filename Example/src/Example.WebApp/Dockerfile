FROM opencvsharp_base
WORKDIR /app

COPY /src/Example.WebApp/Example.WebApp.csproj ./src/Example.WebApp/
WORKDIR /app/src/Example.WebApp
RUN dotnet restore

WORKDIR /app
COPY /src/Example.WebApp/. ./src/Example.WebApp/

WORKDIR /app/src/Example.WebApp
ARG configuration
RUN dotnet publish -c $configuration -o out

WORKDIR /app/src/Example.WebApp/out

ENTRYPOINT ["dotnet", "Example.WebApp.dll"]