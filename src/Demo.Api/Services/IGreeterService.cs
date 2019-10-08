using System.Threading.Tasks;
using Grpc.Core;
using Helloworld;

namespace Demo.Api
{
    public interface IGreeterService
    {
        Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context);
    }
}