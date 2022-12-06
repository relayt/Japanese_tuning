namespace Japanese_tuning
{
    partial class FormVIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVIP));
            this.WebVIP = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebVIP
            // 
            this.WebVIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebVIP.Location = new System.Drawing.Point(0, 0);
            this.WebVIP.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebVIP.Name = "WebVIP";
            this.WebVIP.Size = new System.Drawing.Size(1574, 773);
            this.WebVIP.TabIndex = 0;
            // 
            // FormVIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 773);
            this.Controls.Add(this.WebVIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVIP";
            this.Text = "VIP Style";
            this.Load += new System.EventHandler(this.FormVIP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebVIP;
    }
}