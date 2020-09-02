<!-- region Generated -->
# Az.Swiftlet
This directory contains the PowerShell module for the Swiftlet service.

---
## Status
[![Az.Swiftlet](https://img.shields.io/powershellgallery/v/Az.Swiftlet.svg?style=flat-square&label=Az.Swiftlet "Az.Swiftlet")](https://www.powershellgallery.com/packages/Az.Swiftlet/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.8.1 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.Swiftlet`, see [how-to.md](how-to.md).
<!-- endregion -->

---
## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@autorest`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest-beta`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(this-folder)/resources/swiftlet.json

module-version: 0.1.0
title: Swiftlet
subject-prefix: $(service-name)

# identity-correction-for-post: true

directive:
  # Following is two common directive which are normally required in all the RPs
  # 1. Remove the unexpanded parameter set
  # 2. For New-* cmdlets, ViaIdentity is not required, so CreateViaIdentityExpanded is removed as well
  - where:
      variant: ^Create$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^Update$|^UpdateViaIdentity$
    remove: true
  # Remove the set-* cmdlet
  - where:
      verb: Set
    remove: true

  # rename parameter name to follow design spec:
  
  #change virtualmachine name to VM for get-AzSwiftletVM
  - where:
      subject: VirtualMachine
    set:
      subject: VM
  - where:
      parameter-name: VMName
    set:
      parameter-name: Name
  - where:
      subject: VirtualMachineBundle
    set:
      subject: Bundle
  - where:
      subject: VirtualMachineImage
    set:
      subject: Image
  - where:
      parameter-name: PropertiesSwiftletBundleSku
    set:
      parameter-name: SwiftletBundleSku
  - where:
      parameter-name: PropertiesSwiftletImageId
    set:
      parameter-name: SwiftletImageId

 ```
