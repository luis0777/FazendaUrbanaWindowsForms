using ProjetoFazendaUrbana.conexao;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace ProjetoFazendaUrbana.view
{
    public partial class ResumoPagamento : Form
    {
        private TelaVendas _vendasForm;

        // Variável para armazenar a forma de pagamento escolhida
        public string FormaDePagamentoEscolhida { get; private set; }

        public decimal ValorTotal { get; private set; }

        public ResumoPagamento(TelaVendas vendasForm)
        {
            InitializeComponent();
            _vendasForm = vendasForm;
            AtualizarValoresNoPagamento();
        }

        private void AtualizarValoresNoPagamento()
        {
            decimal valorTotalBranca = _vendasForm.ValorTotalBranca;
            decimal valorTotalVermelha = _vendasForm.ValorTotalVermelha;
            decimal valorTotalAmarela = _vendasForm.ValorTotalAmarela;
            decimal valorTotalGeral = valorTotalBranca + valorTotalVermelha + valorTotalAmarela;

            ValorTotal = valorTotalGeral;

            textValorTotal.Text = "R$ " + valorTotalGeral.ToString("F2");

            
            decimal quantidadeVermelha = _vendasForm.QuantidadeVermelha;
            textQuanSeLVerm.Text = quantidadeVermelha.ToString() + " unidade(s)";
            textPrecSelVerm.Text = "R$ " + valorTotalVermelha.ToString("F2");


            decimal quantidadeBranca = _vendasForm.QuantidadeBranca;
            textQuanSeLBran.Text = quantidadeBranca.ToString() + " unidade(s)";
            textPrecSelBran.Text = "R$ " + valorTotalBranca.ToString("F2");


            decimal quantidadeAmarela = _vendasForm.QuantidadeAmarela;
            textQuanSeLAmar.Text = quantidadeAmarela.ToString() + " unidade(s)";
            textPrecSelAmar.Text = "R$ " + valorTotalAmarela.ToString("F2");

            

            if (_vendasForm.QuantidadeVermelha > 0)
            {
                textNomeSelVerm.Visible = true;
                textPrecSelVerm.Visible = true;
                textQuanSeLVerm.Visible = true;
            }

            if (_vendasForm.QuantidadeBranca > 0)
            {
                textNomeSelBran.Visible = true;
                textPrecSelBran.Visible = true;
                textQuanSeLBran.Visible = true;
            }

            if (_vendasForm.QuantidadeAmarela > 0)
            {
                textNomeSelAmar.Visible = true;
                textPrecSelAmar.Visible = true;
                textQuanSeLAmar.Visible = true;
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (textForPag.SelectedIndex >= 0)
            {
                // Obtenha a opção selecionada e armazene na variável
                FormaDePagamentoEscolhida = textForPag.SelectedItem.ToString();

                switch (FormaDePagamentoEscolhida)
                {
                    case "Débito":
                        MessageBox.Show("Opção de pagamento: Débito");
                        CartaoPagamento debito = new CartaoPagamento(
                            _vendasForm.QuantidadeBranca,
                            _vendasForm.QuantidadeVermelha,
                            _vendasForm.QuantidadeAmarela,
                            _vendasForm.ValorTotalBranca,
                            _vendasForm.ValorTotalVermelha,
                            _vendasForm.ValorTotalAmarela,
                            FormaDePagamentoEscolhida);
                        debito.Show();
                        this.Close();
                        break;
                    case "Crédito":
                        MessageBox.Show("Opção de pagamento: Crédito");
                        CartaoPagamento credito = new CartaoPagamento(
                            _vendasForm.QuantidadeBranca,
                            _vendasForm.QuantidadeVermelha,
                            _vendasForm.QuantidadeAmarela,
                            _vendasForm.ValorTotalBranca,
                            _vendasForm.ValorTotalVermelha,
                            _vendasForm.ValorTotalAmarela,
                            FormaDePagamentoEscolhida);
                        credito.Show();
                        this.Close();
                        break;
                    case "Pix":
                        MessageBox.Show("Opção de pagamento: Pix");
                        textConfirmaPag menu = new textConfirmaPag(
                            this, 
                            _vendasForm.QuantidadeBranca,
                            _vendasForm.QuantidadeVermelha,
                            _vendasForm.QuantidadeAmarela,
                            _vendasForm.ValorTotalBranca,
                            _vendasForm.ValorTotalVermelha,
                            _vendasForm.ValorTotalAmarela,
                            FormaDePagamentoEscolhida);
                        menu.Show();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Opção de pagamento inválida.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Escolha uma forma de pagamento para continuar", "ATENÇÃO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pagamento_Load(object sender, EventArgs e)
        {

        }

        private void textValorTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFormaPagKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                pictureBox11_Click(sender, e);
            }

            else if(e.KeyChar == 27)
            {
                pictureBox1_Click(sender, e);
            }

            else if(e.KeyChar == 112)
            {
                textResumoClick(sender, e);
            }


        }

        private void textQuanSeLVerm_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TelaVendas menu = new TelaVendas();
            menu.Show();
            this.Hide();
        }

        private void textResumo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textResumoClick(object sender, EventArgs e)
        {
            groupBox1.Visible= true;
        }

        private void textFormaPagKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                // Ação desejada quando a tecla F1 é pressionada
                textResumoClick(sender, e);
            }

            else if(e.KeyCode == Keys.F2)
            {
                label3_Click(sender, e);
            }
        }
    }
}

