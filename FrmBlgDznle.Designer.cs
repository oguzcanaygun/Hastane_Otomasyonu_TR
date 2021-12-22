
namespace Hastane_Otomasyon
{
    partial class FrmBlgDznle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBlgDznle));
            this.BtnGncelle = new System.Windows.Forms.Button();
            this.CmbBxCnsyt = new System.Windows.Forms.ComboBox();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskdTxtTlfn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxSyd = new System.Windows.Forms.TextBox();
            this.MskdTcTxt = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.LblHstaSıfre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGncelle
            // 
            this.BtnGncelle.Location = new System.Drawing.Point(272, 472);
            this.BtnGncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGncelle.Name = "BtnGncelle";
            this.BtnGncelle.Size = new System.Drawing.Size(180, 44);
            this.BtnGncelle.TabIndex = 7;
            this.BtnGncelle.Text = "Güncelle";
            this.BtnGncelle.UseVisualStyleBackColor = true;
            this.BtnGncelle.Click += new System.EventHandler(this.BtnGncelle_Click);
            // 
            // CmbBxCnsyt
            // 
            this.CmbBxCnsyt.FormattingEnabled = true;
            this.CmbBxCnsyt.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer"});
            this.CmbBxCnsyt.Location = new System.Drawing.Point(207, 403);
            this.CmbBxCnsyt.Margin = new System.Windows.Forms.Padding(4);
            this.CmbBxCnsyt.Name = "CmbBxCnsyt";
            this.CmbBxCnsyt.Size = new System.Drawing.Size(350, 27);
            this.CmbBxCnsyt.TabIndex = 6;
            // 
            // TxtSfre
            // 
            this.TxtSfre.Location = new System.Drawing.Point(208, 342);
            this.TxtSfre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.PasswordChar = '*';
            this.TxtSfre.Size = new System.Drawing.Size(350, 27);
            this.TxtSfre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 407);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cinsiyet:";
            // 
            // MskdTxtTlfn
            // 
            this.MskdTxtTlfn.Location = new System.Drawing.Point(208, 279);
            this.MskdTxtTlfn.Margin = new System.Windows.Forms.Padding(6);
            this.MskdTxtTlfn.Mask = "(999) 000-0000";
            this.MskdTxtTlfn.Name = "MskdTxtTlfn";
            this.MskdTxtTlfn.Size = new System.Drawing.Size(350, 27);
            this.MskdTxtTlfn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(125, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefon:";
            // 
            // TxSyd
            // 
            this.TxSyd.Location = new System.Drawing.Point(207, 134);
            this.TxSyd.Margin = new System.Windows.Forms.Padding(6);
            this.TxSyd.Name = "TxSyd";
            this.TxSyd.Size = new System.Drawing.Size(348, 27);
            this.TxSyd.TabIndex = 2;
            // 
            // MskdTcTxt
            // 
            this.MskdTcTxt.Location = new System.Drawing.Point(207, 210);
            this.MskdTcTxt.Margin = new System.Windows.Forms.Padding(6);
            this.MskdTcTxt.Mask = "000000000";
            this.MskdTcTxt.Name = "MskdTcTxt";
            this.MskdTcTxt.Size = new System.Drawing.Size(350, 27);
            this.MskdTcTxt.TabIndex = 3;
            this.MskdTcTxt.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "TC Kimlik No:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(208, 63);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(6);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(350, 27);
            this.TxtAd.TabIndex = 1;
            // 
            // LblHstaSıfre
            // 
            this.LblHstaSıfre.AutoSize = true;
            this.LblHstaSıfre.Location = new System.Drawing.Point(158, 66);
            this.LblHstaSıfre.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.LblHstaSıfre.Name = "LblHstaSıfre";
            this.LblHstaSıfre.Size = new System.Drawing.Size(35, 19);
            this.LblHstaSıfre.TabIndex = 21;
            this.LblHstaSıfre.Text = "Ad:";
            // 
            // FrmBlgDznle
            // 
            this.AcceptButton = this.BtnGncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(658, 567);
            this.Controls.Add(this.BtnGncelle);
            this.Controls.Add(this.CmbBxCnsyt);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskdTxtTlfn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxSyd);
            this.Controls.Add(this.MskdTcTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.LblHstaSıfre);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBlgDznle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmBlgDznle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGncelle;
        private System.Windows.Forms.ComboBox CmbBxCnsyt;
        private System.Windows.Forms.TextBox TxtSfre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskdTxtTlfn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxSyd;
        private System.Windows.Forms.MaskedTextBox MskdTcTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label LblHstaSıfre;
    }
}