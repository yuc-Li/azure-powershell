$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzSpool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzSpool' {
    It 'List' {
        # By Subscription
        $spoolsInSubscription = Get-AzSpool
        $spoolsInSubscription.Count | Should -BeGreaterOrEqual 2
    }

    It 'Get' {
        $spool = Get-AzSpool -Name $env.testSpool1 -ResourceGroupName $env.resourceGroup
        $spool.Name | Should -Be $env.testSpool1
    }

    It 'List1' {
        # By Resource Group
        $spoolsInRg = Get-AzSpool -ResourceGroupName $env.resourceGroup
        $spoolsInRg.Count | Should -Be 2
    }

    It 'GetViaIdentity' {
        $identity = @{
            SpoolName = $env.testSpool2
            ResourceGroupName = $env.resourceGroup
            SubscriptionId = $env.SubscriptionId
        }
        $spool = Get-AzSpool -InputObject $identity
        $spool.Name | Should -Be $env.testSpool2
    }
}
