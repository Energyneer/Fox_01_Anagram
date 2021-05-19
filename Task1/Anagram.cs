using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Anagram
    {
        public static string Reverse(string inputLine)
        {
            try
            {
                string[] arr = inputLine.Split(" ");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = ReverseWord(arr[i]);
                }
                return String.Join(' ', arr);
            }
            catch
            {
                return "";
            }
        }

        static string ReverseWord(string source)
        {
            char[] dest = source.ToCharArray();
            char[] src = source.ToCharArray();

            for (int i = 0, endIndex = src.Length - 1; i < src.Length; i++)
            {
                if (char.IsLetter(src[i]))
                {
                    //Console.WriteLine("letter: " + src[i]);
                    for (int j = endIndex; j >= 0; j--)
                    {
                        //Console.WriteLine(">> " + src[k]);
                        if (Char.IsLetter(src[j]))
                        {
                            dest[i] = src[j];
                            endIndex = j - 1;
                            break;
                        }
                    }
                }
            }
            return new string(dest);
        }
    }
}
