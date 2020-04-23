$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzSpoolKey.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzSpoolKey' {
    It 'List' {
        $keys = Get-AzSpoolKey -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup
        $keys.PrimaryKey | Should -Not -BeNullOrEmpty
        $keys.PrimaryConnectionString | Should -Not -BeNullOrEmpty
        $keys.SecondaryKey | Should -Not -BeNullOrEmpty
        $keys.SecondaryConnectionString | Should -Not -BeNullOrEmpty
    }
}
