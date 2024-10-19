using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class TelaVendas : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        // Variáveis para armazenar a quantidade escolhida de cada tipo de pitaya
        public int QuantidadeBranca { get; private set; }
        public int QuantidadeVermelha { get; private set; }
        public int QuantidadeAmarela { get; private set; }

        public decimal ValorTotalBranca { get; private set; }
        public decimal ValorTotalVermelha { get; private set; }
        public decimal ValorTotalAmarela { get; private set; }

        public TelaVendas()
        {
            InitializeComponent();
            this.Load += new EventHandler(vendas_Load);

            // Associe eventos para atualizar valores quando as quantidades mudarem
            textQuantBranca.TextChanged += new EventHandler(textQuantBranca_TextChanged);
            textQuantVermelha.TextChanged += new EventHandler(textQuantVermelha_TextChanged);
            textQuantAmarela.TextChanged += new EventHandler(textQuantAmarela_TextChanged);
        }

        private void vendas_Load(object sender, EventArgs e)
        {
            // Atualize cada Label com o valor correspondente
            AtualizarLabel(textDispBranca, "SELECT quantidade FROM Produtos WHERE ID = 6");
            AtualizarLabel(textDispAmarela, "SELECT quantidade FROM Produtos WHERE ID = 5");
            AtualizarLabel(textDispVermelha, "SELECT quantidade FROM Produtos WHERE ID = 4");
            AtualizarLabelValor(textValorBranca, "SELECT preco FROM Produtos WHERE ID = 6");
            AtualizarLabelValor(textValorAmarela, "SELECT preco FROM Produtos WHERE ID = 5");
            AtualizarLabelValor(textValorVermelha, "SELECT preco FROM Produtos WHERE ID = 4");

            // Atualize os valores iniciais nos Labels de total
            AtualizarValores();
        }

        private void AtualizarLabel(Label label, string query)
        {
            try
            {

                cn.Open();
                using (SqlCommand cm = new SqlCommand(query, cn.Open()))
                {
                    // Execute a consulta e obtenha o resultado
                    object result = cm.ExecuteScalar();

                    // Verifique se o resultado não é nulo e atualize o Label
                    if (result != null)
                    {
                        label.Text = ("Disponível: " + result.ToString());
                    }
                    else
                    {
                        label.Text = "Nenhum dado encontrado.";
                    }
                }

            }
            catch (Exception ex)
            {
                // Mostre uma mensagem de erro se algo der errado
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

        private void AtualizarLabelValor(Label label, string query)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HUTS0O2;initial catalog=BD_FAZENDA;integrated security=true;"))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand(query, cn))
                    {
                        object result = cm.ExecuteScalar();
                        if (result != null)
                        {
                            label.Text = ("R$ " + result.ToString() + " Kg");
                        }
                        else
                        {
                            label.Text = "Nenhum dado encontrado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

        private decimal ObterPreco(string query)
        {
            decimal preco = 0;
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HUTS0O2;initial catalog=BD_FAZENDA;integrated security=true;"))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand(query, cn))
                    {
                        object result = cm.ExecuteScalar();
                        if (result != null)
                        {
                            preco = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
            return preco;
        }

        private int ObterDisponivel(int idProduto)
        {
            int quantidade = 0;
            string query = $"SELECT quantidade FROM Produtos WHERE ID = {idProduto}";
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HUTS0O2;initial catalog=BD_FAZENDA;integrated security=true;"))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand(query, cn))
                    {
                        object result = cm.ExecuteScalar();
                        if (result != null)
                        {
                            int.TryParse(result.ToString(), out quantidade);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
            return quantidade;
        }

        private void AtualizarValores()
        {
            try
            {
                // Obtenha as quantidades dos TextBoxes
                int quantidadeBranca = ObterQuantidade(textQuantBranca);
                int quantidadeVermelha = ObterQuantidade(textQuantVermelha);
                int quantidadeAmarela = ObterQuantidade(textQuantAmarela);

                QuantidadeBranca = quantidadeBranca;
                QuantidadeVermelha = quantidadeVermelha;
                QuantidadeAmarela = quantidadeAmarela;

                // Obtenha as quantidades disponíveis dos Labels
                int disponivelBranca = ObterDisponivel(6);
                int disponivelVermelha = ObterDisponivel(4);
                int disponivelAmarela = ObterDisponivel(5);

                // Verifique se a quantidade inserida é válida
                if (quantidadeBranca > disponivelBranca)
                {
                    MessageBox.Show("Quantidade excede o disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textQuantBranca.Text = disponivelBranca.ToString();
                    quantidadeBranca = disponivelBranca;
                    textQuantBranca.Clear();
                    TelaVendas menu = new TelaVendas();
                    menu.Show();
                    this.Close();
                }

                if (quantidadeVermelha > disponivelVermelha)
                {
                    MessageBox.Show("Quantidade excede o disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textQuantVermelha.Text = disponivelVermelha.ToString();
                    quantidadeVermelha = disponivelVermelha;
                    textQuantVermelha.Clear();
                    TelaVendas menu = new TelaVendas();
                    menu.Show();
                    this.Close();
                }

                if (quantidadeAmarela > disponivelAmarela)
                {
                    MessageBox.Show("Quantidade excede o disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textQuantAmarela.Text = disponivelAmarela.ToString();
                    quantidadeAmarela = disponivelAmarela;
                    textQuantAmarela.Clear();
                    TelaVendas menu = new TelaVendas();
                    menu.Show();
                    this.Close();
                }

                // Obtenha os preços dos Labels
                decimal precoBranca = ObterPreco("SELECT preco FROM Produtos WHERE ID = 6");
                decimal precoVermelha = ObterPreco("SELECT preco FROM Produtos WHERE ID = 4");
                decimal precoAmarela = ObterPreco("SELECT preco FROM Produtos WHERE ID = 5");

                // Calcule os valores totais
                decimal valorTotalBranca = precoBranca * quantidadeBranca;
                decimal valorTotalVermelha = precoVermelha * quantidadeVermelha;
                decimal valorTotalAmarela = precoAmarela * quantidadeAmarela;

                // Calcule os valores totais
                ValorTotalBranca = precoBranca * quantidadeBranca;
                ValorTotalVermelha = precoVermelha * quantidadeVermelha;
                ValorTotalAmarela = precoAmarela * quantidadeAmarela;

                // Atualize os Labels com os valores calculados
                label2.Text = "R$ " + valorTotalBranca.ToString("F2");
                label6.Text = "R$ " + valorTotalVermelha.ToString("F2");
                label7.Text = "R$ " + valorTotalAmarela.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular valores: " + ex.Message);
            }
        }

        private int ObterQuantidade(TextBox textBox)
        {
            int quantidade = 0;
            int.TryParse(textBox.Text, out quantidade);
            return quantidade;
        }

        private void textQuantBranca_TextChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void textQuantVermelha_TextChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void textQuantAmarela_TextChanged(object sender, EventArgs e)
        {
            AtualizarValores();
        }

        private void textFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            IncrementarQuantidade(textQuantBranca);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DecrementarQuantidade(textQuantBranca);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DecrementarQuantidade(textQuantVermelha);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            IncrementarQuantidade(textQuantVermelha);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DecrementarQuantidade(textQuantAmarela);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            IncrementarQuantidade(textQuantAmarela);
        }

        private void IncrementarQuantidade(TextBox textBox)
        {
            int quantidade = ObterQuantidade(textBox);
            quantidade++;
            textBox.Text = quantidade.ToString();
        }

        private void DecrementarQuantidade(TextBox textBox)
        {
            int quantidade = ObterQuantidade(textBox);
            if (quantidade > 0)
            {
                quantidade--;
                textBox.Text = quantidade.ToString();
            }
        }

        private void textQuantAmarela_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            bool algumCampoPreenchido = false;

            TextBox[] campos = new TextBox[]
            {
                textQuantAmarela, textQuantBranca, textQuantVermelha
            };

            foreach (TextBox campo in campos)
            {
                if (!string.IsNullOrWhiteSpace(campo.Text))
                {
                    algumCampoPreenchido = true;
                    break;
                }
            }
            if (algumCampoPreenchido)
            {

                ResumoPagamento pag = new ResumoPagamento(this);
                pag.Show();
                this.Close();

            }

            else
            {
                MessageBox.Show("Informe a quantidade que gostaria de comprar!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            CadastroCliente menu = new CadastroCliente();
            menu.Show();
            this.Close();
        }

        private void textQuantBranca_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                label1_Click(sender, e);
            }

            else if (e.KeyChar == 13)
            {
                pictureBox11_Click(sender, e);
            }
            // Permite apenas números e teclas de controle (como Backspace)
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, insira apenas números inteiros .", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }
    }
}