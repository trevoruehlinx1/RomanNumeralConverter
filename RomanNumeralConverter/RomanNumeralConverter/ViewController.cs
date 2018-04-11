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
            ConvertToNumeralButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                InputToConvertTextField.Text = "";
                int intToConvert;
                Int32.TryParse(InputToConvertTextField.Text, out intToConvert );
                convertedNumber = NumberConverter.ToRomanNumeral(intToConvert);
                AnswerLabel.Text = convertedNumber.ToString();
                // Dismiss the keyboard if text field was tapped
                InputToConvertTextField.ResignFirstResponder();
            };
            // Perform any additional setup after loading the view, typically from a nib.
        }
        //public void ConvertToDecimalButton_TouchUpInside(UIButton sender)
        //{
        //    string convertedNumeral = "";
        //    string NumeralToConvert = NumeralToConvertTextField.Text;
        //    convertedNumeral = NumberConverter.ToDecimal(NumeralToConvert);
        //    AnswerLabel.Text = convertedNumeral;
        //    NumeralToConvertTextField.ResignFirstResponder();
        //}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton2341_TouchUpInside(UIButton sender)
        {
            InputToConvertTextField.Text = "";
            string convertedNumeral = "";
            string NumeralToConvert = InputToConvertTextField.Text;
            convertedNumeral = NumberConverter.ToDecimal(NumeralToConvert);
            AnswerLabel.Text = convertedNumeral;

            InputToConvertTextField.ResignFirstResponder();
        }
    }
}