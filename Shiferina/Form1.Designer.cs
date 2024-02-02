namespace Shiferina
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainText = new TextBox();
            Deshif = new Button();
            Shif = new Button();
            pictureBox1 = new PictureBox();
            OutText = new TextBox();
            Kkey = new TextBox();
            label1 = new Label();
            ImportFile = new Button();
            ExportFile = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainText
            // 
            MainText.BackColor = SystemColors.ControlText;
            MainText.BorderStyle = BorderStyle.FixedSingle;
            MainText.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MainText.ForeColor = Color.White;
            MainText.ImeMode = ImeMode.On;
            MainText.Location = new Point(38, 12);
            MainText.Margin = new Padding(4, 3, 4, 3);
            MainText.Multiline = true;
            MainText.Name = "MainText";
            MainText.ScrollBars = ScrollBars.Vertical;
            MainText.Size = new Size(528, 441);
            MainText.TabIndex = 0;
            // 
            // Deshif
            // 
            Deshif.BackColor = SystemColors.ControlText;
            Deshif.Cursor = Cursors.Hand;
            Deshif.FlatStyle = FlatStyle.Flat;
            Deshif.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Deshif.ForeColor = Color.Lime;
            Deshif.Location = new Point(346, 474);
            Deshif.Name = "Deshif";
            Deshif.Size = new Size(158, 38);
            Deshif.TabIndex = 1;
            Deshif.Text = "Дешифровка";
            Deshif.UseVisualStyleBackColor = false;
            Deshif.Click += Deshif_Click;
            // 
            // Shif
            // 
            Shif.BackColor = SystemColors.ControlText;
            Shif.Cursor = Cursors.Hand;
            Shif.FlatStyle = FlatStyle.Flat;
            Shif.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Shif.ForeColor = Color.Lime;
            Shif.Location = new Point(77, 474);
            Shif.Name = "Shif";
            Shif.Size = new Size(158, 38);
            Shif.TabIndex = 3;
            Shif.Text = "Шифровка";
            Shif.UseVisualStyleBackColor = false;
            Shif.Click += Shif_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.staricon_1;
            pictureBox1.Location = new Point(591, 489);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // OutText
            // 
            OutText.BackColor = SystemColors.ControlText;
            OutText.BorderStyle = BorderStyle.FixedSingle;
            OutText.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            OutText.ForeColor = Color.White;
            OutText.ImeMode = ImeMode.On;
            OutText.Location = new Point(729, 12);
            OutText.Margin = new Padding(4, 3, 4, 3);
            OutText.Multiline = true;
            OutText.Name = "OutText";
            OutText.ScrollBars = ScrollBars.Vertical;
            OutText.Size = new Size(535, 441);
            OutText.TabIndex = 5;
            // 
            // Kkey
            // 
            Kkey.Location = new Point(824, 519);
            Kkey.Name = "Kkey";
            Kkey.Size = new Size(339, 22);
            Kkey.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(823, 490);
            label1.Name = "label1";
            label1.Size = new Size(46, 22);
            label1.TabIndex = 7;
            label1.Text = "Key";
            // 
            // ImportFile
            // 
            ImportFile.BackColor = SystemColors.ControlText;
            ImportFile.Cursor = Cursors.Hand;
            ImportFile.FlatStyle = FlatStyle.Flat;
            ImportFile.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ImportFile.ForeColor = Color.Lime;
            ImportFile.Location = new Point(77, 550);
            ImportFile.Name = "ImportFile";
            ImportFile.Size = new Size(158, 38);
            ImportFile.TabIndex = 8;
            ImportFile.Text = "Импортировать содержание";
            ImportFile.UseVisualStyleBackColor = false;
            ImportFile.Click += ImportFile_Click;
            // 
            // ExportFile
            // 
            ExportFile.BackColor = SystemColors.ControlText;
            ExportFile.Cursor = Cursors.Hand;
            ExportFile.FlatStyle = FlatStyle.Flat;
            ExportFile.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ExportFile.ForeColor = Color.Lime;
            ExportFile.Location = new Point(346, 550);
            ExportFile.Name = "ExportFile";
            ExportFile.Size = new Size(158, 38);
            ExportFile.TabIndex = 9;
            ExportFile.Text = "Экспортировать в файл";
            ExportFile.UseVisualStyleBackColor = false;
            ExportFile.Click += ExportFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1277, 654);
            Controls.Add(ExportFile);
            Controls.Add(ImportFile);
            Controls.Add(label1);
            Controls.Add(Kkey);
            Controls.Add(OutText);
            Controls.Add(pictureBox1);
            Controls.Add(Shif);
            Controls.Add(Deshif);
            Controls.Add(MainText);
            DoubleBuffered = true;
            Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "TextShift";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MainText;
        private Button Deshif;
        private Button Shif;
        private PictureBox pictureBox1;
        private TextBox OutText;
        private TextBox Kkey;
        private Label label1;
        private Button ImportFile;
        private Button ExportFile;
    }
}