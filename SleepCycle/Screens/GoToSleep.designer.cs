// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace SleepCycle
{
	[Register ("GoToSleep")]
	partial class GoToSleep
	{
		[Outlet]
		MonoTouch.UIKit.UILabel labelSuggestedTimeToSleep { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel label5Cycles { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel label4Cycles { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel label3Cycles { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel label2Cycles { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel labelHeader1 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView imageTable { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (labelSuggestedTimeToSleep != null) {
				labelSuggestedTimeToSleep.Dispose ();
				labelSuggestedTimeToSleep = null;
			}

			if (label5Cycles != null) {
				label5Cycles.Dispose ();
				label5Cycles = null;
			}

			if (label4Cycles != null) {
				label4Cycles.Dispose ();
				label4Cycles = null;
			}

			if (label3Cycles != null) {
				label3Cycles.Dispose ();
				label3Cycles = null;
			}

			if (label2Cycles != null) {
				label2Cycles.Dispose ();
				label2Cycles = null;
			}

			if (labelHeader1 != null) {
				labelHeader1.Dispose ();
				labelHeader1 = null;
			}

			if (imageTable != null) {
				imageTable.Dispose ();
				imageTable = null;
			}
		}
	}
}
