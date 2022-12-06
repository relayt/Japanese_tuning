namespace Japanese_tuning
{
    partial class FormSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSummary));
            this.FinalLBX = new System.Windows.Forms.ListBox();
            this.SaveBT = new System.Windows.Forms.Button();
            this.SummaTX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FinalLBX
            // 
            this.FinalLBX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalLBX.FormattingEnabled = true;
            this.FinalLBX.ItemHeight = 17;
            this.FinalLBX.Location = new System.Drawing.Point(67, 28);
            this.FinalLBX.Name = "FinalLBX";
            this.FinalLBX.Size = new System.Drawing.Size(217, 157);
            this.FinalLBX.TabIndex = 0;
            // 
            // SaveBT
            // 
            this.SaveBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBT.Location = new System.Drawing.Point(130, 253);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(91, 32);
            this.SaveBT.TabIndex = 1;
            this.SaveBT.Text = "Сохранить";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // SummaTX
            // 
            this.SummaTX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaTX.Location = new System.Drawing.Point(97, 207);
            this.SummaTX.Name = "SummaTX";
            this.SummaTX.ReadOnly = true;
            this.SummaTX.Size = new System.Drawing.Size(149, 25);
            this.SummaTX.TabIndex = 2;
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(362, 337);
            this.Controls.Add(this.SummaTX);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.FinalLBX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSummary";
            this.Text = "Итог";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSummary_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FinalLBX;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.TextBox SummaTX;
    }
}