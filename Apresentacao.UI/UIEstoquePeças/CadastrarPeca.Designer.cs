namespace ProjetoLogin.Apresentacao.TelasEstoquePeças
{
    partial class CadastrarPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPeca));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNomePeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCodigoPeca = new System.Windows.Forms.TextBox();
            this.txbFornecedor = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.txbDemandaMedia = new System.Windows.Forms.TextBox();
            this.cmbDisponibilidade = new System.Windows.Forms.ComboBox();
            this.btnSalvarDados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nome da peça: ";
            // 
            // txbNomePeca
            // 
            this.txbNomePeca.Location = new System.Drawing.Point(224, 134);
            this.txbNomePeca.Name = "txbNomePeca";
            this.txbNomePeca.Size = new System.Drawing.Size(216, 20);
            this.txbNomePeca.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "Código da peça: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "Demanda média: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Disponibilidade: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Quantidade: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Modelo: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fornecedor: ";
            // 
            // txbCodigoPeca
            // 
            this.txbCodigoPeca.Location = new System.Drawing.Point(224, 160);
            this.txbCodigoPeca.Name = "txbCodigoPeca";
            this.txbCodigoPeca.Size = new System.Drawing.Size(216, 20);
            this.txbCodigoPeca.TabIndex = 1;
            // 
            // txbFornecedor
            // 
            this.txbFornecedor.Location = new System.Drawing.Point(224, 186);
            this.txbFornecedor.Name = "txbFornecedor";
            this.txbFornecedor.Size = new System.Drawing.Size(216, 20);
            this.txbFornecedor.TabIndex = 2;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(224, 212);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(216, 20);
            this.txbModelo.TabIndex = 3;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(224, 238);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(216, 20);
            this.txbQuantidade.TabIndex = 4;
            // 
            // txbDemandaMedia
            // 
            this.txbDemandaMedia.Location = new System.Drawing.Point(224, 290);
            this.txbDemandaMedia.Name = "txbDemandaMedia";
            this.txbDemandaMedia.Size = new System.Drawing.Size(216, 20);
            this.txbDemandaMedia.TabIndex = 6;
            // 
            // cmbDisponibilidade
            // 
            this.cmbDisponibilidade.FormattingEnabled = true;
            this.cmbDisponibilidade.Items.AddRange(new object[] {
            "Disponivel",
            "Indisponivel"});
            this.cmbDisponibilidade.Location = new System.Drawing.Point(224, 263);
            this.cmbDisponibilidade.Name = "cmbDisponibilidade";
            this.cmbDisponibilidade.Size = new System.Drawing.Size(216, 21);
            this.cmbDisponibilidade.TabIndex = 5;
            // 
            // btnSalvarDados
            // 
            this.btnSalvarDados.BackColor = System.Drawing.Color.White;
            this.btnSalvarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarDados.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarDados.Image")));
            this.btnSalvarDados.Location = new System.Drawing.Point(267, 331);
            this.btnSalvarDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarDados.Name = "btnSalvarDados";
            this.btnSalvarDados.Size = new System.Drawing.Size(108, 45);
            this.btnSalvarDados.TabIndex = 7;
            this.btnSalvarDados.Text = "Salvar";
            this.btnSalvarDados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarDados.UseVisualStyleBackColor = false;
            this.btnSalvarDados.Click += new System.EventHandler(this.btnSalvarDados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // CadastrarPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvarDados);
            this.Controls.Add(this.cmbDisponibilidade);
            this.Controls.Add(this.txbDemandaMedia);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.txbFornecedor);
            this.Controls.Add(this.txbCodigoPeca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNomePeca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CadastrarPeca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar | Peça";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNomePeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCodigoPeca;
        private System.Windows.Forms.TextBox txbFornecedor;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.TextBox txbDemandaMedia;
        private System.Windows.Forms.ComboBox cmbDisponibilidade;
        private System.Windows.Forms.Button btnSalvarDados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}