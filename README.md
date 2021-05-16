# Gerenciador de Anúncios

Este projeto se origina de um desafio de programação realizado pela **Academia Capgemini**.  
Autor: Vinicius de Souza Nascimento

O objetivo é criar um sistema de cadastro de anúncios com uma calculadora interna onde são realizados os cálculos de valor investido e o alcance de seu objetivo de acordo o investimento, além de retornar relatórios dos anúncios cadastrados com os dados acima mencionados, sendo possível filtrá-los por data e por cliente.

Para isso, criei uma Web API utilizando **ASP.NET Core 5 (C#)**, com as seguintes características:

- **Estrutura do código** que visa à separação de responsabilidades e busca evitar repetição.
- **Persistência de Dados** fazendo do Entity Framework Core (ORM) para realizar o mapeamento para o banco de dados por meio do code-first.
- **Separação em camadas** baseada no modelo DDD (domain-driven design), consistindo em _Domain_ (classes e interfaces), _Data_ (camada de infraestrutura responsável pela persistência) e _API_ (camada de aplicação onde ficam os controllers).
- **Documentação** dos endpoints da API utilizando o _Swagger_ e comentários XML.

---

## Instruções de Utilização:

Caso tenha o `git` instalado, é possível clonar este repositório com os seguintes comandos:

```console
$ git clone https://github.com/viniciusnasc/Anuncios.git
```

Também é possível baixar o conteúdo em formato `.zip` clicando no botão "Clone" na [homepage](https://github.com/viniciusnasc/Anuncios) do repositório.

Certifique-se de ter o .NET Core instalado, caso não tenha, é possível fazer download do .NET Core 5 [na página oficial](https://dotnet.microsoft.com/download/dotnet) da Microsoft.  
Também é preciso estar com o banco de dados instalado, recomendável a versão EXPRESS do SQL Server, disponível gratuitamente [na página de download](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) da Microsoft.

A string de conexão com o banco deve ser definida. Vá até o arquivo `appsettings.json`, que se encontra em Anuncios e edite o nome do servidor, incluindo o nome do seu servidor local, segundo o modelo: `Server=NomeDoServidorAqui;DataBase=AnunciosCRUD;Trusted_Connection=True`

**Compilar e executar com CLI do .NET:**

A seguir, abra o prompt de comando no diretório do projeto Anuncios e digite:

```console
$ dotnet run
```

Abra o navegador e acesse `https://localhost:5001/swagger/index.html`

**Compilar e executar com Visual Studio:**

Abra o diretório do projeto contendo o arquivo `Anuncios.sln` e clique duas vezes. Isso abrirá a IDE Visual Studio com todos os arquivos pertencentes ao projeto. Aperte a tecla F5 ou então clique no botão com ícone verde contendo o nome Anuncio.API ou IIS Express, na barra de ferramentas. O navegador será automaticamente aberto com o URL `https://localhost:5001/swagger/index.html`

**Utilizando a API:**

Com o Swagger aberto, basta interagir com a API. Para cadastrar um novo anúncio (POST), siga o exemplo de request, informando o nome do anúncio, o nome do cliente, data de início e término de pagamento e o valor de investimento diário.  
Para exibir os relatórios de todos os anúncios cadastrados, o método GET trará informações completas sobre os anúncios, incluindo os valores aproximados de alcance de visualização, compartilhamento e acesso que os potenciais clientes terão, os quais foram gerados automaticamente pelo algoritmo aritmético no momento de sua inclusão.  
Também é possível retornar anúncios pelo identificador (GET por id) e deletar anúncios (DELETE).  
Para manter a consistência das projeções, não é possível editar dados de anúncios, por isso, o método PUT não foi incluído.
