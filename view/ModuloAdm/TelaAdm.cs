using Mysqlx;
using ProjetoFazendaUrbana.conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class TelaAdm : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        public TelaAdm()
        {
            InitializeComponent();
        }
        private void textFechar_Click(object sender, EventArgs e)
        {
           

            //fechar
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textInicio_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            
            FuncionarioRelatorio menu = new FuncionarioRelatorio();
            menu.Show();
            this.Close();

        }

        private void buttonCloseList_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            VendaRelatorio menu = new VendaRelatorio();
            menu.Show();
            this.Close();

        }               



        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textInicio_Click_1(object sender, EventArgs e)
        {
            // Obtém a posição do Label

            CadastroCliente menu = new CadastroCliente();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" || textCPF.Text == "" || textFuncao.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textCPF.Text.Length != 14)
            {
                MessageBox.Show("CPF incompleto, preencha corretamente!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    string strSQL = "Select CPF from Funcionario where CPF = @CPF";
                    cm.Connection = cn.Open();
                    cm.CommandText = strSQL;
                    cm.Parameters.Clear();
                    cm.Parameters.Add("@CPF", SqlDbType.VarChar).Value = textCPF.Text;
                    dt = cm.ExecuteReader();

                    if (dt.HasRows)
                    {
                        MessageBox.Show("Este CPF já foi cadastrado para um funcionario", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        textCPF.Clear();
                    }
                    else
                    {
                        {
                            if (!dt.IsClosed) { dt.Close(); }

                            strSQL = "INSERT INTO [dbo].[Funcionario] (NomeFuncionario, CPF, Funcao) VALUES (@NomeFuncionario, @CPF, @Funcao)";
                            cm.Parameters.Clear(); // Limpa os parâmetros antes de adicionar novos
                            cm.Parameters.Add("@NomeFuncionario", SqlDbType.VarChar).Value = textNome.Text;
                            cm.Parameters.Add("@CPF", SqlDbType.VarChar).Value = textCPF.Text;
                            cm.Parameters.Add("@Funcao", SqlDbType.VarChar).Value = textFuncao.Text;

                            cm.Connection = cn.Open();
                            cm.CommandText = strSQL;

                            cm.ExecuteNonQuery();

                            MessageBox.Show("Funcionario registrado  com sucesso", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textCPF.Clear();
                            textFuncao.Clear();
                            textNome.Clear();
                            cm.Parameters.Clear();

                            cn.Close(); //conexao fechada

                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textRemover.Text == "")
            {
                MessageBox.Show("Obrigatório fornecer o ID do funcionario que deseja remover !!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    string strSQL = "DELETE FROM Funcionario WHERE ID = " + textRemover.Text;

                    cm.Connection = cn.Open();
                    cm.CommandText = strSQL;

                    int rowsAffected = cm.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Funcionario excluido com sucesso", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ID não encontrado. Por favor, forneça um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    cn.Close(); //conexao fechada
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textEmpresa.Text == "" || textCNPJ.Text == "" || textAdubo.Text == "" || textQAdubo.Text == "" || textAgrotoxico.Text == "" || textQAgrotoxico.Text == "" || textMuda.Text == "" || textQMuda.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textCNPJ.Text.Length != 18)
            {
                MessageBox.Show("CNPJ incompleto, preencha corretamente!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                try
                {

                    cn.Open();
                    string strSQL = "INSERT INTO [dbo].[Fornecedor] (NomeEmpresa, CNPJ, adubo, QuantidadeAdubo, agrotoxico, QuantidadeAgrotoxico, muda, QuantidadeMuda) VALUES (@NomeEmpresa, @CNPJ, @adubo, @QuantidadeAdubo, @agrotoxico, @QuantidadeAgrotoxico, @muda, @QuantidadeMuda)";
                    cm.Parameters.Clear(); // Limpa os parâmetros antes de adicionar novos
                    cm.Parameters.Add("@NomeEmpresa", SqlDbType.VarChar).Value = textEmpresa.Text;
                    cm.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = textCNPJ.Text;
                    cm.Parameters.Add("@adubo", SqlDbType.VarChar).Value = textAdubo.Text;
                    cm.Parameters.Add("@QuantidadeAdubo", SqlDbType.VarChar).Value = textQAdubo.Text;
                    cm.Parameters.Add("@agrotoxico", SqlDbType.VarChar).Value = textAgrotoxico.Text;
                    cm.Parameters.Add("@QuantidadeAgrotoxico", SqlDbType.VarChar).Value = textQAgrotoxico.Text;
                    cm.Parameters.Add("@muda", SqlDbType.VarChar).Value = textMuda.Text;
                    cm.Parameters.Add("@QuantidadeMuda", SqlDbType.VarChar).Value = textQMuda.Text;

                    cm.Connection = cn.Open();
                    cm.CommandText = strSQL;

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor registrado com sucesso", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cm.Parameters.Clear();
                    textEmpresa.Clear();
                    textCNPJ.Clear();
                    textQAdubo.Clear();
                    textAdubo.Items.Clear();
                    textAgrotoxico.Items.Clear();
                    textQAgrotoxico.Clear();
                    textMuda.Items.Clear();
                    textQMuda.Clear ();
                    cn.Close(); //conexao fechada
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textRemoverFor.Text == "")
            {
                MessageBox.Show("Obrigatório fornecer o ID do fornecedor que deseja remover !!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    string strSQL = "DELETE FROM Fornecedor WHERE ID = " + textRemoverFor.Text;

                    cm.Connection = cn.Open();
                    cm.CommandText = strSQL;

                    int rowsAffected = cm.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Fornecedor excluido com sucesso", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ID não encontrado. Por favor, forneça um ID válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    cn.Close(); //conexao fechada
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void listViewFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FuncionarioEditar menu = new FuncionarioEditar();
            menu.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
           
            ClienteRelatorio menu = new ClienteRelatorio();
            menu.Show();
            this.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            ProdutoRelatorio menu = new ProdutoRelatorio();   
            menu.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            MateriaPrimaRelatorio menu = new MateriaPrimaRelatorio();
            menu.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProdutoEditar menu = new ProdutoEditar();
            menu.Show();
            this.Close();
        }

        private void AdmTela1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Por favor, insira apenas letras.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Se não for uma letra, cancela o evento
                e.Handled = true;
            }
        }

        private void TextBoxInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Por favor, insira apenas números .", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (como Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Digite o ID corretamente .", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void textCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textTodosKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Ação desejada quando a tecla F1 é pressionada
                buttonShowList_Click(sender, e); //lista funcionarios
            }

            else if (e.KeyCode == Keys.F2)
            {
                label4_Click(sender, e);//lista vendas realizadas
            }

            else if (e.KeyCode == Keys.F3)
            {
                label5_Click_1(sender, e);//lista clientes cadastrados
            }

            else if (e.KeyCode == Keys.F4)
            {
                label6_Click(sender, e);//lista materia prima
            }

            else if (e.KeyCode == Keys.F5)
            {
                label24_Click(sender, e);//lista de produtos
            }

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}