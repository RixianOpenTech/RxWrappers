[CmdletBinding()]
Param(
  [Parameter(Mandatory=$True,Position=1)]
   [string]$ProjectName
)

Move-Item .\NuGet\Empty.NuGet\Empty.NuGet.nuproj .\NuGet\Empty.NuGet\$ProjectName.NuGet.nuproj
Move-Item .\Empty\Empty.csproj .\Empty\$ProjectName.csproj
Move-Item .\NuGet\Empty.NuGet .\NuGet\$ProjectName.NuGet
Rename-Item .\Empty.sln .\$ProjectName.sln
Rename-Item .\Empty .\$ProjectName

$path = ".\$ProjectName.sln"
(Get-Content $path).replace('<<ProjectName>>', $ProjectName) | Set-Content $path -Encoding UTF8

$path = ".\$ProjectName\$ProjectName.csproj"
(Get-Content $path).replace('<<ProjectName>>', $ProjectName) | Set-Content $path -Encoding UTF8

$path = ".\$ProjectName\Properties\AssemblyInfo.cs"
(Get-Content $path).replace('<<ProjectName>>', $ProjectName) | Set-Content $path -Encoding UTF8

$path = ".\NuGet\$ProjectName.NuGet\$ProjectName.NuGet.nuproj"
(Get-Content $path).replace('<<ProjectName>>', $ProjectName) | Set-Content $path -Encoding UTF8