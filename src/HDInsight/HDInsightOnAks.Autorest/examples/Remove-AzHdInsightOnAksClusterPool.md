### Example 1: Remove cluster pool
```powershell
$clusterResourceGroupName = "Group"
$clusterpoolName = "your-clusterpool"
Remove-AzHdInsightOnAksClusterPool -Name $clusterpoolName -ResourceGroupName $clusterResourceGroupName
```

```output
{{ Add output here }}
```

Remove cluster pool with name.