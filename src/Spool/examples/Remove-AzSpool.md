### Example 1: Remove Individual Resource
```powershell
PS C:\> Remove-AzSpool -ResourceGroupName MyRG -Name MySpool
```

Removes a single resource by name.

### Example 2: Remove By Pipeline
```powershell
PS C:\> Get-AzSpool | Where-Object -Property Name -Contains 'test' | Remove-AzSpool
```

Removes all Spool Resources presented by the pipeline. Allows for deleting multiple resources at once and for additional filtering.
