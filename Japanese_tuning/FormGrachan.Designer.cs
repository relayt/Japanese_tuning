namespace Japanese_tuning
{
    partial class FormGrachan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrachan));
            this.WebGrach = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebGrach
            // 
            this.WebGrach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebGrach.Location = new System.Drawing.Point(0, 0);
            this.WebGrach.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebGrach.Name = "WebGrach";
            this.WebGrach.Size = new System.Drawing.Size(1574, 773);
            this.WebGrach.TabIndex = 0;
            // 
            // FormGrachan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 773);
            this.Controls.Add(this.WebGrach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormGrachan";
            this.Text = "Grachan";
            this.Load += new System.EventHandler(this.FormGrachan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebGrach;
    }
}