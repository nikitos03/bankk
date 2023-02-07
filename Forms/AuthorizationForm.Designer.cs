
namespace Banking.UI
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.AuthForm = new System.Windows.Forms.TabPage();
            this.Password = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.UserStart = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.RegistForm = new System.Windows.Forms.TabControl();
            this.AuthForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserStart)).BeginInit();
            this.RegistForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthForm
            // 
            this.AuthForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AuthForm.Controls.Add(this.Login);
            this.AuthForm.Controls.Add(this.Password);
            this.AuthForm.Controls.Add(this.UserStart);
            this.AuthForm.Controls.Add(this.EnterButton);
            this.AuthForm.Controls.Add(this.ExitButton);
            this.AuthForm.Controls.Add(this.LoginLabel);
            this.AuthForm.Controls.Add(this.PasswordLabel);
            this.AuthForm.Location = new System.Drawing.Point(4, 22);
            this.AuthForm.Name = "AuthForm";
            this.AuthForm.Padding = new System.Windows.Forms.Padding(3);
            this.AuthForm.Size = new System.Drawing.Size(602, 261);
            this.AuthForm.TabIndex = 0;
            this.AuthForm.Text = "Авторизация";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(388, 114);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(167, 20);
            this.Password.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(267, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(97, 24);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(267, 48);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(62, 24);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login:";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(349, 200);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(147, 34);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(349, 160);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(147, 34);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // UserStart
            // 
            this.UserStart.Image = ((System.Drawing.Image)(resources.GetObject("UserStart.Image")));
            this.UserStart.Location = new System.Drawing.Point(15, 20);
            this.UserStart.Name = "UserStart";
            this.UserStart.Size = new System.Drawing.Size(200, 200);
            this.UserStart.TabIndex = 7;
            this.UserStart.TabStop = false;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(388, 53);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(167, 20);
            this.Login.TabIndex = 5;
            // 
            // RegistForm
            // 
            this.RegistForm.Controls.Add(this.AuthForm);
            this.RegistForm.Location = new System.Drawing.Point(12, 12);
            this.RegistForm.Name = "RegistForm";
            this.RegistForm.SelectedIndex = 0;
            this.RegistForm.Size = new System.Drawing.Size(610, 287);
            this.RegistForm.TabIndex = 8;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.RegistForm);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.Text = "Omega Bank";
            this.AuthForm.ResumeLayout(false);
            this.AuthForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserStart)).EndInit();
            this.RegistForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage AuthForm;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox UserStart;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TabControl RegistForm;
    }
}

