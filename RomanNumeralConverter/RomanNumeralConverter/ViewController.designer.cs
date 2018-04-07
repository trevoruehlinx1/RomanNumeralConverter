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
        UIKit.UIButton ConvertButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NumberToConvert { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConvertButton != null) {
                ConvertButton.Dispose ();
                ConvertButton = null;
            }

            if (NumberToConvert != null) {
                NumberToConvert.Dispose ();
                NumberToConvert = null;
            }
        }
    }
}