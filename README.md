# Cyber Ark Test Application

## Description
* This is a sample app of testing the CyberArk buildpack on Tanzu Application Service


## Deploying to Linux
* Deploys to `https://cyberark-linux-test.apps.{tas-domain}`
```bash
./deploy-linux.sh
```


## Deploying to Windows
* Deploys to `https://cyberark-windows-test.apps.{tas-domain}`
```bash
./deploy-windows.sh
```

## Testing
* This application has [Steeltoe Management Endpoints](https://docs.steeltoe.io/api/v3/management/using-endpoints.html) enabled
* The `/actuator/env` endpoint included in this will dump out all environment variables, including the ones supplied by the cyberark buildpack