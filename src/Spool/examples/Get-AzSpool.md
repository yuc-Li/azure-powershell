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

Gets a single Spool resource by name in the specified resource group, using the selected subscription if not specified. Often used in pipeline scenarios.

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
