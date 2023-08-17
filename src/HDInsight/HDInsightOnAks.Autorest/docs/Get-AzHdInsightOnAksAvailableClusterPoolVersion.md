---
external help file:
Module Name: Az.HdInsightOnAks
online version: https://learn.microsoft.com/powershell/module/az.hdinsightonaks/get-azhdinsightonaksavailableclusterpoolversion
schema: 2.0.0
---

# Get-AzHdInsightOnAksAvailableClusterPoolVersion

## SYNOPSIS
Returns a list of available cluster pool versions.

## SYNTAX

```
Get-AzHdInsightOnAksAvailableClusterPoolVersion -Location <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Returns a list of available cluster pool versions.

## EXAMPLES

### Example 1: List available cluster pool versions per the location
```powershell
$location = "West US 2"
Get-AzHdInsightOnAksAvailableClusterPoolVersion -Location $location
```

```output
AksVersion                   : 1.26
ClusterPoolVersionValue      : 1.0
Id                           : /subscriptions/00000000-0000-0000-0000-000000000000/providers/Microsoft.HDInsight/locations/West US
                               2/availableclusterpoolversions/1.0
IsPreview                    : False
Name                         : 1.0
```

List available cluster pool versions per the location.

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

### Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.Api20230601Preview.IClusterPoolVersion

## NOTES

ALIASES

## RELATED LINKS

