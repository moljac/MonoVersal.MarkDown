
\samples\XSample.MarkDownSharp.XA
\samples\XSample.MarkDownSharp.XI
\samples\XSample.MarkDownSharp.XI-Classic
\samples\XSample.MarkDownSharp.XA\XSample.MarkDownSharp.XA
\samples\XSample.MarkDownSharp.XI\XSample.MarkDownSharp.XI
\samples\XSample.MarkDownSharp.XI\XSample.MarkDownSharp.XI-Classic
\samples\XSample.MarkDownSharp.XI-Classic\XSample.MarkDownSharp.XI-Classic



https://gist.github.com/newky2k/d03b4f51d474d8e54a0b

MT0030: The executable name (*) and the app name (*) are different, this may prevent crash 
logs from getting symbolicated properly.
When Xcode symbolicates (translates memory addresses to function names and file/line numbers) the 
process may fail if the executable and app have different names (without the extension).

To fix this either change 'Application Name' in the project's Build/iOS Application options, or 
change 'Assembly Name' in the project's Build/Output options.





error MT5210: Native linking failed, undefined symbol: 
    _mono_aot_module_MarkDownSharp_iOS_info. 
Please verify that all the necessary frameworks have been referenced and native libraries are 
properly linked in