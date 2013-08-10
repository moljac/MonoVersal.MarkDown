using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Drawing
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
		internal static System.Windows.Media.Imaging.BitmapImage FromFile(string str)
		{
			System.Windows.Media.Imaging.BitmapImage image = null;

			return default(System.Windows.Media.Imaging.BitmapImage);
		}
	}
}
