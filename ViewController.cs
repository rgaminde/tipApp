using System;

using UIKit;

namespace tipApp
{
    public partial class ViewController : UIViewController
    {
        partial void TipButton_TouchUpInside(UIButton sender)
        {
            
            double amount = Convert.ToDouble(amt.Text);
            double tip = amount * 0.10; 
            tot.Text = Convert.ToString(tip);
            totalBill.Text = Convert.ToString(tip + amount);

        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
