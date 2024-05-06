rm -rf publish

dotnet publish --self-contained -r win-x64 -c Release -o publish

cf push -f manifest-win.yml