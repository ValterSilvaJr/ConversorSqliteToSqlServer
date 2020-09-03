# ConversorSqliteToSqlServer

Teste para criação de um conversor de base dados SQLite para SQLServer utilizando o Entity Framework Core
Documentação do EF-c: https://docs.microsoft.com/pt-br/ef/core/miscellaneous/cli/dotnet

Lista de comandos dentro de EF

D:\Projetos\ConversorBaseDadosSqlite>dotnet ef -h
Entity Framework Core .NET Command-line Tools 3.1.7

Usage: dotnet ef [options] [command]

Options:
  --version        Show version information
  -h|--help        Show help information
  -v|--verbose     Show verbose output.
  --no-color       Don't colorize output.
  --prefix-output  Prefix output with level.

Commands:
  database    Commands to manage the database.
  dbcontext   Commands to manage DbContext types.
  migrations  Commands to manage migrations.

Use "dotnet ef [command] --help" for more information about a command.

-----------------------------------------------------------------------

Lista de comandos dentro do EF DbContext

D:\Projetos\ConversorBaseDadosSqlite>dotnet ef dbcontext -h


Usage: dotnet ef dbcontext [options] [command]

Options:
  -h|--help        Show help information
  -v|--verbose     Show verbose output.
  --no-color       Don't colorize output.
  --prefix-output  Prefix output with level.

Commands:
  info      Gets information about a DbContext type.
  list      Lists available DbContext types.
  scaffold  Scaffolds a DbContext and entity types for a database.
  script    Generates a SQL script from migrations.

Use "dbcontext [command] --help" for more information about a command.