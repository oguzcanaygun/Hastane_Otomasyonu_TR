
namespace Hastane_Otomasyon
{
    partial class frmguvenlikgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmguvenlikgiris));
            this.BtnGrsYap = new System.Windows.Forms.Button();
            this.Txtsfre = new System.Windows.Forms.TextBox();
            this.MskdTxtTC = new System.Windows.Forms.MaskedTextBox();
            this.LblHstaSıfre = new System.Windows.Forms.Label();
            this.LblHstaTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGrsYap
            // 
            this.BtnGrsYap.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnGrsYap.Location = new System.Drawing.Point(197, 213);
            this.BtnGrsYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGrsYap.Name = "BtnGrsYap";
            this.BtnGrsYap.Size = new System.Drawing.Size(150, 38);
            this.BtnGrsYap.TabIndex = 12;
            this.BtnGrsYap.Text = "Giriş Yap";
            this.BtnGrsYap.UseVisualStyleBackColor = false;
            this.BtnGrsYap.Click += new System.EventHandler(this.BtnGrsYap_Click);
            // 
            // Txtsfre
            // 
            this.Txtsfre.BackColor = System.Drawing.Color.CadetBlue;
            this.Txtsfre.Location = new System.Drawing.Point(166, 167);
            this.Txtsfre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txtsfre.Name = "Txtsfre";
            this.Txtsfre.PasswordChar = '*';
            this.Txtsfre.Size = new System.Drawing.Size(235, 27);
            this.Txtsfre.TabIndex = 11;
            // 
            // MskdTxtTC
            // 
            this.MskdTxtTC.BackColor = System.Drawing.Color.CadetBlue;
            this.MskdTxtTC.Location = new System.Drawing.Point(166, 123);
            this.MskdTxtTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MskdTxtTC.Mask = "00000000000";
            this.MskdTxtTC.Name = "MskdTxtTC";
            this.MskdTxtTC.Size = new System.Drawing.Size(235, 27);
            this.MskdTxtTC.TabIndex = 10;
            // 
            // LblHstaSıfre
            // 
            this.LblHstaSıfre.AutoSize = true;
            this.LblHstaSıfre.BackColor = System.Drawing.Color.CadetBlue;
            this.LblHstaSıfre.Location = new System.Drawing.Point(96, 170);
            this.LblHstaSıfre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.LblHstaTC.Location = new System.Drawing.Point(35, 126);
            this.LblHstaTC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "GUVENLİK GİRİŞ PANELİ";
            // 
            // frmguvenlikgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 320);
            this.Controls.Add(this.BtnGrsYap);
            this.Controls.Add(this.Txtsfre);
            this.Controls.Add(this.MskdTxtTC);
            this.Controls.Add(this.LblHstaSıfre);
            this.Controls.Add(this.LblHstaTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmguvenlikgiris";
            this.Text = "frmguvenlikgiris";
            this.Load += new System.EventHandler(this.frmguvenlikgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGrsYap;
        private System.Windows.Forms.TextBox Txtsfre;
        private System.Windows.Forms.MaskedTextBox MskdTxtTC;
        private System.Windows.Forms.Label LblHstaSıfre;
        private System.Windows.Forms.Label LblHstaTC;
        private System.Windows.Forms.Label label1;
    }
}