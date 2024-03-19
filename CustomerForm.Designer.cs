namespace Hotel_Mangement_System
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private RadioButton radioButtonName;
        private ColorDialog colorDialog1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            radioButtonphone = new RadioButton();
            button1 = new Button();
            radioButtonName = new RadioButton();
            radioButtonIdentity = new RadioButton();
            label1 = new Label();
            textBoxSearch = new TextBox();
            dataGridViewSearchResult = new DataGridView();
            dataGridViewAllCustomers = new DataGridView();
            groupBox2 = new GroupBox();
            groupBox3CustomerDeatils = new GroupBox();
            textBoxCustId = new TextBox();
            textBoxCustEmail = new TextBox();
            textBoxCustPhone = new TextBox();
            textBoxCustName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button4delete = new Button();
            button3update = new Button();
            button2insert = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3CustomerDeatils.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxSearch);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(610, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Customer";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonphone);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(radioButtonName);
            groupBox3.Controls.Add(radioButtonIdentity);
            groupBox3.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(6, 99);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(588, 60);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search By";
            // 
            // radioButtonphone
            // 
            radioButtonphone.AutoSize = true;
            radioButtonphone.Location = new Point(272, 25);
            radioButtonphone.Name = "radioButtonphone";
            radioButtonphone.Size = new Size(150, 29);
            radioButtonphone.TabIndex = 7;
            radioButtonphone.TabStop = true;
            radioButtonphone.Text = "By Phone no.";
            radioButtonphone.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(454, 19);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButtonName
            // 
            radioButtonName.AutoSize = true;
            radioButtonName.Location = new Point(136, 25);
            radioButtonName.Name = "radioButtonName";
            radioButtonName.Size = new Size(115, 29);
            radioButtonName.TabIndex = 6;
            radioButtonName.TabStop = true;
            radioButtonName.Text = "By Name";
            radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(6, 25);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(130, 29);
            radioButtonIdentity.TabIndex = 5;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "By Identity";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(512, 32);
            label1.TabIndex = 1;
            label1.Text = "Search customer by name,email,ID or phone no.";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(47, 62);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(382, 31);
            textBoxSearch.TabIndex = 0;
            // 
            // dataGridViewSearchResult
            // 
            dataGridViewSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResult.Location = new Point(56, 204);
            dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            dataGridViewSearchResult.RowHeadersWidth = 62;
            dataGridViewSearchResult.Size = new Size(530, 149);
            dataGridViewSearchResult.TabIndex = 1;
            // 
            // dataGridViewAllCustomers
            // 
            dataGridViewAllCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllCustomers.Location = new Point(6, 33);
            dataGridViewAllCustomers.Name = "dataGridViewAllCustomers";
            dataGridViewAllCustomers.RowHeadersWidth = 62;
            dataGridViewAllCustomers.Size = new Size(576, 283);
            dataGridViewAllCustomers.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAllCustomers);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(662, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(588, 342);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "All Customers";
            // 
            // groupBox3CustomerDeatils
            // 
            groupBox3CustomerDeatils.Controls.Add(textBoxCustId);
            groupBox3CustomerDeatils.Controls.Add(textBoxCustEmail);
            groupBox3CustomerDeatils.Controls.Add(textBoxCustPhone);
            groupBox3CustomerDeatils.Controls.Add(textBoxCustName);
            groupBox3CustomerDeatils.Controls.Add(label5);
            groupBox3CustomerDeatils.Controls.Add(label4);
            groupBox3CustomerDeatils.Controls.Add(label3);
            groupBox3CustomerDeatils.Controls.Add(label2);
            groupBox3CustomerDeatils.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3CustomerDeatils.Location = new Point(74, 377);
            groupBox3CustomerDeatils.Name = "groupBox3CustomerDeatils";
            groupBox3CustomerDeatils.Size = new Size(955, 222);
            groupBox3CustomerDeatils.TabIndex = 5;
            groupBox3CustomerDeatils.TabStop = false;
            groupBox3CustomerDeatils.Text = "Customer Details";
            // 
            // textBoxCustId
            // 
            textBoxCustId.Location = new Point(260, 173);
            textBoxCustId.Name = "textBoxCustId";
            textBoxCustId.Size = new Size(382, 34);
            textBoxCustId.TabIndex = 6;
            // 
            // textBoxCustEmail
            // 
            textBoxCustEmail.Location = new Point(260, 127);
            textBoxCustEmail.Name = "textBoxCustEmail";
            textBoxCustEmail.Size = new Size(382, 34);
            textBoxCustEmail.TabIndex = 5;
            // 
            // textBoxCustPhone
            // 
            textBoxCustPhone.Location = new Point(260, 85);
            textBoxCustPhone.Name = "textBoxCustPhone";
            textBoxCustPhone.Size = new Size(382, 34);
            textBoxCustPhone.TabIndex = 4;
            // 
            // textBoxCustName
            // 
            textBoxCustName.Location = new Point(260, 35);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(382, 34);
            textBoxCustName.TabIndex = 3;
            textBoxCustName.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 170);
            label5.Name = "label5";
            label5.Size = new Size(201, 28);
            label5.TabIndex = 3;
            label5.Text = "Customer Identity No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 130);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 2;
            label4.Text = "Customer Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 85);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 1;
            label3.Text = "Customer Phone No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 38);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 0;
            label2.Text = "Customer Name";
            // 
            // button4delete
            // 
            button4delete.Location = new Point(739, 605);
            button4delete.Name = "button4delete";
            button4delete.Size = new Size(112, 34);
            button4delete.TabIndex = 9;
            button4delete.Text = "Delete";
            button4delete.UseVisualStyleBackColor = true;
            button4delete.Click += button4delete_Click;
            // 
            // button3update
            // 
            button3update.Location = new Point(883, 605);
            button3update.Name = "button3update";
            button3update.Size = new Size(112, 34);
            button3update.TabIndex = 8;
            button3update.Text = "Update";
            button3update.UseVisualStyleBackColor = true;
            button3update.Click += button3update_Click;
            // 
            // button2insert
            // 
            button2insert.Location = new Point(604, 605);
            button2insert.Name = "button2insert";
            button2insert.Size = new Size(112, 34);
            button2insert.TabIndex = 7;
            button2insert.Text = "Insert";
            button2insert.UseVisualStyleBackColor = true;
            button2insert.Click += button2_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 646);
            Controls.Add(button3update);
            Controls.Add(button4delete);
            Controls.Add(dataGridViewSearchResult);
            Controls.Add(groupBox1);
            Controls.Add(button2insert);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3CustomerDeatils);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllCustomers).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3CustomerDeatils.ResumeLayout(false);
            groupBox3CustomerDeatils.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxSearch;
        private Label label1;
        private Button button1;
        private DataGridView dataGridViewSearchResult;
        private DataGridView dataGridViewAllCustomers;
        private GroupBox groupBox2;
        private GroupBox groupBox3CustomerDeatils;
        private TextBox textBoxCustName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxCustId;
        private TextBox textBoxCustEmail;
        private TextBox textBoxCustPhone;
        private Button button4delete;
        private Button button3update;
        private Button button2insert;
        private GroupBox groupBox3;
        private RadioButton radioButtonIdentity;
        private RadioButton radioButtonphone;
    }
}