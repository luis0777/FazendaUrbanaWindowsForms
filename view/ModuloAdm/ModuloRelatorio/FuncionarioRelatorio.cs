using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class FuncionarioRelatorio : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        public FuncionarioRelatorio()
        {
            InitializeComponent();
            // Definir a cor de fundo do panel5 com transparência (alfa)
            Color semiTransparentColor = Color.FromArgb(128, 0, 0, 0); // 128 é o valor alfa (0-255), 0, 0, 0 é a cor RGB (preto)
            panel5.BackColor = semiTransparentColor;
            LoadData();

            // Adicionar o manipulador de eventos Resize
            this.Resize += new EventHandler(Form_Resize);
        }

        private void LoadData()
        {
            try
            {
                cn.Open();
                string query = "SELECT * FROM Funcionario";
                using (SqlCommand cm = new SqlCommand(query, cn.Open()))
                {
                    using (SqlDataReader dt = cm.ExecuteReader())
                    {
                        listViewClientes.Items.Clear();
                        while (dt.Read())
                        {
                            var item = new ListViewItem(dt["ID"].ToString());
                            item.SubItems.Add(dt["NomeFuncionario"].ToString());
                            item.SubItems.Add(dt["CPF"].ToString());
                            item.SubItems.Add(dt["funcao"].ToString());

                            listViewClientes.Items.Add(item);
                        }
                    }
                }

                // Centralizar o ListView no formulário
                listViewClientes.Left = (this.ClientSize.Width - listViewClientes.Width) / 2;
                listViewClientes.Top = (this.ClientSize.Height - listViewClientes.Height) / 2;
                listViewClientes.Visible = true;

                // Ajustar colunas após carregar dados
                Form_Resize(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                cn.Close(); // Certifique-se de fechar a conexão
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            // Verifique se há pelo menos uma coluna
            if (listViewClientes.Columns.Count > 0)
            {
                // Defina a largura total das colunas para a largura do ListView
                int totalWidth = listViewClientes.ClientSize.Width;

                // Ajustar a largura da primeira coluna
                listViewClientes.Columns[0].Width = totalWidth / 4; // Ajuste a largura proporcional conforme necessário

                // Ajustar as larguras das outras colunas
                for (int i = 1; i < listViewClientes.Columns.Count; i++)
                {
                    listViewClientes.Columns[i].Width = (totalWidth - listViewClientes.Columns[0].Width) / (listViewClientes.Columns.Count - 1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
