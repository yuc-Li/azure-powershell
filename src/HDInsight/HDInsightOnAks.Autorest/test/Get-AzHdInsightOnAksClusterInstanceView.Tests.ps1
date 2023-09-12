if(($null -eq $TestName) -or ($TestName -contains 'Get-AzHdInsightOnAksClusterInstanceView'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'sessionRecords\Get-AzHdInsightOnAksClusterInstanceView.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzHdInsightOnAksClusterInstanceView' {
    BeforeAll {
        # Cluster configuration info
        $location = "West US 3"
        $clusterResourceGroupName = "Group"
        $clusterpoolName = "ps-test-cluster-pool"
        $clusterType = "Trino"
        $vmSize = "Standard_E4s_v3"
        $clusterOfferingVersions = Get-AzHdInsightOnAksAvailableClusterVersion -Location $location
        $ComputeProfileNode = New-AzHdInsightOnAksNodeProfile -Type "Worker" -Count 3 -VMSize "Standard_D8d_v5"
        $clusterName = "clustername"

        New-AzHdInsightOnAksClusterPool -Name $clusterpoolName -ResourceGroupName $clusterResourceGroupName -VmSize $vmSize -Location $location
       
        { New-AzHdInsightOnAksCluster -Name $clusterName -PoolName $clusterpoolName `
            -ResourceGroupName $clusterResourceGroupName `
            -Location $location `
            -ClusterType $clusterType `
            -ClusterVersion $clusterOfferingVersions[9].ClusterVersionValue -OssVersion $clusterOfferingVersions[9].OssVersion `
            -ComputeProfileNode $ComputeProfileNode `
            -AuthorizationUserId $env.authorizationUserId `
            -AssignedIdentityClientId $env.msiClientId `
            -AssignedIdentityObjectId $env.msiObjectId `
            -AssignedIdentityResourceId $env.identityProfileMsiResourceId } | Should -Not -Throw

    }

    It 'Get-AzHdInsightOnAksClusterInstanceView' {
        { $script:instance = Get-AzHdInsightOnAksClusterInstanceView -ResourceGroupName $clusterResourceGroupName -ClusterName $clusterName -ClusterPoolName $clusterpoolName } | Should -Not -Throw

        $script:instance | Should -Not -Be $null
        $script:instance.StatusReady | Should -Be $true
        [Console]::WriteLine("GetAzHdInsightOnAksClusterWithRG done")
    }

    AfterAll {
        Remove-AzHdInsightOnAksClusterPool -ResourceGroupName $clusterResourceGroupName -Name $clusterpoolName 
    }

}
