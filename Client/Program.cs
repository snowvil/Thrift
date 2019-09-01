using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift;
using Thrift.Protocol;
using Thrift.Transport;

namespace HelloWorldService
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TTransport transport = new TSocket("localhost", 9091);
                TProtocol protocol = new TBinaryProtocol(transport);
                HelloWorldService.Client client = new HelloWorldService.Client(protocol);

                transport.Open();
                try
                {
                    String recv = client.hello("C# Client Send Hello.");
                    Console.WriteLine(recv);

                    recv = client.hello("C# Client Send World.");
                    Console.WriteLine(recv);
                }
                finally
                {
                    transport.Close();
                }
            }
            catch (TApplicationException x)
            {
                Console.WriteLine(x.StackTrace);
            }
        }
    }
}
