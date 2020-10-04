namespace Sistema_Bar
{
    partial class FrmCategoria
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
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.labelNomeCategoria1 = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.picBoxImageUp = new System.Windows.Forms.PictureBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelCategoria1 = new System.Windows.Forms.Label();
            this.buttonAltNmCateg = new System.Windows.Forms.Button();
            this.comboBoxOpcoesCategoria = new System.Windows.Forms.ComboBox();
            this.picBoxTrocarImagem = new System.Windows.Forms.PictureBox();
            this.comboBoxSelecionarImg = new System.Windows.Forms.ComboBox();
            this.comboBoxSlotImg = new System.Windows.Forms.ComboBox();
            this.buttonSubstituirImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrocarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Location = new System.Drawing.Point(15, 25);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(164, 21);
            this.comboBoxCateg.TabIndex = 0;
            this.comboBoxCateg.Text = "Selecionar Categoria";
            this.comboBoxCateg.Visible = false;
            this.comboBoxCateg.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCateg_SelectedIndexChanged);
            // 
            // labelNomeCategoria1
            // 
            this.labelNomeCategoria1.AutoSize = true;
            this.labelNomeCategoria1.Location = new System.Drawing.Point(12, 9);
            this.labelNomeCategoria1.Name = "labelNomeCategoria1";
            this.labelNomeCategoria1.Size = new System.Drawing.Size(108, 13);
            this.labelNomeCategoria1.TabIndex = 1;
            this.labelNomeCategoria1.Text = "Selecionar Categoria:";
            this.labelNomeCategoria1.Visible = false;
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
            this.picBoxImageUp.Location = new System.Drawing.Point(26, 52);
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
            // labelCategoria1
            // 
            this.labelCategoria1.Location = new System.Drawing.Point(12, 207);
            this.labelCategoria1.Name = "labelCategoria1";
            this.labelCategoria1.Size = new System.Drawing.Size(167, 31);
            this.labelCategoria1.TabIndex = 9;
            this.labelCategoria1.Text = "Alterar Imagem da Categoria Selecionada Para:";
            this.labelCategoria1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCategoria1.Visible = false;
            // 
            // buttonAltNmCateg
            // 
            this.buttonAltNmCateg.Enabled = false;
            this.buttonAltNmCateg.Location = new System.Drawing.Point(57, 267);
            this.buttonAltNmCateg.Name = "buttonAltNmCateg";
            this.buttonAltNmCateg.Size = new System.Drawing.Size(75, 23);
            this.buttonAltNmCateg.TabIndex = 7;
            this.buttonAltNmCateg.Text = "Alterar!";
            this.buttonAltNmCateg.UseVisualStyleBackColor = true;
            this.buttonAltNmCateg.Visible = false;
            this.buttonAltNmCateg.Click += new System.EventHandler(this.ButtonAltNmCateg_Click);
            // 
            // comboBoxOpcoesCategoria
            // 
            this.comboBoxOpcoesCategoria.FormattingEnabled = true;
            this.comboBoxOpcoesCategoria.Location = new System.Drawing.Point(15, 170);
            this.comboBoxOpcoesCategoria.Name = "comboBoxOpcoesCategoria";
            this.comboBoxOpcoesCategoria.Size = new System.Drawing.Size(164, 21);
            this.comboBoxOpcoesCategoria.TabIndex = 12;
            this.comboBoxOpcoesCategoria.Text = "Selecionar Opção";
            this.comboBoxOpcoesCategoria.Visible = false;
            this.comboBoxOpcoesCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxOpcoesCategoria_SelectedIndexChanged);
            // 
            // picBoxTrocarImagem
            // 
            this.picBoxTrocarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxTrocarImagem.Location = new System.Drawing.Point(26, 268);
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
            this.comboBoxSelecionarImg.Location = new System.Drawing.Point(15, 241);
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
            this.comboBoxSlotImg.Location = new System.Drawing.Point(15, 241);
            this.comboBoxSlotImg.Name = "comboBoxSlotImg";
            this.comboBoxSlotImg.Size = new System.Drawing.Size(164, 21);
            this.comboBoxSlotImg.TabIndex = 16;
            this.comboBoxSlotImg.Text = "Selecionar Imagem";
            this.comboBoxSlotImg.Visible = false;
            this.comboBoxSlotImg.SelectedIndexChanged += new System.EventHandler(this.comboBoxSlotImg_SelectedIndexChanged);
            // 
            // buttonSubstituirImg
            // 
            this.buttonSubstituirImg.Location = new System.Drawing.Point(57, 364);
            this.buttonSubstituirImg.Name = "buttonSubstituirImg";
            this.buttonSubstituirImg.Size = new System.Drawing.Size(75, 23);
            this.buttonSubstituirImg.TabIndex = 17;
            this.buttonSubstituirImg.Text = "Substituir!";
            this.buttonSubstituirImg.UseVisualStyleBackColor = true;
            this.buttonSubstituirImg.Visible = false;
            this.buttonSubstituirImg.Click += new System.EventHandler(this.buttonSubstituirImg_Click_1);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 445);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSubstituirImg);
            this.Controls.Add(this.comboBoxSlotImg);
            this.Controls.Add(this.comboBoxSelecionarImg);
            this.Controls.Add(this.picBoxTrocarImagem);
            this.Controls.Add(this.comboBoxOpcoesCategoria);
            this.Controls.Add(this.labelCategoria1);
            this.Controls.Add(this.buttonAltNmCateg);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.picBoxImageUp);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelNomeCategoria1);
            this.Controls.Add(this.comboBoxCateg);
            this.MaximumSize = new System.Drawing.Size(202, 461);
            this.MinimumSize = new System.Drawing.Size(202, 461);
            this.Name = "FrmCategoria";
            this.Load += new System.EventHandler(this.FormConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTrocarImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxCateg;
        public System.Windows.Forms.Label labelNomeCategoria1;
        public System.Windows.Forms.TextBox textBoxResultado;
        public System.Windows.Forms.PictureBox picBoxImageUp;
        public System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.Label labelCategoria1;
        public System.Windows.Forms.Button buttonAltNmCateg;
        public System.Windows.Forms.ComboBox comboBoxOpcoesCategoria;
        public System.Windows.Forms.PictureBox picBoxTrocarImagem;
        public System.Windows.Forms.ComboBox comboBoxSelecionarImg;
        public System.Windows.Forms.ComboBox comboBoxSlotImg;
        public System.Windows.Forms.Button buttonSubstituirImg;
    }
}