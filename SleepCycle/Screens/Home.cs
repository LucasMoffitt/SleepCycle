
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace SleepCycle
{
	public partial class Home : UIViewController
	{
		public Home () : base ("Home", null)
		{
		}

		int cycleLength = 90;
		int timeForHumanSleep = 7;
		
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			labelCurrentTime.Text = DateTime.Now.TimeOfDay.ToString();

			this.NavigationController.NavigationBar.SetBackgroundImage(UIImage.FromFile("res/sleepcycle_navbar.png"), UIBarMetrics.Default);
			this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("res/sleepcycle_background.png"));	
		
			labelHeader1.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 26);
			labelHeader1.TextColor = UIColor.White;


		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();

			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		partial void WhatTimeShouldISleep (MonoTouch.Foundation.NSObject sender) {

			var wakeUpTime = DateTime.Parse (timeSelector.Date.ToString ());

			var youShouldSleepAt = wakeUpTime.AddMinutes (-6*cycleLength);

			var goToSleep = new GoToSleep(youShouldSleepAt);
			this.NavigationController.PushViewController(goToSleep, true);
		}

		partial void GoingToSleepNow (MonoTouch.Foundation.NSObject sender) {
		
			DateTime currentTime = DateTime.Now;

			var normalSleepTime = currentTime.AddMinutes(timeForHumanSleep);
			var suggestedWakeupTime = normalSleepTime.AddMinutes(6*90);
		
			var wakeUp = new WakeUp(suggestedWakeupTime);
			this.NavigationController.PushViewController(wakeUp, true);

		}

		public override void ViewWillAppear (bool animated) {
    		base.ViewWillAppear (animated);
    		//NavigationController.SetNavigationBarHidden (true, animated);
		}

		public override void ViewWillDisappear (bool animated) {
    		base.ViewWillDisappear (animated);
    		//NavigationController.SetNavigationBarHidden (false, animated);
		}

	}
}

