@{
  GUID = 'b50c27e7-4d37-48de-ab24-9b52f8177985'
  RootModule = './Az.Swiftlet.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Swiftlet cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Swiftlet.private.dll'
  FormatsToProcess = './Az.Swiftlet.format.ps1xml'
  FunctionsToExport = 'Get-AzSwiftletVirtualMachine', 'Get-AzSwiftletVirtualMachineBundle', 'Get-AzSwiftletVirtualMachineImage', 'New-AzSwiftletVirtualMachine', 'Remove-AzSwiftletVirtualMachine', 'Start-AzSwiftletVirtualMachine', 'Stop-AzSwiftletVirtualMachine', 'Update-AzSwiftletVirtualMachine', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Swiftlet'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
