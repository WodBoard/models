all: go \
	csharp

go:
	mkdir -p ./go
	protoc --go_out=./go/ *.proto

csharp:
	mkdir -p ./csharp
	protoc --csharp_out=./csharp/ *.proto

.PHONY: all go csharp
