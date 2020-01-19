using System;
using System.Text;
using System.Text.Json;

namespace JsonSplit
{
    public class Program
    {
        private static string JSONTEXT = @"[{""a"":0},{}, ]";

        static void Main(string[] args)
        {
            ReadJson();
        }

        private static void ReadJson() 
        {
            var options = new JsonReaderOptions
            {
                AllowTrailingCommas = true,
                CommentHandling = JsonCommentHandling.Skip
            };
            var jsonBytes = Encoding.UTF8.GetBytes(JSONTEXT);
            Utf8JsonReader reader = new Utf8JsonReader(jsonBytes, options);

            while (reader.Read())
            {
                Console.Write(reader.TokenType);

                // switch (reader.TokenType)
                // {
                //     case JsonTokenType.PropertyName:
                //     case JsonTokenType.String:
                //         {
                //             string text = reader.GetString();
                //             Console.Write(" ");
                //             Console.Write(text);
                //             break;
                //         }

                //     case JsonTokenType.Number:
                //         {
                //             int intValue = reader.GetInt32();
                //             Console.Write(" ");
                //             Console.Write(intValue);
                //             break;
                //         }

                //         // Other token types elided for brevity
                // }
                Console.WriteLine();
            }
        }
    }
}
