FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

WORKDIR webapp

COPY ./*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /webapp

COPY --from=build /webapp/out .

ENTRYPOINT ["dotnet", "DigitalInvest.FundingPlatform.dll"]