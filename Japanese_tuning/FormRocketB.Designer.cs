namespace Japanese_tuning
{
    partial class FormRocketB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRocketB));
            this.WebRocketB = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebRocketB
            // 
            this.WebRocketB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebRocketB.Location = new System.Drawing.Point(0, 0);
            this.WebRocketB.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebRocketB.Name = "WebRocketB";
            this.WebRocketB.Size = new System.Drawing.Size(1574, 773);
            this.WebRocketB.TabIndex = 0;
            // 
            // FormRocketB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 773);
            this.Controls.Add(this.WebRocketB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRocketB";
            this.Text = "Rocket Bunny";
            this.Load += new System.EventHandler(this.FormRocketB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebRocketB;
    }
}