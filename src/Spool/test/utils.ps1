function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
$env = @{}
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.Tenant = (Get-AzContext).Tenant.Id
    $location = 'westus2'
    $null = $env.Add("location", $location)
    $resourceGroup = "rg-spool-powershell-"+ (RandomString -allChars $false -len 6)
    $null = $env.Add("resourceGroup", $resourceGroup)
    New-AzResourceGroup -Name $resourceGroup -Location $location

    # Create two existing spool resources for test
    $testSpool1 = "testSpoolExisting1-" + (RandomString -allChars $false -len 6)
    $null = $env.Add("testSpool1", $testSpool1)
    New-AzSpool -Name $testSpool1 -ResourceGroupName $resourceGroup -Location $location

    $testSpool2 = "testSpoolExisting2-" + (RandomString -allChars $false -len 6)
    $null = $env.Add("testSpool2", $testSpool2)
    New-AzSpool -Name $testSpool2 -ResourceGroupName $resourceGroup -Location $location

    # Create a name for a spool resource that can be created (For New-AzSpool)
    $null = $env.Add("testSpoolName", "testSpoolCreated-" + (RandomString -allChars $false -len 7))

    # Create a name for a spool resource that should be available
    $null = $env.Add("testSpoolNameAvailable", "testSpoolAvailable-" + (RandomString -allChars $false -len 7))

    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}
function cleanupEnv() {
    # Clean resources you create for testing
    # Removing resourcegroup will clean all the resources created for testing.
    Remove-AzResourceGroup -Name $env.resourceGroup
}

