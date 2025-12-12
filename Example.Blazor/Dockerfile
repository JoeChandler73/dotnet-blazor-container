FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build-env /app/out ./

ENV DOTNET_URLS=http://+:80
EXPOSE 80

ENTRYPOINT ["dotnet", "Example.Blazor.dll"]

# docker build -t example-blazor .
# docker run -d -p 8081:80 --name example-blazor example-blazor

# docker buildx create --use --name multi-arch
# docker buildx build --platform linux/amd64,linux/arm64 --push -t joechandler73/example-blazor .
# docker buildx rm multi-arch
