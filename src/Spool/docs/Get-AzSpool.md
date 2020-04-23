---
external help file:
Module Name: Az.Spool
online version: https://docs.microsoft.com/en-us/powershell/module/az.spool/get-azspool
schema: 2.0.0
---

# Get-AzSpool

## SYNOPSIS
Get the Spool service and its properties.

## SYNTAX

### List (Default)
```
Get-AzSpool [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzSpool -Name <String> -ResourceGroupName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzSpool -InputObject <ISpoolIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### List1
```
Get-AzSpool -ResourceGroupName <String> [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Get the Spool service and its properties.

## EXAMPLES

### Example 1: List By Subscription
```powershell
PS C:\> Get-AzSpool

Location Name      Type
-------- ----      ----
westus2  MySpool   Microsoft.SpoolService/spools
westus   MySpool2  Microsoft.SpoolService/spools
```

Lists all Spool resources in a subscription, using the selected subscription if not specified.

### Example 2: List By Resource Group
```powershell
PS C:\> Get-AzSpool -ResourceGroupName MyRG

Location Name     Type
-------- ----    ----
westus2  myspool Microsoft.SpoolService/spools
```

Lists all Spool resources in a resource group, using the selected subscription if not specified.

### Example 3: Get By Resource Group and Name
```powershell
PS C:\> Get-AzSpool -ResourceGroupName MyRG -Name MySpool

Location Name     Type
-------- ----     ----
westus2  MySpool  Microsoft.SpoolService/spools
```

Gets a single Spool resource by name in the specified resource group, using the selected subscription if not specified.

### Example 4: Get By Pipeline
```powershell
PS C:\> @{
>>     SpoolName = 'MySpool'
>>     ResourceGroupName = 'MyRG'
>>     SubscriptionId = '00000000-0000-0000-0000-000000000000'
>> }| Get-AzSpool

Location Name    Type
-------- ----    ----
westus2  MySpool Microsoft.SpoolService/spools
```

Gets a single Spool resource by name in the specified resource group, using the selected subscription if not specified.
Often used in pipeline scenarios.

### Example 5: Alternate Output Formatting
```powershell
PS c:> Get-AzSpool | Format-List

HostName          : myspool.westus2.spool.azure.net
Id                : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/MyRG/providers/Microsoft.SpoolService/spools/MySpool
Location          : westus2
Name              : MySpool
OptionalFeature   : {}
ProvisioningState : Succeeded
Tag               : Microsoft.Azure.PowerShell.Cmdlets.Spool.Models.Api201910Preview.TaggedResourceTags
Type              : Microsoft.SpoolService/spools
Version           :
```

Demonstrates the other properties on the returned object.

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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the Spool resource.

```yaml
Type: System.String
Parameter Sets: Get
Aliases: SpoolName

Required: True
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
Parameter Sets: Get, List1
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
Type: System.String[]
Parameter Sets: Get, List, List1
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Spool.Models.ISpoolIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Spool.Models.Api201910Preview.ISpoolResource

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

