# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create Trino Hive catalog option.
.Description
Create Trino Hive catalog option.
.Example
NA
.Outputs

.Link
#>
function New-AzHdInsightOnAksTrinoHiveCatalog{
    [OutputType([System.String])]
    [CmdletBinding(DefaultParameterSetName='Create', PositionalBinding=$false)]
    param{
        [Parameter(ParameterSetName='Create', Mandatory)]
        [System.String]
        ${CatalogName}
    }
    process{

        try{

            Write-Line "Test custom ps1 file."
        }
        catch{
            throw
        }
    }
}