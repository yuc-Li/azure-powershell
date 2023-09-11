---
external help file:
Module Name: Az.HdInsightOnAks
online version: https://learn.microsoft.com/powershell/module/az.hdinsightonaks/get-azhdinsightonaksavailableclusterversion
schema: 2.0.0
---

# Get-AzHdInsightOnAksAvailableClusterVersion

## SYNOPSIS
Returns a list of available cluster versions.

## SYNTAX

```
Get-AzHdInsightOnAksAvailableClusterVersion -Location <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Returns a list of available cluster versions.

## EXAMPLES

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

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The name of the Azure region.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.
The value must be an UUID.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.Api20230601Preview.IClusterVersion

## NOTES

ALIASES

## RELATED LINKS

