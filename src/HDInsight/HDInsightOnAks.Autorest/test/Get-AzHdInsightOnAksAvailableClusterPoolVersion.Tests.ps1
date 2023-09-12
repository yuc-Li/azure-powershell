if(($null -eq $TestName) -or ($TestName -contains 'Get-AzHdInsightOnAksAvailableClusterPoolVersion'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'sessionRecords\Get-AzHdInsightOnAksAvailableClusterPoolVersion.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzHdInsightOnAksAvailableClusterPoolVersion' {
    BeforeAll{
        $location = "west us 2"
    }

    It 'Get-AzHdInsightOnAksAvailableClusterPoolVersion' {
        { $script:availableVersions = Get-AzHdInsightOnAksAvailableClusterPoolVersion -Location $location } | Should -Not -Throw
        $script:availableVersions | Should -Not -Be $null
        $script:availableVersions[0].AksVersion | Should -Be "1.26"
        $script:availableVersions[0].ClusterPoolVersionValue | Should -Not -Be $null
        $script:availableVersions[0].Id | Should -Not -Be $null

        [Console]::WriteLine("Get-AzHdInsightOnAksAvailableClusterPoolVersion done")
    }
}
