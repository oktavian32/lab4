# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY MemoryTestsLab/*.csproj ./MemoryTestsLab/
COPY MemoryTestsLab.Tests/*.csproj ./MemoryTestsLab.Tests/
RUN dotnet restore

# Copy everything else and build
COPY MemoryTestsLab/. ./MemoryTestsLab/
COPY MemoryTestsLab.Tests/. ./MemoryTestsLab.Tests/
RUN dotnet build

# Run tests
RUN dotnet test
