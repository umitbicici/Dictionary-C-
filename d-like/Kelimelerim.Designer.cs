namespace d_like
{
    partial class Kelimelerim
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
            this.ara = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.Button();
            this.listBoxKelimeler = new System.Windows.Forms.ListBox();
            this.aranacak_kelime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ara
            // 
            this.ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(184)))), ((int)(((byte)(208)))));
            this.ara.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara.Location = new System.Drawing.Point(262, 9);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(121, 33);
            this.ara.TabIndex = 0;
            this.ara.Text = "Ara";
            this.ara.UseVisualStyleBackColor = false;
            this.ara.Click += new System.EventHandler(this.ara_Click);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(184)))), ((int)(((byte)(208)))));
            this.yenile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenile.Location = new System.Drawing.Point(405, 9);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(121, 33);
            this.yenile.TabIndex = 1;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // listBoxKelimeler
            // 
            this.listBoxKelimeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.listBoxKelimeler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxKelimeler.ForeColor = System.Drawing.Color.White;
            this.listBoxKelimeler.FormattingEnabled = true;
            this.listBoxKelimeler.ItemHeight = 18;
            this.listBoxKelimeler.Location = new System.Drawing.Point(12, 55);
            this.listBoxKelimeler.Name = "listBoxKelimeler";
            this.listBoxKelimeler.Size = new System.Drawing.Size(532, 274);
            this.listBoxKelimeler.TabIndex = 2;
            // 
            // aranacak_kelime
            // 
            this.aranacak_kelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.aranacak_kelime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aranacak_kelime.ForeColor = System.Drawing.Color.White;
            this.aranacak_kelime.Location = new System.Drawing.Point(44, 12);
            this.aranacak_kelime.Name = "aranacak_kelime";
            this.aranacak_kelime.Size = new System.Drawing.Size(180, 26);
            this.aranacak_kelime.TabIndex = 3;
            this.aranacak_kelime.Text = "Aranacak Kelime";
            this.aranacak_kelime.Click += new System.EventHandler(this.aranacak_kelime_Click);
            // 
            // Kelimelerim
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 341);
            this.Controls.Add(this.aranacak_kelime);
            this.Controls.Add(this.listBoxKelimeler);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.ara);
            this.Name = "Kelimelerim";
            this.Text = "Kelimelerim";
            this.Load += new System.EventHandler(this.Kelimelerim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ara;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.ListBox listBoxKelimeler;
        private System.Windows.Forms.TextBox aranacak_kelime;
    }
}