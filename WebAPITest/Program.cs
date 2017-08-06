using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Topshelf;
using WebServiceTest;

namespace WebAPITest
{
    public class FooBarNancyModule : NancyModule
    {

        public FooBarNancyModule()
        {

            Get["/foo"] = parameters => Response.AsJson(new {Foo = "Bar"});
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<NancySelfHost>(s =>
                {
                    s.ConstructUsing(name => new NancySelfHost());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();
                x.SetDisplayName("Test WebService");
                x.SetServiceName("Test WebService");
            });
        }
    }    

}
