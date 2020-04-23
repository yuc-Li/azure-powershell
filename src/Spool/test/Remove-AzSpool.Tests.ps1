$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzSpool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-AzSpool' {
    It 'Delete' {
        $name = $env.testSpoolName
        New-AzSpool -Name $name -ResourceGroupName $env.resourceGroup -Location $env.location
        { Remove-AzSpool -Name $name -ResourceGroupName $env.resourceGroup } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' {
        $name = $env.testSpoolName
        $result = New-AzSpool -Name $name -ResourceGroupName $env.resourceGroup -Location $env.location
        { Remove-AzSpool -InputObject $result } | Should -Not -Throw
    }
}
