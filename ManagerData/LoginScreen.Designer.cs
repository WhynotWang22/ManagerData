namespace ManagerData
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_login = new Button();
            txt_clear = new Label();
            btn_exit = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.FromArgb(10, 10, 30);
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.ForeColor = Color.White;
            txt_username.Location = new Point(477, 122);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(331, 23);
            txt_username.TabIndex = 7;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(10, 10, 30);
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.White;
            txt_password.Location = new Point(477, 235);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(331, 23);
            txt_password.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(477, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(0, 117, 214);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(519, 380);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(272, 41);
            btn_login.TabIndex = 4;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_clear
            // 
            txt_clear.AutoSize = true;
            txt_clear.BackColor = Color.Transparent;
            txt_clear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_clear.ForeColor = Color.FromArgb(0, 117, 214);
            txt_clear.Location = new Point(683, 333);
            txt_clear.Name = "txt_clear";
            txt_clear.Size = new Size(116, 23);
            txt_clear.TabIndex = 5;
            txt_clear.Text = "Clear Fields ";
            txt_clear.Click += txt_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.FromArgb(0, 117, 214);
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.Transparent;
            btn_exit.Location = new Point(519, 444);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(272, 41);
            btn_exit.TabIndex = 8;
            btn_exit.Text = "EXIT";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(77, 184, 232);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(820, 534);
            Controls.Add(txt_password);
            Controls.Add(btn_exit);
            Controls.Add(txt_username);
            Controls.Add(txt_clear);
            Controls.Add(btn_login);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_login;
        private Label txt_clear;
        private TextBox txt_username;
        private Button btn_exit;
        private TextBox txt_password;
    }
}
