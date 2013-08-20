@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"


rmdir /q /s .\bin\

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XA\MonoVersal.MarkDown.MarkDownDeep.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\bin\

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XI\MonoVersal.MarkDown.MarkDownDeep.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\bin\



msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XA\MonoVersal.MarkDown.MarkDownDeep.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\lib\Release\Android\

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XA\MonoVersal.MarkDown.MarkDownDeep.XA.csproj ^
		/p:Configuration=Debug ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\lib\Debug\Android\

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XI\MonoVersal.MarkDown.MarkDownDeep.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\lib\Release\iOS

msbuild ..\MonoVersal.MarkDown.MarkDownDeep.XI\MonoVersal.MarkDown.MarkDownDeep.XI.csproj ^
		/p:Configuration=Debug ^
		/property:OutDir=..\XamarinComponent.MarkDownDeep\content\lib\Debug\iOS\

@IF %ERRORLEVEL% NEQ 0 PAUSE	
