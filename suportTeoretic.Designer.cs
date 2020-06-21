namespace matrici
{
    partial class suportTeoretic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suportTeoretic));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.nrColoane = new System.Windows.Forms.NumericUpDown();
            this.nrLinii = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrColoane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(843, 829);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(835, 725);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Utilitate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(835, 796);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Declarare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.nrColoane);
            this.tabPage3.Controls.Add(this.nrLinii);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(835, 725);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exemple";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folosește butoanele din stânga pentru a crea o matrice.\r\n";
            // 
            // nrColoane
            // 
            this.nrColoane.Location = new System.Drawing.Point(110, 24);
            this.nrColoane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nrColoane.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrColoane.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrColoane.Name = "nrColoane";
            this.nrColoane.Size = new System.Drawing.Size(36, 26);
            this.nrColoane.TabIndex = 3;
            this.nrColoane.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrColoane.ValueChanged += new System.EventHandler(this.nrColoane_ValueChanged);
            // 
            // nrLinii
            // 
            this.nrLinii.Location = new System.Drawing.Point(60, 24);
            this.nrLinii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nrLinii.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nrLinii.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrLinii.Name = "nrLinii";
            this.nrLinii.Size = new System.Drawing.Size(36, 26);
            this.nrLinii.TabIndex = 1;
            this.nrLinii.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrLinii.ValueChanged += new System.EventHandler(this.nrLinii_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "int a[           ][           ]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(814, 878);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::matrici.Properties.Resources.tabel_13;
            this.pictureBox1.Location = new System.Drawing.Point(343, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 252);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // suportTeoretic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 845);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "suportTeoretic";
            this.Text = "suportTeoretic";
            this.Load += new System.EventHandler(this.suportTeoretic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrColoane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nrColoane;
        private System.Windows.Forms.NumericUpDown nrLinii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}