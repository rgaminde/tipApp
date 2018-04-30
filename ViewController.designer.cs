// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace tipApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField amt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton tipButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tot { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel totalBill { get; set; }

        [Action ("TipButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TipButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (amt != null) {
                amt.Dispose ();
                amt = null;
            }

            if (tipButton != null) {
                tipButton.Dispose ();
                tipButton = null;
            }

            if (tot != null) {
                tot.Dispose ();
                tot = null;
            }

            if (totalBill != null) {
                totalBill.Dispose ();
                totalBill = null;
            }
        }
    }
}