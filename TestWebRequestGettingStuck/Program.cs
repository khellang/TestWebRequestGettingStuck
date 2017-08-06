using System;
using System.Net.Http;

namespace TestWebRequestGettingStuck
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            for (int i = 1; i < 10001; i++)
            {
                client.GetAsync("http://localhost:9000/foo",HttpCompletionOption.ResponseHeadersRead).Wait();
                Console.WriteLine(i);
            }
        }
    }
}
