$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Test-AzSpoolNameAvailability.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

# Disabled until checknameavailability is supported. Currently blocked on RPaaS support.
Describe 'Test-AzSpoolNameAvailability' {
    It 'CheckExpanded' -skip {
        Test-AzSpoolNameAvailability -Name $env.testSpool1 -Location $env.location | Should -BeFalse
        Test-AzSpoolNameAvailability -Name $env.testSpoolNameAvailable -Location $env.location  | Should -BeTrue
    }
}
