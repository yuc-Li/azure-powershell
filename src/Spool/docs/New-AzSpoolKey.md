---
external help file:
Module Name: Az.Spool
online version: https://docs.microsoft.com/en-us/powershell/module/az.spool/new-azspoolkey
schema: 2.0.0
---

# New-AzSpoolKey

## SYNOPSIS
Regenerate Spool service access key.
PrimaryKey and SecondaryKey cannot be regenerated at the same time.

## SYNTAX

### RegenerateExpanded (Default)
```
New-AzSpoolKey -ResourceGroupName <String> -SpoolName <String> [-SubscriptionId <String>] [-KeyType <KeyType>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RegenerateViaIdentityExpanded
```
New-AzSpoolKey -InputObject <ISpoolIdentity> [-KeyType <KeyType>] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Regenerate Spool service access key.
PrimaryKey and SecondaryKey cannot be regenerated at the same time.

## EXAMPLES

### Example 1: Regenerate a Key By Resource Name
```powershell
PS C:\> New-AzSpoolKey -SpoolName MySpool -ResourceGroupName MyRG -KeyType Secondary

PrimaryConnectionString PrimaryKey SecondaryConnectionString
----------------------- ---------- -------------------------
                                   endpoint=https://myspool.westus2.spool.azure.net/;accesskey=<key removed>...
```

Regenerates a key on an existing resource.
If subscription isn't provided the currently selected subscription is used.

### Example 2: Regenerate a Key By Resource Identity
```powershell
PS C:\> Get-AzSpool -SpoolName MySpool -ResourceGroupName MyRG | New-AzSpoolKey -KeyType Primary

PrimaryConnectionString
-----------------------
endpoint=https://myspool.westus2.spool.azure.net/;accesskey=<key removed>...
```

Regenerate a key using a Spool Identity object.
Often used in pipeline scenarios.

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Spool.Models.ISpoolIdentity
Parameter Sets: RegenerateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -KeyType
The keyType to regenerate.
Must be either 'primary' or 'secondary'(case-insensitive).

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Spool.Support.KeyType
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group that contains the resource.
You can obtain this value from the Azure Resource Manager API or the portal.

```yaml
Type: System.String
Parameter Sets: RegenerateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SpoolName
The name of the Spool resource.

```yaml
Type: System.String
Parameter Sets: RegenerateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
Gets subscription ID which uniquely identifies the Microsoft Azure subscription.
The subscription ID forms part of the URI for every service call.

```yaml
Type: System.String
Parameter Sets: RegenerateExpanded
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Spool.Models.ISpoolIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Spool.Models.Api201910Preview.ISpoolKeys

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <ISpoolIdentity>: Identity Parameter
  - `[Id <String>]`: Resource identity path
  - `[Location <String>]`: The Azure region
  - `[ResourceGroupName <String>]`: The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
  - `[SpoolName <String>]`: The name of the Spool resource.
  - `[SubscriptionId <String>]`: Gets subscription ID which uniquely identifies the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call.

## RELATED LINKS

