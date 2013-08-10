using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XSample.MarkDownDeep.XA
{
	[Activity(Label = "XSample.MarkDownDeep.XA")]
	public class ActivityMarkUp : Activity
	{
		String html = "<html><body>Hello, World!</body></html>";
		String mime = "text/html";
		String encoding = "utf-8";

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.MarkUp);

			// Get our buttonTransform from the layout resource,
			// and attach an event to it
			Button		buttonTransform = FindViewById<Button>(Resource.Id.Transform);
			Android.Webkit.WebView browser = FindViewById<Android.Webkit.WebView>(Resource.Id.webView1);
			browser.LoadData(BusinessLogicObject.MarkUpHTML, mime, encoding);

			buttonTransform.Click += new EventHandler(buttonTransform_Click);
		}

		void buttonTransform_Click(object sender, EventArgs e)
		{
			this.Finish();

			return;
		}
	}
}

