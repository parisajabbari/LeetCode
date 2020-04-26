using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Hello";
            ReverseString(input.ToCharArray());
        }

        public static void ReverseString(char[] s)
        {
            string output = "";
             char[] ArrOutput;
            for (int i = s.Length -1; i >=0 ; i--)
            {
                output += s[i];               
            }
            s = output.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
