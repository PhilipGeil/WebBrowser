using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebBrowser
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Enter the url to get
            Console.WriteLine("Enter url: ");
            string url = Console.ReadLine();

            // New instance of class HttpManager
            HttpManager h = new HttpManager();

            // Call method which gets the website
            string s = await h.GetWebsite(url);

            // Remove html tags with regex
            string result = Regex.Replace(s, @"<[^>]*>", string.Empty);

            // Print result
            Console.WriteLine(result);
        }

    }
}
