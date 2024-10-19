using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class MateriaPrimaRelatorio : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        public MateriaPrimaRelatorio()
        {
            InitializeComponent();
            // Definir a cor de fundo do panel1 com transparência (alfa)
            Color semiTransparentColor = Color.FromArgb(128, 0, 0, 0); // 128 é o valor alfa (0-255), 0, 0, 0 é a cor RGB (preto)
            panel1.BackColor = semiTransparentColor;
            LoadData();

            // Adicionar o manipulador de eventos para o redimensionamento do formulário
            this.Resize += new EventHandler(Form_Resize);
        }

        private void LoadData()
        {
            try
            {
                cn.Open();
                string query = "SELECT * FROM Fornecedor";
                using (SqlCommand cm = new SqlCommand(query, cn.Open()))
                {
                    using (SqlDataReader dt = cm.ExecuteReader())
                    {
                        listViewFornecedor.Items.Clear();
                        while (dt.Read())
                        {
                            var item = new ListViewItem(dt["ID"].ToString());
                            item.SubItems.Add(dt["NomeEmpresa"].ToString());
                            item.SubItems.Add(dt["CNPJ"].ToString());
                            item.SubItems.Add(dt["adubo"].ToString());
                            item.SubItems.Add(dt["QuantidadeAdubo"].ToString());
                            item.SubItems.Add(dt["agrotoxico"].ToString());
                            item.SubItems.Add(dt["QuantidadeAgrotoxico"].ToString());
                            item.SubItems.Add(dt["muda"].ToString());
                            item.SubItems.Add(dt["QuantidadeMuda"].ToString());

                            listViewFornecedor.Items.Add(item);
                        }
                    }
                }

                // Centralizar o ListView no formulário
                listViewFornecedor.Left = (this.ClientSize.Width - listViewFornecedor.Width) / 2;
                listViewFornecedor.Top = (this.ClientSize.Height - listViewFornecedor.Height) / 2;
                listViewFornecedor.Visible = true;

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
            if (listViewFornecedor.Columns.Count > 0)
            {
                int totalWidth = listViewFornecedor.ClientSize.Width;
                int columnWidth = totalWidth / listViewFornecedor.Columns.Count;

                foreach (ColumnHeader column in listViewFornecedor.Columns)
                {
                    column.Width = columnWidth;
                }
            }
        }

        private void listViewVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaAdm menu = new TelaAdm();
            menu.Show();
            this.Close();
        }

        private void listViewFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
