using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    class HttpManager
    {
        // Instantiate new instance of HttpClient
        static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Async method for calling get on a website
        /// </summary>
        /// <param name="url">url of the website to call</param>
        /// <returns></returns>
        public async Task<string> GetWebsite(string url)
        {
            // Try/Catch for error handling
            try
            {
                // Create request to given url and await response
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                // return error message
                return e.Message;
            }
        }
    }
}
