$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzSpoolKey.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzSpoolKey' {
    It 'RegenerateExpanded' {
        $oldKeys = Get-AzSpoolKey -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup
        
        # Result should not include secondary keys and should include updated primary keys
        $regenPrimary = New-AzSpoolKey -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup -KeyType Primary
        $regenPrimary.PrimaryKey | Should -Not -Be $oldKeys.PrimaryKey
        $regenPrimary.PrimaryConnectionString | Should -Not -Be $oldKeys.PrimaryConnectionString
        $regenPrimary.SecondaryKey | Should -BeNullOrEmpty
        $regenPrimary.SecondaryConnectionString | Should -BeNullOrEmpty

        # Primary key should have been changed but secondary should be unchanged
        $newKeys = Get-AzSpoolKey -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup
        $newKeys.PrimaryKey | Should -Be $regenPrimary.PrimaryKey
        $newKeys.PrimaryConnectionString | Should -Be $regenPrimary.PrimaryConnectionString
        $newKeys.SecondaryKey | Should -Be $oldKeys.SecondaryKey
        $newKeys.SecondaryConnectionString | Should -Be $oldKeys.SecondaryConnectionString
        
        # Result should not include primary keys and should include updated secondary keys
        $regenSecondary = New-AzSpoolKey -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup -KeyType Secondary
        $regenSecondary.PrimaryKey | Should -BeNullOrEmpty
        $regenSecondary.PrimaryConnectionString | Should -BeNullOrEmpty
        $regenSecondary.SecondaryKey | Should -Not -Be $oldKeys.SecondaryKey
        $regenSecondary.SecondaryConnectionString | Should -Not -Be $oldKeys.SecondaryConnectionString

        # Final result of the keys should reflect both updates
        $newKeys = Get-AzSpoolKey -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup
        $newKeys.PrimaryKey | Should -Be $regenPrimary.PrimaryKey
        $newKeys.PrimaryConnectionString | Should -Be $regenPrimary.PrimaryConnectionString
        $newKeys.SecondaryKey | Should -Be $regenSecondary.SecondaryKey
        $newKeys.SecondaryConnectionString | Should -Be $regenSecondary.SecondaryConnectionString
    }

    # Temporarily disabled since the generated ViaIdentity parameter set doesn't work.
    It 'RegenerateViaIdentityExpanded' {
        $resourceName = $env.testSpool2
        $identity = Get-AzSpool -Name $resourceName -ResourceGroupName $env.resourceGroup
        # Note: Get-AzSpoolKey does not currently support ViaIdentity
        $oldKeys = Get-AzSpoolKey -Name $resourceName -ResourceGroupName $env.resourceGroup
        
        # Result should not include secondary keys and should include updated primary keys
        $regenPrimary = New-AzSpoolKey -InputObject $identity -KeyType Primary
        $regenPrimary.PrimaryKey | Should -Not -Be $oldKeys.PrimaryKey
        $regenPrimary.PrimaryConnectionString | Should -Not -Be $oldKeys.PrimaryConnectionString
        $regenPrimary.SecondaryKey | Should -BeNullOrEmpty
        $regenPrimary.SecondaryConnectionString | Should -BeNullOrEmpty

        # Primary key should have been changed but secondary should be unchanged
        $newKeys = Get-AzSpoolKey -Name $resourceName -ResourceGroupName $env.resourceGroup
        $newKeys.PrimaryKey | Should -Be $regenPrimary.PrimaryKey
        $newKeys.PrimaryConnectionString | Should -Be $regenPrimary.PrimaryConnectionString
        $newKeys.SecondaryKey | Should -Be $oldKeys.SecondaryKey
        $newKeys.SecondaryConnectionString | Should -Be $oldKeys.SecondaryConnectionString
        
        # Result should not include primary keys and should include updated secondary keys
        $regenSecondary = New-AzSpoolKey -InputObject $identity -KeyType Secondary
        $regenSecondary.PrimaryKey | Should -BeNullOrEmpty
        $regenSecondary.PrimaryConnectionString | Should -BeNullOrEmpty
        $regenSecondary.SecondaryKey | Should -Not -Be $oldKeys.SecondaryKey
        $regenSecondary.SecondaryConnectionString | Should -Not -Be $oldKeys.SecondaryConnectionString

        # Final result of the keys should reflect both updates
        $newKeys = Get-AzSpoolKey -Name $resourceName -ResourceGroupName $env.resourceGroup
        $newKeys.PrimaryKey | Should -Be $regenPrimary.PrimaryKey
        $newKeys.PrimaryConnectionString | Should -Be $regenPrimary.PrimaryConnectionString
        $newKeys.SecondaryKey | Should -Be $regenSecondary.SecondaryKey
        $newKeys.SecondaryConnectionString | Should -Be $regenSecondary.SecondaryConnectionString
    }
}
