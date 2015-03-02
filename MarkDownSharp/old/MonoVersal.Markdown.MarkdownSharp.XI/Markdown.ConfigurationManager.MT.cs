﻿/*
 * MarkdownSharp
 * -------------
 * a C# Markdown processor
 * 
 * Markdown is a text-to-HTML conversion tool for web writers
 * Copyright (c) 2004 John Gruber
 * http://daringfireball.net/projects/markdown/
 * 
 * Markdown.NET
 * Copyright (c) 2004-2009 Milan Negovan
 * http://www.aspnetresources.com
 * http://aspnetresources.com/blog/markdown_announced.aspx
 * 
 * MarkdownSharp
 * Copyright (c) 2009-2011 Jeff Atwood
 * http://stackoverflow.com
 * http://www.codinghorror.com/blog/
 * http://code.google.com/p/markdownsharp/
 * 
 * History: Milan ported the Markdown processor to C#. He granted license to me so I can open source it
 * and let the community contribute to and improve MarkdownSharp.
 * 
 */

#region Copyright and license

/*

Copyright (c) 2009 - 2010 Jeff Atwood

http://www.opensource.org/licenses/mit-license.php
  
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.

Copyright (c) 2003-2004 John Gruber
<http://daringfireball.net/>   
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are
met:

* Redistributions of source code must retain the above copyright notice,
  this list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright
  notice, this list of conditions and the following disclaimer in the
  documentation and/or other materials provided with the distribution.

* Neither the name "Markdown" nor the names of its contributors may
  be used to endorse or promote products derived from this software
  without specific prior written permission.

This software is provided by the copyright holders and contributors "as
is" and any express or implied warranties, including, but not limited
to, the implied warranties of merchantability and fitness for a
particular purpose are disclaimed. In no event shall the copyright owner
or contributors be liable for any direct, indirect, incidental, special,
exemplary, or consequential damages (including, but not limited to,
procurement of substitute goods or services; loss of use, data, or
profits; or business interruption) however caused and on any theory of
liability, whether in contract, strict liability, or tort (including
negligence or otherwise) arising in any way out of the use of this
software, even if advised of the possibility of such damage.
*/

#endregion

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Text.RegularExpressions;

namespace MarkdownSharp
{
	/// <summary>
	/// Markdown is a text-to-HTML conversion tool for web writers. 
	/// Markdown allows you to write using an easy-to-read, easy-to-write plain text format, 
	/// then convert it to structurally valid XHTML (or HTML).
	/// </summary>
	public partial class Markdown
	{
		private void ConfigurationManagerAppSettings()
		{
			/*
			 * TODO: LoadSettings!
			  
			var settings = ConfigurationManager.AppSettings;
			foreach (string key in settings.Keys)
			{
				switch (key)
				{
					case "Markdown.AutoHyperlink":
						_autoHyperlink = Convert.ToBoolean(settings[key]);
						break;
					case "Markdown.AutoNewlines":
						_autoNewlines = Convert.ToBoolean(settings[key]);
						break;
					case "Markdown.EmptyElementSuffix":
						_emptyElementSuffix = settings[key];
						break;
					case "Markdown.EncodeProblemUrlCharacters":
						_encodeProblemUrlCharacters = Convert.ToBoolean(settings[key]);
						break;
					case "Markdown.LinkEmails":
						_linkEmails = Convert.ToBoolean(settings[key]);
						break;
					case "Markdown.StrictBoldItalic":
						_strictBoldItalic = Convert.ToBoolean(settings[key]);
						break;
				}
			}
			 * 
			 */

			return;
		}

	}
}