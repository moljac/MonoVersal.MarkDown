using System;

#if __UNIFIED__
#else
using nint=System.Int32;
#endif

namespace MarkdownDeep
{
	public class ImageInfo
	{
		public string url;
		public bool titled_image;
		public nint width;
		public nint height;
	}
}

