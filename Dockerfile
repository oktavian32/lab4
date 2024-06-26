FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY lab3/MemoryTestsLab.csproj lab3/
COPY MemoryTestsLab.Tests/MemoryTestsLab.Tests.csproj MemoryTestsLab.Tests/

WORKDIR /app/lab3
RUN dotnet restore

WORKDIR /app/MemoryTestsLab.Tests
RUN dotnet restore

WORKDIR /app
COPY . .

WORKDIR /app/lab3
RUN dotnet publish -c Release -o out

WORKDIR /app/MemoryTestsLab.Tests
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/lab3/out .
ENTRYPOINT ["dotnet", "MemoryTestsLab.dll"]
