using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_iShopping.Models;
using Projeto_iShopping.Controller;

namespace Projeto_iShopping.Views
{
    public partial class FormEditarCompra : Form
    {
        // Variável para armazenar o ID da compra a ser editada
        // Usamos o _ para indicar que é uma variável privada da classe
        private int _compraId;

        // Variável para indicar se estamos em modo de edição ou criação
        private bool _isEdicao;

        // Construtor para criar uma nova lista de compras
        public FormEditarCompra() 
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            _compraId = 0; // Inicializa o ID da compra como 0 (indica criação)
            _isEdicao = false; // Inicializa o modo de edição como falso (indica criação)
        }

        // Construtor para editar uma lista existente
        public FormEditarCompra(int compraId)
        {
            InitializeComponent(); // Inicializa os componentes do formulário
            _compraId = compraId; // Define o ID da compra a ser editada
            _isEdicao = true; // Define o modo de edição como verdadeiro (indica edição)
        }

        private void FormEditarCompra_Load(object sender, EventArgs e)
        {
            CarregarArtigosDisponiveis();

            if (_isEdicao)
            {
                CarregaDadosCompra();
                AtualizarGrelha();
            }
            else
            {
                ConfigurarModoNovaCompra();
            }
        }

        // Método para carregar os dados da compra a ser editada
        private void ConfigurarModoNovaCompra()
        {
            btnAdicionar.Enabled = false; // Desativa o botão de adicionar itens, pois ainda não há uma compra criada
            btnRemoverItem.Enabled = false; // Desativa o botão de remover itens, pois não há itens para remover
            comboBoxArtigos.Enabled = false; // Desativa o comboBox de artigos, pois ainda não há uma compra criada
            numQuantidade.Enabled = false; // Desativa o controle de quantidade, pois ainda não há uma compra criada
        }

        // Método para carregar os dados da compra a ser editada
        private void CarregarArtigosDisponiveis()
        {
            // Carrega os artigos disponíveis para seleção no comboBox
            using (iShoppingContext db = new iShoppingContext())
            {
                // Consulta os artigos disponíveis, ordenados por nome, e seleciona apenas o ID e o nome para exibição
                var artigos = db.Artigos
                    .OrderBy(a => a.NomeArtigo) // Ordena os artigos por nome
                    .Select(a => new { a.Id, Nome = a.NomeArtigo }) // Seleciona apenas o ID e o nome do artigo
                    .ToList(); // Converte o resultado para uma lista
                comboBoxArtigos.DataSource = artigos; // Define a fonte de dados do comboBox como a lista de artigos
                comboBoxArtigos.DisplayMember = "Nome"; // Define o membro a ser exibido no comboBox como o nome do artigo
                comboBoxArtigos.ValueMember = "Id"; // Define o membro a ser usado como valor no comboBox como o ID do artigo
            }
        }

        private void CarregarDadosCompra()
        {
            // Carrega os dados da compra a ser editada
            using (iShoppingContext db = new iShoppingContext())
            {
                // Consulta a compra pelo ID e preenche os campos do formulário com os dados da compra
                Compra compra = db.Compras.Find(_compraId);

                // Verifica se a compra foi encontrada no banco de dados
                if (compra != null)
                {
                    // Preenche o campo de nome da compra com o nome da compra encontrada
                    txtNomeCompra.Text = compra.NomeCompra;

                    // Verifica se a compra está fechada, ou seja,
                    // se o campo FechadaPorId tem um valor
                    if (compra.FechadaPorId)
                    {
                        BloquearFormularioLeitura();
                    }
                    else
                    {
                        btnAdicionar.Enabled = true; // Ativa o botão de adicionar itens, pois a compra está aberta
                        btnRemoverItem.Enabled = true; // Ativa o botão de remover itens, pois a compra está aberta
                        comboBoxArtigos.Enabled = true; // Ativa o comboBox de artigos, pois a compra está aberta
                        numQuantidade.Enabled = true; // Ativa o controle de quantidade, pois a compra está aberta
                        btnGuardarCompra.Text = "Atualizar Nome"; // Altera o texto do botão de guardar compra para "Atualizar Nome",
                                                                  // pois estamos a editar uma compra existente
                    }
                }
            }
        }

        private void BloquearFormularioLeitura()
        {
            txtNomeCompra.Enabled = false; // Desativa o campo de nome da compra, pois a compra está fechada
            btnGuardarCompra.Enabled = false; // Desativa o botão de guardar compra, pois a compra está fechada
            comboBoxArtigos.Enabled = false; // Desativa o comboBox de artigos, pois a compra está fechada
            numQuantidade.Enabled = false; // Desativa o controle de quantidade, pois a compra está fechada
            btnAdicionar.Enabled = false; // Desativa o botão de adicionar itens, pois a compra está fechada
            btnRemoverItem.Enabled = false; // Desativa o botão de remover itens, pois a compra está fechada
        
            // Exibe uma mensagem
            MessageBox.Show("Esta compra está fechada e não pode ser editada só pode ser vista.", "Compra Fechada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para atualizar a grelha de itens de compra
        private void AtualizarGrelha()
        {
            // Atualiza a grelha de itens de compra e mostra
            // os itens relacionados à compra atual
            using (iShoppingContext db = new iShoppingContext())
            {
                // Consulta os itens de compra relacionados à compra atual,
                // filtrando pelo ID da compra
                var itens = db.ItemCompra
                    .Where(ic => ic.CompraId == _compraId) // Filtra os itens de compra pelo ID da compra
                    .Select(ic => new // Seleciona os dados abaixo
                    {
                        Id = ic.Id, // Seleciona o ID do item de compra
                        Artigo = ic.Artigo.NomeArtigo, // Seleciona o nome do artigo relacionado ao item de compra
                        Quantidade = ic.QuantidadePrevista // Seleciona a quantidade prevista do item de compra
                    })
                    .ToList(); // Converte o resultado para uma lista
                DGV_Historico_de_Orcamentos.DataSource = itens; // Define a fonte de dados do DataGridView
                                                                // como a lista de itens de compra
            }
        }

        private void btnGuardarCompra_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCompra.Text.Trim(); // Obtém o nome da compra do campo de texto,
                                                           // e retira espaços em branco

            if (string.IsNullOrEmpty(nome)) // Verifica se o nome da compra está vazio
            {
                MessageBox.Show("O nome da compra não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // Exibe uma mensagem de erro
                return; // O nome da compra é obrigatório, por isso sai do método
            }

            string mensagem; // recebe mensagem de retorno out da camada Controller

            // Se o formulario estiver em modo criação de uma nova lista
            if (_isEdicao)
            {
                int mesAtual = DateTime.Now.Month; // busca mês atual
                int anoAtual = DateTime.Now.Year; // busca ano atual

                // Envia os parâmetros para a camada lógica de negócio no controlador
                bool sucesso = CompraController.CriarCompra(nome, mesAtual, anoAtual, out mensagem);

                MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Se o controlador conseguir gravar o registo com sucesso
                if (sucesso)
                {
                    using (iShoppingContext db = new iShoppingContext())
                    {
                        var novaCompra = db.Compras
                            .OrderByDescending(c => c.Id) // Ordena pelo ID mais recente
                            .FirstOrDefault(c => c.NomeCompra == nome); // Garante que o nome coincide
                    
                        if (novaCompra != null)
                        {
                            _compraId = novaCompra.Id; // Atualiza a variável da classe com o ID real da BD
                            _isEdicao = true; // Muda o estado para modo de Edição

                            btnAdicionar.Enabled = true;
                            btnRemoverItem.Enabled = true;
                            comboBoxArtigos.Enabled = true;
                            numQuantidade.Enabled = true;
                            btnGuardarCompra.Text = "Atualizar Nome"; // Modifica o texto do botão do topo
                        }
                    
                    }
                }
            
            }
        }
    }
}
