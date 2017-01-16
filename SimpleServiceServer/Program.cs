﻿using System;
using Consul;
using JRPC.Service;
using JRPC.Service.Registry;

namespace SimpleServiceServer {
    class Program {
        static void Main(string[] args) {
            var client = new ConsulClient();
            var registry = new DefaultModulesRegistry();
            registry.AddJRpcModule(new SimpleService());
            var svc = new JRpcService(registry, client);
            svc.Start();
            Console.ReadLine();
            svc.Stop();
        }
    }
}
