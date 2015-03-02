using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if __UNIFIED__
#else
using nint=System.Int32;
#endif

namespace MarkdownDeep
{
	public partial class Markdown
	{
		private void PatchSystemDrawingImageFromFile(ref nint width, ref nint height, string str)
		{
			/// HolisticWare Recommendations (Style guides) do not recommend implicit types
			/// (for readability), but this is excellent sample where it is allowed, because
			/// each platform returns different object!
			var img = System.Drawing.Image.FromFile(str);


			width = img.Width;
			height = img.Height;

			if (MaxImageWidth != 0 && width > MaxImageWidth)
			{
				height = (int)((double)height * (double)MaxImageWidth / (double)width);
				width = MaxImageWidth;
			}
		}
	}
}
