// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace MonoMobilis
{
	[Register ("MonoMobilisViewController")]
	partial class MonoMobilisViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextField login { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField password { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton submit { get; set; }

		[Action ("actionSubmit:")]
		partial void actionSubmit (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (login != null) {
				login.Dispose ();
				login = null;
			}

			if (password != null) {
				password.Dispose ();
				password = null;
			}

			if (submit != null) {
				submit.Dispose ();
				submit = null;
			}
		}
	}
}
