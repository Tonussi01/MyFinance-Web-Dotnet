# Sistema de Gestão de Planos de Conta e Transações

## Descrição do Projeto
Este sistema permite gerenciar planos de conta e registrar transações associadas a esses planos. Desenvolvido em C# para a matéria de Implementação e Evolução de Software.

## Arquitetura Utilizada
O sistema segue a arquitetura MVC (Model-View-Controller) e é composto pelos seguintes componentes:

 - Models
 - Views
 - Controllers
 - Services
 - Interfaces
 - Mappers
 - Domains

## Tecnologias
- C#
- ASP.NET Core
- Entity Framework Core
- SQL Server

## Como Configurar para Startup do Projeto

### Pré-requisitos
- .NET Core SDK 6.0 ou superior
- SQL Server

### Passos para Instalação

1. Clone o repositório:   
	git clone https://github.com/Tonussi01/MyFinance-Web-Dotnet.git
   
2. Navegue até o diretório do projeto:
	cd nome-do-projeto

3. Restaure os pacotes NuGet:
	dotnet restore
	
4. Crie o banco de dados Sql de acordo com o script localizado na pasta Docs.

5. Caso deseje exemplos pra teste tambem há um scripts para isto na pasta Docs.
	
6. Configure a string de conexão com o banco de dados no MyFinanceDbContext.

7. Compile e execute o projeto: 
	dotnet run

	
