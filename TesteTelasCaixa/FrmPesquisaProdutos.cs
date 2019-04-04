using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteTelasCaixa
{
    public partial class FrmPesquisaProdutos : Form
    {
        public FrmPesquisaProdutos()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frmCadastroProduto = new FrmCadastroProduto();
            frmCadastroProduto.Show();
        }
    }
}
