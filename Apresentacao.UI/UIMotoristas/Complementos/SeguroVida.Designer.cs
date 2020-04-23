namespace ProjetoLogin.Apresentacao.Complementos
{
    partial class SeguroVida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguroVida));
            this.label1 = new System.Windows.Forms.Label();
            this.imgSeguro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSeguro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela Seguro de Vida ";
            // 
            // imgSeguro
            // 
            this.imgSeguro.Image = ((System.Drawing.Image)(resources.GetObject("imgSeguro.Image")));
            this.imgSeguro.Location = new System.Drawing.Point(12, 12);
            this.imgSeguro.Name = "imgSeguro";
            this.imgSeguro.Size = new System.Drawing.Size(114, 109);
            this.imgSeguro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSeguro.TabIndex = 52;
            this.imgSeguro.TabStop = false;
            this.imgSeguro.Click += new System.EventHandler(this.imgSeguro_Click);
            // 
            // SeguroVida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgSeguro);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeguroVida";
            this.ShowIcon = false;
            this.Text = "Seguro de Vida";
            ((System.ComponentModel.ISupportInitialize)(this.imgSeguro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgSeguro;
    }
}