using System;
using Nancy.Hosting.Self;

namespace WebServiceTest
{
    public class NancySelfHost
    {
        private NancyHost m_nancyHost;

        public void Start()
        {
            m_nancyHost = new NancyHost(new Uri("http://localhost:9000"));
            m_nancyHost.Start();

        }

        public void Stop()
        {
            m_nancyHost.Stop();
            Console.WriteLine("Stopped. Good bye!");
        }
    }
}
