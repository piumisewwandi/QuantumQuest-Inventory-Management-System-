namespace Quantum_Quest_Database_Management_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            bglogo = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblusername = new Label();
            lblpassword = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            lblerror = new Label();
            linklblforgotpassword = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)bglogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bglogo
            // 
            bglogo.BackColor = Color.Transparent;
            bglogo.Image = Properties.Resources.LOGO_03;
            bglogo.Location = new Point(89, 25);
            bglogo.Name = "bglogo";
            bglogo.Size = new Size(232, 167);
            bglogo.SizeMode = PictureBoxSizeMode.Zoom;
            bglogo.TabIndex = 0;
            bglogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.usericon_removebg_preview__1_;
            pictureBox1.Location = new Point(47, 212);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.passwrdicon_removebg_preview;
            pictureBox2.Location = new Point(43, 296);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = Color.Transparent;
            lblusername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.ForeColor = Color.White;
            lblusername.Location = new Point(96, 221);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(87, 23);
            lblusername.TabIndex = 3;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.BackColor = Color.Transparent;
            lblpassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblpassword.ForeColor = Color.White;
            lblpassword.Location = new Point(96, 306);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(82, 23);
            lblpassword.TabIndex = 4;
            lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(233, 217);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 27);
            txtusername.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(233, 305);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '●';
            txtpassword.Size = new Size(125, 27);
            txtpassword.TabIndex = 6;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.White;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.Location = new Point(132, 419);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(155, 29);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "Login to the System";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.BackColor = Color.DarkRed;
            lblerror.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblerror.ForeColor = Color.White;
            lblerror.Location = new Point(139, 183);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(0, 20);
            lblerror.TabIndex = 9;
            // 
            // linklblforgotpassword
            // 
            linklblforgotpassword.ActiveLinkColor = Color.White;
            linklblforgotpassword.AutoSize = true;
            linklblforgotpassword.BackColor = Color.Transparent;
            linklblforgotpassword.LinkColor = Color.White;
            linklblforgotpassword.Location = new Point(233, 330);
            linklblforgotpassword.Name = "linklblforgotpassword";
            linklblforgotpassword.Padding = new Padding(10);
            linklblforgotpassword.Size = new Size(138, 40);
            linklblforgotpassword.TabIndex = 11;
            linklblforgotpassword.TabStop = true;
            linklblforgotpassword.Text = "Forgot Password";
            linklblforgotpassword.LinkClicked += linklblforgotpassword_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(411, 493);
            Controls.Add(linklblforgotpassword);
            Controls.Add(lblerror);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bglogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)bglogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bglogo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblusername;
        private Label lblpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Label lblerror;
        private LinkLabel linklblforgotpassword;
    }
}