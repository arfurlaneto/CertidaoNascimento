namespace CertidaoNascimento {
    partial class FormPrincipal {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonGerar = new System.Windows.Forms.Button();
            this.textBoxCertidoes = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.groupBoxValidar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValidar = new System.Windows.Forms.TextBox();
            this.groupGerar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxValidar.SuspendLayout();
            this.groupGerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.imagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGerar.Location = new System.Drawing.Point(156, 19);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(607, 23);
            this.buttonGerar.TabIndex = 0;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // textBoxCertidoes
            // 
            this.textBoxCertidoes.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCertidoes.Location = new System.Drawing.Point(6, 48);
            this.textBoxCertidoes.Multiline = true;
            this.textBoxCertidoes.Name = "textBoxCertidoes";
            this.textBoxCertidoes.ReadOnly = true;
            this.textBoxCertidoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCertidoes.Size = new System.Drawing.Size(757, 137);
            this.textBoxCertidoes.TabIndex = 1;
            // 
            // buttonValidar
            // 
            this.buttonValidar.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidar.Location = new System.Drawing.Point(6, 45);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(757, 23);
            this.buttonValidar.TabIndex = 3;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // groupBoxValidar
            // 
            this.groupBoxValidar.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxValidar.Controls.Add(this.label2);
            this.groupBoxValidar.Controls.Add(this.textBoxValidar);
            this.groupBoxValidar.Controls.Add(this.buttonValidar);
            this.groupBoxValidar.Location = new System.Drawing.Point(12, 199);
            this.groupBoxValidar.Name = "groupBoxValidar";
            this.groupBoxValidar.Size = new System.Drawing.Size(769, 74);
            this.groupBoxValidar.TabIndex = 5;
            this.groupBoxValidar.TabStop = false;
            this.groupBoxValidar.Text = "Validar Certidão de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número";
            // 
            // textBoxValidar
            // 
            this.textBoxValidar.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValidar.Location = new System.Drawing.Point(56, 19);
            this.textBoxValidar.MaxLength = 50;
            this.textBoxValidar.Name = "textBoxValidar";
            this.textBoxValidar.Size = new System.Drawing.Size(707, 20);
            this.textBoxValidar.TabIndex = 4;
            // 
            // groupGerar
            // 
            this.groupGerar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupGerar.Controls.Add(this.label1);
            this.groupGerar.Controls.Add(this.textBoxQtd);
            this.groupGerar.Controls.Add(this.buttonGerar);
            this.groupGerar.Controls.Add(this.textBoxCertidoes);
            this.groupGerar.Location = new System.Drawing.Point(12, 279);
            this.groupGerar.Name = "groupGerar";
            this.groupGerar.Size = new System.Drawing.Size(769, 191);
            this.groupGerar.TabIndex = 6;
            this.groupGerar.TabStop = false;
            this.groupGerar.Text = "Gerar Certidões de Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(74, 19);
            this.textBoxQtd.MaxLength = 5;
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(76, 20);
            this.textBoxQtd.TabIndex = 2;
            this.textBoxQtd.Text = "500";
            // 
            // imagem
            // 
            this.imagem.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagem.ErrorImage = global::CertidaoNascimento.Properties.Resources.numeroCertidao;
            this.imagem.Image = global::CertidaoNascimento.Properties.Resources.numeroCertidao;
            this.imagem.InitialImage = global::CertidaoNascimento.Properties.Resources.numeroCertidao;
            this.imagem.Location = new System.Drawing.Point(168, 12);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(613, 171);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagem.TabIndex = 7;
            this.imagem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CertidaoNascimento.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.groupGerar);
            this.Controls.Add(this.groupBoxValidar);
            this.MaximumSize = new System.Drawing.Size(809, 99999999);
            this.MinimumSize = new System.Drawing.Size(809, 520);
            this.Name = "formPrincipal";
            this.Text = "PREFEITURA DE SOROCABA - Validador/Gerador de Números de Certidão de Nascimento";
            this.groupBoxValidar.ResumeLayout(false);
            this.groupBoxValidar.PerformLayout();
            this.groupGerar.ResumeLayout(false);
            this.groupGerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.imagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.TextBox textBoxCertidoes;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.GroupBox groupBoxValidar;
        private System.Windows.Forms.TextBox textBoxValidar;
        private System.Windows.Forms.GroupBox groupGerar;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
