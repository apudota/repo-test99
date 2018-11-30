#
# Script.ps1

Add-PSSnapin WDeplosnap3.0

$package = "C:\Users\Apudota\Documents\GitAzureRepo\DLAP ACH\WCFDeploy\WCFService.zip"

Restore-WDPackage -Package $package 