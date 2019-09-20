using System;
using System.IO;
using System.Web;

namespace pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var incomingFileLocation = $"{AppContext.BaseDirectory}data";
            var text = File.ReadAllText(incomingFileLocation);

            var pdfInBytes = Convert.FromBase64String(text);

            var fileName = DateTimeOffset.Now.ToString("yyyyMMdd'_'HHmmss");
            var resultFileLocation = $"{AppContext.BaseDirectory}result_{fileName}.pdf";
            File.WriteAllBytes(resultFileLocation, pdfInBytes);

            Console.WriteLine($"Generated file location: {resultFileLocation}");
        }
    }
}
