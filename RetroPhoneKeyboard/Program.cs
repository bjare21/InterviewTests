using System;
using System.Collections.Generic;
using System.Text;

namespace RetroPhoneKeyboard
{
    class Program
    {

        private static Dictionary<string, string> keys = new Dictionary<string, string>(
            new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string,string>("A", "2"),
                new KeyValuePair<string,string>("K", "55"),
                new KeyValuePair<string, string>("O", "666"),
                new KeyValuePair<string, string>("T", "8")
            }
            );

        private static string getLetter(string letter)
        {
            if (string.IsNullOrEmpty(letter))
            {
                return String.Empty;
            }
            return keys[letter];
        }

        private static string getCode(string message)
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(message)) return String.Empty;
            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsLetter(message[i]))
                    sb.Append(getLetter(message[i].ToString()));
            }
            return sb.ToString();
        }


        static void Main(string[] args)
        {
            Console.WriteLine(getCode("KOT"));
        }
    }
}
