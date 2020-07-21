namespace matrici
{
    partial class suportTeoretic6
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtSumePartiale = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtPointeri = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rtSumePartiale);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sume parțiale în matrice";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtPointeri);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pointeri în matrice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtSumePartiale
            // 
            this.rtSumePartiale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtSumePartiale.Location = new System.Drawing.Point(22, 0);
            this.rtSumePartiale.Name = "rtSumePartiale";
            this.rtSumePartiale.Size = new System.Drawing.Size(937, 432);
            this.rtSumePartiale.TabIndex = 1;
            this.rtSumePartiale.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vizualizează codul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtPointeri
            // 
            this.rtPointeri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtPointeri.Location = new System.Drawing.Point(24, 0);
            this.rtPointeri.Name = "rtPointeri";
            this.rtPointeri.Size = new System.Drawing.Size(933, 506);
            this.rtPointeri.TabIndex = 0;
            this.rtPointeri.Text = "";
            // 
            // suportTeoretic6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "suportTeoretic6";
            this.Text = "suportTeoretic6";
            this.Load += new System.EventHandler(this.suportTeoretic6_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtSumePartiale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtPointeri;
    }
}