using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using ProjetoFazendaUrbana.conexao;

namespace ProjetoFazendaUrbana.view
{
    public partial class FuncionarioEditar : Form
    {
        public FuncionarioEditar()
        {
            InitializeComponent();
            // Definir a cor de fundo do panel1 com transparência (alfa)
            Color semiTransparentColor = Color.FromArgb(128, 0, 0, 0); // 128 é o valor alfa (0-255), 0, 0, 0 é a cor RGB (preto)
            panel8.BackColor = semiTransparentColor;
        }

        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textFechar_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            var position = label.PointToScreen(System.Drawing.Point.Empty);
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Hide();
        }

        private void AlterarFuncao_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textFechar_Click_1(object sender, EventArgs e)
        {
            TelaAdm admTela1 = new TelaAdm();
            admTela1.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFuncaoNova.Text))
            {
                MessageBox.Show("Obrigatório preencher o campo da nova função!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(textID.Text))
            {
                MessageBox.Show("Obrigatório preencher o campo do ID do funcionário!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int funcionarioID;
            if (!int.TryParse(textID.Text, out funcionarioID))
            {
                MessageBox.Show("ID do funcionário inválido!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Variáveis para armazenar o nome e a função antiga
                string nomeFuncionario = string.Empty;
                string funcaoAntiga = string.Empty;

                // Verificando se o ID do funcionário existe e obtendo o nome e a função antiga
                string checkIDQuery = "SELECT NomeFuncionario, Funcao FROM Funcionario WHERE ID = @id";
                using (SqlCommand checkIDCommand = new SqlCommand(checkIDQuery, cn.Open()))
                {
                    checkIDCommand.Parameters.Add("@id", SqlDbType.Int).Value = funcionarioID;
                    cn.Open();
                    using (SqlDataReader reader = checkIDCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nomeFuncionario = reader["NomeFuncionario"].ToString();
                            funcaoAntiga = reader["Funcao"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("ID do funcionário não encontrado!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cn.Close();
                            return;
                        }
                    }
                    cn.Close();
                }

                // Atualizando a função do funcionário
                string strSQL = "UPDATE Funcionario SET Funcao = @funcao WHERE ID = @id";
                using (SqlCommand updateCommand = new SqlCommand(strSQL, cn.Open()))
                {
                    updateCommand.Parameters.Add("@funcao", SqlDbType.VarChar).Value = textFuncaoNova.Text;
                    updateCommand.Parameters.Add("@id", SqlDbType.Int).Value = funcionarioID;

                    cn.Open();
                    updateCommand.ExecuteNonQuery();
                    cn.Close();

                    // Mensagem de sucesso com o nome do funcionário, função antiga e nova
                    MessageBox.Show($"Funcionário {nomeFuncionario} era '{funcaoAntiga}' e agora é '{textFuncaoNova.Text}'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult resultado = MessageBox.Show("Deseja fazer outra alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        FuncionarioEditar alterarFuncao = new FuncionarioEditar();
                        alterarFuncao.Show();
                        this.Hide();
                    }
                    else
                    {
                        TelaAdm admTela1 = new TelaAdm();
                        admTela1.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                if (cn.Open().State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == 13)
            {
                button8_Click_1(sender, e);
            }

            else if(e.KeyChar == 27)
            {
                textFechar_Click_1(sender, e);
            }

            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Digite o ID corretamente .", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textNovaFuncaoKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button8_Click_1(sender, e);
            }
            else if (e.KeyChar == 27)
            {
                textFechar_Click_1(sender, e);
            }
        }
    }
}

