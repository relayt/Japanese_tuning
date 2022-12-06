namespace Japanese_tuning
{
    partial class RegisrtationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisrtationForm));
            this.RegBT = new System.Windows.Forms.Button();
            this.EntLoginLB = new System.Windows.Forms.Label();
            this.EntLoginTX = new System.Windows.Forms.TextBox();
            this.EntPasswordTX = new System.Windows.Forms.TextBox();
            this.EntPasswordLB = new System.Windows.Forms.Label();
            this.EntPasswordSecTX = new System.Windows.Forms.TextBox();
            this.EntPasswordSecLB = new System.Windows.Forms.Label();
            this.LogoReg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoReg)).BeginInit();
            this.SuspendLayout();
            // 
            // RegBT
            // 
            this.RegBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBT.Location = new System.Drawing.Point(171, 199);
            this.RegBT.Name = "RegBT";
            this.RegBT.Size = new System.Drawing.Size(146, 26);
            this.RegBT.TabIndex = 0;
            this.RegBT.Text = "Зарегистрироваться";
            this.RegBT.UseVisualStyleBackColor = true;
            this.RegBT.Click += new System.EventHandler(this.RegBT_Click);
            // 
            // EntLoginLB
            // 
            this.EntLoginLB.AutoSize = true;
            this.EntLoginLB.BackColor = System.Drawing.Color.Silver;
            this.EntLoginLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntLoginLB.Location = new System.Drawing.Point(117, 112);
            this.EntLoginLB.Name = "EntLoginLB";
            this.EntLoginLB.Size = new System.Drawing.Size(102, 17);
            this.EntLoginLB.TabIndex = 1;
            this.EntLoginLB.Text = "Введите логин:";
            // 
            // EntLoginTX
            // 
            this.EntLoginTX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntLoginTX.Location = new System.Drawing.Point(221, 108);
            this.EntLoginTX.Name = "EntLoginTX";
            this.EntLoginTX.Size = new System.Drawing.Size(194, 25);
            this.EntLoginTX.TabIndex = 2;
            this.EntLoginTX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntLoginTX_KeyPress);
            // 
            // EntPasswordTX
            // 
            this.EntPasswordTX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntPasswordTX.Location = new System.Drawing.Point(221, 134);
            this.EntPasswordTX.Name = "EntPasswordTX";
            this.EntPasswordTX.PasswordChar = '●';
            this.EntPasswordTX.Size = new System.Drawing.Size(194, 25);
            this.EntPasswordTX.TabIndex = 4;
            this.EntPasswordTX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntPasswordTX_KeyPress);
            // 
            // EntPasswordLB
            // 
            this.EntPasswordLB.AutoSize = true;
            this.EntPasswordLB.BackColor = System.Drawing.Color.Silver;
            this.EntPasswordLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntPasswordLB.Location = new System.Drawing.Point(108, 138);
            this.EntPasswordLB.Name = "EntPasswordLB";
            this.EntPasswordLB.Size = new System.Drawing.Size(111, 17);
            this.EntPasswordLB.TabIndex = 3;
            this.EntPasswordLB.Text = "Введите пароль:";
            // 
            // EntPasswordSecTX
            // 
            this.EntPasswordSecTX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntPasswordSecTX.Location = new System.Drawing.Point(221, 160);
            this.EntPasswordSecTX.Name = "EntPasswordSecTX";
            this.EntPasswordSecTX.PasswordChar = '●';
            this.EntPasswordSecTX.Size = new System.Drawing.Size(194, 25);
            this.EntPasswordSecTX.TabIndex = 6;
            this.EntPasswordSecTX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntPasswordSecTX_KeyPress);
            // 
            // EntPasswordSecLB
            // 
            this.EntPasswordSecLB.AutoSize = true;
            this.EntPasswordSecLB.BackColor = System.Drawing.Color.Silver;
            this.EntPasswordSecLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntPasswordSecLB.Location = new System.Drawing.Point(91, 164);
            this.EntPasswordSecLB.Name = "EntPasswordSecLB";
            this.EntPasswordSecLB.Size = new System.Drawing.Size(128, 17);
            this.EntPasswordSecLB.TabIndex = 5;
            this.EntPasswordSecLB.Text = "Повторите пароль:";
            // 
            // LogoReg
            // 
            this.LogoReg.Image = ((System.Drawing.Image)(resources.GetObject("LogoReg.Image")));
            this.LogoReg.Location = new System.Drawing.Point(94, 33);
            this.LogoReg.Name = "LogoReg";
            this.LogoReg.Size = new System.Drawing.Size(338, 68);
            this.LogoReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoReg.TabIndex = 8;
            this.LogoReg.TabStop = false;
            // 
            // RegisrtationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(516, 269);
            this.Controls.Add(this.LogoReg);
            this.Controls.Add(this.EntPasswordSecTX);
            this.Controls.Add(this.EntPasswordSecLB);
            this.Controls.Add(this.EntPasswordTX);
            this.Controls.Add(this.EntPasswordLB);
            this.Controls.Add(this.EntLoginTX);
            this.Controls.Add(this.EntLoginLB);
            this.Controls.Add(this.RegBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisrtationForm";
            this.Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)(this.LogoReg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegBT;
        private System.Windows.Forms.Label EntLoginLB;
        private System.Windows.Forms.TextBox EntLoginTX;
        private System.Windows.Forms.TextBox EntPasswordTX;
        private System.Windows.Forms.Label EntPasswordLB;
        private System.Windows.Forms.TextBox EntPasswordSecTX;
        private System.Windows.Forms.Label EntPasswordSecLB;
        private System.Windows.Forms.PictureBox LogoReg;
    }
}