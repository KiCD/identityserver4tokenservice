FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5200
EXPOSE 44320

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /identityserver4tokenservice
# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore identityserver4tokenservice.csproj

# Copy everything else and build
COPY . .
WORKDIR /identityserver4tokenservice
RUN dotnet build identityserver4tokenservice.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish identityserver4tokenservice.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "identityserver4tokenservice.dll"]
