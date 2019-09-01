using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    class HelloWorldServer : HelloWorldService.Iface
    {
        public string hello(string name)
        {
            Console.WriteLine("Recv From Client : " + name + " ");
            return name + "--> Response : Hello World From C# ";
        }
    }
}
