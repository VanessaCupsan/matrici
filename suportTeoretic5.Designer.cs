namespace matrici
{
    partial class suportTeoretic5
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
            this.rGenerareaMatricilor1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rGenerarePatrateMagice = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rGenerareaMatricilor1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(961, 508);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Pătratul magic- definiție și scurtă istorie";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rGenerareaMatricilor1
            // 
            this.rGenerareaMatricilor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rGenerareaMatricilor1.Location = new System.Drawing.Point(23, 0);
            this.rGenerareaMatricilor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rGenerareaMatricilor1.Name = "rGenerareaMatricilor1";
            this.rGenerareaMatricilor1.Size = new System.Drawing.Size(913, 508);
            this.rGenerareaMatricilor1.TabIndex = 1;
            this.rGenerareaMatricilor1.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rGenerarePatrateMagice);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(961, 508);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Generarea pătratelor magice de diferite ordine";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rGenerarePatrateMagice
            // 
            this.rGenerarePatrateMagice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rGenerarePatrateMagice.Location = new System.Drawing.Point(24, 0);
            this.rGenerarePatrateMagice.Name = "rGenerarePatrateMagice";
            this.rGenerarePatrateMagice.Size = new System.Drawing.Size(911, 508);
            this.rGenerarePatrateMagice.TabIndex = 0;
            this.rGenerarePatrateMagice.Text = "";
            // 
            // suportTeoretic5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 545);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "suportTeoretic5";
            this.Text = "suportTeoretic5";
            this.Load += new System.EventHandler(this.suportTeoretic5_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rGenerareaMatricilor1;
        private System.Windows.Forms.RichTextBox rGenerarePatrateMagice;
    }
}