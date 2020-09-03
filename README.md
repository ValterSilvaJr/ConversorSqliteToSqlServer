# ConversorSqliteToSqlServer

Teste para criação de um conversor de base dados SQLite para SQLServer utilizando o Entity Framework Core
Documentação do EF-c: https://docs.microsoft.com/pt-br/ef/core/miscellaneous/cli/dotnet

<h3><b>Comando para verificar a versão do dotnet</h3></b>

comando: dotnet --version

3.1.300

-------------------

<h3><b>Comando para verificar a versão do dotnet-ef</b></h3>

comando: dotnet tool list -g

ID do Pacote  |    Versão  |    Comandos

dotnet-ef     |    3.1.7   |     dotnet-ef

Obs: As demais ferramentas que serão instaladas precisam ser iguais a versão do dotnet-ef ou menores para funcionarem.

---------------------------------------

<h3><b>Lista de comandos dentro de EF</h3></b>

comando: dotnet ef -h

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

<h3><b>Lista de comandos dentro do EF DbContext</h3></b>

comando: dotnet ef dbcontext -h


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

------------------

<h3><b>Criando o projeto</h3></b>

comando: dotnet new console -n NomeDoProjeto

The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on NomeDoProjeto\NomeDoProjeto.csproj...
  Determinando os projetos a serem restaurados...
  D:\Projetos\test\NomeDoProjeto\NomeDoProjeto.csproj restaurado (em 200 ms).

Restore succeeded.

--------------

<h3><b>Comando para criar o scaffold do database Sqlite</h3></b>

Comando: dotnet ef dbcontext scaffold 'data source=databaseClass/database.sqlite' Microsoft.EntityFrameworkCore.Sqlite