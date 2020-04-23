namespace ProjetoLogin.Apresentacao.TelasEstoquePeças
{
    partial class ConsultarPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarPeca));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConsultarTodos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProcurarNome = new System.Windows.Forms.Button();
            this.txbNomePecas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnConsultarTodos
            // 
            this.btnConsultarTodos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarTodos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTodos.Location = new System.Drawing.Point(323, 162);
            this.btnConsultarTodos.Name = "btnConsultarTodos";
            this.btnConsultarTodos.Size = new System.Drawing.Size(115, 27);
            this.btnConsultarTodos.TabIndex = 59;
            this.btnConsultarTodos.Text = "Consultar Todos";
            this.btnConsultarTodos.UseVisualStyleBackColor = false;
            this.btnConsultarTodos.Click += new System.EventHandler(this.btnConsultarTodos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 194);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 269);
            this.dataGridView1.TabIndex = 58;
            // 
            // btnProcurarNome
            // 
            this.btnProcurarNome.BackColor = System.Drawing.Color.White;
            this.btnProcurarNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurarNome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProcurarNome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProcurarNome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProcurarNome.ForeColor = System.Drawing.Color.White;
            this.btnProcurarNome.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarNome.Image")));
            this.btnProcurarNome.Location = new System.Drawing.Point(494, 119);
            this.btnProcurarNome.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcurarNome.Name = "btnProcurarNome";
            this.btnProcurarNome.Size = new System.Drawing.Size(44, 28);
            this.btnProcurarNome.TabIndex = 57;
            this.btnProcurarNome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcurarNome.UseVisualStyleBackColor = false;
            // 
            // txbNomePecas
            // 
            this.txbNomePecas.Location = new System.Drawing.Point(277, 124);
            this.txbNomePecas.Margin = new System.Windows.Forms.Padding(2);
            this.txbNomePecas.Name = "txbNomePecas";
            this.txbNomePecas.Size = new System.Drawing.Size(207, 20);
            this.txbNomePecas.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultarPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConsultarTodos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProcurarNome);
            this.Controls.Add(this.txbNomePecas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ConsultarPeca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar | Peça";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConsultarTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProcurarNome;
        private System.Windows.Forms.TextBox txbNomePecas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}