// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RomanNumeralConverter
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AnswerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConvertDecimalButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ConvertToDecimal2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConvertToNumeralButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InputToConvertTextField { get; set; }

        [Action ("UIButton2341_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton2341_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AnswerLabel != null) {
                AnswerLabel.Dispose ();
                AnswerLabel = null;
            }

            if (ConvertDecimalButton != null) {
                ConvertDecimalButton.Dispose ();
                ConvertDecimalButton = null;
            }

            if (ConvertToDecimal2 != null) {
                ConvertToDecimal2.Dispose ();
                ConvertToDecimal2 = null;
            }

            if (ConvertToNumeralButton != null) {
                ConvertToNumeralButton.Dispose ();
                ConvertToNumeralButton = null;
            }

            if (InputToConvertTextField != null) {
                InputToConvertTextField.Dispose ();
                InputToConvertTextField = null;
            }
        }
    }
}