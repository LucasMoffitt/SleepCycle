using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SleepCycle
{
	public partial class WakeUp : UIViewController
	{
		DateTime suggestedWakeUpTime;

		public WakeUp (DateTime suggestedWakeUpTime) : base ("WakeUp", null)
		{
			this.suggestedWakeUpTime = suggestedWakeUpTime;

		}
		
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
		
		public override void ViewDidLoad ()
		{
			this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("res/sleepcycle_background.png"));	
		
			labelHeader1.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 30);
			labelHeader1.TextColor = UIColor.White;

			labelWakeUpTime.Text = suggestedWakeUpTime.ToString();

			base.ViewDidLoad ();
		}

		partial void ScheduleWakeUpReminder (MonoTouch.Foundation.NSObject sender) {

			//Testing
			var tempreminder = DateTime.Now.AddSeconds (30);

			UILocalNotification notification = new UILocalNotification{
				FireDate = tempreminder,
  				TimeZone = NSTimeZone.LocalTimeZone,
  				AlertBody = "Yo Bitch! Wake UP!",
  				RepeatInterval = 0,
			};

			UIApplication.SharedApplication.ScheduleLocalNotification(notification);
			Console.WriteLine ("Notification Scheduled for: " + tempreminder.ToString ("hh:mm tt"));
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
	}
}

