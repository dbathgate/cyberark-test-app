# Cyber Ark Test Application

## Description
* This is a sample app of testing the CyberArk buildpack on Tanzu Application Service

## Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) Installed
* [CF CLI](https://github.com/cloudfoundry/cli/releases) installed and authenticated to TAS with desired target org/space

## Deploying to Linux
* Deploys to `https://cyberark-linux-test.apps.{tas-domain}`
```bash
# Unix
./deploy-linux.sh

# Windows (Powershell)
./deploy-linux.ps1
```


## Deploying to Windows
* Deploys to `https://cyberark-windows-test.apps.{tas-domain}`
```bash
# Unix
./deploy-windows.sh

# Windows (Powershell)
./deploy-windows.ps1
```

## Testing
* This application has [Steeltoe Management Endpoints](https://docs.steeltoe.io/api/v3/management/using-endpoints.html) enabled
* The `/actuator/env` endpoint included in this will dump out all environment variables, including the ones supplied by the cyberark buildpack