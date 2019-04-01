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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            if(login != null)
            {
                this.Hide();        
                FrmCaixa frmCaixa = new FrmCaixa();
                abrirAplicacao(frmCaixa);                
            }
        }

        public void abrirAplicacao(Form form)
        {
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
