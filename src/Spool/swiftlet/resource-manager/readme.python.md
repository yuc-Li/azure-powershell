## Python

```yaml $(python)
python:
    azure-arm: true
    license-header: MICROSOFT_MIT_NO_VERSION
    namespace: azure.mgmt.swiftlet
    package-name: azure-mgmt-swiftlet
    clear-output-folder: true
```

``` yaml $(python) && $(python-mode) == 'update'
python:
    no-namespace-folders: true
    output-folder: $(python-sdks-folder)/swiftlet/azure-mgmt-swiftlet/azure/mgmt/swiftlet
```
``` yaml $(python) && $(python-mode) == 'create'
python:
    basic-setup-py: true
    output-folder: $(python-sdks-folder)/swiftlet/azure-mgmt-swiftlet
```
