namespace Hotel_Mangement_System
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textboxpassword = new TextBox();
            textboxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 40);
            label1.Name = "label1";
            label1.Size = new Size(539, 36);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Hotel Management Sytem";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(120, 100, 200);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textboxpassword);
            groupBox1.Controls.Add(textboxUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(199, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(735, 312);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please login to continue";
            // 
            // button1
            // 
            button1.Location = new Point(194, 217);
            button1.Name = "button1";
            button1.Size = new Size(302, 46);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textboxpassword
            // 
            textboxpassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxpassword.Location = new Point(194, 142);
            textboxpassword.Name = "textboxpassword";
            textboxpassword.PasswordChar = '*';
            textboxpassword.Size = new Size(302, 37);
            textboxpassword.TabIndex = 4;
            // 
            // textboxUsername
            // 
            textboxUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxUsername.Location = new Point(194, 67);
            textboxUsername.Name = "textboxUsername";
            textboxUsername.Size = new Size(302, 37);
            textboxUsername.TabIndex = 3;
            textboxUsername.TextChanged += textboxUsername_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 142);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 67);
            label2.Name = "label2";
            label2.Size = new Size(128, 32);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1120, 598);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hotel Management System";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textboxpassword;
        private TextBox textboxUsername;
        private Label label3;
        private Button button1;
    }
}
