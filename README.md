# 🛒 iShopping — Sistema de Gestão de Compras Domésticas
![Politécnico de Leiria](https://projectoeuconsigo.pt/wp-content/uploads/2024/11/1-1024x390.webp)

## 🏫 Instituição e outras informações

| Informação | Resultado |
|------------|--------|
| Instituição | Escola Superior de Tecnologia e Gestão de Leiria (ESTG) |
| Curso | TeSP em Programação de Sistemas de Informação |
| Unidade Curricular | Desenvolvimento de Aplicações |
| Unidade Curricular | Metodologias de Desenvolvimento de Software |
| Ano Letivo | 2025/2026 |
| Semestre | 2.º Semestre |

---

## 👥 Identificação da Equipa
**Grupo: PL1/3**

| Nº Aluno | Nome |
|-----------|------|
| 2025182962 | Cátia Leocádio |
| 2025188640 | Ivan Monteiro |
| 2025191285 | Alexandre Santos |

---

## 📖 Descrição do Projeto
O **iShopping** é um projeto desenvolvido em **C# (Windows Forms)** que tem a persistência de dados
em **SQL Server** através do **Entity Framework**.
O sistema permite planear compras, gerir artigos e categorias, controlar despesas mensais e acompanhar a utilização do orçamento disponível.
A aplicação foi feita para diminuir a falta de controlo financeiro familiar e as compras que são feitas por impulso no supermercado.

---

# 🎯 Objetivos
- Melhorar o controlo financeiro familiar
- Reduzir compras por impulso
- Facilitar o planeamento de compras
- Apoiar decisões através das estatísticas
- Acompanhar os gastos mensais
- Aplicar o Scrum e as boas práticas de engenharia de software

---

# 💻 Tecnologias Utilizadas
- C#
- Windows Forms
- .NET
- SQL Server
- Entity Framework
- Git
- GitHub
- Jira
- UML
- Scrum

---

## 🧩 Funcionalidades Implementadas

### Formulário de Login

- Autenticação com Username e Password;
- Validação de credenciais;
- Armazenamento do ID do utilizador durante a execução da aplicação.

### Formulário Principal

- Acesso às restantes funcionalidades através do menu;
- Visualização das compras em aberto;
- Acesso ao Modo Compra.

### Gestão de Tipos de Artigo

- Visualização dos tipos de artigo;
- Criação de novos tipos;
- Edição de tipos existentes;
- Remoção de tipos de artigo.

### Gestão de Artigos

- Visualização de artigos;
- Filtragem por tipo de artigo;
- CRUD completo dos artigos.

### Gestão de Orçamentos

- Visualização dos orçamentos existentes;
- Criação de novos orçamentos;
- Alteração de orçamentos;
- Remoção de orçamentos.

### Planeamento de Compras

- Visualização de todas as compras;
- Filtragem por estado;
- Criação de novas compras;
- Alteração de compras ainda abertas.

### Criação e Alteração de Compras Planeadas

- Edição dos dados da compra;
- Gestão dos itens previstos;
- Definição das quantidades previstas;
- Modo apenas leitura para compras fechadas.

### Modo Compra

- Registo dos artigos adquiridos;
- Registo da quantidade adquirida;
- Registo do preço unitário;
- Adição de artigos não previstos;
- Fecho da compra.

### Estatísticas

#### Estatísticas Gerais

- Listagem mensal de orçamentos;
- Total gasto por mês;
- Diferença entre orçamento e despesas;
- Percentagem de artigos previstos e não previstos.

#### Apoio à Decisão

- Sugestão de orçamento para o mês seguinte;
- Sugestão de lista de compras baseada em compras anteriores.

### Exportação CSV

- Exportação de compras fechadas;
- Ficheiro CSV separado por ponto e vírgula.

---

## 🏗️ Arquitetura e Engenharia de Software
O sistema foi desenvolvido de acordo com os princípios da programação orientada a objetos e também organizado conforme a arquitetura MVC (Model-View-Controller).

A persistência dos dados é feita através do SQL Server, que utiliza o Entity Framework como uma camada de acesso aos dados.

O modelo de dados foi representado através de um diagrama de classes UML, que tem as entidades necessárias para a gestão de utilizadores, artigos, orçamentos e compras, o que permite uma estrutura organizada, escalável e que tenha pelo menos uma fácil manutenção.

---

## 🔄 Metodologia Scrum
O desenvolvimento do projeto seguiu a metedologia Scrum.

### Ferramentas Utilizadas

- Jira
- Git
- GitHub

### Eventos Scrum

- Sprint Planning
- Weekly Scrum
- Sprint Review
- Sprint Retrospective

---

### Sprint (o que foi estipulado fazer):
### Sprint 1
É estiulado fazer:
* Criação do Repositório;
* Diagrama de Classes;
* Construção da Base de Dados (BD);
* Criação da estrutura do projeto de DA;
* Escrita das Users Stories (US);
* Fazer a secção de "Introdução" do relatório de MDS.

#### Sprint 2
Foi feito:
* Fazer a continuação da Introdução do relatório de MDS.
* Tornar realidade as Users Stories:
  * Autenticação do Utilizador;
  *  Gestão do Tipo de Artigo;
  *  Gestão de Catálogo de Artigos;
  *  Gestão de Orçamentos;
  *  Exportação de Histórico (CSV);
  *  Registo de Itens Não Previstos;
  *  Gestão de Membros da Família;
  *  Planeamento das Compras;
  *  Estatísticas e Apoio á Decisão;
  *  Execução de Compra (Modo Compra)
*  Wireframes;
*  Análise concorrencial;
*  Critérios de Aceitação.

#### Sprint 3
Focada em:
* Fazer o ficheiro READ.MD;
* Introdução;
* Aplicação SCRUM ao projeto;
* Stakeholders;
* Conclusões;
* Retroespctive da Sprint 3;
* Completar o template;
* Incluir o resto das Users Stories que ainda não foram tornadas no que é pedido;
* Relatório de DA;
* Retroespective da Sprint 2, Weekly Scrum e Sprint Planning;
* Screenshot do backlog.

---

## 🧩 Diagrama de Classes
 
 <img width="945" height="1278" alt="Diagrama de Classes drawio (1)" src="https://github.com/user-attachments/assets/6d0882a7-f0ae-4b99-b124-9f556e1ee8b3" />



