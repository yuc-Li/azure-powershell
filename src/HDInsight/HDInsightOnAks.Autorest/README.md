<!-- region Generated -->
# Az.HdInsightOnAks
This directory contains the PowerShell module for the HdInsightOnAks service.

---
## Status
[![Az.HdInsightOnAks](https://img.shields.io/powershellgallery/v/Az.HdInsightOnAks.svg?style=flat-square&label=Az.HdInsightOnAks "Az.HdInsightOnAks")](https://www.powershellgallery.com/packages/Az.HdInsightOnAks/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.7.5 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.HdInsightOnAks`, see [how-to.md](how-to.md).
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
> `autorest`

---
### AutoRest Configuration
> see https://aka.ms/autorest

### General settings
> Values
``` yaml
require:
  - $(this-folder)/../../readme.azure.noprofile.md
input-file:
  - D:\source\azure-rest-api-specs\specification\hdinsight\resource-manager\Microsoft.HDInsight\HDInsightOnAks\preview\2023-06-01-preview\hdinsight.json
inlining-threshold: 100
```

> Names
``` yaml
module-version: 0.2.0
title: HdInsightOnAks
subject-prefix: "$(service-name)"
directive:
  - from: D:\source\azure-rest-api-specs\specification\hdinsight\resource-manager\Microsoft.HDInsight\HDInsightOnAks\preview\2023-06-01-preview\hdinsight.json
    where: $..responses.202
    transform: delete $.headers

```

> Exclude some properties in table view
``` yaml
# For a specific module, we could override this configuration by setting default-exclude-tableview-properties to false in readme.md of that module.
default-exclude-tableview-properties: true
```

> Directives
``` yaml
identity-correction-for-post: true
directive:
  - from: swagger-document
    where: $..responses.202
    transform: delete $.headers
  - where:
      model-name: ClusterPoolListResult
    set:
      suppress-format: true
  - where:
      model-name: ClusterPool
    set:
      suppress-format: true
  - where:
      model-name: Cluster
    set:
      suppress-format: true
  - where:
      model-name: ClusterInstanceViewResult
    set:
      suppress-format: true
  - where:
      model-name: ClusterOfferingVersions
    set:
      suppress-format: true
  - where:
      model-name: ClusterServiceConfig
    set:
      suppress-format: true
  - where:
      verb: New
      subject: [Cluster|ClusterPool]
      parameter-name: LogAnalyticProfileEnabled
    set:
      parameter-name: EnableAzureMonitor
  - where:
      verb: New
      subject: [Cluster|ClusterPool]
      parameter-name: LogAnalyticProfileWorkspaceId
    set:
      parameter-name: LogAnalyticWorkspaceResourceId
  - where:
      verb: New
      subject: [Cluster]
      parameter-name: ComputeProfileCount
    set:
      parameter-name: ClusterNodeCount
  - where:
      verb: New
      subject: [Cluster]
      parameter-name: ComputeProfileVMSize
    set:
      parameter-name: ClusterNodeSize
  - where:
      verb: New
      subject: Cluster
      parameter-name: (^AuthorizationProfile)(.*)
    set:
      parameter-name: Authorization$2
  - where:
      verb: New
      subject: [Cluster]
      parameter-name: (^ClusterProfile)(.*)
    set:
      parameter-name: $2

```
