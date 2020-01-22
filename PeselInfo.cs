using System;
using System.Collections.Generic;
using System.Text;

namespace PeselChecker
{
    class PeselInfo
    {
        private string Pesel_Code;

        public PeselInfo()
        {
            Pesel_Code = string.Empty;
        }
        public PeselInfo(string pesel)
        {
            Pesel_Code = pesel;
        }

        public int GetDay()
        {
            return Convert.ToInt32(Pesel_Code.Substring(4, 2));
        }

        public int GetMonth()
        {
            string m = Pesel_Code.Substring(2, 2);
            int month = Convert.ToInt32(m);

            switch (GetCountry())
            {
                case 18: return month - 80;
                case 19: return month;
                case 20: return month - 20;
                case 21: return month - 40;
                default: return 0;
            }
        }

        public int GetYear()
        {
            string y = GetCountry().ToString() + Pesel_Code.Remove(2);
            return Convert.ToInt32(y);
        }

        public int GetCountry()
        {
            switch (Pesel_Code[2])
            {
                case '8': return Convert.ToInt32("18");
                case '9': return Convert.ToInt32("18");
                case '0': return Convert.ToInt32("19");
                case '1': return Convert.ToInt32("19");
                case '2': return Convert.ToInt32("20");
                case '3': return Convert.ToInt32("20");
                case '4': return Convert.ToInt32("21");
                case '5': return Convert.ToInt32("21");
                default: return 0;
            }
        }

        public string GetSex()
        {
            string p = Pesel_Code.ToString();

            if (p[9] % 2 == 0)
            {
                return "FEMALE";
            }
            else
            {
                return "MALE";
            }
        }

        public int GetCheckSum()
        {
            int a = Convert.ToInt32(Pesel_Code[0]);
            int b = Convert.ToInt32(Pesel_Code[1]);
            int c = Convert.ToInt32(Pesel_Code[2]);
            int d = Convert.ToInt32(Pesel_Code[3]);
            int e = Convert.ToInt32(Pesel_Code[4]);
            int f = Convert.ToInt32(Pesel_Code[5]);
            int g = Convert.ToInt32(Pesel_Code[6]);
            int h = Convert.ToInt32(Pesel_Code[7]);
            int i = Convert.ToInt32(Pesel_Code[9]);
            int j = Convert.ToInt32(Pesel_Code[10]);

            int sum = 9 * a + 7 * b + 3 * c + 1 * d + 9 * e + 7 * f + 3*g + 1 * h + 9 * i + 7 * j;
            //return sum % 10;
            return sum;
        }
    }
}
