namespace Task1
{
    public class Anagram
    {
        public static string Reverse(string inputLine)
        {
            string line = inputLine ?? "";
            string[] words = line.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = ReverseWord(words[i]);
            }
            return string.Join(" ", words);
        }

        static string ReverseWord(string source)
        {
            char[] dest = source.ToCharArray();
            char[] src = source.ToCharArray();

            for (int i = 0, endIndex = src.Length - 1; i < src.Length; i++)
            {
                if (char.IsLetter(src[i]))
                {
                    for (int j = endIndex; j >= 0; j--)
                    {
                        if (char.IsLetter(src[j]))
                        {
                            dest[i] = src[j];
                            endIndex = j - 1;
                            break;
                        }
                    }
                }
            }
            return string.Join("", dest);
        }
    }
}
