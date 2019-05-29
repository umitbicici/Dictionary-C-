namespace d_like
{
    partial class OgrenmeMerkezi
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
            this.f = new System.Windows.Forms.TextBox();
            this.d = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(220, 256);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(127, 21);
            this.f.TabIndex = 3;
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(220, 229);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 21);
            this.d.TabIndex = 4;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(220, 202);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 21);
            this.c.TabIndex = 5;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(220, 175);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 21);
            this.b.TabIndex = 6;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(220, 148);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 21);
            this.a.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(231, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(432, 227);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // OgrenmeMerkezi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "OgrenmeMerkezi";
            this.Text = "Öürenme Merkezi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox a;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}