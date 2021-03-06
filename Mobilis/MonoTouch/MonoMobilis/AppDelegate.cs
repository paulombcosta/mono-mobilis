using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Mobilis.Lib;
using Mobilis.Lib.Database;

namespace MonoMobilis
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		private UserDao userDao;
		private CourseDao courseDao;

		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			userDao = new UserDao ();
			courseDao = new CourseDao ();
			this.window = new UIWindow (UIScreen.MainScreen.Bounds);
			var rootNavigationController = new UINavigationController ();

			if (userDao.tokenExists () && courseDao.existCourses ()) 
			{
				CoursesViewController courseView = new CoursesViewController();
				rootNavigationController.PushViewController(courseView,false);
			} 
			else 
			{
				MonoMobilisViewController loginView = new MonoMobilisViewController();
				rootNavigationController.PushViewController(loginView,false);
			}

			//MonoMobilisViewController loginView = new MonoMobilisViewController();
			//rootNavigationController.PushViewController(loginView,false);

			this.window.RootViewController = rootNavigationController;
			this.window.MakeKeyAndVisible();
			ServiceLocator.Dispatcher = new DispatchAdapter(this);
			return true;
		}
	}
}

