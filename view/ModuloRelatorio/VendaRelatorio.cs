using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class VendaRelatorio : Form
    {
        ConexaoSql cn = new ConexaoSql(); // Instância da classe de conexão
        SqlCommand cm = new SqlCommand(); // Comando SQL
        SqlDataReader dt;

        public VendaRelatorio()
        {
            InitializeComponent();
            // Definir a cor de fundo do panel5 com transparência (alfa)
            Color semiTransparentColor = Color.FromArgb(128, 0, 0, 0); // 128 é o valor alfa (0-255), 0, 0, 0 é a cor RGB (preto)
            panel5.BackColor = semiTransparentColor;

            // Configurar o ComboBox
            comboBox1.Items.AddRange(new string[] { "Todas", "Pitaya Branca", "Pitaya Vermelha", "Pitaya Amarela" });
            comboBox1.SelectedIndex = 0; // Definir valor inicial como "Todas"

            LoadData(); // Carregar dados sem filtro inicialmente

            // Adicionar o manipulador de eventos para o redimensionamento do formulário
            this.Resize += new EventHandler(Form_Resize);

            // Configurar o manipulador de eventos para o ComboBox
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        // Método para carregar os dados do banco de dados no ListView com base no filtro
        private void LoadData(string filtro = "")
        {
            try
            {
                cn.Open();
                string query = "SELECT * FROM Vendas";
                if (!string.IsNullOrEmpty(filtro) && filtro != "Todas")
                {
                    query += " WHERE Produto = @Produto";
                }

                using (SqlCommand cm = new SqlCommand(query, cn.Open()))
                {
                    if (!string.IsNullOrEmpty(filtro) && filtro != "Todas")
                    {
                        cm.Parameters.AddWithValue("@Produto", filtro);
                    }

                    using (SqlDataReader dt = cm.ExecuteReader())
                    {
                        listViewVendas.Items.Clear();
                        listViewVendas.Columns.Clear(); // Limpar colunas existentes

                        // Adicionar colunas ao ListView
                        listViewVendas.Columns.Add("ID");
                        listViewVendas.Columns.Add("Produto");
                        listViewVendas.Columns.Add("Quantidade Vendida");
                        listViewVendas.Columns.Add("Valor Total");
                        listViewVendas.Columns.Add("Forma de Pagamento");

                        int totalUnidades = 0;
                        decimal totalPreco = 0m;

                        while (dt.Read())
                        {
                            var item = new ListViewItem(dt["ID"].ToString());
                            item.SubItems.Add(dt["Produto"].ToString());
                            item.SubItems.Add(dt["QuantidadeVendida"].ToString());
                            item.SubItems.Add(dt["ValorTotal"].ToString());
                            item.SubItems.Add(dt["FormaDePagamento"].ToString());

                            listViewVendas.Items.Add(item);

                            // Atualizar totais
                            totalUnidades += Convert.ToInt32(dt["QuantidadeVendida"]);
                            totalPreco += Convert.ToDecimal(dt["ValorTotal"]);
                        }

                        // Atualizar os campos textUnidades e textPreço
                        textUnidades.Text = totalUnidades.ToString();
                        textPreço.Text = totalPreco.ToString("F2"); // Formatar com duas casas decimais
                    }
                }

                // Centralizar o ListView no formulário
                listViewVendas.Left = (this.ClientSize.Width - listViewVendas.Width) / 2;
                listViewVendas.Top = (this.ClientSize.Height - listViewVendas.Height) / 2;
                listViewVendas.Visible = true;

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
            if (listViewVendas.Columns.Count > 0)
            {
                int totalWidth = listViewVendas.ClientSize.Width;
                int columnWidth = totalWidth / listViewVendas.Columns.Count;

                foreach (ColumnHeader column in listViewVendas.Columns)
                {
                    column.Width = columnWidth;
                }
            }
        }

        // Manipulador do evento SelectedIndexChanged do ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            LoadData(selectedItem);
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

        private void listViewVendas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textUnidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPreço_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
