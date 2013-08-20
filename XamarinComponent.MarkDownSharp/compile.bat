@echo off
call "%PROGRAMFILES%\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"


rmdir /q /s .\bin\

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XA\MonoVersal.MarkDown.MarkDownSharp.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\bin

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XI\MonoVersal.MarkDown.MarkDownSharp.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\bin\

\

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XA\MonoVersal.MarkDown.MarkDownSharp.XA.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\lib\Release\Android\

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XA\MonoVersal.MarkDown.MarkDownSharp.XA.csproj ^
		/p:Configuration=Debug ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\lib\Debug\Android\

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XI\MonoVersal.MarkDown.MarkDownSharp.XI.csproj ^
		/p:Configuration=Release ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\lib\Release\iOS

msbuild ..\MonoVersal.MarkDown.MarkDownSharp.XI\MonoVersal.MarkDown.MarkDownSharp.XI.csproj ^
		/p:Configuration=Debug ^
		/property:OutDir=..\XamarinComponent.MarkDownSharp\content\lib\Debug\iOS\

@IF %ERRORLEVEL% NEQ 0 PAUSE	
