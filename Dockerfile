ARG TAG=8.0-windowsservercore-ltsc2019

FROM mcr.microsoft.com/dotnet/sdk:${TAG} as build
WORKDIR /app
COPY app.csproj ./

RUN dotnet restore
#RUN dotnet restore --use-current-runtime

COPY . .
RUN dotnet publish -c Release -o /app --use-current-runtime --self-contained false --no-restore

FROM mcr.microsoft.com/dotnet/runtime:${TAG}
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "app.dll"]
