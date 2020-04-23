namespace ProjetoLogin.Apresentacao.UI.UISinistro
{
    partial class CadastrarSinistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarSinistro));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMatriculaMotorista = new System.Windows.Forms.TextBox();
            this.mskDataAcontecido = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoSinistro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDescricaoSinistro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbOrcamento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskContatoTerceiro = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvarSinistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbPlacaVeiculo = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Placa do veículo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tipo do sinistro: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "Data do ocorrido: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Matricula do motorista: ";
            // 
            // txbMatriculaMotorista
            // 
            this.txbMatriculaMotorista.Location = new System.Drawing.Point(358, 170);
            this.txbMatriculaMotorista.MaxLength = 50;
            this.txbMatriculaMotorista.Name = "txbMatriculaMotorista";
            this.txbMatriculaMotorista.Size = new System.Drawing.Size(154, 20);
            this.txbMatriculaMotorista.TabIndex = 1;
            // 
            // mskDataAcontecido
            // 
            this.mskDataAcontecido.Location = new System.Drawing.Point(358, 196);
            this.mskDataAcontecido.Mask = "00/00/0000";
            this.mskDataAcontecido.Name = "mskDataAcontecido";
            this.mskDataAcontecido.Size = new System.Drawing.Size(88, 20);
            this.mskDataAcontecido.TabIndex = 2;
            this.mskDataAcontecido.ValidatingType = typeof(System.DateTime);
            // 
            // cmbTipoSinistro
            // 
            this.cmbTipoSinistro.FormattingEnabled = true;
            this.cmbTipoSinistro.Items.AddRange(new object[] {
            "Multa",
            "Colisão ",
            "Roubo/Furto",
            "Causas Naturais",
            "Outros"});
            this.cmbTipoSinistro.Location = new System.Drawing.Point(358, 248);
            this.cmbTipoSinistro.Name = "cmbTipoSinistro";
            this.cmbTipoSinistro.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoSinistro.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Descrição do sinistro: ";
            // 
            // txbDescricaoSinistro
            // 
            this.txbDescricaoSinistro.Location = new System.Drawing.Point(358, 301);
            this.txbDescricaoSinistro.MaxLength = 4000;
            this.txbDescricaoSinistro.Multiline = true;
            this.txbDescricaoSinistro.Name = "txbDescricaoSinistro";
            this.txbDescricaoSinistro.Size = new System.Drawing.Size(289, 101);
            this.txbDescricaoSinistro.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 67;
            this.label8.Text = "Valor do orçamento:";
            // 
            // txbOrcamento
            // 
            this.txbOrcamento.Location = new System.Drawing.Point(383, 222);
            this.txbOrcamento.MaxLength = 10;
            this.txbOrcamento.Name = "txbOrcamento";
            this.txbOrcamento.Size = new System.Drawing.Size(128, 20);
            this.txbOrcamento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 69;
            this.label5.Text = "Contato de terceiros: ";
            // 
            // mskContatoTerceiro
            // 
            this.mskContatoTerceiro.Location = new System.Drawing.Point(358, 275);
            this.mskContatoTerceiro.Mask = "(00)00000-9999";
            this.mskContatoTerceiro.Name = "mskContatoTerceiro";
            this.mskContatoTerceiro.Size = new System.Drawing.Size(88, 20);
            this.mskContatoTerceiro.TabIndex = 5;
            // 
            // btnSalvarSinistro
            // 
            this.btnSalvarSinistro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarSinistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarSinistro.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarSinistro.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarSinistro.Image")));
            this.btnSalvarSinistro.Location = new System.Drawing.Point(358, 408);
            this.btnSalvarSinistro.Name = "btnSalvarSinistro";
            this.btnSalvarSinistro.Size = new System.Drawing.Size(110, 45);
            this.btnSalvarSinistro.TabIndex = 7;
            this.btnSalvarSinistro.Text = "Salvar";
            this.btnSalvarSinistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarSinistro.UseVisualStyleBackColor = false;
            this.btnSalvarSinistro.Click += new System.EventHandler(this.btnSalvarSinistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // txbPlacaVeiculo
            // 
            this.txbPlacaVeiculo.Location = new System.Drawing.Point(358, 141);
            this.txbPlacaVeiculo.Mask = "AAA-0000";
            this.txbPlacaVeiculo.Name = "txbPlacaVeiculo";
            this.txbPlacaVeiculo.Size = new System.Drawing.Size(88, 20);
            this.txbPlacaVeiculo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 18);
            this.label7.TabIndex = 74;
            this.label7.Text = "R$:";
            // 
            // CadastrarSinistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 491);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbPlacaVeiculo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalvarSinistro);
            this.Controls.Add(this.mskContatoTerceiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbOrcamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDescricaoSinistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoSinistro);
            this.Controls.Add(this.mskDataAcontecido);
            this.Controls.Add(this.txbMatriculaMotorista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarSinistro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir | Sinistro";
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
        private System.Windows.Forms.TextBox txbMatriculaMotorista;
        private System.Windows.Forms.MaskedTextBox mskDataAcontecido;
        private System.Windows.Forms.ComboBox cmbTipoSinistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDescricaoSinistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbOrcamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskContatoTerceiro;
        private System.Windows.Forms.Button btnSalvarSinistro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txbPlacaVeiculo;
        private System.Windows.Forms.Label label7;
    }
}