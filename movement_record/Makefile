all: go csharp

go:
	protoc --go_out=./go/ *.proto

csharp:
	protoc --csharp_out=./csharp/ *.proto

.PHONY: all go csharp