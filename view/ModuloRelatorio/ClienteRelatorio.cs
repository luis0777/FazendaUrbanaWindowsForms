using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class ClienteRelatorio : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;
        public ClienteRelatorio()
        {
            InitializeComponent();
            // Definir a cor de fundo do panel5 com transparência (alfa)
            Color semiTransparentColor = Color.FromArgb(128, 0, 0, 0); // 128 é o valor alfa (0-255), 0, 0, 0 é a cor RGB (preto)
            panel5.BackColor = semiTransparentColor;
            LoadData();

            // Adicionar o manipulador de eventos para o redimensionamento do formulário
            this.Resize += new EventHandler(Form_Resize);
        }

        

        // Método para carregar os dados do banco de dados no ListView
        private void LoadData()
        {
            try
            {
                cn.Open();

                string query = "SELECT * FROM Cliente";
                using (SqlCommand cm = new SqlCommand(query, cn.Open()))
                {
                    using (SqlDataReader dt = cm.ExecuteReader())
                    {
                        listViewCliente.Items.Clear();
                        listViewCliente.Columns.Clear(); // Limpar colunas existentes

                        // Adicionar colunas ao ListView
                        listViewCliente.Columns.Add("ID");
                        listViewCliente.Columns.Add("Nome");
                        listViewCliente.Columns.Add("CPF");
                        listViewCliente.Columns.Add("Email");
                        listViewCliente.Columns.Add("Senha");

                        while (dt.Read())
                        {
                            var item = new ListViewItem(dt["ID"].ToString());
                            item.SubItems.Add(dt["NomeCliente"].ToString());
                            item.SubItems.Add(dt["CPF"].ToString());
                            item.SubItems.Add(dt["Email"].ToString());
                            item.SubItems.Add(dt["Senha"].ToString());

                            listViewCliente.Items.Add(item);
                        }
                    }
                }

                // Ajustar a largura das colunas inicialmente
                AdjustColumnWidths();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        // Manipulador do evento Resize para ajustar as colunas
        private void Form_Resize(object sender, EventArgs e)
        {
            AdjustColumnWidths();
        }

        // Método para ajustar a largura das colunas
        private void AdjustColumnWidths()
        {
            // Ajustar a largura das colunas para preencher a largura do ListView
            if (listViewCliente.Columns.Count > 0)
            {
                int totalWidth = listViewCliente.ClientSize.Width;
                int columnWidth = totalWidth / listViewCliente.Columns.Count;

                foreach (ColumnHeader column in listViewCliente.Columns)
                {
                    column.Width = columnWidth;
                }
            }
        }

        // Implementação do evento SelectedIndexChanged, se necessário
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Adicione aqui o código que deseja executar quando o item selecionado no ListView mudar
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Close();
        }

        private void listViewCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
