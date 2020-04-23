namespace ProjetoLogin.Apresentacao.TelasManutenção
{
    partial class CadastrarManutencao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarManutencao));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPlaca = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.txbMotivo = new System.Windows.Forms.TextBox();
            this.txbServicoRealizado = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbRevisao = new System.Windows.Forms.TextBox();
            this.btnSalvarManutencao = new System.Windows.Forms.Button();
            this.mskDataManutencao = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Placa: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Data da manutenção: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Resultado: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Motivo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Valor: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Serviço realizado: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Revisão: ";
            // 
            // txbPlaca
            // 
            this.txbPlaca.Location = new System.Drawing.Point(300, 143);
            this.txbPlaca.Name = "txbPlaca";
            this.txbPlaca.Size = new System.Drawing.Size(173, 20);
            this.txbPlaca.TabIndex = 0;
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(300, 195);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(173, 20);
            this.txbResultado.TabIndex = 2;
            // 
            // txbMotivo
            // 
            this.txbMotivo.Location = new System.Drawing.Point(300, 221);
            this.txbMotivo.Name = "txbMotivo";
            this.txbMotivo.Size = new System.Drawing.Size(173, 20);
            this.txbMotivo.TabIndex = 3;
            // 
            // txbServicoRealizado
            // 
            this.txbServicoRealizado.Location = new System.Drawing.Point(300, 247);
            this.txbServicoRealizado.Name = "txbServicoRealizado";
            this.txbServicoRealizado.Size = new System.Drawing.Size(173, 20);
            this.txbServicoRealizado.TabIndex = 4;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(333, 273);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(84, 20);
            this.txbValor.TabIndex = 5;
            // 
            // txbRevisao
            // 
            this.txbRevisao.Location = new System.Drawing.Point(300, 299);
            this.txbRevisao.Name = "txbRevisao";
            this.txbRevisao.Size = new System.Drawing.Size(173, 20);
            this.txbRevisao.TabIndex = 6;
            // 
            // btnSalvarManutencao
            // 
            this.btnSalvarManutencao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarManutencao.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarManutencao.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarManutencao.Image")));
            this.btnSalvarManutencao.Location = new System.Drawing.Point(312, 338);
            this.btnSalvarManutencao.Name = "btnSalvarManutencao";
            this.btnSalvarManutencao.Size = new System.Drawing.Size(97, 44);
            this.btnSalvarManutencao.TabIndex = 7;
            this.btnSalvarManutencao.Text = "Salvar";
            this.btnSalvarManutencao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarManutencao.UseVisualStyleBackColor = false;
            this.btnSalvarManutencao.Click += new System.EventHandler(this.btnSalvarManutencao_Click);
            // 
            // mskDataManutencao
            // 
            this.mskDataManutencao.Location = new System.Drawing.Point(300, 170);
            this.mskDataManutencao.Mask = "00/00/0000";
            this.mskDataManutencao.Name = "mskDataManutencao";
            this.mskDataManutencao.Size = new System.Drawing.Size(63, 20);
            this.mskDataManutencao.TabIndex = 1;
            this.mskDataManutencao.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 18);
            this.label8.TabIndex = 70;
            this.label8.Text = "R$: ";
            // 
            // CadastrarManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 437);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskDataManutencao);
            this.Controls.Add(this.btnSalvarManutencao);
            this.Controls.Add(this.txbRevisao);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.txbServicoRealizado);
            this.Controls.Add(this.txbMotivo);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.txbPlaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarManutencao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar | Manutencão";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPlaca;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.TextBox txbMotivo;
        private System.Windows.Forms.TextBox txbServicoRealizado;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbRevisao;
        private System.Windows.Forms.Button btnSalvarManutencao;
        private System.Windows.Forms.MaskedTextBox mskDataManutencao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}