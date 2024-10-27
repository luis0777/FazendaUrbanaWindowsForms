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
    public partial class LoginAdm : Form
    {
        public LoginAdm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textInicio_Click(object sender, EventArgs e)
        {
            
            
            CadastroCliente menu = new CadastroCliente();
            menu.Show();
            this.Hide();
        }

        private void textFechar_Click(object sender, EventArgs e)
        {
            

            //fechar
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "" || textSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    if(textUsuario.Text == "admin" && textSenha.Text == "5891")
                    {
                        MessageBox.Show("Login bem sucedido", "SUCESSO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TelaAdm menu = new TelaAdm();
                        menu.Show();
                        this.Hide();
                        
                    }

                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!!!", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textUsuario.Clear();
                        textSenha.Clear();
                    }
                }
                catch (Exception erro)
                {

                    
                }
            
            }

        }

        private void LoginAdm_Load(object sender, EventArgs e)
        {

        }

        private void textUserKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                Cadastrar_Click(sender, e);
            }

            if(e.KeyChar == 27)
            {
                textInicio_Click(sender, e);
            }


        }

        private void textSenhaKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //13 é enter
            {

                Cadastrar_Click(sender, e);
            }

            if (e.KeyChar == 27) // 27 é ESC
            {
                textInicio_Click(sender, e);
            }
        }

        private void textEntrarKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) // 27 é ESC
            {
                textInicio_Click(sender, e);
            }
        }
    }
}
