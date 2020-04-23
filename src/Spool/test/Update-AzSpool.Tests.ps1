$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzSpool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-AzSpool' {
    It 'UpdateExpanded' {
        $retrieved = Get-AzSpool -Name $env.testSPool1 -ResourceGroupName $env.resourceGroup
        $retrieved.Tag.ContainsKey("powershell") | Should -BeFalse
        $updated = Update-AzSpool -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup -Tag @{powershell='UpdateExpanded'}
        $updated.Tag.ContainsKey("powershell") | Should -BeTrue
        $updated.Tag.Item("powershell") | Should -Be "UpdateExpanded"
        $retrieved = Get-AzSpool -Name $env.testSPool1 -ResourceGroupName $env.resourceGroup
        $retrieved.Tag.ContainsKey("powershell") | Should -BeTrue
        $retrieved.Tag.Item("powershell") | Should -Be "UpdateExpanded"
    }

    It 'UpdateViaIdentityExpanded' {
        $retrieved = Get-AzSpool -Name $env.testSpool2 -ResourceGroupName $env.resourceGroup
        $retrieved.Tag.ContainsKey("powershell") | Should -BeFalse
        $updated = Update-AzSpool -InputObject $retrieved -Tag @{powershell='UpdateViaIdentityExpanded'}
        $updated.Tag.ContainsKey("powershell") | Should -BeTrue
        $updated.Tag.Item("powershell") | Should -Be "UpdateViaIdentityExpanded"
        $retrieved = Get-AzSpool -Name $env.testSpool2 -ResourceGroupName $env.resourceGroup
        $retrieved.Tag.ContainsKey("powershell") | Should -BeTrue
        $retrieved.Tag.Item("powershell") | Should -Be "UpdateViaIdentityExpanded"
    }
}
