namespace Shiferina
{
    partial class Aut2
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
            Login = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(138, 72);
            Login.Name = "Login";
            Login.Size = new Size(507, 27);
            Login.TabIndex = 0;
            // 
            // Password
            // 
            Password.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(138, 179);
            Password.Name = "Password";
            Password.PasswordChar = '@';
            Password.Size = new Size(507, 27);
            Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(138, 45);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(138, 152);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = SystemColors.MenuBar;
            linkLabel1.Location = new Point(325, 350);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 14);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Нет учётной записи?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Stencil", 45F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(225, 250);
            button1.Name = "button1";
            button1.Size = new Size(322, 89);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Aut2
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 420);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Login);
            Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Aut2";
            RightToLeft = RightToLeft.No;
            Text = "Aut2";
            FormClosed += Aut2_FormClosed;
            Load += Aut2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Login;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}