namespace Web_App
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            comboBoxGender = new ComboBox();
            labelContactID = new Label();
            textBoxContactID = new TextBox();
            textBoxContactNo = new TextBox();
            labelContactNo = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            labelGender = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvContactList = new DataGridView();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGender
            // 
            comboBoxGender.AllowDrop = true;
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male ", "Female" });
            comboBoxGender.Location = new Point(157, 479);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(237, 29);
            comboBoxGender.TabIndex = 12;
            // 
            // labelContactID
            // 
            labelContactID.AutoSize = true;
            labelContactID.BackColor = Color.Transparent;
            labelContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactID.Location = new Point(53, 93);
            labelContactID.Name = "labelContactID";
            labelContactID.Size = new Size(82, 21);
            labelContactID.TabIndex = 1;
            labelContactID.Text = "Contact ID";
            // 
            // textBoxContactID
            // 
            textBoxContactID.BackColor = SystemColors.Window;
            textBoxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactID.Location = new Point(157, 93);
            textBoxContactID.Name = "textBoxContactID";
            textBoxContactID.ReadOnly = true;
            textBoxContactID.Size = new Size(237, 29);
            textBoxContactID.TabIndex = 2;
            textBoxContactID.TextChanged += textBoxContactID_TextChanged;
            // 
            // textBoxContactNo
            // 
            textBoxContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactNo.Location = new Point(157, 265);
            textBoxContactNo.Name = "textBoxContactNo";
            textBoxContactNo.Size = new Size(237, 29);
            textBoxContactNo.TabIndex = 4;
            textBoxContactNo.TextChanged += textBox1_TextChanged;
            // 
            // labelContactNo
            // 
            labelContactNo.AutoSize = true;
            labelContactNo.BackColor = Color.Transparent;
            labelContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactNo.Location = new Point(53, 265);
            labelContactNo.Name = "labelContactNo";
            labelContactNo.Size = new Size(88, 21);
            labelContactNo.TabIndex = 3;
            labelContactNo.Text = "Contact No";
            labelContactNo.Click += label1_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(157, 211);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(237, 29);
            textBoxLastName.TabIndex = 6;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.BackColor = Color.Transparent;
            labelLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(55, 211);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(84, 21);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            labelLastName.Click += labelLastName_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(157, 160);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(237, 29);
            textBoxFirstName.TabIndex = 8;
            textBoxFirstName.TextChanged += textBox3_TextChanged;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(53, 160);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(86, 21);
            labelFirstName.TabIndex = 7;
            labelFirstName.Text = "First Name";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.BackColor = Color.Transparent;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(55, 331);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(66, 21);
            labelAddress.TabIndex = 9;
            labelAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(157, 331);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(237, 107);
            textBoxAddress.TabIndex = 10;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.Transparent;
            labelGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(60, 487);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(61, 21);
            labelGender.TabIndex = 11;
            labelGender.Text = "Gender";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(726, 482);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(853, 483);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(989, 479);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 192, 0);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(1112, 479);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 29);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button4_Click;
            // 
            // dgvContactList
            // 
            dgvContactList.AccessibleName = "";
            dgvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactList.Location = new Point(551, 148);
            dgvContactList.Name = "dgvContactList";
            dgvContactList.Size = new Size(670, 304);
            dgvContactList.TabIndex = 17;
            dgvContactList.RowHeaderMouseClick += dgvContactList_RowHeaderMouseClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(626, 99);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(595, 23);
            textBoxSearch.TabIndex = 18;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(551, 101);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(57, 21);
            labelSearch.TabIndex = 19;
            labelSearch.Text = "Search";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.None;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(452, 24);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(294, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 533);
            Controls.Add(labelSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dgvContactList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxContactNo);
            Controls.Add(labelContactNo);
            Controls.Add(textBoxContactID);
            Controls.Add(labelContactID);
            Controls.Add(pictureBoxLogo);
            Name = "Econtact";
            Text = "Form1";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelContactID;
        private TextBox textBoxContactID;
        private TextBox textBoxContactNo;
        private Label labelContactNo;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvContactList;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private PictureBox pictureBoxLogo;
    }
}
