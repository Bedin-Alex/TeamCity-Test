write-host "Hello from git"
write-host "Im here:"
pwd
write-host "Making an artifact"
mkdir temp
"some text" | out-file .\temp\sample-file.txt