using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace RomanNumeralConverter
{
    public static class NumberConverter
    {
        public static string ToRomanNumeral(string numToConvert)
        {
            var convertedNumber = "";

            if (numToConvert == "1")
            {
                convertedNumber = "I";
            }
            else if (numToConvert == "2")
            {
                convertedNumber = "II";
            }
            else if (numToConvert == "3")
            {
                convertedNumber = "III";
            }
            else if (numToConvert == "4")
            {
                convertedNumber = "IV";
            }
            else if (numToConvert == "6")
            {
                convertedNumber = "VI";
            }
            else if (numToConvert == "7")
            {
                convertedNumber = "VII";
            }
            else if (numToConvert == "8")
            {
                convertedNumber = "VII";
            }
            else if (numToConvert == "9")
            {
                convertedNumber = "IX";
            }
            else if (numToConvert == "10")
            {
                convertedNumber = "X";
            }
            else
            {
                convertedNumber = "Number must be between 1 and 10";
            }
            return convertedNumber;
        }
    }
}