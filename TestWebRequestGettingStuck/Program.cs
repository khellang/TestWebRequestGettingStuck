using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Raven.Abstractions.Util;

namespace TestWebRequestGettingStuck
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            for (int i = 1; i < 10001; i++)
            {
                AsyncHelpers.RunSync(() => client.GetAsync("http://localhost:9000/foo",HttpCompletionOption.ResponseHeadersRead));
                Console.WriteLine(i);
            }
        }
    }
}
