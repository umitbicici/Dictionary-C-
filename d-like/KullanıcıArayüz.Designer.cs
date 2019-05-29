namespace d_like
{
    partial class KullanıcıArayüz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıArayüz));
            this.kelime_ekle = new System.Windows.Forms.Button();
            this.kelimelerim = new System.Windows.Forms.Button();
            this.ogrenme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kelime_ekle
            // 
            this.kelime_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            resources.ApplyResources(this.kelime_ekle, "kelime_ekle");
            this.kelime_ekle.Name = "kelime_ekle";
            this.kelime_ekle.UseVisualStyleBackColor = false;
            this.kelime_ekle.Click += new System.EventHandler(this.kelime_ekle_Click_1);
            // 
            // kelimelerim
            // 
            this.kelimelerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            resources.ApplyResources(this.kelimelerim, "kelimelerim");
            this.kelimelerim.Name = "kelimelerim";
            this.kelimelerim.UseVisualStyleBackColor = false;
            this.kelimelerim.Click += new System.EventHandler(this.kelimelerim_Click_1);
            // 
            // ogrenme
            // 
            this.ogrenme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            resources.ApplyResources(this.ogrenme, "ogrenme");
            this.ogrenme.Name = "ogrenme";
            this.ogrenme.UseVisualStyleBackColor = false;
            this.ogrenme.Click += new System.EventHandler(this.ogrenme_Click);
            // 
            // KullanıcıArayüz
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ogrenme);
            this.Controls.Add(this.kelimelerim);
            this.Controls.Add(this.kelime_ekle);
            this.Name = "KullanıcıArayüz";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kelime_ekle;
        private System.Windows.Forms.Button kelimelerim;
        private System.Windows.Forms.Button ogrenme;
    }
}