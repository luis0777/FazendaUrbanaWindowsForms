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
    public partial class LoginCliente : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;
        public LoginCliente()
        {
            InitializeComponent();
        }
        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void textInicio_Click(object sender, EventArgs e)
        {
           
            CadastroCliente menu = new CadastroCliente();
            menu.Show();
            this.Hide();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (textCPF.Text == "" || textSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(textSenha.Text.Length != 4)
            {
                MessageBox.Show("Senha incompleta!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "SELECT * from Cliente where CPF = ('" + textCPF.Text + "') and Senha = ('" + textSenha.Text + "')";
                    cm.Connection = cn.Open();
                    dt = cm.ExecuteReader();

                    if (dt.HasRows)
                    {
                        MessageBox.Show("Login bem sucedido!!!", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        TelaVendas menu = new TelaVendas();
                        menu.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!!!", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cn.Close();
                        textCPF.Clear();
                        textSenha.Clear();
                    }

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
        }

        private void textFechar_Click(object sender, EventArgs e)
        {
            // Obtém a posição do Label
            var label = sender as Label;
            var position = label.PointToScreen(System.Drawing.Point.Empty);

            //fechar
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textSenha.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textSenha.UseSystemPasswordChar = true;
        }

        private void textCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TextCPFKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //13 representa a tecla ENTER 
            {

                Cadastrar_Click(sender, e);
            }

            if(e.KeyChar == 27) //27 representa a tecla ESC
            {
                textInicio_Click(sender, e);
            }

        }

        private void textSenhaKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//13 representa a tecla ENTER 
            {

                Cadastrar_Click(sender, e);
            }

            if (e.KeyChar == 27)//27 representa a tecla ESC
            {
                textInicio_Click(sender, e);
            }
        }

        private void textEntrarKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                textInicio_Click(sender, e);
            }
        }
    }
}
