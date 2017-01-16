using JRPC.Service;
using SimpleServiceLibrary;

namespace SimpleServiceServer {
    public class SimpleService : JRpcModule, ISimpleService {
        public string SimpleMethod() {
            return "DATA FROM SERVICE";
        }
    }
}
