using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SleepCycle
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			var rootNavigationController = new UINavigationController();

			Home home = new Home();
			rootNavigationController.PushViewController(home, false);
			window.RootViewController = rootNavigationController;
			window.MakeKeyAndVisible ();

			UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.BlackOpaque, true);
			return true;
		}

		public override void ReceivedLocalNotification (UIApplication application, UILocalNotification notification)
		{
			Console.WriteLine(notification.AlertBody);
		}
	}
}

