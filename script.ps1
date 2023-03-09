write-host "Hello from git"
write-host "Im here:"
pwd
write-host "Making an artifact"
mkdir temp
"Hi. I'm an artifact and I was created at $(Get-Date -Format hh:mm)" | out-file .\temp\pretty-artifact.txt
