$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzSpool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzSpool' {
    It 'CreateExpanded' {
        $name = $env.testSpoolName
        $res = New-AzSpool -Name $name -ResourceGroupName $env.resourceGroup -Location $env.location -Tag @{test="powershell"}
        $res.Name | Should -Be $name
        $res.Tag.Count | Should -Be 1
        { Remove-AzSpool -Name $name -ResourceGroupName $env.resourceGroup } | Should -Not -Throw
    }
}
