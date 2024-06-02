namespace Third_Assignment
{
    partial class StudentLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(307, 172);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(190, 22);
            this.UsernameTxt.TabIndex = 0;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(307, 244);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';  // Dodano za skrivanje lozinke
            this.PasswordTxt.Size = new System.Drawing.Size(190, 22);
            this.PasswordTxt.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(313, 153);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(70, 16);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(313, 225);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(357, 300);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 39);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Name = "StudentLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Login;
    }
}
