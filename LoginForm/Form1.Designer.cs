
namespace LoginForm41
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);

            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 330);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login Form 4.1";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            AcceptButton = btnLogin;
            CancelButton = btnExit;

            // Title
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(155, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(190, 41);
            lblTitle.Text = "ĐĂNG NHẬP";

            // Username label
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(50, 105);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(109, 20);
            lblUsername.Text = "Tên đăng nhập:";

            // Username textbox
            txtUsername.Location = new System.Drawing.Point(180, 101);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(250, 27);
            txtUsername.TabIndex = 0;

            // Password label
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(50, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(80, 20);
            lblPassword.Text = "Mật khẩu:";

            // Password textbox
            txtPassword.Location = new System.Drawing.Point(180, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(250, 27);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TabIndex = 1;

            // Show password checkbox
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new System.Drawing.Point(180, 184);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new System.Drawing.Size(129, 24);
            chkShowPassword.Text = "Hiện mật khẩu";
            chkShowPassword.TabIndex = 2;
            chkShowPassword.UseVisualStyleBackColor = true;

            // Login button
            btnLogin.Location = new System.Drawing.Point(180, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(110, 38);
            btnLogin.Text = "Đăng nhập";
            btnLogin.TabIndex = 3;
            btnLogin.UseVisualStyleBackColor = true;

            // Exit button
            btnExit.Location = new System.Drawing.Point(320, 230);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(110, 38);
            btnExit.Text = "Thoát";
            btnExit.TabIndex = 4;
            btnExit.UseVisualStyleBackColor = true;

            // ErrorProvider
            errorProvider1.ContainerControl = this;

            // Add controls
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);

            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
