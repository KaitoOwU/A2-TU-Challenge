using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string value = "";
            for(int j = 0; j <= 1; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == j)
                        value += input[i];
                }
            }
            
            return value;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input.Length == 0)
                return true;
            
            foreach(char c in input.ToCharArray())
            {
                if(c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        public static string MixString(string a, string b)
        {
            if(IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
            {
                throw new ArgumentException();
            }

            string value = "";
            for(int i = 0; i < (a.Length > b.Length ? a.Length : b.Length); i++)
            {
                value = value + (i >= a.Length ? "" : a[i]) + (i >= b.Length ? "" : b[i]);
            }
            return value;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string value = "";
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lower = "abcdefghijklmnopqrstuvwxyz";

            foreach (char ch in input.ToCharArray())
            {
                if (upper.Contains(ch))
                {
                    int index = upper.IndexOf(ch) + offset;
                    if (index > 25)
                        index -= 26;
                    value += upper[index];
                    continue;
                } else if (lower.Contains(ch))
                {
                    int index = lower.IndexOf(ch) + offset;
                    if (index > 25)
                        index -= 26;
                    value += lower[index];
                    continue;
                }
                value += ch;
            }
            return value;
        }

        public static string ToLowerCase(string a)
        {
            //CODE ASCII A MAJ = 65 A MIN = 97 DIFF = 32
            string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach(char ch in upper.ToCharArray())
            {
                a = a.Replace(ch, (char)(ch + 32))
                    .Replace('É', 'é')
                    .Replace('È', 'è')
                    .Replace('À', 'à')
                    .Replace('Ç', 'ç');
            }
            return a;
                
        }

        public static string UnBazardString(string input)
        {
            string value = "";
            int midValue = (input.Length + 1) / 2;
            for(int i = 0; i <= midValue - 1; i++)
            {
                value = value + input[i] + input[i + midValue];
            }
            return value;

        }

        public static string Voyelles(string a)
        {
            a = ToLowerCase(a);
            string value = "";
            string voyelle = "aeiouy";
            for(int i = 0; i<a.Length; i++)
            {
                if (voyelle.Contains(a[i]) && !value.Contains(a[i]))
                {
                    value += a[i];
                }
            }
            return value;
        }

        public static string Reverse(string a)
        {
            string value = "";
            for(int i = 0; i < a.Length ; i++)
            {
                value += a[a.Length - 1 - i];
            }
            return value;
        }


    }
}
