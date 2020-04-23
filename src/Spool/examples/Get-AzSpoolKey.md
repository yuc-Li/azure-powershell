### Example 1: List Keys
```powershell
PS C:\> Get-AzSpoolKey -SpoolName MySpool -ResourceGroupName MyRG

PrimaryConnectionString
-----------------------
endpoint=https://myspool.westus2.spool.azure.net/;accesskey=<key removed>
```

Retrieves the current keys for the specified resource. If subscription is not specified the currently active subscription is used.


