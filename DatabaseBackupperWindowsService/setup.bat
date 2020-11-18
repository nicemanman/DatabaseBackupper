@echo off

set "ServiceName=DatabaseBackupperService"
set "ServiceDisplayName=DatabaseBackupperService"
set "ServiceDescription=Background services host for database backupper app"



set "CurrentDir=%~dp0"
if "%CurrentDir:~-1%" == "\" (
    set "CurrentDir=%CurrentDir:~0,-1%"
)
pushd "%CurrentDir%"

echo  Please, make sure you run the script as Administrator
echo;

echo  ^> Installing service "%ServiceName%" with Name = "%ServiceDisplayName%"
echo;

rem https://support.microsoft.com/en-us/help/251192/how-to-create-a-windows-service-by-using-sc-exe

sc create "%ServiceName%" DisplayName= "%ServiceDisplayName%" start= auto binpath= "%CurrentDir%\Chronos.exe --service"

sc description "%ServiceName%" "%ServiceDescription%"
if not "%ErrorLevel%"=="0" goto :Finish

:Finish
echo;
pause
