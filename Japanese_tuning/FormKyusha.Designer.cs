namespace Japanese_tuning
{
    partial class FormKyusha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKyusha));
            this.WebKyusha = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebKyusha
            // 
            this.WebKyusha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebKyusha.Location = new System.Drawing.Point(0, 0);
            this.WebKyusha.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebKyusha.Name = "WebKyusha";
            this.WebKyusha.Size = new System.Drawing.Size(1574, 773);
            this.WebKyusha.TabIndex = 0;
            // 
            // FormKyusha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 773);
            this.Controls.Add(this.WebKyusha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKyusha";
            this.Text = "Kyusha Style";
            this.Load += new System.EventHandler(this.FormKyusha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebKyusha;
    }
}