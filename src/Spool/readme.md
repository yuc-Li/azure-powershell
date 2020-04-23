<!-- region Generated -->
# Az.Spool
This directory contains the PowerShell module for the Spool service.

---
## Status
[![Az.Spool](https://img.shields.io/powershellgallery/v/Az.Spool.svg?style=flat-square&label=Az.Spool "Az.Spool")](https://www.powershellgallery.com/packages/Az.Spool/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.7.2 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.Spool`, see [how-to.md](how-to.md).
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
> `autorest-beta --azure && pwsh .\build-module.ps1`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.noprofile.md
input-file:
  - $(repo)/specification/spool/resource-manager/Microsoft.SpoolService/preview/2019-10-10-preview/spool.json

module-version: 0.1.0
title: Spool
subject-prefix: $(service-name)
identity-correction-for-post: true

inlining-threshold: 40

directive:
  # Remove non-expanded parameter sets for create and update
  - where:
      variant: ^Create$|^Update$|^Regenerate$|^Check$|^RegenerateViaIdentity$|^UpdateViaIdentity$
    remove: true
  # Remove via-identity parameter sets where it doesn't make sense
  - where:
      variant: ^CheckViaIdentity.*$|^CreateViaIdentity.*$
    remove: true
  # Remove the set-* cmdlet
  - where:
      verb: Set
    remove: true
  # Make "type" default to Microsoft.SpoolService/spools for checknameavailability
  - where:
      verb: Test
      parameter-name: Type
    set:
      default:
        name: Type default
        description: Type default
        script: '"Microsoft.SpoolService/spools"'
      completer:
        name: Type completer
        description: Type completer
        script: "Microsoft.SpoolService/spools"
```
