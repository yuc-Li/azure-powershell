### Example 1: List available cluster versions per location
```powershell
$location = "West US 2"
Get-AzHdInsightOnAksAvailableClusterVersion -Location $location
```

```output
ClusterPoolVersion           : 1.0
ClusterType                  : Trino
ClusterVersionValue          : 1.0.6
Component                    : {Trino, Hive metastore}
Id                           : /subscriptions/10e32bab-26da-4cc4-a441-52b318f824e6/providers/Microsoft.HDInsight/locations/westus2/availableclusterversions/trino_0.
                               410.0-1.0.6
IsPreview                    : False
Name                         : trino_0.410.0-1.0.6
OssVersion                   : 0.410.0
SystemData                   : Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.Api40.SystemData
```

List available cluster versions per location

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

