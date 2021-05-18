using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] result = Reverse(inputLine);
            StringBuilder builder = new StringBuilder();
            foreach (string line in result)
            {
                if (line.Length < 1)
                    builder.Append(" ");

                builder.Append(line);
            }
            Console.WriteLine(">>>" + builder.ToString());
        }

        static string[] Reverse(string inputLine)
        {
            string[] arr = inputLine.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine(i + "\t>" + arr[i] + "\t>>" + ReverseWord(arr[i]));
                arr[i] = ReverseWord(arr[i]);
            }
            return arr;
        }

        static string ReverseWord(string source)
        {
            if (source == null)
                return "";

            char[] dest = source.ToCharArray();

            //Regex regex = new Regex("[^A-Za-zА-Яа-я]");
            //char[] lettersOnly = regex.Replace(source, "").ToCharArray();

            char[] src = source.ToCharArray();

            for (int i = 0, j = src.Length - 1; i < src.Length; i++)
            {
                if (Char.IsLetter(src[i]))
                {
                    Console.WriteLine("letter: " + src[i]);
                    for (int k = j; k >= 0; k--)
                    {
                        Console.WriteLine(">> " + src[k]);
                        if (Char.IsLetter(src[k]))
                        {
                            dest[i] = src[k];
                            j = k - 1;
                            break;
                        }
                    }
                }
            }
            return new string(dest);
        }

    }
}
