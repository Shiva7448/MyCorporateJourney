# Use the official ASP.NET runtime image for Windows
FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809
WORKDIR /app
EXPOSE 80

# Copy the published output into the container
COPY ./bin/Release/net8.0/publish/ .
ENTRYPOINT ["dotnet", "MyCorporateJourney.dll"]