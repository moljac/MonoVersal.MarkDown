using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkdownDeep
{
	public partial class Markdown
	{
		private void PatchSystemDrawingImageFromFile(ref int width, ref int height, string str)
		{
			/// HolisticWare Recommendations (Style guides) do not recommend implicit types
			/// (for readability), but this is excellent sample where it is allowed, because
			/// each platform returns different object!
			var img = System.Drawing.Image.FromFile(str);


			width = img.PixelWidth;
			height = img.PixelHeight;

			if (MaxImageWidth != 0 && width > MaxImageWidth)
			{
				height = (int)((double)height * (double)MaxImageWidth / (double)width);
				width = MaxImageWidth;
			}
		}
	}
}
