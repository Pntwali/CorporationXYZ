# Define the project name
$projectName = "CorporationXYZ"

# Create the directory structure
New-Item -ItemType Directory -Path "./src/$projectName.Api/Controllers"
New-Item -ItemType Directory -Path "./src/$projectName.Service"
New-Item -ItemType Directory -Path "./src/$projectName.Data/Models"
New-Item -ItemType Directory -Path "./src/$projectName.Data/Migrations"
New-Item -ItemType Directory -Path "./src/$projectName.Common"
New-Item -ItemType Directory -Path "./tests/$projectName.UnitTests"
New-Item -ItemType Directory -Path "./tests/$projectName.IntTests"
New-Item -ItemType Directory -Path "./scripts"
New-Item -ItemType Directory -Path "./docs"
New-Item -ItemType Directory -Path "./.github/workflows"

# Create the necessary files
New-Item -ItemType File -Path "./.gitignore"
New-Item -ItemType File -Path "./Dockerfile"
New-Item -ItemType File -Path "./docker-compose.yml"
New-Item -ItemType File -Path "./README.md"
New-Item -ItemType File -Path "./ROADMAP.md"
New-Item -ItemType File -Path "./REQUIREMENTS.md"
New-Item -ItemType File -Path "./CONTRIBUTING.md"
New-Item -ItemType File -Path "./LICENSE"
New-Item -ItemType File -Path "./.github/workflows/dotnet.yml"

# Initialize the git repository
Set-Location ./
git init

# Create the .NET solution
dotnet new sln -n $projectName

# Create the .NET projects (Api, Service, Data, Common, UnitTests, IntTests)
dotnet new webapi -n "$projectName.Api" -o "./src/$projectName.Api"
dotnet new classlib -n "$projectName.Service" -o "./src/$projectName.Service"
dotnet new classlib -n "$projectName.Data" -o "./src/$projectName.Data"
dotnet new classlib -n "$projectName.Common" -o "./src/$projectName.Common"
dotnet new xunit -n "$projectName.UnitTests" -o "./tests/$projectName.UnitTests"
dotnet new xunit -n "$projectName.IntTests" -o "./tests/$projectName.IntTests"

# Add the projects to the solution
dotnet sln add "./src/$projectName.Api/$projectName.Api.csproj"
dotnet sln add "./src/$projectName.Service/$projectName.Service.csproj"
dotnet sln add "./src/$projectName.Data/$projectName.Data.csproj"
dotnet sln add "./src/$projectName.Common/$projectName.Common.csproj"
dotnet sln add "./tests/$projectName.UnitTests/$projectName.UnitTests.csproj"
dotnet sln add "./tests/$projectName.IntTests/$projectName.IntTests.csproj"
