namespace Hotel_Mangement_System
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            btn1exit = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn1exit
            // 
            btn1exit.BackColor = SystemColors.AppWorkspace;
            btn1exit.Font = new Font("Arial monospaced for SAP", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn1exit.Location = new Point(495, 200);
            btn1exit.Name = "btn1exit";
            btn1exit.Size = new Size(146, 43);
            btn1exit.TabIndex = 0;
            btn1exit.Text = "Exit";
            btn1exit.UseVisualStyleBackColor = false;
            btn1exit.Click += btn1exit_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleVioletRed;
            groupBox1.Controls.Add(button2);
            groupBox1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(144, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Management";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(21, 68);
            button2.Name = "button2";
            button2.Size = new Size(258, 34);
            button2.TabIndex = 0;
            button2.Text = "Open Customer Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 55);
            label1.Name = "label1";
            label1.Size = new Size(395, 48);
            label1.TabIndex = 2;
            label1.Text = "Customer Registration";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btn1exit);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btn1exit;
        private GroupBox groupBox1;
        private Button button2;
        private Label label1;
    }
}