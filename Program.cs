using Grpc.Net.Client;
using Grpc.Net.Client.Web;

var handler = new GrpcWebHandler(new HttpClientHandler());

using var channel = GrpcChannel.ForAddress("http://127.0.0.1:6660", new GrpcChannelOptions { HttpHandler = handler });

var client = new Connectrpc.Eliza.V1.ElizaService.ElizaServiceClient(channel);
var request = new Connectrpc.Eliza.V1.SayRequest { Sentence = "World from .NET" };
Console.WriteLine(request.Sentence);
var reply = await client.SayAsync(request);
Console.WriteLine(reply.Sentence);

