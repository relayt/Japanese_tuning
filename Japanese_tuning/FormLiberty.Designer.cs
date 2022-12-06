namespace Japanese_tuning
{
    partial class FormLiberty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLiberty));
            this.WebLiberty = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebLiberty
            // 
            this.WebLiberty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebLiberty.Location = new System.Drawing.Point(0, 0);
            this.WebLiberty.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebLiberty.Name = "WebLiberty";
            this.WebLiberty.Size = new System.Drawing.Size(1574, 773);
            this.WebLiberty.TabIndex = 0;
            // 
            // FormLiberty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 773);
            this.Controls.Add(this.WebLiberty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLiberty";
            this.Text = "Liberty Walk";
            this.Load += new System.EventHandler(this.FormLiberty_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebLiberty;
    }
}