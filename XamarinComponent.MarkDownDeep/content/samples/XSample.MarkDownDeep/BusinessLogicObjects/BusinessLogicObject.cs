using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XSample.MarkDownDeep
{
	public partial class BusinessLogicObject 
	{
		public static MarkdownDeep.Markdown MarkDownEngine = null;

		public static string MarkDown = "";
		public static string MarkUpHTML = "";


		static BusinessLogicObject()
		{
			MarkDownEngine = new MarkdownDeep.Markdown();
		}
	}
}
