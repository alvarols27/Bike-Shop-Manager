namespace MyBikes.user
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelUser = new Label();
            buttonLogin = new Button();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            pictureBox3 = new PictureBox();
            labelPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(270, 214);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(270, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // labelUser
            // 
            labelUser.BackColor = Color.Beige;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(389, 143);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(146, 45);
            labelUser.TabIndex = 13;
            labelUser.Text = "User:";
            labelUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Beige;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(525, 323);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(129, 60);
            buttonLogin.TabIndex = 17;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUser
            // 
            textBoxUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxUser.Location = new Point(588, 150);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(175, 35);
            textBoxUser.TabIndex = 15;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxPassword.Location = new Point(588, 238);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(175, 35);
            textBoxPassword.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = MyBikes2.Properties.Resources.bikelog;
            pictureBox3.Location = new Point(-2, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1115, 496);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // labelPassword
            // 
            labelPassword.BackColor = Color.Beige;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPassword.ForeColor = Color.Black;
            labelPassword.Location = new Point(389, 225);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(151, 48);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 493);
            Controls.Add(labelPassword);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPassword);
            Controls.Add(pictureBox2);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxUser);
            Controls.Add(labelUser);
            Controls.Add(pictureBox3);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelUser;
        private Button buttonLogin;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private PictureBox pictureBox3;
        private Label labelPassword;
    }
}