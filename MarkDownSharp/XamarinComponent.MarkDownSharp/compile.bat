@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"


rmdir /q /s .\bin\
rmdir /q /s .\content\bin\
rmdir /q /s .\content\lib

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XA\MonoVersal.MarkDown.MarkDownSharp.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\bin\

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XI\MonoVersal.MarkDown.MarkDownSharp.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\bin\

echo ======================================================================================
echo creating references for component samples in content\lib
echo folders 
echo		lib\android 
echo and
echo 		lib\ios
echo are generated during xam packaging
echo only Release build is for component
echo ======================================================================================

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XA\MonoVersal.MarkDown.MarkDownSharp.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\lib\android

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XI\MonoVersal.MarkDown.MarkDownSharp.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\lib\ios


@IF %ERRORLEVEL% NEQ 0 PAUSE	
