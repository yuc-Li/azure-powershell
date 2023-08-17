### Example 1: Get cluster pool by name
```powershell
$clusterResourceGroupName = "Group"
$clusterpoolName = "your-clusterpool"
Get-AzHdInsightOnAksClusterPool -Name $clusterpoolName -ResourceGroupName $clusterResourceGroupName 
```

```output
AkClusterAgentPoolIdentityProfileMsiClientId   : 00000000-0000-0000-0000-000000000000
AkClusterAgentPoolIdentityProfileMsiObjectId   : 00000000-0000-0000-0000-000000000000
AkClusterAgentPoolIdentityProfileMsiResourceId : /subscriptions/00000000-0000-0000-0000-000000000000/resourcegroups/MC_hdi-00000000-0000-0000-0000-000000000000_your-clusterpool_westu
                                                 s2/providers/Microsoft.ManagedIdentity/userAssignedIdentities/your-clusterpool-agentpool
AkClusterProfileAksClusterResourceId           : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/hdi-00000000-0000-0000-0000-000000000000/providers/M
                                                 icrosoft.ContainerService/managedClusters/your-clusterpool
AkClusterProfileAksVersion                     : 1.26
AksManagedResourceGroupName                    : MC_hdi-00000000-0000-0000-0000-000000000000_your-clusterpool_westus2
ComputeProfileCount                            : 3
ComputeProfileVMSize                           : standard_f4s_v2
DeploymentId                                   : b671489750ff4112aa8c8fac8d153f7b
Id                                             : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/Group/providers/Microsoft.HDInsight/clus
                                                 terpools/your-clusterpool
Location                                       : West US 2
```

Get cluster pool by name.

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

