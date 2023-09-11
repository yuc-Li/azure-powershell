### Example 1: {{ Add title here }}
```powershell
$catalogName="{your catalog name}"
$metastoreDbConnectionURL="jdbc:sqlserver://{your sql server url};database={your db name};encrypt=true;trustServerCertificate=true;loginTimeout=30;";
$metastoreDbUserName="{your db user name}";
$metastoreDbPasswordSecret=$secretName;
$metastoreWarehouseDir="abfs://{your container name}@{your adls gen2 endpoint}/{your path}";

$trinoHiveCatalogOption=New-AzHdInsightOnAksTrinoHiveCatalog -CatalogName $catalogName -MetastoreDbConnectionUrl $metastoreDbConnectionURL -MetastoreDbConnectionUserName 
```

```output
{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
{{ Add code here }}
```

```output
{{ Add output here }}
```

{{ Add description here }}

