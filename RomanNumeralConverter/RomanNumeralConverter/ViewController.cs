using System;

using UIKit;

namespace RomanNumeralConverter
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            string convertedNumber = "";
            ConvertButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                convertedNumber = NumberConverter.ToRomanNumeral(NumberToConvert.Text);

                // Dismiss the keyboard if text field was tapped
                NumberToConvert.ResignFirstResponder();
            };
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}