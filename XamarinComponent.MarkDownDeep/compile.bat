@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"


rmdir /q /s .\bin\
rmdir /q /s .\content\bin\
rmdir /q /s .\content\lib

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XA\MonoVersal.MarkDown.MarkDownDeep.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\bin\

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XI\MonoVersal.MarkDown.MarkDownDeep.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\bin\

echo ======================================================================================
echo creating references for component samples in content\lib
echo folders 
echo		lib\android 
echo and
echo 		lib\ios
echo are generated during xam packaging
echo only Release build is for component
echo ======================================================================================

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XA\MonoVersal.MarkDown.MarkDownDeep.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\lib\android

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XI\MonoVersal.MarkDown.MarkDownDeep.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\lib\ios


@IF %ERRORLEVEL% NEQ 0 PAUSE	
