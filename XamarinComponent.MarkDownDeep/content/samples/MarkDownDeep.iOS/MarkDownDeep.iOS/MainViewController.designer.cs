// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MarkDownDeep.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonMarkUp { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView textViewMarkDown { get; set; }

		[Action ("showInfo:")]
		partial void showInfo (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (textViewMarkDown != null) {
				textViewMarkDown.Dispose ();
				textViewMarkDown = null;
			}

			if (buttonMarkUp != null) {
				buttonMarkUp.Dispose ();
				buttonMarkUp = null;
			}
		}
	}
}
