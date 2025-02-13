
This shows a bug with grpc-dotnet where it doesn't properly uncompress compressed gRPC-Web trailers.


Starting the (go) server:
```
go run server/main.go
```

Running the client:
```
dotnet run
```

Client Output:
```
World from .NET
Unhandled exception. Grpc.Core.RpcException: Status(StatusCode="Internal", Detail="Error starting gRPC call. InvalidOperationException: Error parsing badly formatted trailing header.", DebugException="System.InvalidOperationException: Error parsing badly formatted trailing header.")
 ---> System.InvalidOperationException: Error parsing badly formatted trailing header.
   at Grpc.Net.Client.Web.Internal.GrpcWebResponseStream.ParseTrailers(ReadOnlySpan`1 span)
   at Grpc.Net.Client.Web.Internal.GrpcWebResponseStream.ReadTrailersAsync(Int32 trailerLength, Memory`1 data, CancellationToken cancellationToken)
   at Grpc.Net.Client.Web.Internal.GrpcWebResponseStream.ReadAsync(Memory`1 data, CancellationToken cancellationToken)
   at Grpc.Net.Client.Internal.StreamExtensions.ReadMessageAsync[TResponse](Stream responseStream, GrpcCall call, Func`2 deserializer, String grpcEncoding, Boolean singleMessage, CancellationToken cancellationToken)
   at Grpc.Net.Client.Internal.GrpcCall`2.ReadMessageAsync(Stream responseStream, String grpcEncoding, Boolean singleMessage, CancellationToken cancellationToken)
   at Grpc.Net.Client.Internal.GrpcCall`2.RunCall(HttpRequestMessage request, Nullable`1 timeout)
   --- End of inner exception stack trace ---
   at Program.<Main>$(String[] args) in /Users/kevin/Projects/csharp/Program.cs:line 11
   at Program.<Main>(String[] args)
```
