$sln = Get-ChildItem . -Filter "*.sln"
.nuget\NuGet.exe update $sln