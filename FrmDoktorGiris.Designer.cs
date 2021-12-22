
namespace Hastane_Otomasyon
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.BtnHstaGrsYp = new System.Windows.Forms.Button();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskdTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.LblHstaSıfre = new System.Windows.Forms.Label();
            this.LblHstaTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHstaGrsYp
            // 
            this.BtnHstaGrsYp.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnHstaGrsYp.Location = new System.Drawing.Point(230, 211);
            this.BtnHstaGrsYp.Name = "BtnHstaGrsYp";
            this.BtnHstaGrsYp.Size = new System.Drawing.Size(100, 26);
            this.BtnHstaGrsYp.TabIndex = 12;
            this.BtnHstaGrsYp.Text = "Giriş Yap";
            this.BtnHstaGrsYp.UseVisualStyleBackColor = false;
            this.BtnHstaGrsYp.Click += new System.EventHandler(this.BtnHstaGrsYp_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.BackColor = System.Drawing.Color.CadetBlue;
            this.TxtSifre.Location = new System.Drawing.Point(200, 166);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.PasswordChar = '*';
            this.TxtSifre.Size = new System.Drawing.Size(158, 27);
            this.TxtSifre.TabIndex = 11;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskdTxtTC
            // 
            this.MskdTxtTC.BackColor = System.Drawing.Color.CadetBlue;
            this.MskdTxtTC.Location = new System.Drawing.Point(200, 118);
            this.MskdTxtTC.Mask = "000000000";
            this.MskdTxtTC.Name = "MskdTxtTC";
            this.MskdTxtTC.Size = new System.Drawing.Size(158, 27);
            this.MskdTxtTC.TabIndex = 10;
            this.MskdTxtTC.ValidatingType = typeof(int);
            // 
            // LblHstaSıfre
            // 
            this.LblHstaSıfre.AutoSize = true;
            this.LblHstaSıfre.BackColor = System.Drawing.Color.CadetBlue;
            this.LblHstaSıfre.Location = new System.Drawing.Point(135, 169);
            this.LblHstaSıfre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHstaSıfre.Name = "LblHstaSıfre";
            this.LblHstaSıfre.Size = new System.Drawing.Size(47, 19);
            this.LblHstaSıfre.TabIndex = 9;
            this.LblHstaSıfre.Text = "Sifre:";
            // 
            // LblHstaTC
            // 
            this.LblHstaTC.AutoSize = true;
            this.LblHstaTC.BackColor = System.Drawing.Color.CadetBlue;
            this.LblHstaTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHstaTC.Location = new System.Drawing.Point(74, 121);
            this.LblHstaTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHstaTC.Name = "LblHstaTC";
            this.LblHstaTC.Size = new System.Drawing.Size(108, 19);
            this.LblHstaTC.TabIndex = 8;
            this.LblHstaTC.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.BtnHstaGrsYp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 285);
            this.Controls.Add(this.BtnHstaGrsYp);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskdTxtTC);
            this.Controls.Add(this.LblHstaSıfre);
            this.Controls.Add(this.LblHstaTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.FrmDoktorGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHstaGrsYp;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskdTxtTC;
        private System.Windows.Forms.Label LblHstaSıfre;
        private System.Windows.Forms.Label LblHstaTC;
        private System.Windows.Forms.Label label1;
    }
}