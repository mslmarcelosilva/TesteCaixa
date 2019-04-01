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
    public partial class FrmCaixa : Form
    {
        public FrmCaixa()
        {
            InitializeComponent();
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {

        }

        public void abrirAplicacao(Form form)
        {            
            form.Show();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            FrmReceberPagamento frmReceberPagamento = new FrmReceberPagamento();
            abrirAplicacao(frmReceberPagamento);
        }

        private void FrmCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {   
                case Keys.F1:
                    btnReceber_Click(sender, e);
                    break;
                case Keys.F2:
                    btnPesquisaProduto_Click(sender, e);
                    break;
                case Keys.F3:
                    btnPesquisaPedidos_Click(sender, e);
                    break;
                case Keys.F5:
                    btnCancelarCupons_Click(sender, e);
                    break;
                case Keys.F6:
                    btnReimprimirCupom_Click(sender, e);
                    break;
                case Keys.F7:
                    btnMenuPrincipal_Click(sender, e);
                    break;
                case Keys.F8:
                    btnFechamentoCaixa_Click(sender, e);
                    break;
                case Keys.F9:
                    btnBloquearTela_Click(sender, e);
                    break;
            }
        }

        private void FrmCaixa_KeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            FrmPesquisaProdutos frmProdutos = new FrmPesquisaProdutos();
            abrirAplicacao(frmProdutos);
        }

        private void btnPesquisaPedidos_Click(object sender, EventArgs e)
        {
            FrmPesquisaPedidos frmPesquisaPedidos = new FrmPesquisaPedidos();
            abrirAplicacao(frmPesquisaPedidos);
        }

        private void btnCancelarCupons_Click(object sender, EventArgs e)
        {
            FrmCancelarCupons frmCancelarCupons = new FrmCancelarCupons();
            abrirAplicacao(frmCancelarCupons);
        }

        private void btnReimprimirCupom_Click(object sender, EventArgs e)
        {
            FrmReimprimirCupom frmReimprimirCupom = new FrmReimprimirCupom();
            abrirAplicacao(frmReimprimirCupom);
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            abrirAplicacao(frmMenuPrincipal);
        }

        private void btnFechamentoCaixa_Click(object sender, EventArgs e)
        {
            FrmFechamentoCaixa frmFechamentoCaixa = new FrmFechamentoCaixa();
            abrirAplicacao(frmFechamentoCaixa);
        }

        private void btnBloquearTela_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            abrirAplicacao(frmLogin);
        }
    }
}
