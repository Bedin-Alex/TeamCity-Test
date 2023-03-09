write-host "Hello from git"
write-host "Im here:"
pwd
write-host "Making an artifact"
mkdir temp
"Hi. I'm an artifact and I was created at $(Get-Date -Format hh:mm)" | out-file .\temp\pretty-artifact.txt

write-host "Now I'm going to install cake"
dotnet new tool-manifest
dotnet tool install Cake.Tool --version 3.0.0