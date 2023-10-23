namespace for_dongusu_ornek4___826
{
    partial class Form1
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
            this.btnYaz = new System.Windows.Forms.Button();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.txtBaslangic = new System.Windows.Forms.TextBox();
            this.txtBitis = new System.Windows.Forms.TextBox();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(15, 192);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(105, 36);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(12, 49);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(53, 13);
            this.lblBaslangic.TabIndex = 1;
            this.lblBaslangic.Text = "Başlangıç";
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(12, 65);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(100, 20);
            this.txtBaslangic.TabIndex = 2;
            // 
            // txtBitis
            // 
            this.txtBitis.Location = new System.Drawing.Point(12, 140);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(100, 20);
            this.txtBitis.TabIndex = 3;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(12, 115);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(26, 13);
            this.lblBitis.TabIndex = 4;
            this.lblBitis.Text = "Bitiş";
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(162, 49);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(126, 186);
            this.lbSayilar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.txtBitis);
            this.Controls.Add(this.txtBaslangic);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.btnYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.TextBox txtBaslangic;
        private System.Windows.Forms.TextBox txtBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

