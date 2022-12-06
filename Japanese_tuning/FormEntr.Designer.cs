namespace Japanese_tuning
{
    partial class PassLogForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassLogForm));
            this.EntranceBT = new System.Windows.Forms.Button();
            this.LoginTX = new System.Windows.Forms.TextBox();
            this.PasswordTX = new System.Windows.Forms.TextBox();
            this.RegistrationBT = new System.Windows.Forms.Button();
            this.LoginLB = new System.Windows.Forms.Label();
            this.PasswordLB = new System.Windows.Forms.Label();
            this.LogoEnt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoEnt)).BeginInit();
            this.SuspendLayout();
            // 
            // EntranceBT
            // 
            this.EntranceBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntranceBT.Location = new System.Drawing.Point(263, 153);
            this.EntranceBT.Name = "EntranceBT";
            this.EntranceBT.Size = new System.Drawing.Size(76, 25);
            this.EntranceBT.TabIndex = 3;
            this.EntranceBT.Text = "Вход";
            this.EntranceBT.UseVisualStyleBackColor = true;
            this.EntranceBT.Click += new System.EventHandler(this.EntranceBT_Click);
            // 
            // LoginTX
            // 
            this.LoginTX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTX.Location = new System.Drawing.Point(91, 88);
            this.LoginTX.Name = "LoginTX";
            this.LoginTX.Size = new System.Drawing.Size(248, 25);
            this.LoginTX.TabIndex = 1;
            this.LoginTX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginTX_KeyPress);
            // 
            // PasswordTX
            // 
            this.PasswordTX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTX.Location = new System.Drawing.Point(91, 118);
            this.PasswordTX.Name = "PasswordTX";
            this.PasswordTX.PasswordChar = '●';
            this.PasswordTX.Size = new System.Drawing.Size(248, 25);
            this.PasswordTX.TabIndex = 2;
            this.PasswordTX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTX_KeyPress);
            // 
            // RegistrationBT
            // 
            this.RegistrationBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationBT.Location = new System.Drawing.Point(32, 153);
            this.RegistrationBT.Name = "RegistrationBT";
            this.RegistrationBT.Size = new System.Drawing.Size(145, 25);
            this.RegistrationBT.TabIndex = 4;
            this.RegistrationBT.Text = "Зарегистрироваться";
            this.RegistrationBT.UseVisualStyleBackColor = true;
            this.RegistrationBT.Click += new System.EventHandler(this.RegistrationBT_Click);
            // 
            // LoginLB
            // 
            this.LoginLB.AutoSize = true;
            this.LoginLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLB.Location = new System.Drawing.Point(42, 91);
            this.LoginLB.Name = "LoginLB";
            this.LoginLB.Size = new System.Drawing.Size(46, 17);
            this.LoginLB.TabIndex = 5;
            this.LoginLB.Text = "Логин";
            // 
            // PasswordLB
            // 
            this.PasswordLB.AutoSize = true;
            this.PasswordLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLB.Location = new System.Drawing.Point(33, 122);
            this.PasswordLB.Name = "PasswordLB";
            this.PasswordLB.Size = new System.Drawing.Size(55, 17);
            this.PasswordLB.TabIndex = 6;
            this.PasswordLB.Text = "Пароль";
            // 
            // LogoEnt
            // 
            this.LogoEnt.Image = ((System.Drawing.Image)(resources.GetObject("LogoEnt.Image")));
            this.LogoEnt.Location = new System.Drawing.Point(29, 12);
            this.LogoEnt.Name = "LogoEnt";
            this.LogoEnt.Size = new System.Drawing.Size(321, 68);
            this.LogoEnt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoEnt.TabIndex = 7;
            this.LogoEnt.TabStop = false;
            // 
            // PassLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(393, 203);
            this.Controls.Add(this.LogoEnt);
            this.Controls.Add(this.PasswordLB);
            this.Controls.Add(this.LoginLB);
            this.Controls.Add(this.RegistrationBT);
            this.Controls.Add(this.PasswordTX);
            this.Controls.Add(this.LoginTX);
            this.Controls.Add(this.EntranceBT);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassLogForm";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassLogForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LogoEnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntranceBT;
        private System.Windows.Forms.TextBox PasswordTX;
        private System.Windows.Forms.Button RegistrationBT;
        private System.Windows.Forms.Label LoginLB;
        private System.Windows.Forms.Label PasswordLB;
        public System.Windows.Forms.TextBox LoginTX;
        private System.Windows.Forms.PictureBox LogoEnt;
    }
}

