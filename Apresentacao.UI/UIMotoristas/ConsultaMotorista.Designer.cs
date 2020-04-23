namespace ProjetoLogin
{
    partial class ConsultaMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaMotorista));
            this.txbConsultarMotorista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConsultarMotorista = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConsultarMotorista = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarMotorista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbConsultarMotorista
            // 
            this.txbConsultarMotorista.Location = new System.Drawing.Point(267, 142);
            this.txbConsultarMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.txbConsultarMotorista.Name = "txbConsultarMotorista";
            this.txbConsultarMotorista.Size = new System.Drawing.Size(207, 20);
            this.txbConsultarMotorista.TabIndex = 1;
            this.txbConsultarMotorista.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "Matricula:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvConsultarMotorista
            // 
            this.dgvConsultarMotorista.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultarMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarMotorista.Location = new System.Drawing.Point(79, 190);
            this.dgvConsultarMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultarMotorista.Name = "dgvConsultarMotorista";
            this.dgvConsultarMotorista.RowHeadersWidth = 51;
            this.dgvConsultarMotorista.RowTemplate.Height = 24;
            this.dgvConsultarMotorista.Size = new System.Drawing.Size(574, 277);
            this.dgvConsultarMotorista.TabIndex = 52;
            this.dgvConsultarMotorista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btnConsultarMotorista
            // 
            this.btnConsultarMotorista.BackColor = System.Drawing.Color.White;
            this.btnConsultarMotorista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarMotorista.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarMotorista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultarMotorista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnConsultarMotorista.ForeColor = System.Drawing.Color.White;
            this.btnConsultarMotorista.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarMotorista.Image")));
            this.btnConsultarMotorista.Location = new System.Drawing.Point(493, 137);
            this.btnConsultarMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarMotorista.Name = "btnConsultarMotorista";
            this.btnConsultarMotorista.Size = new System.Drawing.Size(44, 28);
            this.btnConsultarMotorista.TabIndex = 2;
            this.btnConsultarMotorista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarMotorista.UseVisualStyleBackColor = false;
            this.btnConsultarMotorista.Click += new System.EventHandler(this.btnConsultarMotorista_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ConsultaMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 494);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgvConsultarMotorista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsultarMotorista);
            this.Controls.Add(this.txbConsultarMotorista);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaMotorista";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar | Motorista";
            this.Load += new System.EventHandler(this.ConsultaMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarMotorista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarMotorista;
        private System.Windows.Forms.TextBox txbConsultarMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvConsultarMotorista;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}