using ProjetoFazendaUrbana.conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class ProdutoEditar : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;
        public ProdutoEditar()
        {
            InitializeComponent();
            // Definir a cor de fundo do panel1 com transparência (alfa)
            Color semiTransparentColor = Color.FromArgb(128, 0, 0, 0); // 128 é o valor alfa (0-255), 0, 0, 0 é a cor RGB (preto)
            panel1.BackColor = semiTransparentColor;

            this.Load += new EventHandler(AlterarProduto_Load);
        }

        private void AlterarProduto_Load(object sender, EventArgs e)
        {
            // Atualize cada Label com o valor correspondente
            AtualizarLabel(TextQuantBranca, "SELECT quantidade FROM Produtos WHERE ID = 6");
            AtualizarLabel(TextQuantAmarela, "SELECT quantidade FROM Produtos WHERE ID = 5");
            AtualizarLabel(TextQuantVermelha, "SELECT quantidade FROM Produtos WHERE ID = 4");
            AtualizarLabelValor(textValorBranca, "SELECT preco FROM Produtos WHERE ID = 6");
            AtualizarLabelValor(textValorAmarela, "SELECT preco FROM Produtos WHERE ID = 5");
            AtualizarLabelValor(textValorVermelha, "SELECT preco FROM Produtos WHERE ID = 4");
        }

        private void AtualizarLabelValor(Label label, string query)
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
                        label.Text = ("VALOR ATUAL R$ " + result.ToString());
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
        private void AtualizarLabel(Label label, string query)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HUTS0O2;initial catalog=BD_FAZENDA;integrated security=true;"))
                {
                    cn.Open();
                    using (SqlCommand cm = new SqlCommand(query, cn))
                    {
                        // Execute a consulta e obtenha o resultado
                        object result = cm.ExecuteScalar();

                        // Verifique se o resultado não é nulo e atualize o Label
                        if (result != null)
                        {
                            label.Text = ("QUANTIDADE: " + result.ToString());
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
                // Mostre uma mensagem de erro se algo der errado
                MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
            }
        }

        // Outras funções e eventos...

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void TextQuantAmarela_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool algumCampoPreenchido = false;

            TextBox[] campos = new TextBox[]
            {
        textAddAmarela, textAddBranca, textAddVermelha, textPrecoAmarela, textPrecoBranca, textPrecoVermelha, textRemAmarela, textRemBranca, textRemVermelha
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
                using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-HUTS0O2;Initial Catalog=BD_FAZENDA;Integrated Security=True;"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand();

                    // Atualiza o preço Amarela, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textPrecoAmarela.Text))
                    {
                        if (Decimal.TryParse(textPrecoAmarela.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal precoAmarela))
                        {
                            cmd.CommandText = "UPDATE Produtos SET preco = @preco WHERE ID = 5";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@preco", precoAmarela);
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Valor do preço amarelo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Atualiza o preço Branca, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textPrecoBranca.Text))
                    {
                        if (Decimal.TryParse(textPrecoBranca.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal precoBranca))
                        {
                            cmd.CommandText = "UPDATE Produtos SET preco = @preco WHERE ID = 6";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@preco", precoBranca);
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Valor do preço branco inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Atualiza o preço Vermelha, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textPrecoVermelha.Text))
                    {
                        if (Decimal.TryParse(textPrecoVermelha.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal precoVermelha))
                        {
                            cmd.CommandText = "UPDATE Produtos SET preco = @preco WHERE ID = 4";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@preco", precoVermelha);
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Valor do preço vermelho inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Adiciona a quantidade Amarela, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textAddAmarela.Text))
                    {
                        if (Decimal.TryParse(textAddAmarela.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal addAmarela))
                        {
                            cmd.CommandText = "UPDATE Produtos SET quantidade = quantidade + @quantidade WHERE ID = 5";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@quantidade", addAmarela);
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Valor de adição para amarelo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Adiciona a quantidade Branca, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textAddBranca.Text))
                    {
                        if (Decimal.TryParse(textAddBranca.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal addBranca))
                        {
                            cmd.CommandText = "UPDATE Produtos SET quantidade = quantidade + @quantidade WHERE ID = 6";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@quantidade", addBranca);
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Valor de adição para branco inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Adiciona a quantidade Vermelha, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textAddVermelha.Text))
                    {
                        if (Decimal.TryParse(textAddVermelha.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal addVermelha))
                        {
                            cmd.CommandText = "UPDATE Produtos SET quantidade = quantidade + @quantidade WHERE ID = 4";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@quantidade", addVermelha);
                            cmd.Connection = cn;
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Valor de adição para vermelho inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Verifica e subtrai a quantidade Amarela, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textRemAmarela.Text))
                    {
                        if (Decimal.TryParse(textRemAmarela.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal remAmarela))
                        {
                            // Verifica a quantidade atual no banco
                            cmd.CommandText = "SELECT quantidade FROM Produtos WHERE ID = 5";
                            cmd.Parameters.Clear();
                            cmd.Connection = cn;
                            object result = cmd.ExecuteScalar();
                            if (result != null && Decimal.TryParse(result.ToString(), out decimal quantidadeAtualAmarela))
                            {
                                if (quantidadeAtualAmarela >= remAmarela)
                                {
                                    cmd.CommandText = "UPDATE Produtos SET quantidade = quantidade - @quantidade WHERE ID = 5";
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@quantidade", remAmarela);
                                    cmd.Connection = cn;
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Quantidade para remoção é maior do que a quantidade disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Valor de remoção para amarelo inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textAddAmarela.Clear();
                            return;
                        }
                    }

                    // Verifica e subtrai a quantidade Branca, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textRemBranca.Text))
                    {
                        if (Decimal.TryParse(textRemBranca.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal remBranca))
                        {
                            // Verifica a quantidade atual no banco
                            cmd.CommandText = "SELECT quantidade FROM Produtos WHERE ID = 6";
                            cmd.Parameters.Clear();
                            cmd.Connection = cn;
                            object result = cmd.ExecuteScalar();
                            if (result != null && Decimal.TryParse(result.ToString(), out decimal quantidadeAtualBranca))
                            {
                                if (quantidadeAtualBranca >= remBranca)
                                {
                                    cmd.CommandText = "UPDATE Produtos SET quantidade = quantidade - @quantidade WHERE ID = 6";
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@quantidade", remBranca);
                                    cmd.Connection = cn;
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Quantidade para remoção é maior do que a quantidade disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Valor de remoção para branco inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textRemBranca.Clear();
                            return;
                        }
                    }

                    // Verifica e subtrai a quantidade Vermelha, se estiver preenchido
                    if (!string.IsNullOrWhiteSpace(textRemVermelha.Text))
                    {
                        if (Decimal.TryParse(textRemVermelha.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal remVermelha))
                        {
                            // Verifica a quantidade atual no banco
                            cmd.CommandText = "SELECT quantidade FROM Produtos WHERE ID = 4";
                            cmd.Parameters.Clear();
                            cmd.Connection = cn;
                            object result = cmd.ExecuteScalar();
                            if (result != null && Decimal.TryParse(result.ToString(), out decimal quantidadeAtualVermelha))
                            {
                                if (quantidadeAtualVermelha >= remVermelha)
                                {
                                    cmd.CommandText = "UPDATE Produtos SET quantidade = quantidade - @quantidade WHERE ID = 4";
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@quantidade", remVermelha);
                                    cmd.Connection = cn;
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Quantidade para remoção é maior do que a quantidade disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    textRemVermelha.Clear();
                                    return;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Valor de remoção para vermelho inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                MessageBox.Show("Dados salvos com sucesso!!!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                textAddAmarela.Clear(); textPrecoAmarela.Clear(); textRemAmarela.Clear();
                textAddBranca.Clear(); textRemBranca.Clear(); textPrecoBranca.Clear();
                textAddVermelha.Clear(); textPrecoVermelha.Clear(); textRemVermelha.Clear();

                ProdutoEditar menu = new ProdutoEditar();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum campo preenchido!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TextBoxInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                button1_Click(sender, e);
            }

            else if (e.KeyChar == 13)
            {
                button2_Click(sender, e);
            }

            // Permite apenas números e teclas de controle (como Backspace)
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, insira apenas números inteiros positivos.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 27)
            {
                button1_Click(sender, e);
            }

            else if (e.KeyChar == 13)
            {
                button2_Click(sender, e);
            }


            // Permite apenas números, teclas de controle (como Backspace) e ponto decimal
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {

                e.Handled = true;
                MessageBox.Show("Por favor, insira apenas números e um ponto decimal.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (e.KeyChar == '.')
            {
                // Permite apenas um ponto decimal
                TextBox textBox = sender as TextBox;
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                    MessageBox.Show("Somente um ponto decimal é permitido.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TextBoxDecimal_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            // Verifica se há um ponto decimal
            if (text.Contains("."))
            {
                string[] parts = text.Split('.');

                // Se há mais de duas partes ou mais de duas casas decimais
                if (parts.Length > 2 || (parts.Length == 2 && parts[1].Length > 2))
                {
                    textBox.Text = text.Substring(0, text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length; // Move o cursor para o final
                    MessageBox.Show("Por favor, insira um valor com até duas casas decimais.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TextQuantBranca_Click(object sender, EventArgs e)
        {

        }

        private void TextQuantVermelha_Click(object sender, EventArgs e)
        {

        }

        private void textAddBranca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textRemBranca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

