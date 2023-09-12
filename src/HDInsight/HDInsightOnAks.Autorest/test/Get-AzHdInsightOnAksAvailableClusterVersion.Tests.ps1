if(($null -eq $TestName) -or ($TestName -contains 'Get-AzHdInsightOnAksAvailableClusterVersion'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'sessionRecords\Get-AzHdInsightOnAksAvailableClusterVersion.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzHdInsightOnAksAvailableClusterVersion' {
    BeforeAll{
        $location = "west us 2"
    }

    It 'Get-AzHdInsightOnAksAvailableClusterVersion' {
        { $script:availableVersions = Get-AzHdInsightOnAksAvailableClusterVersion -Location $location } | Should -Not -Throw
        $script:availableVersions[0].ClusterPoolVersion | Should -Not -Be $null
        $script:availableVersions[0].ClusterType | Should -Not -Be $null
        $script:availableVersions[0].Id | Should -Not -Be $null

        [Console]::WriteLine("Get-AzHdInsightOnAksAvailableClusterVersion done")
    }
}
