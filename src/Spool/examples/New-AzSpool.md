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

