
namespace Hastane_Otomasyon
{
    partial class FrmRandevuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbBxDoktor = new System.Windows.Forms.ComboBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.CmbBxBrans = new System.Windows.Forms.ComboBox();
            this.MskdTxtBxSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskdTxtBxTarih = new System.Windows.Forms.MaskedTextBox();
            this.MskdTxtBxTC = new System.Windows.Forms.MaskedTextBox();
            this.CheckBxDrm = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1188, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1062, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbBxDoktor
            // 
            this.CmbBxDoktor.FormattingEnabled = true;
            this.CmbBxDoktor.Location = new System.Drawing.Point(91, 548);
            this.CmbBxDoktor.Name = "CmbBxDoktor";
            this.CmbBxDoktor.Size = new System.Drawing.Size(125, 27);
            this.CmbBxDoktor.TabIndex = 25;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(91, 402);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(125, 27);
            this.TxtID.TabIndex = 24;
            // 
            // CmbBxBrans
            // 
            this.CmbBxBrans.FormattingEnabled = true;
            this.CmbBxBrans.Location = new System.Drawing.Point(91, 509);
            this.CmbBxBrans.Name = "CmbBxBrans";
            this.CmbBxBrans.Size = new System.Drawing.Size(125, 27);
            this.CmbBxBrans.TabIndex = 23;
            // 
            // MskdTxtBxSaat
            // 
            this.MskdTxtBxSaat.Location = new System.Drawing.Point(91, 471);
            this.MskdTxtBxSaat.Mask = "00:00";
            this.MskdTxtBxSaat.Name = "MskdTxtBxSaat";
            this.MskdTxtBxSaat.Size = new System.Drawing.Size(125, 27);
            this.MskdTxtBxSaat.TabIndex = 22;
            this.MskdTxtBxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskdTxtBxTarih
            // 
            this.MskdTxtBxTarih.Location = new System.Drawing.Point(91, 435);
            this.MskdTxtBxTarih.Mask = "00/00/0000";
            this.MskdTxtBxTarih.Name = "MskdTxtBxTarih";
            this.MskdTxtBxTarih.Size = new System.Drawing.Size(125, 27);
            this.MskdTxtBxTarih.TabIndex = 21;
            this.MskdTxtBxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // MskdTxtBxTC
            // 
            this.MskdTxtBxTC.Location = new System.Drawing.Point(91, 581);
            this.MskdTxtBxTC.Mask = "000000000";
            this.MskdTxtBxTC.Name = "MskdTxtBxTC";
            this.MskdTxtBxTC.Size = new System.Drawing.Size(125, 27);
            this.MskdTxtBxTC.TabIndex = 20;
            this.MskdTxtBxTC.ValidatingType = typeof(int);
            // 
            // CheckBxDrm
            // 
            this.CheckBxDrm.AutoSize = true;
            this.CheckBxDrm.Location = new System.Drawing.Point(107, 614);
            this.CheckBxDrm.Name = "CheckBxDrm";
            this.CheckBxDrm.Size = new System.Drawing.Size(77, 23);
            this.CheckBxDrm.TabIndex = 19;
            this.CheckBxDrm.Text = "Durum";
            this.CheckBxDrm.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 584);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "TC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID:";
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1188, 641);
            this.Controls.Add(this.CmbBxDoktor);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.CmbBxBrans);
            this.Controls.Add(this.MskdTxtBxSaat);
            this.Controls.Add(this.MskdTxtBxTarih);
            this.Controls.Add(this.MskdTxtBxTC);
            this.Controls.Add(this.CheckBxDrm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRandevuListesi";
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbBxDoktor;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.ComboBox CmbBxBrans;
        private System.Windows.Forms.MaskedTextBox MskdTxtBxSaat;
        private System.Windows.Forms.MaskedTextBox MskdTxtBxTarih;
        private System.Windows.Forms.MaskedTextBox MskdTxtBxTC;
        private System.Windows.Forms.CheckBox CheckBxDrm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}