using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkdownDeep
{
	public partial class Image
	{
		/// <summary>
		/// Platforms:
		///		desktop (client profile) + web:		
		///			System.Drawing.Image
		///			http://msdn.microsoft.com/en-us/library/system.drawing.image.fromfile.aspx
		///			http://msdn.microsoft.com/en-us/library/System.Drawing.Image.aspx
		///			Bitmap : Image
		///			
		///		silverlight (RIA + Windows Phone):	
		///			System.Windows.Controls.Image
		///			System.Windows.Media.Imaging.BitmapImage
		///		http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.bitmapimage(v=vs.95).aspx
		///		BitmapImage : BitmapSource : ImageSource
		///		
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		internal static object FromFile(string str)
		{
			global::System.Drawing.Image.FromFile(
		}
	}
}
