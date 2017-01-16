using System;
using JRPC.Client;
using SimpleServiceLibrary;

namespace SimpleServiceClient {
    class Program {
        static void Main(string[] args) {
            var client = new JRpcClient("http://127.0.0.1:12345");
            var proxy = client.GetProxy<ISimpleService>("SimpleService");
            Console.WriteLine(proxy.SimpleMethod());
            Console.ReadLine();
        }
    }
}
