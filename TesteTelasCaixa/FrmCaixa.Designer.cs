namespace TesteTelasCaixa
{
    partial class FrmCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReceber = new System.Windows.Forms.Button();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.btnPesquisaPedidos = new System.Windows.Forms.Button();
            this.btnCancelarCupons = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnFechamentoCaixa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnReimprimirCupom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBloquearTela = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atendimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(969, 474);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1076, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código do Produto:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1023, 330);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 34);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1015, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1263, 378);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(73, 34);
            this.textBox4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1024, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReceber.BackgroundImage = global::TesteTelasCaixa.Properties.Resources.money2;
            this.btnReceber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReceber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReceber.Location = new System.Drawing.Point(6, 553);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(94, 145);
            this.btnReceber.TabIndex = 10;
            this.btnReceber.Text = "Receber (F1)";
            this.btnReceber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPesquisaProduto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaProduto.Image")));
            this.btnPesquisaProduto.Location = new System.Drawing.Point(106, 553);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(94, 145);
            this.btnPesquisaProduto.TabIndex = 11;
            this.btnPesquisaProduto.Text = "Pesquisa de Produtos (F2)";
            this.btnPesquisaProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisaProduto.UseVisualStyleBackColor = false;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.btnPesquisaProduto_Click);
            // 
            // btnPesquisaPedidos
            // 
            this.btnPesquisaPedidos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPesquisaPedidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaPedidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisaPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaPedidos.Image")));
            this.btnPesquisaPedidos.Location = new System.Drawing.Point(206, 553);
            this.btnPesquisaPedidos.Name = "btnPesquisaPedidos";
            this.btnPesquisaPedidos.Size = new System.Drawing.Size(94, 145);
            this.btnPesquisaPedidos.TabIndex = 12;
            this.btnPesquisaPedidos.Text = "Pesquisa de Pedidos (F3)";
            this.btnPesquisaPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisaPedidos.UseVisualStyleBackColor = false;
            this.btnPesquisaPedidos.Click += new System.EventHandler(this.btnPesquisaPedidos_Click);
            // 
            // btnCancelarCupons
            // 
            this.btnCancelarCupons.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelarCupons.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCupons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCupons.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarCupons.Image")));
            this.btnCancelarCupons.Location = new System.Drawing.Point(307, 553);
            this.btnCancelarCupons.Name = "btnCancelarCupons";
            this.btnCancelarCupons.Size = new System.Drawing.Size(94, 145);
            this.btnCancelarCupons.TabIndex = 13;
            this.btnCancelarCupons.Text = "Cancelar Cupom (F5)";
            this.btnCancelarCupons.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCupons.UseVisualStyleBackColor = false;
            this.btnCancelarCupons.Click += new System.EventHandler(this.btnCancelarCupons_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenuPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuPrincipal.Image")));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(942, 553);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(94, 145);
            this.btnMenuPrincipal.TabIndex = 14;
            this.btnMenuPrincipal.Text = "Menu Principal (F7)";
            this.btnMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnFechamentoCaixa
            // 
            this.btnFechamentoCaixa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechamentoCaixa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechamentoCaixa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechamentoCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnFechamentoCaixa.Image")));
            this.btnFechamentoCaixa.Location = new System.Drawing.Point(1142, 553);
            this.btnFechamentoCaixa.Name = "btnFechamentoCaixa";
            this.btnFechamentoCaixa.Size = new System.Drawing.Size(94, 145);
            this.btnFechamentoCaixa.TabIndex = 15;
            this.btnFechamentoCaixa.Text = "Fechamento de Caixa (F8)";
            this.btnFechamentoCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechamentoCaixa.UseVisualStyleBackColor = false;
            this.btnFechamentoCaixa.Click += new System.EventHandler(this.btnFechamentoCaixa_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1042, 553);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 145);
            this.button6.TabIndex = 16;
            this.button6.Text = "Abrir Gaveta (ALT+A)";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnReimprimirCupom
            // 
            this.btnReimprimirCupom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReimprimirCupom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimirCupom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReimprimirCupom.Image = ((System.Drawing.Image)(resources.GetObject("btnReimprimirCupom.Image")));
            this.btnReimprimirCupom.Location = new System.Drawing.Point(407, 553);
            this.btnReimprimirCupom.Name = "btnReimprimirCupom";
            this.btnReimprimirCupom.Size = new System.Drawing.Size(94, 145);
            this.btnReimprimirCupom.TabIndex = 17;
            this.btnReimprimirCupom.Text = "Reimprimir Cupom (F6)";
            this.btnReimprimirCupom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReimprimirCupom.UseVisualStyleBackColor = false;
            this.btnReimprimirCupom.Click += new System.EventHandler(this.btnReimprimirCupom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1018, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total:                      R$ 0,00";
            // 
            // btnBloquearTela
            // 
            this.btnBloquearTela.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBloquearTela.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBloquearTela.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBloquearTela.Image = ((System.Drawing.Image)(resources.GetObject("btnBloquearTela.Image")));
            this.btnBloquearTela.Location = new System.Drawing.Point(1242, 553);
            this.btnBloquearTela.Name = "btnBloquearTela";
            this.btnBloquearTela.Size = new System.Drawing.Size(94, 145);
            this.btnBloquearTela.TabIndex = 19;
            this.btnBloquearTela.Text = "Bloquear Caixa (F9)";
            this.btnBloquearTela.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBloquearTela.UseVisualStyleBackColor = false;
            this.btnBloquearTela.Click += new System.EventHandler(this.btnBloquearTela_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Operador:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(240, 1);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 21;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1370, 702);
            this.ControlBox = false;
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBloquearTela);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReimprimirCupom);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnFechamentoCaixa);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnCancelarCupons);
            this.Controls.Add(this.btnPesquisaPedidos);
            this.Controls.Add(this.btnPesquisaProduto);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCaixa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReceber;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.Button btnPesquisaPedidos;
        private System.Windows.Forms.Button btnCancelarCupons;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnFechamentoCaixa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnReimprimirCupom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBloquearTela;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
    }
}