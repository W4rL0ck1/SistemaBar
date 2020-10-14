namespace Sistema_Bar
{
    partial class FrmProduto2
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
            this.textBoxCodigoBarras = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelProduto1 = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.comboBoxOpcoesProduto = new System.Windows.Forms.ComboBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.picBoxImageUp = new System.Windows.Forms.PictureBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageUp)).BeginInit();
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
            // textBoxCodigoBarras
            // 
            this.textBoxCodigoBarras.Location = new System.Drawing.Point(15, 241);
            this.textBoxCodigoBarras.MaxLength = 13;
            this.textBoxCodigoBarras.Name = "textBoxCodigoBarras";
            this.textBoxCodigoBarras.Size = new System.Drawing.Size(164, 20);
            this.textBoxCodigoBarras.TabIndex = 2;
            this.textBoxCodigoBarras.Visible = false;
            this.textBoxCodigoBarras.TextChanged += new System.EventHandler(this.textBoxCodigoBarras_TextChanged);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(57, 309);
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
            this.labelProduto1.Text = "Testeeeee";
            this.labelProduto1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProduto1.Visible = false;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Enabled = false;
            this.buttonAlterar.Location = new System.Drawing.Point(57, 280);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 7;
            this.buttonAlterar.Text = "Alterar!";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Visible = false;
            this.buttonAlterar.Click += new System.EventHandler(this.ButtonAltNmCateg_Click);
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
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(15, 241);
            this.textBoxPreco.MaxLength = 14;
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(164, 20);
            this.textBoxPreco.TabIndex = 19;
            this.textBoxPreco.Visible = false;
            this.textBoxPreco.TextChanged += new System.EventHandler(this.textBoxPreco_TextChanged);
            // 
            // FrmProduto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 336);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.comboBoxProduto);
            this.Controls.Add(this.comboBoxOpcoesProduto);
            this.Controls.Add(this.labelProduto1);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.picBoxImageUp);
            this.Controls.Add(this.textBoxCodigoBarras);
            this.Controls.Add(this.labelNomeProduto1);
            this.Controls.Add(this.comboBoxCategoria);
            this.MaximumSize = new System.Drawing.Size(202, 352);
            this.MinimumSize = new System.Drawing.Size(202, 352);
            this.Name = "FrmProduto2";
            this.Load += new System.EventHandler(this.FormConfirm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxCategoria;
        public System.Windows.Forms.Label labelNomeProduto1;
        public System.Windows.Forms.TextBox textBoxCodigoBarras;
        public System.Windows.Forms.PictureBox picBoxImageUp;
        public System.Windows.Forms.Button buttonCancelar;
        public System.Windows.Forms.Label labelProduto1;
        public System.Windows.Forms.Button buttonAlterar;
        public System.Windows.Forms.ComboBox comboBoxOpcoesProduto;
        public System.Windows.Forms.ComboBox comboBoxProduto;
        public System.Windows.Forms.TextBox textBoxPreco;
    }
}