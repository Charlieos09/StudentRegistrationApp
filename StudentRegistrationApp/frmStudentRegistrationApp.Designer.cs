namespace StudentRegistrationApp
{
    partial class frmStudentRegistrationApp
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
            registerButton = new Button();
            lnBox = new TextBox();
            titleLabel = new Label();
            lnLabel = new Label();
            fnLabel = new Label();
            fnBox = new TextBox();
            mnBox = new TextBox();
            mnLabel = new Label();
            genderLabel = new Label();
            maleRad = new RadioButton();
            femaleRad = new RadioButton();
            dobLabel = new Label();
            dayCombo = new ComboBox();
            monthCombo = new ComboBox();
            yearCombo = new ComboBox();
            courseLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            imagebox = new PictureBox();
            courseCombo = new ComboBox();
            browseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)imagebox).BeginInit();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Crimson;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 12F);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(28, 474);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(152, 36);
            registerButton.TabIndex = 0;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterButton_Click;
            // 
            // lnBox
            // 
            lnBox.Font = new Font("Segoe UI", 12F);
            lnBox.Location = new Point(13, 89);
            lnBox.Name = "lnBox";
            lnBox.Size = new Size(328, 29);
            lnBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleLabel.Location = new Point(81, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(210, 21);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Student Registration Form";
            titleLabel.Click += label1_Click;
            // 
            // lnLabel
            // 
            lnLabel.AutoSize = true;
            lnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lnLabel.Location = new Point(12, 65);
            lnLabel.Name = "lnLabel";
            lnLabel.Size = new Size(101, 21);
            lnLabel.TabIndex = 5;
            lnLabel.Text = "Last Name *";
            lnLabel.Click += label2_Click;
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fnLabel.Location = new Point(12, 121);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new Size(103, 21);
            fnLabel.TabIndex = 6;
            fnLabel.Text = "First Name *";
            // 
            // fnBox
            // 
            fnBox.Font = new Font("Segoe UI", 12F);
            fnBox.Location = new Point(12, 145);
            fnBox.Name = "fnBox";
            fnBox.Size = new Size(329, 29);
            fnBox.TabIndex = 7;
            // 
            // mnBox
            // 
            mnBox.Font = new Font("Segoe UI", 12F);
            mnBox.Location = new Point(12, 201);
            mnBox.Name = "mnBox";
            mnBox.Size = new Size(329, 29);
            mnBox.TabIndex = 9;
            // 
            // mnLabel
            // 
            mnLabel.AutoSize = true;
            mnLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            mnLabel.Location = new Point(13, 177);
            mnLabel.Name = "mnLabel";
            mnLabel.Size = new Size(125, 21);
            mnLabel.TabIndex = 8;
            mnLabel.Text = "Middle Name *";
            mnLabel.Click += label3_Click;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            genderLabel.Location = new Point(13, 233);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(76, 21);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender *";
            // 
            // maleRad
            // 
            maleRad.AutoSize = true;
            maleRad.Font = new Font("Segoe UI", 12F);
            maleRad.Location = new Point(95, 236);
            maleRad.Name = "maleRad";
            maleRad.Size = new Size(62, 25);
            maleRad.TabIndex = 11;
            maleRad.TabStop = true;
            maleRad.Text = "Male";
            maleRad.UseVisualStyleBackColor = true;
            // 
            // femaleRad
            // 
            femaleRad.AutoSize = true;
            femaleRad.Font = new Font("Segoe UI", 12F);
            femaleRad.Location = new Point(173, 236);
            femaleRad.Name = "femaleRad";
            femaleRad.Size = new Size(78, 25);
            femaleRad.TabIndex = 12;
            femaleRad.TabStop = true;
            femaleRad.Text = "Female";
            femaleRad.UseVisualStyleBackColor = true;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dobLabel.Location = new Point(12, 297);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(118, 21);
            dobLabel.TabIndex = 13;
            dobLabel.Text = "Date of Birth *";
            // 
            // dayCombo
            // 
            dayCombo.Font = new Font("Segoe UI", 12F);
            dayCombo.FormattingEnabled = true;
            dayCombo.Location = new Point(13, 321);
            dayCombo.Name = "dayCombo";
            dayCombo.Size = new Size(59, 29);
            dayCombo.TabIndex = 14;
            dayCombo.Text = "DD";
            // 
            // monthCombo
            // 
            monthCombo.Font = new Font("Segoe UI", 12F);
            monthCombo.FormattingEnabled = true;
            monthCombo.Location = new Point(78, 321);
            monthCombo.Name = "monthCombo";
            monthCombo.Size = new Size(59, 29);
            monthCombo.TabIndex = 15;
            monthCombo.Text = "MM";
            // 
            // yearCombo
            // 
            yearCombo.Font = new Font("Segoe UI", 12F);
            yearCombo.FormattingEnabled = true;
            yearCombo.Location = new Point(143, 321);
            yearCombo.Name = "yearCombo";
            yearCombo.Size = new Size(66, 29);
            yearCombo.TabIndex = 16;
            yearCombo.Text = "YYYY";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            courseLabel.Location = new Point(12, 377);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(156, 21);
            courseLabel.TabIndex = 17;
            courseLabel.Text = "Program to Apply *";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // imagebox
            // 
            imagebox.Location = new Point(479, 87);
            imagebox.Name = "imagebox";
            imagebox.Size = new Size(192, 174);
            imagebox.TabIndex = 18;
            imagebox.TabStop = false;
            // 
            // courseCombo
            // 
            courseCombo.Font = new Font("Segoe UI", 12F);
            courseCombo.FormattingEnabled = true;
            courseCombo.Location = new Point(13, 401);
            courseCombo.Name = "courseCombo";
            courseCombo.Size = new Size(328, 29);
            courseCombo.TabIndex = 19;
            courseCombo.Text = "-Select Program-";
            // 
            // browseButton
            // 
            browseButton.BackColor = SystemColors.AppWorkspace;
            browseButton.Location = new Point(523, 267);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(104, 30);
            browseButton.TabIndex = 21;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = false;
            // 
            // frmStudentRegistrationApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 542);
            Controls.Add(browseButton);
            Controls.Add(courseCombo);
            Controls.Add(imagebox);
            Controls.Add(courseLabel);
            Controls.Add(yearCombo);
            Controls.Add(monthCombo);
            Controls.Add(dayCombo);
            Controls.Add(dobLabel);
            Controls.Add(femaleRad);
            Controls.Add(maleRad);
            Controls.Add(genderLabel);
            Controls.Add(mnBox);
            Controls.Add(mnLabel);
            Controls.Add(fnBox);
            Controls.Add(fnLabel);
            Controls.Add(lnLabel);
            Controls.Add(titleLabel);
            Controls.Add(lnBox);
            Controls.Add(registerButton);
            Name = "frmStudentRegistrationApp";
            Text = "Student Registration";
            Load += frmStudentRegistrationApp_Load;
            ((System.ComponentModel.ISupportInitialize)imagebox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TextBox lnBox;
        private Label titleLabel;
        private Label lnLabel;
        private Label fnLabel;
        private TextBox fnBox;
        private TextBox mnBox;
        private Label mnLabel;
        private Label genderLabel;
        private RadioButton maleRad;
        private RadioButton femaleRad;
        private Label dobLabel;
        private ComboBox dayCombo;
        private ComboBox monthCombo;
        private ComboBox yearCombo;
        private Label courseLabel;
        private OpenFileDialog openFileDialog1;
        private PictureBox imagebox;
        private ComboBox courseCombo;
        private Button browseButton;
    }
}
