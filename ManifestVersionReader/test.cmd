echo off
for /f %%i in ('ManifestVersionReader.exe "C:\Users\Matti\Documents\Visual Studio 2017\Projects\DrroidApp\DrroidApp\Properties\AndroidManifest.xml"') do set VAR=%%i
echo %VAR%