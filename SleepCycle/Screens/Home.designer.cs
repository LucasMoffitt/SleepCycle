// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SleepCycle
{
	[Register ("Home")]
	partial class Home
	{
		[Outlet]
		MonoTouch.UIKit.UIDatePicker timeSelector { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelCurrentTime { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelHeader1 { get; set; }

		[Action ("WhatTimeShouldISleep:")]
		partial void WhatTimeShouldISleep (MonoTouch.Foundation.NSObject sender);

		[Action ("GoingToSleepNow:")]
		partial void GoingToSleepNow (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (timeSelector != null) {
				timeSelector.Dispose ();
				timeSelector = null;
			}

			if (labelCurrentTime != null) {
				labelCurrentTime.Dispose ();
				labelCurrentTime = null;
			}

			if (labelHeader1 != null) {
				labelHeader1.Dispose ();
				labelHeader1 = null;
			}
		}
	}
}
