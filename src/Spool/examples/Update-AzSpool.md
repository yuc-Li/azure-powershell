### Example 1: Update Tags
```powershell
PS C:\> Update-AzSpool -ResourceGroupName MyRG -Name MySpool -Tag @{
>> Tag1 = 'testtag'
>> }

Location Name     Type
-------- ----     ----
westus2  MySpool  Microsoft.SpoolService/spools
```

Adds or updates tags on a Spool Resource.

### Example 2: Update Tags From Pipeline
```powershell
PS C:\> Get-AzSpool -ResourceGroup MyRG | Update-AzSpool -Tag @{
>> Tag1 = 'testtag'
>> }

Location Name     Type
-------- ----     ----
westus2  MySpool  Microsoft.SpoolService/spools
```

Adds or updates tags on Spool Resources from the pipeline.