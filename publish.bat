dotnet clean
dotnet restore
dotnet build
dotnet publish
copy ".\bin\Debug\net7.0\win10-x64\publish\SortDomainNames.exe" ".\SortDomainNames.exe"
