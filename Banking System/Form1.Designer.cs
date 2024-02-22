namespace Banking_System
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            login = new Button();
            clear = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 24);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(24, 176);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt1
            // 
            txt1.Cursor = Cursors.IBeam;
            txt1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt1.Location = new Point(131, 91);
            txt1.Margin = new Padding(2, 3, 2, 3);
            txt1.Name = "txt1";
            txt1.Size = new Size(195, 30);
            txt1.TabIndex = 2;
            // 
            // txt2
            // 
            txt2.Cursor = Cursors.IBeam;
            txt2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt2.Location = new Point(131, 169);
            txt2.Margin = new Padding(2, 3, 2, 3);
            txt2.Name = "txt2";
            txt2.PasswordChar = '.';
            txt2.Size = new Size(195, 32);
            txt2.TabIndex = 3;
            // 
            // login
            // 
            login.Cursor = Cursors.AppStarting;
            login.Font = new Font("Bernard MT Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = SystemColors.ActiveCaptionText;
            login.Location = new Point(131, 264);
            login.Margin = new Padding(2, 3, 2, 3);
            login.Name = "login";
            login.Size = new Size(97, 27);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // clear
            // 
            clear.Cursor = Cursors.AppStarting;
            clear.Font = new Font("Bernard MT Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            clear.ForeColor = SystemColors.ActiveCaptionText;
            clear.Location = new Point(257, 264);
            clear.Margin = new Padding(2, 3, 2, 3);
            clear.Name = "clear";
            clear.Size = new Size(81, 27);
            clear.TabIndex = 5;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bank_ico;
            pictureBox1.Location = new Point(185, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 303);
            label3.Name = "label3";
            label3.Size = new Size(0, 22);
            label3.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(447, 347);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(clear);
            Controls.Add(login);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Book Antiqua", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Location = new Point(50, 50);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt1;
        private TextBox txt2;
        private Button login;
        private Button clear;
        private PictureBox pictureBox1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}