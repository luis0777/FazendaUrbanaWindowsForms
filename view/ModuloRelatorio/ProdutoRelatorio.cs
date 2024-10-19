using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class ProdutoRelatorio : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        public ProdutoRelatorio()
        {
            InitializeComponent();
            // Definir a cor de fundo do panel5 com transparência (alfa)
            Color semiTransparentColor = Color.FromArgb(128, 0, 0, 0); // 128 é o valor alfa (0-255), 0, 0, 0 é a cor RGB (preto)
            panel5.BackColor = semiTransparentColor;
            LoadData();

            // Adicionar o manipulador de eventos para o redimensionamento do formulário
            this.Resize += new EventHandler(Form_Resize);
        } 

        private void LoadData()
        {
            try
            {
                cn.Open();
                string query = "SELECT * FROM Produtos";
                using (SqlCommand cm = new SqlCommand(query, cn.Open()))
                {
                    using (SqlDataReader dt = cm.ExecuteReader())
                    {
                        listViewProducts.Items.Clear();
                        while (dt.Read())
                        {
                            var item = new ListViewItem(dt["ID"].ToString());
                            item.SubItems.Add(dt["produto"].ToString());
                            item.SubItems.Add(dt["quantidade"].ToString());
                            item.SubItems.Add(dt["preco"].ToString());

                            listViewProducts.Items.Add(item);
                        }
                    }
                }

                // Centralizar o ListView no formulário
                listViewProducts.Left = (this.ClientSize.Width - listViewProducts.Width) / 2;
                listViewProducts.Top = (this.ClientSize.Height - listViewProducts.Height) / 2;
                listViewProducts.Visible = true;

                // Ajustar a largura das colunas inicialmente
                AdjustColumnWidths();
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

        // Manipulador do evento Resize para ajustar as colunas
        private void Form_Resize(object sender, EventArgs e)
        {
            AdjustColumnWidths();
        }

        // Método para ajustar a largura das colunas
        private void AdjustColumnWidths()
        {
            // Ajustar a largura das colunas para preencher a largura do ListView
            if (listViewProducts.Columns.Count > 0)
            {
                int totalWidth = listViewProducts.ClientSize.Width;
                int columnWidth = totalWidth / listViewProducts.Columns.Count;

                foreach (ColumnHeader column in listViewProducts.Columns)
                {
                    column.Width = columnWidth;
                }
            }
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void listViewProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                button4_Click_2(sender, e);
            }
        }
    }
}
