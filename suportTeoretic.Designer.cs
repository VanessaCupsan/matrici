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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nrLinii = new System.Windows.Forms.NumericUpDown();
            this.nrColoane = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrColoane)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Utilitate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 509);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1146, 509);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exemple";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1150, 300);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "int a[           ][           ]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nrLinii
            // 
            this.nrLinii.Location = new System.Drawing.Point(80, 30);
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
            this.nrLinii.Size = new System.Drawing.Size(48, 30);
            this.nrLinii.TabIndex = 1;
            this.nrLinii.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrLinii.ValueChanged += new System.EventHandler(this.nrLinii_ValueChanged);
            // 
            // nrColoane
            // 
            this.nrColoane.Location = new System.Drawing.Point(146, 30);
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
            this.nrColoane.Size = new System.Drawing.Size(48, 30);
            this.nrColoane.TabIndex = 3;
            this.nrColoane.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrColoane.ValueChanged += new System.EventHandler(this.nrColoane_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Folosește butoanele din stânga pentru a crea o matrice.\r\n";
            // 
            // suportTeoretic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "suportTeoretic";
            this.Text = "suportTeoretic";
            this.Load += new System.EventHandler(this.suportTeoretic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrColoane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nrColoane;
        private System.Windows.Forms.NumericUpDown nrLinii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}