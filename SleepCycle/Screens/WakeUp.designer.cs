// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SleepCycle
{
	[Register ("WakeUp")]
	partial class WakeUp
	{
		[Outlet]
		MonoTouch.UIKit.UILabel labelWakeUpTime { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelHeader1 { get; set; }

		[Action ("ScheduleWakeUpReminder:")]
		partial void ScheduleWakeUpReminder (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (labelWakeUpTime != null) {
				labelWakeUpTime.Dispose ();
				labelWakeUpTime = null;
			}

			if (labelHeader1 != null) {
				labelHeader1.Dispose ();
				labelHeader1 = null;
			}
		}
	}
}
