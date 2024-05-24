namespace BitirmeProjesi
{
    partial class frmRapor
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
            this.btnDoktora = new System.Windows.Forms.Button();
            this.btnTrDoktora = new System.Windows.Forms.Button();
            this.btnYdDoktora = new System.Windows.Forms.Button();
            this.btnYuksekLisans = new System.Windows.Forms.Button();
            this.btnTrYuksekLisans = new System.Windows.Forms.Button();
            this.btnYdYuksekLisans = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoktora
            // 
            this.btnDoktora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktora.Location = new System.Drawing.Point(67, 38);
            this.btnDoktora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoktora.Name = "btnDoktora";
            this.btnDoktora.Size = new System.Drawing.Size(285, 35);
            this.btnDoktora.TabIndex = 2;
            this.btnDoktora.Text = "Doktora Yapan Öğrencileri Listele";
            this.btnDoktora.UseVisualStyleBackColor = true;
            this.btnDoktora.Click += new System.EventHandler(this.btnDoktora_Click);
            // 
            // btnTrDoktora
            // 
            this.btnTrDoktora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrDoktora.Location = new System.Drawing.Point(67, 78);
            this.btnTrDoktora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrDoktora.Name = "btnTrDoktora";
            this.btnTrDoktora.Size = new System.Drawing.Size(285, 37);
            this.btnTrDoktora.TabIndex = 3;
            this.btnTrDoktora.Text = "Türkiyede Doktora Yapan Öğrencileri Listele";
            this.btnTrDoktora.UseVisualStyleBackColor = true;
            this.btnTrDoktora.Click += new System.EventHandler(this.btnTrDoktora_Click);
            // 
            // btnYdDoktora
            // 
            this.btnYdDoktora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYdDoktora.Location = new System.Drawing.Point(67, 120);
            this.btnYdDoktora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYdDoktora.Name = "btnYdDoktora";
            this.btnYdDoktora.Size = new System.Drawing.Size(285, 37);
            this.btnYdDoktora.TabIndex = 4;
            this.btnYdDoktora.Text = "Yurtdışında Doktora Yapan Öğrencileri Listele";
            this.btnYdDoktora.UseVisualStyleBackColor = true;
            this.btnYdDoktora.Click += new System.EventHandler(this.btnYdDoktora_Click);
            // 
            // btnYuksekLisans
            // 
            this.btnYuksekLisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYuksekLisans.Location = new System.Drawing.Point(67, 162);
            this.btnYuksekLisans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYuksekLisans.Name = "btnYuksekLisans";
            this.btnYuksekLisans.Size = new System.Drawing.Size(285, 37);
            this.btnYuksekLisans.TabIndex = 5;
            this.btnYuksekLisans.Text = "Yüksek Lisans Yapan Öğrencileri Listele";
            this.btnYuksekLisans.UseVisualStyleBackColor = true;
            this.btnYuksekLisans.Click += new System.EventHandler(this.btnYuksekLisans_Click);
            // 
            // btnTrYuksekLisans
            // 
            this.btnTrYuksekLisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrYuksekLisans.Location = new System.Drawing.Point(356, 65);
            this.btnTrYuksekLisans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrYuksekLisans.Name = "btnTrYuksekLisans";
            this.btnTrYuksekLisans.Size = new System.Drawing.Size(309, 50);
            this.btnTrYuksekLisans.TabIndex = 6;
            this.btnTrYuksekLisans.Text = "Türkiyede Yüksek Lisans Yapan Öğrencileri Listele";
            this.btnTrYuksekLisans.UseVisualStyleBackColor = true;
            this.btnTrYuksekLisans.Click += new System.EventHandler(this.btnTrYuksekLisans_Click);
            // 
            // btnYdYuksekLisans
            // 
            this.btnYdYuksekLisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYdYuksekLisans.Location = new System.Drawing.Point(356, 119);
            this.btnYdYuksekLisans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYdYuksekLisans.Name = "btnYdYuksekLisans";
            this.btnYdYuksekLisans.Size = new System.Drawing.Size(309, 52);
            this.btnYdYuksekLisans.TabIndex = 7;
            this.btnYdYuksekLisans.Text = "Yurtdışında Yüksek Lisans Yapan Öğrencileri Listele";
            this.btnYdYuksekLisans.UseVisualStyleBackColor = true;
            this.btnYdYuksekLisans.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(316, 454);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(78, 37);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eğitim Bilgileri Raporları";
            // 
            // gridRapor
            // 
            this.gridRapor.AllowUserToAddRows = false;
            this.gridRapor.AllowUserToDeleteRows = false;
            this.gridRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRapor.Location = new System.Drawing.Point(9, 203);
            this.gridRapor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridRapor.MultiSelect = false;
            this.gridRapor.Name = "gridRapor";
            this.gridRapor.ReadOnly = true;
            this.gridRapor.RowHeadersWidth = 51;
            this.gridRapor.RowTemplate.Height = 24;
            this.gridRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRapor.Size = new System.Drawing.Size(682, 247);
            this.gridRapor.TabIndex = 13;
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 515);
            this.Controls.Add(this.gridRapor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYdYuksekLisans);
            this.Controls.Add(this.btnTrYuksekLisans);
            this.Controls.Add(this.btnYuksekLisans);
            this.Controls.Add(this.btnYdDoktora);
            this.Controls.Add(this.btnTrDoktora);
            this.Controls.Add(this.btnDoktora);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRapor";
            this.Text = "Raporlama";
            ((System.ComponentModel.ISupportInitialize)(this.gridRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDoktora;
        private System.Windows.Forms.Button btnTrDoktora;
        private System.Windows.Forms.Button btnYdDoktora;
        private System.Windows.Forms.Button btnYuksekLisans;
        private System.Windows.Forms.Button btnTrYuksekLisans;
        private System.Windows.Forms.Button btnYdYuksekLisans;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRapor;
    }
}