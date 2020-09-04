# ConversorSqliteToSqlServer

Teste para criação de um conversor de base dados SQLite para SQLServer utilizando o Entity Framework Core

Documentação do EF-c: https://docs.microsoft.com/pt-br/ef/core/miscellaneous/cli/dotnet

Extensões utilizadas: Docker
                      NutGet Package Manager
                      SQL Server(mssql)

Programas: Docker - https://www.docker.com/


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

Comando: dotnet ef dbcontext scaffold 'data source=databaseLocation/database.sqlite' Microsoft.EntityFrameworkCore.Sqlite

-----------

<h3><b>Comando para gerar a imagem do banco SQL-Server</h3></b>

Comando: docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=P@ssword1' -p 1433:1433 -d microsoft/mssql-server-linux

-e => Significa o ambiente
-p => Significa qual porta sera aberta para o bando de dados
-d => Significa que é uma dependência de desenvolvimento

Após rodar o comando, algumas alterações no DatabaseEFcore.csproj precisaram ser alteradas
na linha onde contém <b>PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="3.1.7"</b> deverá ser alterada para <b>PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.7" </b>.

A classe dataBaseContext.cs deverá ficar assim:

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=EcoletaDatabase;User id=sa;Password=P@ssword1");
            }
        }

-----

<h3><b>Comando para rodar as migrations</h3></b>

Comando: dotnet ef migrations add init

Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'

------------

<h3><b>Comando para atualizar a base de dados com as estruturas do Sqlite</h3></b>

Comando: dotnet ef database update

Build started...
Build succeeded.
Applying migration '20200904012718_init'.
Done.