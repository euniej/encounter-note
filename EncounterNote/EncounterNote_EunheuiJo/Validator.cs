using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EncounterNote_EunheuiJo
{
    public static class Validator
    {
        private static string title = "Entry Error";
        public static string Title
        {
            get => title;
            set => title = value;
        }

        public static bool IsPresent(String text)
        {
            if (text == "")
            {
                return false;
            }
            return true;
        }

        public static bool IsFuture(DateTime date)
        {
            return date > DateTime.Now;
        }


    }
}
