namespace BitirmeProjesi
{
    partial class frmEgitimBilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genelBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitimBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelBilgilerToolStripMenuItem,
            this.eğitimBilgileriToolStripMenuItem,
            this.işBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genelBilgilerToolStripMenuItem
            // 
            this.genelBilgilerToolStripMenuItem.Name = "genelBilgilerToolStripMenuItem";
            this.genelBilgilerToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.genelBilgilerToolStripMenuItem.Text = "Genel Bilgiler";
            // 
            // eğitimBilgileriToolStripMenuItem
            // 
            this.eğitimBilgileriToolStripMenuItem.Name = "eğitimBilgileriToolStripMenuItem";
            this.eğitimBilgileriToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.eğitimBilgileriToolStripMenuItem.Text = "Eğitim Bilgileri";
            // 
            // işBilgileriToolStripMenuItem
            // 
            this.işBilgileriToolStripMenuItem.Name = "işBilgileriToolStripMenuItem";
            this.işBilgileriToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.işBilgileriToolStripMenuItem.Text = "İş Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "eğitim bilgileri sayfası";
            // 
            // frmEgitimBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEgitimBilgileri";
            this.Text = "Eğiitim Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genelBilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitimBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işBilgileriToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}