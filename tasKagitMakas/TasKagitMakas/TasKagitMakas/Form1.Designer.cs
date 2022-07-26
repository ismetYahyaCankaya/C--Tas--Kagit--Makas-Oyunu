namespace TasKagitMakas
{
    partial class tasKagirMakasForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tasKagirMakasForm));
            this.secimTas = new System.Windows.Forms.PictureBox();
            this.secimKagit = new System.Windows.Forms.PictureBox();
            this.tkmPic = new System.Windows.Forms.PictureBox();
            this.secimMakas = new System.Windows.Forms.PictureBox();
            this.skorLabel = new System.Windows.Forms.Label();
            this.durumLabel = new System.Windows.Forms.Label();
            this.skorPcLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secimTas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secimKagit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkmPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secimMakas)).BeginInit();
            this.SuspendLayout();
            // 
            // secimTas
            // 
            this.secimTas.Image = ((System.Drawing.Image)(resources.GetObject("secimTas.Image")));
            this.secimTas.Location = new System.Drawing.Point(55, 145);
            this.secimTas.Name = "secimTas";
            this.secimTas.Size = new System.Drawing.Size(181, 98);
            this.secimTas.TabIndex = 0;
            this.secimTas.TabStop = false;
            this.secimTas.Click += new System.EventHandler(this.secimTas_Click);
            // 
            // secimKagit
            // 
            this.secimKagit.Image = ((System.Drawing.Image)(resources.GetObject("secimKagit.Image")));
            this.secimKagit.Location = new System.Drawing.Point(252, 145);
            this.secimKagit.Name = "secimKagit";
            this.secimKagit.Size = new System.Drawing.Size(173, 98);
            this.secimKagit.TabIndex = 1;
            this.secimKagit.TabStop = false;
            this.secimKagit.Click += new System.EventHandler(this.secimKagit_Click);
            // 
            // tkmPic
            // 
            this.tkmPic.Location = new System.Drawing.Point(547, 177);
            this.tkmPic.Name = "tkmPic";
            this.tkmPic.Size = new System.Drawing.Size(172, 128);
            this.tkmPic.TabIndex = 2;
            this.tkmPic.TabStop = false;
            // 
            // secimMakas
            // 
            this.secimMakas.Image = ((System.Drawing.Image)(resources.GetObject("secimMakas.Image")));
            this.secimMakas.Location = new System.Drawing.Point(168, 267);
            this.secimMakas.Name = "secimMakas";
            this.secimMakas.Size = new System.Drawing.Size(172, 120);
            this.secimMakas.TabIndex = 3;
            this.secimMakas.TabStop = false;
            this.secimMakas.Click += new System.EventHandler(this.secimMakas_Click);
            // 
            // skorLabel
            // 
            this.skorLabel.AutoSize = true;
            this.skorLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skorLabel.Location = new System.Drawing.Point(215, 100);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(181, 27);
            this.skorLabel.TabIndex = 4;
            this.skorLabel.Text = "Oyuncu Skor: ";
            // 
            // durumLabel
            // 
            this.durumLabel.AutoSize = true;
            this.durumLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durumLabel.Location = new System.Drawing.Point(214, 26);
            this.durumLabel.Name = "durumLabel";
            this.durumLabel.Size = new System.Drawing.Size(145, 36);
            this.durumLabel.TabIndex = 5;
            this.durumLabel.Text = "Durum: ";
            // 
            // skorPcLabel
            // 
            this.skorPcLabel.AutoSize = true;
            this.skorPcLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skorPcLabel.Location = new System.Drawing.Point(562, 134);
            this.skorPcLabel.Name = "skorPcLabel";
            this.skorPcLabel.Size = new System.Drawing.Size(117, 27);
            this.skorPcLabel.TabIndex = 6;
            this.skorPcLabel.Text = "Pc Skor: ";
            // 
            // tasKagirMakasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.skorPcLabel);
            this.Controls.Add(this.durumLabel);
            this.Controls.Add(this.skorLabel);
            this.Controls.Add(this.secimMakas);
            this.Controls.Add(this.tkmPic);
            this.Controls.Add(this.secimKagit);
            this.Controls.Add(this.secimTas);
            this.Name = "tasKagirMakasForm";
            this.Text = "Taş Kağıt Makas";
            ((System.ComponentModel.ISupportInitialize)(this.secimTas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secimKagit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkmPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secimMakas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox secimTas;
        private System.Windows.Forms.PictureBox secimKagit;
        private System.Windows.Forms.PictureBox tkmPic;
        private System.Windows.Forms.PictureBox secimMakas;
        private System.Windows.Forms.Label skorLabel;
        private System.Windows.Forms.Label durumLabel;
        private System.Windows.Forms.Label skorPcLabel;
    }
}

