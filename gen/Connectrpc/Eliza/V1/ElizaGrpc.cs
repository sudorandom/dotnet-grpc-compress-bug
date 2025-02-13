// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: connectrpc/eliza/v1/eliza.proto
// </auto-generated>
// Original file comments:
// Copyright 2022-2023 The Connect Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Connectrpc.Eliza.V1 {
  /// <summary>
  /// ElizaService provides a way to talk to Eliza, a port of the DOCTOR script
  /// for Joseph Weizenbaum's original ELIZA program. Created in the mid-1960s at
  /// the MIT Artificial Intelligence Laboratory, ELIZA demonstrates the
  /// superficiality of human-computer communication. DOCTOR simulates a
  /// psychotherapist, and is commonly found as an Easter egg in emacs
  /// distributions.
  /// </summary>
  public static partial class ElizaService
  {
    static readonly string __ServiceName = "connectrpc.eliza.v1.ElizaService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Connectrpc.Eliza.V1.SayRequest> __Marshaller_connectrpc_eliza_v1_SayRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Connectrpc.Eliza.V1.SayRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Connectrpc.Eliza.V1.SayResponse> __Marshaller_connectrpc_eliza_v1_SayResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Connectrpc.Eliza.V1.SayResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Connectrpc.Eliza.V1.ConverseRequest> __Marshaller_connectrpc_eliza_v1_ConverseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Connectrpc.Eliza.V1.ConverseRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Connectrpc.Eliza.V1.ConverseResponse> __Marshaller_connectrpc_eliza_v1_ConverseResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Connectrpc.Eliza.V1.ConverseResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Connectrpc.Eliza.V1.IntroduceRequest> __Marshaller_connectrpc_eliza_v1_IntroduceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Connectrpc.Eliza.V1.IntroduceRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Connectrpc.Eliza.V1.IntroduceResponse> __Marshaller_connectrpc_eliza_v1_IntroduceResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Connectrpc.Eliza.V1.IntroduceResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Connectrpc.Eliza.V1.SayRequest, global::Connectrpc.Eliza.V1.SayResponse> __Method_Say = new grpc::Method<global::Connectrpc.Eliza.V1.SayRequest, global::Connectrpc.Eliza.V1.SayResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Say",
        __Marshaller_connectrpc_eliza_v1_SayRequest,
        __Marshaller_connectrpc_eliza_v1_SayResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Connectrpc.Eliza.V1.ConverseRequest, global::Connectrpc.Eliza.V1.ConverseResponse> __Method_Converse = new grpc::Method<global::Connectrpc.Eliza.V1.ConverseRequest, global::Connectrpc.Eliza.V1.ConverseResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Converse",
        __Marshaller_connectrpc_eliza_v1_ConverseRequest,
        __Marshaller_connectrpc_eliza_v1_ConverseResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Connectrpc.Eliza.V1.IntroduceRequest, global::Connectrpc.Eliza.V1.IntroduceResponse> __Method_Introduce = new grpc::Method<global::Connectrpc.Eliza.V1.IntroduceRequest, global::Connectrpc.Eliza.V1.IntroduceResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Introduce",
        __Marshaller_connectrpc_eliza_v1_IntroduceRequest,
        __Marshaller_connectrpc_eliza_v1_IntroduceResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Connectrpc.Eliza.V1.ElizaReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ElizaService</summary>
    [grpc::BindServiceMethod(typeof(ElizaService), "BindService")]
    public abstract partial class ElizaServiceBase
    {
      /// <summary>
      /// Say is a unary RPC. Eliza responds to the prompt with a single sentence.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Connectrpc.Eliza.V1.SayResponse> Say(global::Connectrpc.Eliza.V1.SayRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Converse is a bidirectional RPC. The caller may exchange multiple
      /// back-and-forth messages with Eliza over a long-lived connection. Eliza
      /// responds to each ConverseRequest with a ConverseResponse.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task Converse(grpc::IAsyncStreamReader<global::Connectrpc.Eliza.V1.ConverseRequest> requestStream, grpc::IServerStreamWriter<global::Connectrpc.Eliza.V1.ConverseResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Introduce is a server streaming RPC. Given the caller's name, Eliza
      /// returns a stream of sentences to introduce itself.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task Introduce(global::Connectrpc.Eliza.V1.IntroduceRequest request, grpc::IServerStreamWriter<global::Connectrpc.Eliza.V1.IntroduceResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ElizaService</summary>
    public partial class ElizaServiceClient : grpc::ClientBase<ElizaServiceClient>
    {
      /// <summary>Creates a new client for ElizaService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ElizaServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ElizaService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ElizaServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ElizaServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ElizaServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Say is a unary RPC. Eliza responds to the prompt with a single sentence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Connectrpc.Eliza.V1.SayResponse Say(global::Connectrpc.Eliza.V1.SayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Say(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Say is a unary RPC. Eliza responds to the prompt with a single sentence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Connectrpc.Eliza.V1.SayResponse Say(global::Connectrpc.Eliza.V1.SayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Say, null, options, request);
      }
      /// <summary>
      /// Say is a unary RPC. Eliza responds to the prompt with a single sentence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Connectrpc.Eliza.V1.SayResponse> SayAsync(global::Connectrpc.Eliza.V1.SayRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Say is a unary RPC. Eliza responds to the prompt with a single sentence.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Connectrpc.Eliza.V1.SayResponse> SayAsync(global::Connectrpc.Eliza.V1.SayRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Say, null, options, request);
      }
      /// <summary>
      /// Converse is a bidirectional RPC. The caller may exchange multiple
      /// back-and-forth messages with Eliza over a long-lived connection. Eliza
      /// responds to each ConverseRequest with a ConverseResponse.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Connectrpc.Eliza.V1.ConverseRequest, global::Connectrpc.Eliza.V1.ConverseResponse> Converse(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Converse(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Converse is a bidirectional RPC. The caller may exchange multiple
      /// back-and-forth messages with Eliza over a long-lived connection. Eliza
      /// responds to each ConverseRequest with a ConverseResponse.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Connectrpc.Eliza.V1.ConverseRequest, global::Connectrpc.Eliza.V1.ConverseResponse> Converse(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Converse, null, options);
      }
      /// <summary>
      /// Introduce is a server streaming RPC. Given the caller's name, Eliza
      /// returns a stream of sentences to introduce itself.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Connectrpc.Eliza.V1.IntroduceResponse> Introduce(global::Connectrpc.Eliza.V1.IntroduceRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Introduce(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Introduce is a server streaming RPC. Given the caller's name, Eliza
      /// returns a stream of sentences to introduce itself.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Connectrpc.Eliza.V1.IntroduceResponse> Introduce(global::Connectrpc.Eliza.V1.IntroduceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_Introduce, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ElizaServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ElizaServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ElizaServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Say, serviceImpl.Say)
          .AddMethod(__Method_Converse, serviceImpl.Converse)
          .AddMethod(__Method_Introduce, serviceImpl.Introduce).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ElizaServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Say, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Connectrpc.Eliza.V1.SayRequest, global::Connectrpc.Eliza.V1.SayResponse>(serviceImpl.Say));
      serviceBinder.AddMethod(__Method_Converse, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Connectrpc.Eliza.V1.ConverseRequest, global::Connectrpc.Eliza.V1.ConverseResponse>(serviceImpl.Converse));
      serviceBinder.AddMethod(__Method_Introduce, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Connectrpc.Eliza.V1.IntroduceRequest, global::Connectrpc.Eliza.V1.IntroduceResponse>(serviceImpl.Introduce));
    }

  }
}
#endregion
