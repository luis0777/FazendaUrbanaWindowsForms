using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFazendaUrbana.view
{
    public partial class QuemSomos : Form
    {
        public QuemSomos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
            
            CadastroCliente menu = new CadastroCliente();
            menu.Show();
            this.Hide();
        }

        private void textFechar_Click(object sender, EventArgs e)
        {
            // Obtém a posição do Label
            var label = sender as Label;
            var position = label.PointToScreen(System.Drawing.Point.Empty);

            //fechar
            Application.Exit();
        }

        private void QuemSomos_Load(object sender, EventArgs e)
        {

        }

        private void aaaa(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                label1_Click(sender, e);
            }
        }
    }
}
