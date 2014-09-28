#!/bin/bash

MONO=mono
XPKG=sbin/xpkg/xpkg.exe
RAKE=rake


:: rake downloads xpkg and runs:

set PACKAGE=HolisticWare-SharpSerializer
cd SharpSerializer

%MONO% \
	%XPKG% \
	create %PACKAGE%-1.0.xam \
	--name="HolisticWare SharpSerializer component" \
	--summary="%PACKAGE% ported and packaged by HolisticWare" \
	--publisher="HolisticWare LLC" \
	--website="http://holisticware.net/" \
	--details="content/Details.md" \
	--license="content/License.md" \
	--getting-started="content/GettingStarted.md" \
	--icon="content/icons/%PACKAGE%_128x128.png" \
	--icon="content/icons/%PACKAGE%_512x512.png" \
	--library="ios":"content/bin/%PACKAGE%.iOS.dll" \
	--library="android":"content/bin/%PACKAGE%.Android.dll" \
	--sample="iOS Sample. Demonstrates Awesomeness on iOS.":"content/samples/Awesome.iOS.sln" \
	--sample="Android Sample. Demonstrates Awesomeness on Android":"content/samples/Awesome.Android.sln"

