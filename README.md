# Models
Contains data models that are going through network between client application, API and databases.

# Language
This repository is meant to contains definitions of datastructures in the language protobuf by Google. It allows multi-languages support and makes it possible for both client application and API server to stay up-to-date with the data protocol without harm and extra coding requirements.

# Build
Each directory has its `.proto` file that defines a model, to generate the model structures and definitions for both languages, just cd into the directory and run `make`.
Two new subdirectories called `csharp` and `go` should be created, with generated files inside.