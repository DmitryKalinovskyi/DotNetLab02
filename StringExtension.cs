using System;
using System.Text;

namespace DotNetLab2
{
    public static class StringExtension
    {
        public static int CountOccurence(this string s, char c)
        {
            int answer = 0;

            foreach(char ch in s) 
            {
                if (ch == c) answer++;
            }

            return answer;
        }

        public static string Invert(this string s)
        {
            StringBuilder reversed = new(s);

            for(int i = 0; i < s.Length / 2; i++)
            {
                char tmp = reversed[i];
                reversed[i] = reversed[s.Length - 1 - i];
                reversed[s.Length - 1 - i] = tmp;
            }

            return reversed.ToString();
        }
    }
}
