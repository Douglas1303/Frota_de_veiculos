namespace ProjetoLogin
{
    partial class ExcluirMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirMotorista));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbExcluirMotorista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExcluirMotorista = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBuscarMotorista = new System.Windows.Forms.Button();
            this.dgvConsultarMotorista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(299, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // txbExcluirMotorista
            // 
            this.txbExcluirMotorista.Location = new System.Drawing.Point(403, 164);
            this.txbExcluirMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.txbExcluirMotorista.Name = "txbExcluirMotorista";
            this.txbExcluirMotorista.Size = new System.Drawing.Size(207, 20);
            this.txbExcluirMotorista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Matricula:";
            // 
            // BtnExcluirMotorista
            // 
            this.BtnExcluirMotorista.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnExcluirMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluirMotorista.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluirMotorista.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluirMotorista.Location = new System.Drawing.Point(403, 459);
            this.BtnExcluirMotorista.Name = "BtnExcluirMotorista";
            this.BtnExcluirMotorista.Size = new System.Drawing.Size(211, 45);
            this.BtnExcluirMotorista.TabIndex = 3;
            this.BtnExcluirMotorista.Text = "Excluir Motorista";
            this.BtnExcluirMotorista.UseVisualStyleBackColor = false;
            this.BtnExcluirMotorista.Click += new System.EventHandler(this.BtnExcluirMotorista_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBuscarMotorista
            // 
            this.btnBuscarMotorista.BackColor = System.Drawing.Color.White;
            this.btnBuscarMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarMotorista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarMotorista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscarMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBuscarMotorista.ForeColor = System.Drawing.Color.White;
            this.btnBuscarMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMotorista.Image")));
            this.btnBuscarMotorista.Location = new System.Drawing.Point(614, 159);
            this.btnBuscarMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarMotorista.Name = "btnBuscarMotorista";
            this.btnBuscarMotorista.Size = new System.Drawing.Size(44, 28);
            this.btnBuscarMotorista.TabIndex = 2;
            this.btnBuscarMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarMotorista.UseVisualStyleBackColor = false;
            this.btnBuscarMotorista.Click += new System.EventHandler(this.btnBuscarMotorista_Click_1);
            // 
            // dgvConsultarMotorista
            // 
            this.dgvConsultarMotorista.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultarMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarMotorista.Location = new System.Drawing.Point(131, 197);
            this.dgvConsultarMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultarMotorista.Name = "dgvConsultarMotorista";
            this.dgvConsultarMotorista.RowHeadersWidth = 51;
            this.dgvConsultarMotorista.RowTemplate.Height = 24;
            this.dgvConsultarMotorista.Size = new System.Drawing.Size(737, 246);
            this.dgvConsultarMotorista.TabIndex = 60;
            this.dgvConsultarMotorista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarMotorista_CellClick);
            // 
            // ExcluirMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 527);
            this.Controls.Add(this.dgvConsultarMotorista);
            this.Controls.Add(this.btnBuscarMotorista);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnExcluirMotorista);
            this.Controls.Add(this.txbExcluirMotorista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcluirMotorista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir | Motorista";
            this.Load += new System.EventHandler(this.ExcluirMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarMotorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txbExcluirMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcluirMotorista;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuscarMotorista;
        private System.Windows.Forms.DataGridView dgvConsultarMotorista;
    }
}