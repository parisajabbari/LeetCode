using System;
using System.Collections.Generic;

namespace project
{
    public class TinyURL
    {
        private static Dictionary<string, string> URLlookup = new Dictionary<string, string>();
        public static string Encode(string URL)
        {
            string randomShortURL = CreateRandomURL();
            string shortURL = "http://tinyurl.com/" + randomShortURL;

            URLlookup.Add(randomShortURL, URL);
            
            return shortURL;
        }

        public static string Decode(string TinyURL)
        {
            var PreparedTinyURL = TinyURL.Substring(19);
            string output = "Not found";
                if(URLlookup.ContainsKey(PreparedTinyURL))
                {
                    URLlookup.TryGetValue(PreparedTinyURL, out output);
                }
            
            return output;
        }

        private static string CreateRandomURL()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
    }
}
