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
        public static string ToRomanNumeral(int numToConvert)
        {

            string[] romanNumerals = { "0", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };

            var convertedNumber = "";
            if(numToConvert < 11 && numToConvert > 0)
            {
                convertedNumber = romanNumerals[numToConvert];
            }
            else
            {
                convertedNumber = "Must be between 1 and 10";
            }
            return convertedNumber.ToString();
        }
        public static string ToDecimal(string RomanNumeralToConvert)
        {
            string numeralToConvert = RomanNumeralToConvert.ToUpper();
            string convertedNumeral = "";
            switch(numeralToConvert)
            {
                case "I":
                    convertedNumeral = 1.ToString();
                    break;
                case "II":
                    convertedNumeral = 2.ToString();
                    break;
                case "III":
                    convertedNumeral = 3.ToString();
                    break;
                case "IV":
                    convertedNumeral = 4.ToString();
                    break;
                case "V":
                    convertedNumeral = 5.ToString();
                    break;
                case "VI":
                    convertedNumeral = 6.ToString();
                    break;
                case "VII":
                    convertedNumeral = 7.ToString();
                    break;
                case "VIII":
                    convertedNumeral = 8.ToString();
                    break;
                case "IX":
                    convertedNumeral = 9.ToString();
                    break;
                case "X":
                    convertedNumeral = 10.ToString();
                    break;
                default:
                    convertedNumeral = "Must be between I and X";
                    break;
            }
            return convertedNumeral;
        }
    }
}