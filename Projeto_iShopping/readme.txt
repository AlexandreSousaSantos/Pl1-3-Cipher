iShopping — README.txt

1) Projeto
Nome: iShopping (Pl1-3-Cipher)
Tipo: Aplicação Desktop em C# WinForms (.NET Framework 4.7.2)
Arquitetura: MVC (Model-View-Controller)
Persistência: Entity Framework com SQL Server / LocalDB

2) Processos de Instalação

2.1 Requisitos:

Para executar a aplicação é preciso:

Windows 10 ou superior
Visual Studio 2019/2022/2026 com suporte a .NET Desktop Development
.NET Framework 4.7.2 Developer Pack
SQL Server Express ou LocalDB

2.2 Fazer o clone do projeto

git clone https://github.com/AlexandreSousaSantos/Pl1-3-Cipher.git

2.3 Abrir solução

Abrir o ficheiro na pasta:
Projeto_iShopping.sln

2.4 Restaurar dependências

O Visual Studio deverá restaurar automaticamente os pacotes NuGet.
Caso necessário, utilizar:
Restore NuGet Packages

3) Configuração da Aplicação

3.1 Base de Dados

A aplicação utiliza Entity Framework Code First.

A base de dados vai ser criada automaticamente ao executar a aplicação pela primeira vez.

3.2 Migrações / Inicialização

A base de dados é criada automaticamente através do Entity Framework.
Caso exista initializer no projeto, ele será executado no arranque da aplicação.

4) Execução da Aplicação

Executar com:
F5 (Debug) ou Ctrl + F5
A aplicação vai iniciar com o formulário de Login

4.1 Login

O acesso é feito através de:

Acesso por default:

Username -> admin
Password > admin123

Dá para adicionar mais utilizadores, através da página principal, no botão Utilizadores,
adicionar o utilizador com o username e password e fazer a confirmação dela.

5) Dados e Utilização

Após autenticação, o utilizador pode:

Gerir utilizadores
Gerir tipos de artigo
Gerir artigos
Gerir orçamentos
Fazer o planeamento das compras
Criar e gerir compras
Registar os itens adquiridos no modo compra
Exportar compras fechadas para CSV
Consultar estatísticas

Todos os dados estão registados na base de dados.

6) Exportação dos Dados

A exportação CSV cria um ficheiro que tem como separador o ponto e virgula que tem:

NomeCompra
DataCriacao
DataFechada
NomeArtigo
ArtigoPrevisto
ArtigoNaoPrevisto
QuantidadePrevista
QuantidadeAdquirida
PrecoUnitario

7) Estrutura do Projeto
Models -> entidades dos dados
Views -> formulários
Controllers -> lógica de negócio
Data Access -> Entity Framework DbContext

8) Elementos do Grupo
Alexandre Santos - 2025191285
Cátia Leocádio - 2025182962
Ivan Monteiro - 2025188640

9) Notas Finais
O projeto foi desenvolvido em arquitetura MVC.
Todos os dados são guardados na base de dados pelo Entity Framework.