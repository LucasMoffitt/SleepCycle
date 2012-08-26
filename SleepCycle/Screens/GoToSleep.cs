
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SleepCycle
{
	public partial class GoToSleep : UIViewController
	{
		int cycleLength = 90;
		DateTime suggestedTimeToSleep;

		public GoToSleep (DateTime suggestedTimeToSleep) : base ("GoToSleep", null)
		{
			this.suggestedTimeToSleep = suggestedTimeToSleep;
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
		
		public override void ViewDidLoad ()
		{

			base.ViewDidLoad ();

			labelHeader1.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 30);
			labelHeader1.TextColor = UIColor.White;
			this.View.BackgroundColor = UIColor.FromPatternImage(UIImage.FromFile("res/sleepcycle_background.png"));	

			imageTable.Image = UIImage.FromFile("res/sleepcycle_times.png");
			this.View.SendSubviewToBack(imageTable);

			labelSuggestedTimeToSleep.Text = suggestedTimeToSleep.ToString ("hh:mm tt");
			labelSuggestedTimeToSleep.TextColor = UIColor.FromRGB(70, 202, 90);
			labelSuggestedTimeToSleep.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 42);

			label5Cycles.Text = (suggestedTimeToSleep.AddMinutes(cycleLength)).ToString ("hh:mm tt");
			label5Cycles.TextColor = UIColor.FromRGB(145, 215, 110);
			label5Cycles.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 42);

			label4Cycles.Text = (suggestedTimeToSleep.AddMinutes(cycleLength*2)).ToString("hh:mm tt");
			label4Cycles.TextColor = UIColor.FromRGB(244, 239, 94);
			label4Cycles.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 42);

			label3Cycles.Text = (suggestedTimeToSleep.AddMinutes(cycleLength*3)).ToString("hh:mm tt");
			label3Cycles.TextColor = UIColor.White;
			label3Cycles.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 42);

			label2Cycles.Text = (suggestedTimeToSleep.AddMinutes(cycleLength*4)).ToString ("hh:mm tt");
			label2Cycles.TextColor = UIColor.White;
			label2Cycles.Font = UIFont.FromName("Univers LT 59 UltraCondensed", 42);

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

