FROM mcr.microsoft.com/dotnet/sdk:8.0
ENV ASPNETCORE_URLS http://+:5000
RUN mkdir /app
WORKDIR /app
COPY app.csproj ./
RUN dotnet restore
COPY . .
CMD dotnet run
