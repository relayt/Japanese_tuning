namespace Japanese_tuning
{
    partial class FormYanky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYanky));
            this.WebYanky = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebYanky
            // 
            this.WebYanky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebYanky.Location = new System.Drawing.Point(0, 0);
            this.WebYanky.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebYanky.Name = "WebYanky";
            this.WebYanky.Size = new System.Drawing.Size(1574, 773);
            this.WebYanky.TabIndex = 0;
            // 
            // FormYanky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 773);
            this.Controls.Add(this.WebYanky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYanky";
            this.Text = "Yanky Style";
            this.Load += new System.EventHandler(this.FormYanky_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebYanky;
    }
}