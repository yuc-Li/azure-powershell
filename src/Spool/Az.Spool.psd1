@{
  GUID = '1b1f8ec3-f3bc-45a1-8daa-b4dc7130348f'
  RootModule = './Az.Spool.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Spool cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Spool.private.dll'
  FormatsToProcess = './Az.Spool.format.ps1xml'
  FunctionsToExport = 'Get-AzSpool', 'Get-AzSpoolKey', 'New-AzSpool', 'New-AzSpoolKey', 'Remove-AzSpool', 'Test-AzSpoolNameAvailability', 'Update-AzSpool', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Spool'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
