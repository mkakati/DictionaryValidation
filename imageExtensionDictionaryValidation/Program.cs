using System;
using System.Collections.Generic;

namespace imageExtensionDictionaryValidation
{
    class Program
    {
        public static readonly IDictionary<string, string> ImageMimeDictionary = new Dictionary<string, string>
        {
        { ".bmp", "image/bmp" },
        { ".dib", "image/bmp" },
        { ".gif", "image/gif" },
        { ".svg", "image/svg+xml" },
        { ".jpe", "image/jpeg" },
        { ".jpeg", "image/jpeg" },
        { ".jpg", "image/jpeg" },
        { ".png", "image/png" },
        { ".pnz", "image/png" }
        };
        static void Main(string[] args)
        {
            var pathExtension = ".jpg";
            bool Is = ImageMimeDictionary.ContainsKey(pathExtension.ToLower());
            if (Is)
            {
                Console.WriteLine("Hurrah! this extension s valid.");
            }
            
        }
    }
}
