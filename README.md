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

# 🧩 Funcionalidades do Sistema (Formulários Obrigatórios)

A aplicação **iShopping** foi desenvolvida em **Windows Forms (C#)** e implementa nove formulários obrigatórios definidos no enunciado:

## 🔐 a) Formulário de Login
Primeira janela da aplicação.

- Identificação do utilizador através de Username e Password
- Validação de credenciais
- O **Id do utilizador autenticado é guardado em memória durante toda a execução da aplicação**

---

## 🏠 b) Formulário Principal
Janela principal de navegação.

- Menu de acesso a todos os módulos
- Lista de **compras em aberto**
- Acesso direto ao **Modo Compra**

---

## 🏷️ c) Gestão de Tipos de Artigo
Gestão das categorias de artigos.

- Visualização de todos os tipos de artigo
- CRUD completo:
  - Criar
  - Ler
  - Atualizar
  - Eliminar

---

## 📦 d) Gestão de Artigos
Gestão do catálogo de produtos.

- Visualização de artigos
- Filtro por tipo de artigo ou todos
- CRUD completo

---

## 💰 e) Gestão de Orçamentos
Gestão do orçamento mensal.

- Visualização de todos os orçamentos
- CRUD completo
- Associação ao utilizador que cria e altera o registo

---

## 📝 f) Planeamento de Compras
Gestão das listas de compras.

- Visualização de compras (abertas e fechadas)
- Filtro por estado
- Criação de novas compras
- Edição de compras ainda não fechadas
- Acesso ao formulário de criação/edição

---

## 🧾 g) Criação/Alteração de Compra Planeada
Gestão detalhada de cada compra.

- Visualização e edição de dados da compra
- Gestão de itens da lista:
  - Itens previstos
  - Quantidades
- Inserção de novos itens
- Se a compra estiver fechada:
  - Apenas leitura

---

## 🛒 h) Modo Compra
Execução prática da compra.

- Registo de itens comprados
- Inserção de:
  - Quantidade
  - Preço unitário
- Possibilidade de adicionar itens não previstos
- Atualização automática do orçamento
- Fecho da compra com data/hora e utilizador responsável

---

## 📊 i) Estatísticas
Módulo de análise e apoio à decisão.

Organizado em separadores:

### 📈 Estatísticas Gerais
- Listagem mensal de:
  - Orçamento
  - Total gasto
  - Diferença entre ambos

- Percentagem de:
  - Artigos previstos
  - Artigos não previstos

### 🧠 Apoio à Decisão
- Sugestão de orçamento para o próximo mês
- Sugestão de lista de compras com base em padrões históricos (por semana do mês)

---

## 📄 Exportação CSV (Funcionalidade Extra do Sistema)

- Exportação de compras fechadas
- Formato CSV separado por ponto e vírgula
- Inclui:
  - NomeCompra
  - DataCriacao
  - DataFechada
  - NomeArtigo
  - Quantidades
  - Preços
  - Previstos / Não previstos

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
 em:
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

## Arquitetura e Engenharia de Software
O sistema assenta em **8 tabelas estruturadas com herança e composição** no Diagrama de Classes UML.
