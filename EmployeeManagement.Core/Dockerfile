FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app

COPY EmployeeManagement.Core/*.sln .
COPY EmployeeManagement.Core/EmployeeManagement.Api/*.csproj  ./EmployeeManagement.Api/
COPY EmployeeManagement.Core/EmployeeManagement.Model/*.csproj ./EmployeeManagement.Model/
COPY EmployeeManagement.Core/EmployeeManagement.Provider/*.csproj ./EmployeeManagement.Provider/
COPY EmployeeManagement.Core/EmployeeManagement.Repository/*.csproj ./EmployeeManagement.Repository/
RUN dotnet restore


COPY EmployeeManagement.Core/EmployeeManagement.Api/. ./EmployeeManagement.Api/
COPY EmployeeManagement.Core/EmployeeManagement.Model/. ./EmployeeManagement.Model/
COPY EmployeeManagement.Core/EmployeeManagement.Provider/. ./EmployeeManagement.Provider/
COPY EmployeeManagement.Core/EmployeeManagement.Repository/. ./EmployeeManagement.Repository/
WORKDIR /app/EmployeeManagement.Api
RUN dotnet publish -c Release -o /app

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "EmployeeManagement.Api.dll"]

