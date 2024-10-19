using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ProjetoFazendaUrbana.conexao;
using QRCoder;

namespace ProjetoFazendaUrbana.view
{
    public partial class textConfirmaPag : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        private ResumoPagamento _pagamentoForms;
        private int quantidadeBranca;
        private int quantidadeVermelha;
        private int quantidadeAmarela;
        private decimal valorTotalBranca;
        private decimal valorTotalVermelha;
        private decimal valorTotalAmarela;
        private string formaDePagamentoEscolhida;
        public textConfirmaPag(ResumoPagamento pagamentoForms, int qBranca, int qVermelha, int qAmarela, decimal vBranca, decimal vVermelha, decimal vAmarela, string formaPagamento)
        {
            InitializeComponent();
            _pagamentoForms = pagamentoForms;
            ValorTotalPix();
            quantidadeBranca = qBranca;
            quantidadeVermelha = qVermelha;
            quantidadeAmarela = qAmarela;
            valorTotalBranca = vBranca;
            valorTotalVermelha = vVermelha;
            valorTotalAmarela = vAmarela;
            formaDePagamentoEscolhida = formaPagamento;
        }

        private void ValorTotalPix()
        {
            decimal ValorTotal = _pagamentoForms.ValorTotal;
            
            textValorTotal.Text = "Valor a Pagar: R$ " + ValorTotal.ToString("F2");
        }
        private void Pix_Load(object sender, EventArgs e)
        {
            // Defina o texto para o QR Code (exemplo: chave Pix)
            string chavePix = "SUA_CHAVE_PIX_AQUI"; // Substitua por uma chave válida
            GerarQRCode(chavePix);
        }

        private void GerarQRCode(string texto)
        {
            try
            {
                if (string.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("O texto para gerar o QR Code não pode ser nulo ou vazio.");
                    return;
                }

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    // Gera os dados do QR Code
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);

                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        // Gera a imagem do QR Code com tamanho proporcional ao PictureBox
                        Bitmap qrCodeImage = qrCode.GetGraphic(20);

                        // Redimensiona a imagem para o tamanho do PictureBox
                        Bitmap resizedQrCodeImage = new Bitmap(qrCodeImage, new Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height));

                        // Define a imagem do PictureBox
                        pictureBoxQRCode.Image = resizedQrCodeImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar QR Code: " + ex.Message);
            }
        }


        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {
            // Você pode adicionar código aqui caso queira alguma ação quando o QR Code for clicado
        }

        private void CopiarChave_Click(object sender, EventArgs e)
        {
            // Localiza a posição inicial da chave Pix após o prefixo "Chave Pix: "
            int startIndex = textChavePix.Text.IndexOf("Chave Pix: ") + "Chave Pix: ".Length;

            // Extrai a chave Pix, que começa após o prefixo
            string chavePix = textChavePix.Text.Substring(startIndex).Trim();

            // Copia apenas a chave Pix para a área de transferência
            Clipboard.SetText(chavePix);

            // Exibe uma mensagem confirmando que a chave foi copiada
            MessageBox.Show("Chave Pix copiada para a área de transferência!","Copiado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
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
        private void InserirProduto(string nomeProduto, int quantidade, decimal valor, string formaPagamento)
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
    }
}

