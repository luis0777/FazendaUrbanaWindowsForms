using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class CartaoPagamento : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        private decimal quantidadeBranca;
        private decimal quantidadeVermelha;
        private decimal quantidadeAmarela;
        private decimal valorTotalBranca;
        private decimal valorTotalVermelha;
        private decimal valorTotalAmarela;
        private string formaDePagamentoEscolhida;

        public CartaoPagamento(decimal qBranca, decimal qVermelha, decimal qAmarela, decimal vBranca, decimal vVermelha, decimal vAmarela, string formaPagamento)
        {
            InitializeComponent();
            quantidadeBranca = qBranca;
            quantidadeVermelha = qVermelha;
            quantidadeAmarela = qAmarela;
            valorTotalBranca = vBranca;
            valorTotalVermelha = vVermelha;
            valorTotalAmarela = vAmarela;
            formaDePagamentoEscolhida = formaPagamento;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textNome.Text == "" || textCVV.Text == "" || textNumero.Text == "" || TextData.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textCVV.Text.Length != 3)
            {
                MessageBox.Show("Preencha o campo CVV corretamente!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textNumero.Text.Length != 19)
            {
                MessageBox.Show("Preencha o campo número do cartão corretamente!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TextData.Text.Length != 5)
            {
                MessageBox.Show("Preencha o campo data de validade corretamente!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (quantidadeBranca > 0)
                    {
                        InserirProduto("Pitaya Branca", quantidadeBranca, valorTotalBranca, formaDePagamentoEscolhida);
                    }
                    if (quantidadeVermelha > 0)
                    {
                        InserirProduto("Pitaya Vermelha", quantidadeVermelha, valorTotalVermelha, formaDePagamentoEscolhida);
                    }
                    if (quantidadeAmarela > 0)
                    {
                        InserirProduto("Pitaya Amarela", quantidadeAmarela, valorTotalAmarela, formaDePagamentoEscolhida);
                    }

                    // Atualizar a quantidade de pitayas no banco de dados
                    AtualizarQuantidadeNoBanco();


                    MessageBox.Show("Compra realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultado = MessageBox.Show("Deseja continuar no aplicativo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        TelaVendas vendas = new TelaVendas();
                        vendas.Show();
                        this.Close();
                        
                       
                    }
                    else
                    {
                        Application.Exit();
                    }

                    // Fecha a conexão com o banco de dados
                    cn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

        private void InserirProduto(string nomeProduto, decimal quantidade, decimal valor, string formaPagamento)
        {
            try
            {
                // Abre a conexão com o banco de dados
                cn.Open();

                // Define o comando SQL para inserir o produto
                cm.Connection = cn.Open();
                cm.CommandText = "INSERT INTO Vendas (Produto, QuantidadeVendida, ValorTotal, FormaDePagamento) VALUES (@Produto, @QuantidadeVendida, @ValorTotal, @FormaDePagamento)";
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("@Produto", nomeProduto);
                cm.Parameters.AddWithValue("@QuantidadeVendida", quantidade);
                cm.Parameters.AddWithValue("@ValorTotal", valor);
                cm.Parameters.AddWithValue("@FormaDePagamento", formaPagamento);

                // Executa o comando
                cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados
                if (cn.Open().State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void AtualizarQuantidadeNoBanco()
        {
            try
            {
                // Abre a conexão com o banco de dados
                cn.Open();

                // Atualizar quantidade de pitayas no banco de dados
                if (quantidadeBranca > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE produtos SET quantidade = quantidade - @quantidade WHERE id = 6", cn.Open());
                    cmd.Parameters.AddWithValue("@quantidade", quantidadeBranca);
                    cmd.ExecuteNonQuery();
                }

                if (quantidadeVermelha > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE produtos SET quantidade = quantidade - @quantidade WHERE id = 4", cn.Open());
                    cmd.Parameters.AddWithValue("@quantidade", quantidadeVermelha);
                    cmd.ExecuteNonQuery();
                }

                if (quantidadeAmarela > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE produtos SET quantidade = quantidade - @quantidade WHERE id = 5", cn.Open());
                    cmd.Parameters.AddWithValue("@quantidade", quantidadeAmarela);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar quantidade: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados
                if (cn.Open().State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostra a MessageBox com os botões Sim e Não
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar a compra?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Verifica o resultado da MessageBox
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("COMPRA CANCELADA", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaVendas vendas = new TelaVendas();
                vendas.Show();
                this.Close();
            }
        }

        private void CartaoPagamento_Load(object sender, EventArgs e)
        {
            // Código a ser executado ao carregar a tela, se necessário
        }

        

        private void textNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TextBoxInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }

           else if(e.KeyChar == 27)
            {
                button2_Click(sender, e);
            }
        }

        private void textBoxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }

            else if (e.KeyChar == 27)
            {
                button2_Click(sender, e);
            }

            else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Por favor, insira apenas letras.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Se não for uma letra, cancela o evento
                e.Handled = true;
            }
        }

        private void TextData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
