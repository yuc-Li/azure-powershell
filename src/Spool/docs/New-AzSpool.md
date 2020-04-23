---
external help file:
Module Name: Az.Spool
online version: https://docs.microsoft.com/en-us/powershell/module/az.spool/new-azspool
schema: 2.0.0
---

# New-AzSpool

## SYNOPSIS
Create a new Spool service or update an existing Spool service.

## SYNTAX

```
New-AzSpool -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>] [-Location <String>]
 [-OptionalFeature <OptionalFeature[]>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new Spool service or update an existing Spool service.

## EXAMPLES

### Example 1: Create Default Resource
```powershell
PS C:\> New-AzSpool -Name MySpool -ResourceGroupName MyRg -Location westus2

Location Name     Type
-------- ----     ----
westus2  MySpool  Microsoft.SpoolService/spools
```

Creates a new spool resource using only default values.

### Example 2: Create Fully Specified Resource
```powershell
PS C:\> New-AzSpool -Name MySpool -ResourceGroupName MyRg -SubscriptionId 00000000-0000-0000-0000-000000000000 -Location westus2 -Tag @{
>> FirstTag = 'FirstTagValue'
>> SecondTag = 'SecondTagValue'
}

Location Name     Type
-------- ----     ----
westus2  MySpool  Microsoft.SpoolService/spools
```

Creates a new spool resource with tags

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

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

### -Location
The Azure location where the Spool service is running.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Name
The name of the Spool resource.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: SpoolName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OptionalFeature
Features that may optionally be enabled on a Spool instance.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Spool.Support.OptionalFeature[]
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
Parameter Sets: (All)
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
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Tag
Tags of the service which is a list of key value pairs that describe the resource.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Spool.Models.Api201910Preview.ISpoolResource

## ALIASES

## NOTES

## RELATED LINKS

