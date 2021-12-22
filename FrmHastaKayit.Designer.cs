
namespace Hastane_Otomasyon
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.LblHstaSıfre = new System.Windows.Forms.Label();
            this.TxtSyd = new System.Windows.Forms.TextBox();
            this.TxtTc = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskdTxtTlfn = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSfre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBxCnsyt = new System.Windows.Forms.ComboBox();
            this.BtnKytOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(175, 106);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(235, 27);
            this.TxtAd.TabIndex = 1;
            // 
            // LblHstaSıfre
            // 
            this.LblHstaSıfre.AutoSize = true;
            this.LblHstaSıfre.Location = new System.Drawing.Point(130, 109);
            this.LblHstaSıfre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblHstaSıfre.Name = "LblHstaSıfre";
            this.LblHstaSıfre.Size = new System.Drawing.Size(35, 19);
            this.LblHstaSıfre.TabIndex = 6;
            this.LblHstaSıfre.Text = "Ad:";
            // 
            // TxtSyd
            // 
            this.TxtSyd.Location = new System.Drawing.Point(174, 155);
            this.TxtSyd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSyd.Name = "TxtSyd";
            this.TxtSyd.Size = new System.Drawing.Size(233, 27);
            this.TxtSyd.TabIndex = 2;
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(174, 207);
            this.TxtTc.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTc.Mask = "00000000000";
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(235, 27);
            this.TxtTc.TabIndex = 3;
            this.TxtTc.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik No:";
            // 
            // MskdTxtTlfn
            // 
            this.MskdTxtTlfn.Location = new System.Drawing.Point(175, 254);
            this.MskdTxtTlfn.Margin = new System.Windows.Forms.Padding(4);
            this.MskdTxtTlfn.Mask = "(999) 000-0000";
            this.MskdTxtTlfn.Name = "MskdTxtTlfn";
            this.MskdTxtTlfn.Size = new System.Drawing.Size(235, 27);
            this.MskdTxtTlfn.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cinsiyet:";
            // 
            // TxtSfre
            // 
            this.TxtSfre.Location = new System.Drawing.Point(175, 297);
            this.TxtSfre.Name = "TxtSfre";
            this.TxtSfre.PasswordChar = '*';
            this.TxtSfre.Size = new System.Drawing.Size(235, 27);
            this.TxtSfre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sifre:";
            // 
            // CmbBxCnsyt
            // 
            this.CmbBxCnsyt.FormattingEnabled = true;
            this.CmbBxCnsyt.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer"});
            this.CmbBxCnsyt.Location = new System.Drawing.Point(174, 339);
            this.CmbBxCnsyt.Name = "CmbBxCnsyt";
            this.CmbBxCnsyt.Size = new System.Drawing.Size(235, 27);
            this.CmbBxCnsyt.TabIndex = 6;
            // 
            // BtnKytOl
            // 
            this.BtnKytOl.Location = new System.Drawing.Point(217, 386);
            this.BtnKytOl.Name = "BtnKytOl";
            this.BtnKytOl.Size = new System.Drawing.Size(120, 30);
            this.BtnKytOl.TabIndex = 7;
            this.BtnKytOl.Text = "Kayıt Ol";
            this.BtnKytOl.UseVisualStyleBackColor = true;
            this.BtnKytOl.Click += new System.EventHandler(this.BtnKytOl_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKytOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(481, 491);
            this.Controls.Add(this.BtnKytOl);
            this.Controls.Add(this.CmbBxCnsyt);
            this.Controls.Add(this.TxtSfre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskdTxtTlfn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSyd);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.LblHstaSıfre);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "FrmHastaKayit";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label LblHstaSıfre;
        private System.Windows.Forms.TextBox TxtSyd;
        private System.Windows.Forms.MaskedTextBox TxtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskdTxtTlfn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSfre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBxCnsyt;
        private System.Windows.Forms.Button BtnKytOl;
    }
}