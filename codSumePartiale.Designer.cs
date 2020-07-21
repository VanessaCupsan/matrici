namespace matrici
{
    partial class codSumePartiale
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
            this.rtCod = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtCod
            // 
            this.rtCod.Location = new System.Drawing.Point(0, 0);
            this.rtCod.Name = "rtCod";
            this.rtCod.Size = new System.Drawing.Size(546, 429);
            this.rtCod.TabIndex = 0;
            this.rtCod.Text = "";
            // 
            // codSumePartiale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 427);
            this.Controls.Add(this.rtCod);
            this.Name = "codSumePartiale";
            this.Text = "codSumePartiale";
            this.Load += new System.EventHandler(this.codSumePartiale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtCod;
    }
}