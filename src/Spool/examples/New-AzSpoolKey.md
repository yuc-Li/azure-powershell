### Example 1: Regenerate a Key By Resource Name
```powershell
PS C:\> New-AzSpoolKey -SpoolName MySpool -ResourceGroupName MyRG -KeyType Secondary

PrimaryConnectionString PrimaryKey SecondaryConnectionString
----------------------- ---------- -------------------------
                                   endpoint=https://myspool.westus2.spool.azure.net/;accesskey=<key removed>...
```

Regenerates a key on an existing resource. If subscription isn't provided the currently selected subscription is used.

### Example 2: Regenerate a Key By Resource Identity
```powershell
PS C:\> Get-AzSpool -SpoolName MySpool -ResourceGroupName MyRG | New-AzSpoolKey -KeyType Primary

PrimaryConnectionString
-----------------------
endpoint=https://myspool.westus2.spool.azure.net/;accesskey=<key removed>...
```

Regenerate a key using a Spool Identity object. Often used in pipeline scenarios.

