
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetoFazendaUrbana.conexao;

namespace ProjetoFazendaUrbana.view
{
    public partial class CadastroCliente : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;
        public CadastroCliente()
        {
            InitializeComponent();
        }

        

        private void INICIO_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" || textCPF.Text == "" || textEmail.Text == "" || textSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher todos os campos!!!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textCPF.Text.Length != 14)
            {
                MessageBox.Show("CPF deve ter exatamente 11 dígitos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (textSenha.Text.Length != 4)
            {
                MessageBox.Show("A senha deve ter exatamente 4 dígitos!", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
            {
                try
                {
                    cn.Open();

                    string strSQL = "Select CPF from Cliente where CPF = @CPF";
                    cm.Connection = cn.Open();
                    cm.CommandText = strSQL;
                    cm.Parameters.Clear();
                    cm.Parameters.Add("@CPF", SqlDbType.VarChar).Value = textCPF.Text;
                    dt = cm.ExecuteReader();

                    if (dt.HasRows)
                    {
                        MessageBox.Show("CPF já cadastrado", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (!dt.IsClosed) { dt.Close(); }

                        strSQL = "INSERT INTO [dbo].[Cliente] (NomeCliente, CPF, Email, Senha) VALUES (@NomeCliente, @CPF, @Email, @Senha)";
                        cm.Parameters.Clear(); // Limpa os parâmetros antes de adicionar novos
                        cm.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = textNome.Text;
                        cm.Parameters.Add("@CPF", SqlDbType.VarChar).Value = textCPF.Text;
                        cm.Parameters.Add("@Email", SqlDbType.VarChar).Value = textEmail.Text;
                        cm.Parameters.Add("@Senha", SqlDbType.VarChar).Value = textSenha.Text;

                        cm.Connection = cn.Open();
                        cm.CommandText = strSQL;

                        cm.ExecuteNonQuery();

                        MessageBox.Show("Dados cadastrado com sucesso", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cm.Parameters.Clear();
                        cn.Close(); //conexao fechada

                        TelaVendas menu = new TelaVendas();
                        menu.Show();
                        this.Hide();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
            }
}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // Limpa itens existentes para evitar duplicação
            contextMenuStrip1.Items.Clear();

            // Adiciona itens "Cliente" e "Administrador" ao ContextMenuStrip
            ToolStripMenuItem clienteItem = new ToolStripMenuItem("Cliente");
            ToolStripMenuItem administradorItem = new ToolStripMenuItem("Administrador");

            clienteItem.Click += ClienteItem_Click;
            administradorItem.Click += AdministradorItem_Click;

            contextMenuStrip1.Items.Add(clienteItem);
            contextMenuStrip1.Items.Add(administradorItem);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Obtém a posição do Label
            var label = sender as Label;
            var position = label.PointToScreen(System.Drawing.Point.Empty);
            // Mostra o ContextMenuStrip na posição do Label
            contextMenuStrip1.Show(position.X, position.Y + label.Height);
        }

        private void ClienteItem_Click(object sender, EventArgs e)
        {
            // Abre a tela de login para Cliente
            LoginCliente loginForm = new LoginCliente();
            loginForm.Show();
            this.Hide();
        }

        private void AdministradorItem_Click(object sender, EventArgs e)
        {
            // Abre a tela de login para Administrador
            LoginAdm loginForm = new LoginAdm();
            loginForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Obtém a posição do Label
            var label = sender as Label;
            var position = label.PointToScreen(System.Drawing.Point.Empty);
            QuemSomos menu = new QuemSomos();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Obtém a posição do Label
            var label = sender as Label;
            var position = label.PointToScreen(System.Drawing.Point.Empty);

            //fechar
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            
               

            if (e.KeyChar == 13)
            {

                Cadastrar_Click(sender, e);
            }

        }

        private void textBoxLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Por favor, insira apenas letras.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Se não for uma letra, cancela o evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {

                Cadastrar_Click(sender, e);
            }


        }

        private void textClienteLog_Click(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmailKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                Cadastrar_Click(sender, e);
            }
        }

        private void TextSenhaKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                Cadastrar_Click(sender, e);
            }
        }

        private void textSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}