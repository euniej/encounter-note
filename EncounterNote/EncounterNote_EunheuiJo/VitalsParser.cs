using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace EncounterNote_EunheuiJo
{
    internal class VitalsParser
    {

        public const string BP = "BP";
        public const string HR = "HR";
        public const string RR = "RR";
        public const string T = "T";

        public string BloodPressure { get; set; }
        public string HeartRate { get; set; }
        public string RespirationRate { get; set; }
        public string Temperature { get; set; }

        public string ParsingResults { get; set; }

        public void ParsingVitals(RichTextBox notes)
        {
            ParsingResults = string.Empty;

            using (StringReader sr = new StringReader(notes.Text))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    BloodPressure = GetBloodPressure(line);
                    HeartRate = GetHeartRate(line);
                    RespirationRate = GetRespirationRate(line);
                    Temperature = GetTemperature(line);

                    if (BloodPressure != string.Empty)
                    {
                        ParsingResults += "BP: " + BloodPressure + " mmHg" + CheckValue(BloodPressure, BP)+";";
                    }

                    if (HeartRate != string.Empty)
                    {
                        ParsingResults += "HR: " + HeartRate + " bpm" + CheckValue(HeartRate, HR) + ";";
                    }

                    if (RespirationRate != string.Empty)
                    {
                        ParsingResults += "RR: " + RespirationRate + " breaths per minute" + CheckValue(RespirationRate, RR) + ";";

                    }

                    if (Temperature != string.Empty)
                    {
                        ParsingResults += "T: " + string.Format("{0}°C", Temperature)  + CheckValue(Temperature, T) + ";";

                    }
                }
            }
        }

        public string GetReulst()
        {
            return string.Empty;
        }

        public string GetBloodPressure(string note)
        {
            string result = "";
            var pattern = @"BP:?\s?\d{2,3}\/\d{2,3}";
            var match = Regex.Match(note, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                result = match.Value.Replace(BP, "").Replace(":","");
            }
            return result;
        }

        public string GetHeartRate(string note)
        {
            string result = "";
            var pattern = @"HR:?\s?\d{2,3}";

            var match = Regex.Match(note, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                result = match.Value.Replace(HR, "").Replace(":", "");
            }
            return result;
        }

        public string GetRespirationRate(string note)
        {
            string result = "";
            var pattern = @"RR:?\s?\d{2,3}";

            var match = Regex.Match(note, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                result = match.Value.Replace(RR, "").Replace(":", "");
            }
            return result;
        }
        public string GetTemperature(string note)
        {
            string result = "";
            var pattern = @"T:?\s?[0-9]{2}([.,][0-9]{1,3})?";

            var match = Regex.Match(note, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                result = match.Value.Replace(T, "").Replace(":", "");
            }
            return result;
        }

        public string CheckValue(string value, string type)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(value)) return result;

            switch (type)
            {
                case BP:
                    string[] bp = value.Split('/');
                    if ((Convert.ToInt64(bp[0]) <= 90) && (Convert.ToInt64(bp[1]) <= 60))
                    {
                        result = "(Low)";
                    }
                    else if ((Convert.ToInt64(bp[0]) >= 130) && (Convert.ToInt64(bp[1]) >= 80))
                    {
                        result = "(High)";
                    }
                    break;
                case HR:
                    if ((Convert.ToInt64(value) <= 100) && (Convert.ToInt64(value) >= 60))
                    {
                        result = "(Normal)";
                    }
                    break;
                case RR:
                    if ((Convert.ToInt64(value) <= 16) && (Convert.ToInt64(value) >= 12))
                    {
                        result = "(Normal)";
                    }
                    break;
                case T:
                    if ((Convert.ToDouble(value) >= 36.5) && (Convert.ToDouble(value) <= 37.2))
                    {
                        result = "(Normal)";
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

}
