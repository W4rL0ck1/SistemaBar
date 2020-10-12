namespace Sistema_Bar
{
    partial class FrmProduto
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
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelNomeProduto1 = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.picBoxImageUp = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelProduto1 = new System.Windows.Forms.Label();
            this.buttonAltNmProduto = new System.Windows.Forms.Button();
            this.comboBoxOpcoesProduto = new System.Windows.Forms.ComboBox();
            this.picBoxTrocarImagem = new System.Windows.Forms.PictureBox();
            this.comboBoxSelecionarImg = new System.Windows.Forms.ComboBox();
            this.comboBoxSlotImg = new System.Windows.Forms.ComboBox();
            this.buttonSubstituirImg = new System.Windows.Forms.Button();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.buttonDesativarProduto = new System.Windows.Forms.Button();
            this.buttonAtivarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrocarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(15, 25);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(164, 21);
            this.comboBoxCategoria.TabIndex = 0;
            this.comboBoxCategoria.Text = "Selecionar Categoria";
            this.comboBoxCategoria.Visible = false;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCateg_SelectedIndexChanged);
            // 
            // labelNomeProduto1
            // 
            this.labelNomeProduto1.AutoSize = true;
            this.labelNomeProduto1.Location = new System.Drawing.Point(12, 9);
            this.labelNomeProduto1.Name = "labelNomeProduto1";
            this.labelNomeProduto1.Size = new System.Drawing.Size(108, 13);
            this.labelNomeProduto1.TabIndex = 1;
            this.labelNomeProduto1.Text = "Selecionar Categoria:";
            this.labelNomeProduto1.Visible = false;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(15, 241);
            this.textBoxResultado.MaxLength = 14;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(164, 20);
            this.textBoxResultado.TabIndex = 2;
            this.textBoxResultado.Visible = false;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // picBoxImageUp
            // 
            this.picBoxImageUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxImageUp.Location = new System.Drawing.Point(26, 79);
            this.picBoxImageUp.Name = "picBoxImageUp";
            this.picBoxImageUp.Size = new System.Drawing.Size(136, 101);
            this.picBoxImageUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImageUp.TabIndex = 4;
            this.picBoxImageUp.TabStop = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(57, 421);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Fechar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Visible = false;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // labelProduto1
            // 
            this.labelProduto1.Location = new System.Drawing.Point(12, 207);
            this.labelProduto1.Name = "labelProduto1";
            this.labelProduto1.Size = new System.Drawing.Size(167, 31);
            this.labelProduto1.TabIndex = 9;
            this.labelProduto1.Text = "Alterar Imagem do Produto para :";
            this.labelProduto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProduto1.Visible = false;
            // 
            // buttonAltNmProduto
            // 
            this.buttonAltNmProduto.Enabled = false;
            this.buttonAltNmProduto.Location = new System.Drawing.Point(57, 297);
            this.buttonAltNmProduto.Name = "buttonAltNmProduto";
            this.buttonAltNmProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonAltNmProduto.TabIndex = 7;
            this.buttonAltNmProduto.Text = "Alterar!";
            this.buttonAltNmProduto.UseVisualStyleBackColor = true;
            this.buttonAltNmProduto.Visible = false;
            this.buttonAltNmProduto.Click += new System.EventHandler(this.ButtonAltNmCateg_Click);
            // 
            // comboBoxOpcoesProduto
            // 
            this.comboBoxOpcoesProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOpcoesProduto.FormattingEnabled = true;
            this.comboBoxOpcoesProduto.Location = new System.Drawing.Point(15, 183);
            this.comboBoxOpcoesProduto.Name = "comboBoxOpcoesProduto";
            this.comboBoxOpcoesProduto.Size = new System.Drawing.Size(164, 21);
            this.comboBoxOpcoesProduto.TabIndex = 12;
            this.comboBoxOpcoesProduto.Text = "Selecionar Opção";
            this.comboBoxOpcoesProduto.Visible = false;
            this.comboBoxOpcoesProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpcoesCategoria_SelectedIndexChanged);
            // 
            // picBoxTrocarImagem
            // 
            this.picBoxTrocarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxTrocarImagem.Location = new System.Drawing.Point(26, 297);
            this.picBoxTrocarImagem.Name = "picBoxTrocarImagem";
            this.picBoxTrocarImagem.Size = new System.Drawing.Size(136, 90);
            this.picBoxTrocarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTrocarImagem.TabIndex = 13;
            this.picBoxTrocarImagem.TabStop = false;
            this.picBoxTrocarImagem.Visible = false;
            // 
            // comboBoxSelecionarImg
            // 
            this.comboBoxSelecionarImg.FormattingEnabled = true;
            this.comboBoxSelecionarImg.Location = new System.Drawing.Point(12, 267);
            this.comboBoxSelecionarImg.Name = "comboBoxSelecionarImg";
            this.comboBoxSelecionarImg.Size = new System.Drawing.Size(164, 21);
            this.comboBoxSelecionarImg.TabIndex = 14;
            this.comboBoxSelecionarImg.Text = "Selecionar Imagem";
            this.comboBoxSelecionarImg.Visible = false;
            this.comboBoxSelecionarImg.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelecionarImg_SelectedIndexChanged);
            // 
            // comboBoxSlotImg
            // 
            this.comboBoxSlotImg.FormattingEnabled = true;
            this.comboBoxSlotImg.Location = new System.Drawing.Point(-2, 270);
            this.comboBoxSlotImg.Name = "comboBoxSlotImg";
            this.comboBoxSlotImg.Size = new System.Drawing.Size(164, 21);
            this.comboBoxSlotImg.TabIndex = 16;
            this.comboBoxSlotImg.Text = "Selecionar Imagem";
            this.comboBoxSlotImg.Visible = false;
            // 
            // buttonSubstituirImg
            // 
            this.buttonSubstituirImg.Location = new System.Drawing.Point(57, 392);
            this.buttonSubstituirImg.Name = "buttonSubstituirImg";
            this.buttonSubstituirImg.Size = new System.Drawing.Size(75, 23);
            this.buttonSubstituirImg.TabIndex = 17;
            this.buttonSubstituirImg.Text = "Substituir!";
            this.buttonSubstituirImg.UseVisualStyleBackColor = true;
            this.buttonSubstituirImg.Visible = false;
            this.buttonSubstituirImg.Click += new System.EventHandler(this.buttonSubstituirImg_Click_1);
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(15, 52);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(164, 21);
            this.comboBoxProduto.TabIndex = 18;
            this.comboBoxProduto.Text = "Selecionar Produto";
            this.comboBoxProduto.Visible = false;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // buttonDesativarProduto
            // 
            this.buttonDesativarProduto.Enabled = false;
            this.buttonDesativarProduto.Location = new System.Drawing.Point(99, 268);
            this.buttonDesativarProduto.Name = "buttonDesativarProduto";
            this.buttonDesativarProduto.Size = new System.Drawing.Size(80, 23);
            this.buttonDesativarProduto.TabIndex = 19;
            this.buttonDesativarProduto.Text = "DESATIVAR";
            this.buttonDesativarProduto.UseVisualStyleBackColor = true;
            this.buttonDesativarProduto.Visible = false;
            this.buttonDesativarProduto.Click += new System.EventHandler(this.buttonDesativarProduto_Click);
            // 
            // buttonAtivarProduto
            // 
            this.buttonAtivarProduto.Enabled = false;
            this.buttonAtivarProduto.Location = new System.Drawing.Point(15, 268);
            this.buttonAtivarProduto.Name = "buttonAtivarProduto";
            this.buttonAtivarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonAtivarProduto.TabIndex = 20;
            this.buttonAtivarProduto.Text = "ATIVAR";
            this.buttonAtivarProduto.UseVisualStyleBackColor = true;
            this.buttonAtivarProduto.Visible = false;
            this.buttonAtivarProduto.Click += new System.EventHandler(this.buttonAtivarProduto_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 445);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAtivarProduto);
            this.Controls.Add(this.buttonDesativarProduto);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.buttonSubstituirImg);
            this.Controls.Add(this.comboBoxSlotImg);
            this.Controls.Add(this.comboBoxSelecionarImg);
            this.Controls.Add(this.picBoxTrocarImagem);
            this.Controls.Add(this.comboBoxOpcoesProduto);
            this.Controls.Add(this.labelProduto1);
            this.Controls.Add(this.buttonAltNmProduto);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.picBoxImageUp);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelNomeProduto1);
            this.Controls.Add(this.comboBoxCategoria);
            this.MaximumSize = new System.Drawing.Size(202, 461);
            this.MinimumSize = new System.Drawing.Size(202, 461);
            this.Name = "FrmProduto";
            this.Load += new System.EventHandler(this.FormConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrocarImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxCategoria;
        public System.Windows.Forms.Label labelNomeProduto1;
        public System.Windows.Forms.TextBox textBoxResultado;
        public System.Windows.Forms.PictureBox picBoxImageUp;
        public System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.Label labelProduto1;
        public System.Windows.Forms.Button buttonAltNmProduto;
        public System.Windows.Forms.ComboBox comboBoxOpcoesProduto;
        public System.Windows.Forms.PictureBox picBoxTrocarImagem;
        public System.Windows.Forms.ComboBox comboBoxSelecionarImg;
        public System.Windows.Forms.ComboBox comboBoxSlotImg;
        public System.Windows.Forms.Button buttonSubstituirImg;
        public System.Windows.Forms.ComboBox comboBoxProduto;
        public System.Windows.Forms.Button buttonDesativarProduto;
        public System.Windows.Forms.Button buttonAtivarProduto;
    }
}