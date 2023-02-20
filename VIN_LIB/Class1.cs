using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VIN_LIB
{
    public class Class1
    {
        private static char[] symbols = new char[] { 
            '0', '1', '2', '3', '4', '5', '6', '7', '8', 
            '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 
            'U','V', 'W', 'X', 'Y', 'Z' };

        public static bool CheckVIN(string vin)
        {
            if (vin.Length != 17)
            {
                return false;
            }

            for (int i = 0; i < 17; i++)
            {
                int count = 0;

                foreach (char item in symbols)
                {
                    count++;

                    if (vin[i] == item)
                    {
                        break;
                    }
                }

                if (count == symbols.Length && vin[i] != symbols[symbols.Length - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public static string GetVINCountry(string vin)
        {
            Regex Africa = new Regex(@"^[A-H]{1}");
            Regex Asia = new Regex(@"^[J-R]{1}");
            Regex Europe = new Regex(@"^[S-Z]{1}");
            Regex NorthernAmerica = new Regex(@"^[1-5]{1}");
            Regex Oceania = new Regex(@"^[6-7]{1}");
            Regex SouthAmerica = new Regex(@"^[8-9]{1}");
            for (int i = 0; i < symbols.Length; i++)
            {
                if (vin[0] == symbols[i])
                {
                    if (Africa.IsMatch(Convert.ToString(symbols[i])) == true)
                    {
                        return "Африка";
                    }
                    if (Asia.IsMatch(Convert.ToString(symbols[i])) == true)
                    {
                        return "Азия";
                    }
                    if (Europe.IsMatch(Convert.ToString(symbols[i])) == true)
                    {
                        return "Европа";
                    }
                    if (NorthernAmerica.IsMatch(Convert.ToString(symbols[i])) == true)
                    {
                        return "Северная Америка";
                    }
                    if (Oceania.IsMatch(Convert.ToString(symbols[i])) == true)
                    {
                        return "Океания";
                    }
                    if (SouthAmerica.IsMatch(Convert.ToString(symbols[i])) == true)
                    {
                        return "Южная Америка";
                    }
                }
            }

            return "Не найдено";
        }
    }
}
