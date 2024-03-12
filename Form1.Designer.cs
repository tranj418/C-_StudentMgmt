namespace StudentPortal
{
    partial class AdminForm
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
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.headerLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.newBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.zipcodelabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.zipcodeBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.beginYrLabel = new System.Windows.Forms.Label();
            this.endYrlabel = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.beginYrBox = new System.Windows.Forms.TextBox();
            this.endYrBox = new System.Windows.Forms.TextBox();
            this.majorlistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGrid
            // 
            this.studentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(13, 339);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.Size = new System.Drawing.Size(758, 188);
            this.studentGrid.TabIndex = 0;
            this.studentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellClick);
            this.studentGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(229, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(459, 38);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Student Portal";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(24, 60);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(76, 19);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Student ID";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(24, 96);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 19);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(24, 133);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(75, 19);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(24, 168);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 19);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(107, 60);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(61, 23);
            this.idBox.TabIndex = 6;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameBox.Location = new System.Drawing.Point(107, 97);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(166, 23);
            this.firstNameBox.TabIndex = 7;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameBox.Location = new System.Drawing.Point(107, 134);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(166, 23);
            this.lastNameBox.TabIndex = 8;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(107, 167);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(166, 23);
            this.emailBox.TabIndex = 9;
            // 
            // newBtn
            // 
            this.newBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(21, 279);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(92, 32);
            this.newBtn.TabIndex = 10;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(147, 279);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(92, 32);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(276, 279);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(92, 32);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(405, 279);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(92, 32);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 204);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(100, 23);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "Phone Num";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // streetLabel
            // 
            this.streetLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.Location = new System.Drawing.Point(299, 64);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(69, 15);
            this.streetLabel.TabIndex = 15;
            this.streetLabel.Text = "Street Addr";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // citylabel
            // 
            this.citylabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citylabel.Location = new System.Drawing.Point(310, 97);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(35, 18);
            this.citylabel.TabIndex = 16;
            this.citylabel.Text = "City";
            this.citylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zipcodelabel
            // 
            this.zipcodelabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodelabel.Location = new System.Drawing.Point(310, 131);
            this.zipcodelabel.Name = "zipcodelabel";
            this.zipcodelabel.Size = new System.Drawing.Size(58, 22);
            this.zipcodelabel.TabIndex = 17;
            this.zipcodelabel.Text = "Zipcode";
            this.zipcodelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(107, 207);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 18;
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(397, 64);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(165, 20);
            this.streetBox.TabIndex = 19;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(397, 97);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(165, 20);
            this.cityBox.TabIndex = 20;
            // 
            // zipcodeBox
            // 
            this.zipcodeBox.Location = new System.Drawing.Point(397, 134);
            this.zipcodeBox.Name = "zipcodeBox";
            this.zipcodeBox.Size = new System.Drawing.Size(165, 20);
            this.zipcodeBox.TabIndex = 21;
            // 
            // stateLabel
            // 
            this.stateLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(299, 168);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(65, 23);
            this.stateLabel.TabIndex = 22;
            this.stateLabel.Text = "State";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginYrLabel
            // 
            this.beginYrLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginYrLabel.Location = new System.Drawing.Point(310, 206);
            this.beginYrLabel.Name = "beginYrLabel";
            this.beginYrLabel.Size = new System.Drawing.Size(63, 21);
            this.beginYrLabel.TabIndex = 23;
            this.beginYrLabel.Text = "Begin Yr";
            this.beginYrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endYrlabel
            // 
            this.endYrlabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endYrlabel.Location = new System.Drawing.Point(313, 236);
            this.endYrlabel.Name = "endYrlabel";
            this.endYrlabel.Size = new System.Drawing.Size(60, 25);
            this.endYrlabel.TabIndex = 24;
            this.endYrlabel.Text = "End Yr";
            this.endYrlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(397, 171);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(165, 20);
            this.stateBox.TabIndex = 25;
            // 
            // beginYrBox
            // 
            this.beginYrBox.Location = new System.Drawing.Point(397, 208);
            this.beginYrBox.Name = "beginYrBox";
            this.beginYrBox.Size = new System.Drawing.Size(59, 20);
            this.beginYrBox.TabIndex = 26;
            // 
            // endYrBox
            // 
            this.endYrBox.Location = new System.Drawing.Point(397, 240);
            this.endYrBox.Name = "endYrBox";
            this.endYrBox.Size = new System.Drawing.Size(59, 20);
            this.endYrBox.TabIndex = 27;
            // 
            // majorlistBox
            // 
            this.majorlistBox.FormattingEnabled = true;
            this.majorlistBox.Items.AddRange(new object[] {
            "Computer Science",
            "Information Systems",
            "Business Mgmt",
            "Accounting",
            "Physical Therapy",
            "Psychology",
            "Mechanical Engineering",
            "English",
            "History",
            "Math",
            "Astronomy",
            "Bio Chemistry",
            "Undecided"});
            this.majorlistBox.Location = new System.Drawing.Point(609, 59);
            this.majorlistBox.Name = "majorlistBox";
            this.majorlistBox.Size = new System.Drawing.Size(131, 199);
            this.majorlistBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Birthdate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdatePicker.Location = new System.Drawing.Point(107, 240);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(166, 20);
            this.birthdatePicker.TabIndex = 30;
            this.birthdatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 539);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.majorlistBox);
            this.Controls.Add(this.endYrBox);
            this.Controls.Add(this.beginYrBox);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.endYrlabel);
            this.Controls.Add(this.beginYrLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.zipcodeBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.zipcodelabel);
            this.Controls.Add(this.citylabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.studentGrid);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label citylabel;
        private System.Windows.Forms.Label zipcodelabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox zipcodeBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label beginYrLabel;
        private System.Windows.Forms.Label endYrlabel;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox beginYrBox;
        private System.Windows.Forms.TextBox endYrBox;
        private System.Windows.Forms.ListBox majorlistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
    }
}

