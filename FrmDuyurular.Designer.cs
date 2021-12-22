
namespace Hastane_Otomasyon
{
    partial class FrmDuyurular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyurular));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOlstur = new System.Windows.Forms.Button();
            this.RchTxtBxDuyuruOlstr = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1123, 516);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnOlstur
            // 
            this.BtnOlstur.BackColor = System.Drawing.Color.Red;
            this.BtnOlstur.Location = new System.Drawing.Point(843, 540);
            this.BtnOlstur.Name = "BtnOlstur";
            this.BtnOlstur.Size = new System.Drawing.Size(134, 29);
            this.BtnOlstur.TabIndex = 3;
            this.BtnOlstur.Text = "Sil";
            this.BtnOlstur.UseVisualStyleBackColor = false;
            this.BtnOlstur.Click += new System.EventHandler(this.BtnOlstur_Click);
            // 
            // RchTxtBxDuyuruOlstr
            // 
            this.RchTxtBxDuyuruOlstr.Location = new System.Drawing.Point(12, 522);
            this.RchTxtBxDuyuruOlstr.Name = "RchTxtBxDuyuruOlstr";
            this.RchTxtBxDuyuruOlstr.Size = new System.Drawing.Size(581, 69);
            this.RchTxtBxDuyuruOlstr.TabIndex = 2;
            this.RchTxtBxDuyuruOlstr.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(703, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duyuru ID:";
            // 
            // FrmDuyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1119, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnOlstur);
            this.Controls.Add(this.RchTxtBxDuyuruOlstr);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDuyurular";
            this.Text = "Duyurlar";
            this.Load += new System.EventHandler(this.FrmDuyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOlstur;
        private System.Windows.Forms.RichTextBox RchTxtBxDuyuruOlstr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}