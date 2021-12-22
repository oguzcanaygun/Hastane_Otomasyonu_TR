
namespace Hastane_Otomasyon
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.LblHstaTC = new System.Windows.Forms.Label();
            this.LblHstaSıfre = new System.Windows.Forms.Label();
            this.MskdTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtHstaSfre = new System.Windows.Forms.TextBox();
            this.BtnHstaGrsYp = new System.Windows.Forms.Button();
            this.LnkLblHstUyeOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // LblHstaTC
            // 
            this.LblHstaTC.AutoSize = true;
            this.LblHstaTC.BackColor = System.Drawing.Color.CadetBlue;
            this.LblHstaTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblHstaTC.Location = new System.Drawing.Point(94, 107);
            this.LblHstaTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHstaTC.Name = "LblHstaTC";
            this.LblHstaTC.Size = new System.Drawing.Size(108, 19);
            this.LblHstaTC.TabIndex = 1;
            this.LblHstaTC.Text = "TC Kimlik No:";
            // 
            // LblHstaSıfre
            // 
            this.LblHstaSıfre.AutoSize = true;
            this.LblHstaSıfre.BackColor = System.Drawing.Color.CadetBlue;
            this.LblHstaSıfre.Location = new System.Drawing.Point(155, 155);
            this.LblHstaSıfre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHstaSıfre.Name = "LblHstaSıfre";
            this.LblHstaSıfre.Size = new System.Drawing.Size(47, 19);
            this.LblHstaSıfre.TabIndex = 2;
            this.LblHstaSıfre.Text = "Sifre:";
            // 
            // MskdTxtTC
            // 
            this.MskdTxtTC.BackColor = System.Drawing.Color.CadetBlue;
            this.MskdTxtTC.Location = new System.Drawing.Point(220, 104);
            this.MskdTxtTC.Mask = "00000000000";
            this.MskdTxtTC.Name = "MskdTxtTC";
            this.MskdTxtTC.Size = new System.Drawing.Size(158, 27);
            this.MskdTxtTC.TabIndex = 3;
            // 
            // TxtHstaSfre
            // 
            this.TxtHstaSfre.BackColor = System.Drawing.Color.CadetBlue;
            this.TxtHstaSfre.Location = new System.Drawing.Point(220, 152);
            this.TxtHstaSfre.Name = "TxtHstaSfre";
            this.TxtHstaSfre.PasswordChar = '*';
            this.TxtHstaSfre.Size = new System.Drawing.Size(158, 27);
            this.TxtHstaSfre.TabIndex = 4;
            // 
            // BtnHstaGrsYp
            // 
            this.BtnHstaGrsYp.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnHstaGrsYp.Location = new System.Drawing.Point(250, 197);
            this.BtnHstaGrsYp.Name = "BtnHstaGrsYp";
            this.BtnHstaGrsYp.Size = new System.Drawing.Size(100, 26);
            this.BtnHstaGrsYp.TabIndex = 5;
            this.BtnHstaGrsYp.Text = "Giriş Yap";
            this.BtnHstaGrsYp.UseVisualStyleBackColor = false;
            this.BtnHstaGrsYp.Click += new System.EventHandler(this.BtnHstaGrsYp_Click);
            // 
            // LnkLblHstUyeOl
            // 
            this.LnkLblHstUyeOl.AutoSize = true;
            this.LnkLblHstUyeOl.BackColor = System.Drawing.Color.CadetBlue;
            this.LnkLblHstUyeOl.Location = new System.Drawing.Point(408, 155);
            this.LnkLblHstUyeOl.Name = "LnkLblHstUyeOl";
            this.LnkLblHstUyeOl.Size = new System.Drawing.Size(57, 19);
            this.LnkLblHstUyeOl.TabIndex = 6;
            this.LnkLblHstUyeOl.TabStop = true;
            this.LnkLblHstUyeOl.Text = "Üye Ol";
            this.LnkLblHstUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLblHstUyeOl_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.BtnHstaGrsYp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 285);
            this.Controls.Add(this.LnkLblHstUyeOl);
            this.Controls.Add(this.BtnHstaGrsYp);
            this.Controls.Add(this.TxtHstaSfre);
            this.Controls.Add(this.MskdTxtTC);
            this.Controls.Add(this.LblHstaSıfre);
            this.Controls.Add(this.LblHstaTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHstaTC;
        private System.Windows.Forms.Label LblHstaSıfre;
        private System.Windows.Forms.MaskedTextBox MskdTxtTC;
        private System.Windows.Forms.TextBox TxtHstaSfre;
        private System.Windows.Forms.Button BtnHstaGrsYp;
        private System.Windows.Forms.LinkLabel LnkLblHstUyeOl;
    }
}