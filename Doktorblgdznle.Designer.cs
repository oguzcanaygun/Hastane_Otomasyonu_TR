
namespace Hastane_Otomasyon
{
    partial class Doktorblgdznle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorblgdznle));
            this.Txtsyd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.LblHstaSıfre = new System.Windows.Forms.Label();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBrans = new System.Windows.Forms.Label();
            this.CmbBxBrns = new System.Windows.Forms.ComboBox();
            this.BtnGncelle = new System.Windows.Forms.Button();
            this.mskdbxTC = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Txtsyd
            // 
            this.Txtsyd.Location = new System.Drawing.Point(133, 107);
            this.Txtsyd.Margin = new System.Windows.Forms.Padding(4);
            this.Txtsyd.Name = "Txtsyd";
            this.Txtsyd.Size = new System.Drawing.Size(233, 27);
            this.Txtsyd.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "TC Kimlik No:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(134, 58);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(235, 27);
            this.TxtAd.TabIndex = 14;
            // 
            // LblHstaSıfre
            // 
            this.LblHstaSıfre.AutoSize = true;
            this.LblHstaSıfre.Location = new System.Drawing.Point(89, 61);
            this.LblHstaSıfre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblHstaSıfre.Name = "LblHstaSıfre";
            this.LblHstaSıfre.Size = new System.Drawing.Size(35, 19);
            this.LblHstaSıfre.TabIndex = 13;
            this.LblHstaSıfre.Text = "Ad:";
            // 
            // TxtSfre
            // 
            this.TxtSfre.Location = new System.Drawing.Point(131, 270);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.PasswordChar = '*';
            this.TxtSfre.Size = new System.Drawing.Size(235, 27);
            this.TxtSfre.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sifre:";
            // 
            // TxtBrans
            // 
            this.TxtBrans.AutoSize = true;
            this.TxtBrans.Location = new System.Drawing.Point(79, 220);
            this.TxtBrans.Name = "TxtBrans";
            this.TxtBrans.Size = new System.Drawing.Size(45, 19);
            this.TxtBrans.TabIndex = 21;
            this.TxtBrans.Text = "Braş:";
            // 
            // CmbBxBrns
            // 
            this.CmbBxBrns.FormattingEnabled = true;
            this.CmbBxBrns.Location = new System.Drawing.Point(133, 220);
            this.CmbBxBrns.Name = "CmbBxBrns";
            this.CmbBxBrns.Size = new System.Drawing.Size(233, 27);
            this.CmbBxBrns.TabIndex = 22;
            // 
            // BtnGncelle
            // 
            this.BtnGncelle.Location = new System.Drawing.Point(161, 314);
            this.BtnGncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGncelle.Name = "BtnGncelle";
            this.BtnGncelle.Size = new System.Drawing.Size(180, 44);
            this.BtnGncelle.TabIndex = 34;
            this.BtnGncelle.Text = "Güncelle";
            this.BtnGncelle.UseVisualStyleBackColor = true;
            this.BtnGncelle.Click += new System.EventHandler(this.BtnGncelle_Click);
            // 
            // mskdbxTC
            // 
            this.mskdbxTC.Location = new System.Drawing.Point(134, 160);
            this.mskdbxTC.Mask = "000000000";
            this.mskdbxTC.Name = "mskdbxTC";
            this.mskdbxTC.Size = new System.Drawing.Size(232, 27);
            this.mskdbxTC.TabIndex = 35;
            this.mskdbxTC.ValidatingType = typeof(int);
            // 
            // Doktorblgdznle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(429, 407);
            this.Controls.Add(this.mskdbxTC);
            this.Controls.Add(this.BtnGncelle);
            this.Controls.Add(this.CmbBxBrns);
            this.Controls.Add(this.TxtBrans);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtsyd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.LblHstaSıfre);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Doktorblgdznle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.Doktorblgdznle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtsyd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label LblHstaSıfre;
        private System.Windows.Forms.TextBox TxtSfre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TxtBrans;
        private System.Windows.Forms.ComboBox CmbBxBrns;
        private System.Windows.Forms.Button BtnGncelle;
        private System.Windows.Forms.MaskedTextBox mskdbxTC;
    }
}