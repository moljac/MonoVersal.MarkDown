using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#if __UNIFIED__
using UIKit;
using Foundation;
using CoreAnimation;
using CoreGraphics;
#else
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;

using System.Drawing;
using CGRect = global::System.Drawing.RectangleF;
using CGPoint = global::System.Drawing.PointF;
using CGSize = global::System.Drawing.SizeF;
#endif

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
		///		Xamarin.Android:
		///		http://stackoverflow.com/questions/10072513/reading-an-image-file-from-local-storage-on-mono-for-android
		///		http://stackoverflow.com/questions/8574076/monodroid-download-image-to-imageview
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		internal static CGBitmapContext FromFile(string str)
		{
			// Android.Graphics.Bitmap bitmap = 
			// 	Android.Graphics.BitmapFactory.DecodeStream(context.OpenFileInput(string));

			return default(MonoTouch.CoreGraphics.CGBitmapContext);
		}
	}
}
