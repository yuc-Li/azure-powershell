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
branch: f09aacf4c6b63be416212cb182f6b31e8bc6d545
require:
  - $(this-folder)/../../readme.azure.noprofile.md
  - $(repo)/specification/hdinsight/resource-manager/Microsoft.HDInsight/HDInsightOnAks/readme.md

# input-file:
#  - D:\source\azure-rest-api-specs\specification\hdinsight\resource-manager\Microsoft.HDInsight\HDInsightOnAks\preview\2023-06-01-preview\hdinsight.json
inlining-threshold: 100
```

> Names
``` yaml
module-version: 0.1.0
title: HdInsightOnAks
subject-prefix: "$(service-name)"
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
    where: $.paths..responses.202
    transform: delete $.headers
  - where:
      parameter-name: SubscriptionId
    set:
      default:
        name: SubscriptionId Default
        description: Gets the SubscriptionId from the current context.
        script: '(Get-AzContext).Subscription.Id'    
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
      model-name: ClusterPoolVersion
    set:
      suppress-format: true
  - where:
      model-name: ClusterPoolVersion
      property-name: PropertiesClusterPoolVersion
    set:
      property-name: ClusterPoolVersionValue
  - where:
      model-name: ClusterVersion
    set:
      suppress-format: true
  - where:
      model-name: ClusterVersion
      property-name: PropertiesClusterVersion
    set:
      property-name: ClusterVersionValue      
# the below is cmdlet part      
  - where:
      verb: New|Set
      subject: [Cluster|ClusterPool]
      parameter-name: LogAnalyticProfileEnabled
    set:
      parameter-name: EnableAzureMonitor
  - where:
      verb: New|Set
      subject: [Cluster|ClusterPool]
      parameter-name: LogAnalyticProfileWorkspaceId
    set:
      parameter-name: LogAnalyticWorkspaceResourceId
  - where:
      verb: New|Set
      subject: [Cluster|ClusterPool]
      parameter-name: NetworkProfileSubnetId
    set:
      parameter-name: SubnetId     
  - where:
      verb: New|Set
      subject: [ClusterPool]
      parameter-name: ClusterPoolProfileClusterPoolVersion
    set:
      parameter-name: ClusterPoolVersion
  - where:
      verb: New|Set
      subject: [ClusterPool]
      parameter-name: ComputeProfileVMSize
    set:
      parameter-name: VmSize
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
# The below customize the output model   

```
