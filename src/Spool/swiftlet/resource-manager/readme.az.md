## AZ

These settings apply only when `--az` is specified on the command line.

``` yaml $(az)
az:
    extensions: swiftlet
    namespace: azure.mgmt.swiftlet
    package-name: azure-mgmt-swiftlet
az-output-folder: $(azure-cli-extension-folder)/src/swiftlet
python-sdk-output-folder: "$(az-output-folder)/azext_swiftlet/vendored_sdks/swiftlet"
# add additinal configuration here specific for Azure CLI
# refer to the faq.md for more details
```
