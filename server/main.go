package main

import (
	"context"
	"log"
	"log/slog"
	"net/http"

	"connectrpc.com/connect"
	"golang.org/x/net/http2"
	"golang.org/x/net/http2/h2c"

	"buf.build/gen/go/connectrpc/eliza/connectrpc/go/connectrpc/eliza/v1/elizav1connect"
	elizav1 "buf.build/gen/go/connectrpc/eliza/protocolbuffers/go/connectrpc/eliza/v1"
)

var _ elizav1connect.ElizaServiceHandler = (*server)(nil)

type server struct {
	elizav1connect.UnimplementedElizaServiceHandler
}

// Say implements elizav1connect.ElizaServiceHandler.
func (s *server) Say(ctx context.Context, req *connect.Request[elizav1.SayRequest]) (*connect.Response[elizav1.SayResponse], error) {
	slog.Info("Say()", "req", req)
	return connect.NewResponse(&elizav1.SayResponse{
		Sentence: req.Msg.GetSentence(),
	}), nil
}

func main() {
	mux := http.NewServeMux()
	mux.Handle(elizav1connect.NewElizaServiceHandler(&server{}))

	addr := "127.0.0.1:6660"
	log.Printf("Starting connectrpc on %s", addr)
	http.ListenAndServe(
		":6660",
		h2c.NewHandler(mux, &http2.Server{}),
	)
}
