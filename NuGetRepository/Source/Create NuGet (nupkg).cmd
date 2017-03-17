echo off
for %%f in (*.nupkg) do del %%f
for %%f in (*.nuspec) do NuGet pack %%f
for %%f in (*.nupkg) do move %%f ..
pause
