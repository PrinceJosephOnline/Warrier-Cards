using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WarrierCards.Website.Common
{
    public static class ExtensionMethods
    {
        public static string ToTitleCase(this string input)
        {
            string result = string.Empty;
            try
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                result = textInfo.ToTitleCase(input);
            }
            catch
            {
                // TODO: log and ignore this
            }

            return result;
        }
    }
}