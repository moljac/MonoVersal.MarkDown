using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XSample.MarkDownDeep.XI
{
	public partial class MarkUpController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public MarkUpController()
			: base (UserInterfaceIdiomIsPhone ? "MarkUpController_iPhone" : "MarkUpController_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.

			webViewMarkUp.LoadHtmlString(BusinessLogicObject.MarkUpHTML, null);

			return;
		}
		
		
		public override void ViewWillAppear (bool animated)
		{        
		}

		void HandleTouchUpInside (object sender, EventArgs e)
		{
			//this.DismissViewController(true, Aa);
			this.NavigationController.PopViewControllerAnimated(true);
			
			return;
		}
		
		public void Aa()
		{
		
		}
	}
}

