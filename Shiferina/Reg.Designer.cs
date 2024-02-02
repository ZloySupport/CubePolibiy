namespace Shiferina
{
    partial class Reg
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
            button1 = new Button();
            label1 = new Label();
            RegUserN = new TextBox();
            label3 = new Label();
            label4 = new Label();
            PasswordF = new TextBox();
            PasswordS = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(120, 309);
            button1.Name = "button1";
            button1.Size = new Size(255, 108);
            button1.TabIndex = 0;
            button1.Text = "Reg";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(72, 93);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // RegUserN
            // 
            RegUserN.Location = new Point(198, 97);
            RegUserN.Name = "RegUserN";
            RegUserN.Size = new Size(176, 23);
            RegUserN.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(72, 186);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(72, 231);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // PasswordF
            // 
            PasswordF.Location = new Point(199, 190);
            PasswordF.Name = "PasswordF";
            PasswordF.Size = new Size(176, 23);
            PasswordF.TabIndex = 6;
            // 
            // PasswordS
            // 
            PasswordS.Location = new Point(198, 235);
            PasswordS.Name = "PasswordS";
            PasswordS.Size = new Size(176, 23);
            PasswordS.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.staricon_1;
            pictureBox1.InitialImage = Properties.Resources.staricon_1;
            pictureBox1.Location = new Point(380, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(648, 450);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordS);
            Controls.Add(PasswordF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RegUserN);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(664, 489);
            Name = "Reg";
            Text = "Reg";
            TopMost = true;
            Load += Reg_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox RegUserN;
        private Label label3;
        private Label label4;
        private TextBox PasswordF;
        private TextBox PasswordS;
        private PictureBox pictureBox1;
    }
}