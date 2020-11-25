using System;
using System.IO;

namespace pdf
{
    public class Program
    {
        public static readonly string FilesDirectoryPath = "./Files/";
        public static readonly string SourceFileName = "example.txt";
        public static readonly string ResultFileName = $"result_{DateTimeOffset.Now.ToString("yyyyMMdd'_'HHmmss")}.pdf";

        public static void Main(string[] args)
        {
            var incomingFileLocation = $"{FilesDirectoryPath}{SourceFileName}";
            var text = File.ReadAllText(incomingFileLocation);

            var pdfInBytes = Convert.FromBase64String(text);

            var resultFileLocation = $"{FilesDirectoryPath}{ResultFileName}";
            File.WriteAllBytes(resultFileLocation, pdfInBytes);

            Console.WriteLine($"Generated file location: {resultFileLocation}");
        }
    }
}
