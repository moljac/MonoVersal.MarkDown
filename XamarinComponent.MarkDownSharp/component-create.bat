:: component-create.bat
@echo off
setlocal ENABLEDELAYEDEXPANSION

set MONO="%PROGRAMFILES%\Mono-3.0.9\bin\mono.exe"
::set XPKG=sbin\xpkg\xpkg.exe
set XPKG=sbin\xpkg\xamarin-component.exe
set RAKE=C:\bin\Ruby200\bin\rake

:: rake downloads xpkg and runs:

set PACKAGE=MarkDownSharp

DEL /Q *.xam *.xam.zip

call .\compile.bat
dir /s .\content\bin\*.dll
dir /s .\content\lib\

pause


%MONO% ^
	%XPKG% ^
	create-manually ^
	%PACKAGE%-1.0.xam ^
	--name="MarkDownSharp" ^
	--summary="MarkDownSharp Xamarin component by TopTenSoftware ported by HolisticWare" ^
	--publisher="HolisticWare LLC" ^
	--website="http://holisticware.net/" ^
	--details="content/Details.md" ^
	--license="content/License.md" ^
	--getting-started="content/GettingStarted.md" ^
	--icon="content/icons/%PACKAGE%_128x128.png" ^
	--icon="content/icons/%PACKAGE%_512x512.png" ^
	--library="ios":"content/bin/%PACKAGE%.iOS.dll" ^
	--sample="Sample for iOS. %PACKAGE% sample for iOS.":"content/samples/%PACKAGE%.iOS/%PACKAGE%.iOS.sln" ^
	--library="android":"content/bin/%PACKAGE%.Android.dll" ^
	--sample="Sample for Android. %PACKAGE% sample for Android.":"content/samples/%PACKAGE%.Android/%PACKAGE%.Android.sln"
	

@IF %ERRORLEVEL% NEQ 0 PAUSE