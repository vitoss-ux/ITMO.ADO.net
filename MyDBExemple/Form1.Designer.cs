namespace MyDBExample
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NewUserTextBoxLoginName = new System.Windows.Forms.TextBox();
            this.UpdateUserDataButton = new System.Windows.Forms.Button();
            this.UpdateUserDataButtonGetUserData = new System.Windows.Forms.Button();
            this.UpdateUserDataTextBoxPhone = new System.Windows.Forms.TextBox();
            this.UpdateUserDataTextBoxEmail = new System.Windows.Forms.TextBox();
            this.UpdateUserDataTextBoxLastName = new System.Windows.Forms.TextBox();
            this.UpdateUserDataTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.UpdateUserDataTextBoxPassword = new System.Windows.Forms.TextBox();
            this.UpdateUserDataTextBoxLoginName = new System.Windows.Forms.TextBox();
            this.UpdateUserDataTextBoxID = new System.Windows.Forms.TextBox();
            this.NewUserButtonSignUp = new System.Windows.Forms.Button();
            this.NewUserTextBoxPhone = new System.Windows.Forms.TextBox();
            this.NewUserTextBoxEmail = new System.Windows.Forms.TextBox();
            this.NewUserTextBoxLastName = new System.Windows.Forms.TextBox();
            this.NewUserTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.NewUserTextBoxPassword = new System.Windows.Forms.TextBox();
            this.SelectAllUserDataButton = new System.Windows.Forms.Button();
            this.NewUserGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateUserDataGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteUserTextBoxID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DeleteDataGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.SelectAllUserDataGridView = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewUserGroupBox.SuspendLayout();
            this.UpdateUserDataGroupBox.SuspendLayout();
            this.DeleteDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NewUserTextBoxLoginName
            // 
            this.NewUserTextBoxLoginName.Location = new System.Drawing.Point(144, 40);
            this.NewUserTextBoxLoginName.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserTextBoxLoginName.Name = "NewUserTextBoxLoginName";
            this.NewUserTextBoxLoginName.Size = new System.Drawing.Size(302, 31);
            this.NewUserTextBoxLoginName.TabIndex = 14;
            // 
            // UpdateUserDataButton
            // 
            this.UpdateUserDataButton.Location = new System.Drawing.Point(144, 392);
            this.UpdateUserDataButton.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataButton.Name = "UpdateUserDataButton";
            this.UpdateUserDataButton.Size = new System.Drawing.Size(306, 44);
            this.UpdateUserDataButton.TabIndex = 38;
            this.UpdateUserDataButton.Text = "Update Data";
            this.UpdateUserDataButton.UseVisualStyleBackColor = true;
            this.UpdateUserDataButton.Click += new System.EventHandler(this.Update_User_Data_Button_Click);
            // 
            // UpdateUserDataButtonGetUserData
            // 
            this.UpdateUserDataButtonGetUserData.Location = new System.Drawing.Point(284, 37);
            this.UpdateUserDataButtonGetUserData.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataButtonGetUserData.Name = "UpdateUserDataButtonGetUserData";
            this.UpdateUserDataButtonGetUserData.Size = new System.Drawing.Size(166, 44);
            this.UpdateUserDataButtonGetUserData.TabIndex = 37;
            this.UpdateUserDataButtonGetUserData.Text = "Get User Data";
            this.UpdateUserDataButtonGetUserData.UseVisualStyleBackColor = true;
            this.UpdateUserDataButtonGetUserData.Click += new System.EventHandler(this.Update_User_Data_Button_Get_User_Data_Click);
            // 
            // UpdateUserDataTextBoxPhone
            // 
            this.UpdateUserDataTextBoxPhone.Location = new System.Drawing.Point(144, 340);
            this.UpdateUserDataTextBoxPhone.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataTextBoxPhone.Name = "UpdateUserDataTextBoxPhone";
            this.UpdateUserDataTextBoxPhone.Size = new System.Drawing.Size(302, 31);
            this.UpdateUserDataTextBoxPhone.TabIndex = 36;
            // 
            // UpdateUserDataTextBoxEmail
            // 
            this.UpdateUserDataTextBoxEmail.Location = new System.Drawing.Point(144, 290);
            this.UpdateUserDataTextBoxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataTextBoxEmail.Name = "UpdateUserDataTextBoxEmail";
            this.UpdateUserDataTextBoxEmail.Size = new System.Drawing.Size(302, 31);
            this.UpdateUserDataTextBoxEmail.TabIndex = 35;
            // 
            // UpdateUserDataTextBoxLastName
            // 
            this.UpdateUserDataTextBoxLastName.Location = new System.Drawing.Point(144, 240);
            this.UpdateUserDataTextBoxLastName.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataTextBoxLastName.Name = "UpdateUserDataTextBoxLastName";
            this.UpdateUserDataTextBoxLastName.Size = new System.Drawing.Size(302, 31);
            this.UpdateUserDataTextBoxLastName.TabIndex = 34;
            // 
            // UpdateUserDataTextBoxFirstName
            // 
            this.UpdateUserDataTextBoxFirstName.Location = new System.Drawing.Point(144, 190);
            this.UpdateUserDataTextBoxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataTextBoxFirstName.Name = "UpdateUserDataTextBoxFirstName";
            this.UpdateUserDataTextBoxFirstName.Size = new System.Drawing.Size(302, 31);
            this.UpdateUserDataTextBoxFirstName.TabIndex = 33;
            // 
            // UpdateUserDataTextBoxPassword
            // 
            this.UpdateUserDataTextBoxPassword.Location = new System.Drawing.Point(144, 140);
            this.UpdateUserDataTextBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataTextBoxPassword.Name = "UpdateUserDataTextBoxPassword";
            this.UpdateUserDataTextBoxPassword.Size = new System.Drawing.Size(302, 31);
            this.UpdateUserDataTextBoxPassword.TabIndex = 32;
            // 
            // UpdateUserDataTextBoxLoginName
            // 
            this.UpdateUserDataTextBoxLoginName.Location = new System.Drawing.Point(144, 90);
            this.UpdateUserDataTextBoxLoginName.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataTextBoxLoginName.Name = "UpdateUserDataTextBoxLoginName";
            this.UpdateUserDataTextBoxLoginName.Size = new System.Drawing.Size(302, 31);
            this.UpdateUserDataTextBoxLoginName.TabIndex = 31;
            // 
            // UpdateUserDataTextBoxID
            // 
            this.UpdateUserDataTextBoxID.Location = new System.Drawing.Point(144, 40);
            this.UpdateUserDataTextBoxID.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataTextBoxID.Name = "UpdateUserDataTextBoxID";
            this.UpdateUserDataTextBoxID.Size = new System.Drawing.Size(124, 31);
            this.UpdateUserDataTextBoxID.TabIndex = 30;
            // 
            // NewUserButtonSignUp
            // 
            this.NewUserButtonSignUp.Location = new System.Drawing.Point(144, 342);
            this.NewUserButtonSignUp.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserButtonSignUp.Name = "NewUserButtonSignUp";
            this.NewUserButtonSignUp.Size = new System.Drawing.Size(306, 44);
            this.NewUserButtonSignUp.TabIndex = 20;
            this.NewUserButtonSignUp.Text = "Sign Up";
            this.NewUserButtonSignUp.UseVisualStyleBackColor = true;
            this.NewUserButtonSignUp.Click += new System.EventHandler(this.New_User_Button_Sign_Up_Click);
            // 
            // NewUserTextBoxPhone
            // 
            this.NewUserTextBoxPhone.Location = new System.Drawing.Point(144, 290);
            this.NewUserTextBoxPhone.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserTextBoxPhone.Name = "NewUserTextBoxPhone";
            this.NewUserTextBoxPhone.Size = new System.Drawing.Size(302, 31);
            this.NewUserTextBoxPhone.TabIndex = 19;
            // 
            // NewUserTextBoxEmail
            // 
            this.NewUserTextBoxEmail.Location = new System.Drawing.Point(144, 240);
            this.NewUserTextBoxEmail.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserTextBoxEmail.Name = "NewUserTextBoxEmail";
            this.NewUserTextBoxEmail.Size = new System.Drawing.Size(302, 31);
            this.NewUserTextBoxEmail.TabIndex = 18;
            // 
            // NewUserTextBoxLastName
            // 
            this.NewUserTextBoxLastName.Location = new System.Drawing.Point(144, 190);
            this.NewUserTextBoxLastName.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserTextBoxLastName.Name = "NewUserTextBoxLastName";
            this.NewUserTextBoxLastName.Size = new System.Drawing.Size(302, 31);
            this.NewUserTextBoxLastName.TabIndex = 17;
            // 
            // NewUserTextBoxFirstName
            // 
            this.NewUserTextBoxFirstName.Location = new System.Drawing.Point(144, 140);
            this.NewUserTextBoxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserTextBoxFirstName.Name = "NewUserTextBoxFirstName";
            this.NewUserTextBoxFirstName.Size = new System.Drawing.Size(302, 31);
            this.NewUserTextBoxFirstName.TabIndex = 16;
            // 
            // NewUserTextBoxPassword
            // 
            this.NewUserTextBoxPassword.Location = new System.Drawing.Point(144, 90);
            this.NewUserTextBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserTextBoxPassword.Name = "NewUserTextBoxPassword";
            this.NewUserTextBoxPassword.PasswordChar = '*';
            this.NewUserTextBoxPassword.Size = new System.Drawing.Size(302, 31);
            this.NewUserTextBoxPassword.TabIndex = 15;
            // 
            // SelectAllUserDataButton
            // 
            this.SelectAllUserDataButton.BackColor = System.Drawing.Color.Azure;
            this.SelectAllUserDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAllUserDataButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.SelectAllUserDataButton.Location = new System.Drawing.Point(1452, 927);
            this.SelectAllUserDataButton.Margin = new System.Windows.Forms.Padding(6);
            this.SelectAllUserDataButton.Name = "SelectAllUserDataButton";
            this.SelectAllUserDataButton.Size = new System.Drawing.Size(306, 58);
            this.SelectAllUserDataButton.TabIndex = 43;
            this.SelectAllUserDataButton.Text = "Get All User Data";
            this.SelectAllUserDataButton.UseVisualStyleBackColor = false;
            this.SelectAllUserDataButton.Click += new System.EventHandler(this.SelectAllUserDataButton_Click);
            // 
            // NewUserGroupBox
            // 
            this.NewUserGroupBox.Controls.Add(this.NewUserButtonSignUp);
            this.NewUserGroupBox.Controls.Add(this.NewUserTextBoxPhone);
            this.NewUserGroupBox.Controls.Add(this.NewUserTextBoxEmail);
            this.NewUserGroupBox.Controls.Add(this.NewUserTextBoxLastName);
            this.NewUserGroupBox.Controls.Add(this.NewUserTextBoxFirstName);
            this.NewUserGroupBox.Controls.Add(this.NewUserTextBoxPassword);
            this.NewUserGroupBox.Controls.Add(this.NewUserTextBoxLoginName);
            this.NewUserGroupBox.Controls.Add(this.label6);
            this.NewUserGroupBox.Controls.Add(this.label1);
            this.NewUserGroupBox.Controls.Add(this.label2);
            this.NewUserGroupBox.Controls.Add(this.label5);
            this.NewUserGroupBox.Controls.Add(this.label3);
            this.NewUserGroupBox.Controls.Add(this.label4);
            this.NewUserGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewUserGroupBox.Location = new System.Drawing.Point(12, 6);
            this.NewUserGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.NewUserGroupBox.Name = "NewUserGroupBox";
            this.NewUserGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.NewUserGroupBox.Size = new System.Drawing.Size(462, 400);
            this.NewUserGroupBox.TabIndex = 42;
            this.NewUserGroupBox.TabStop = false;
            this.NewUserGroupBox.Text = "New User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Login Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone";
            // 
            // UpdateUserDataGroupBox
            // 
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataButton);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataButtonGetUserData);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataTextBoxPhone);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataTextBoxEmail);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataTextBoxLastName);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataTextBoxFirstName);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataTextBoxPassword);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataTextBoxLoginName);
            this.UpdateUserDataGroupBox.Controls.Add(this.UpdateUserDataTextBoxID);
            this.UpdateUserDataGroupBox.Controls.Add(this.label13);
            this.UpdateUserDataGroupBox.Controls.Add(this.label12);
            this.UpdateUserDataGroupBox.Controls.Add(this.label11);
            this.UpdateUserDataGroupBox.Controls.Add(this.label7);
            this.UpdateUserDataGroupBox.Controls.Add(this.label10);
            this.UpdateUserDataGroupBox.Controls.Add(this.label9);
            this.UpdateUserDataGroupBox.Controls.Add(this.label8);
            this.UpdateUserDataGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateUserDataGroupBox.Location = new System.Drawing.Point(12, 542);
            this.UpdateUserDataGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataGroupBox.Name = "UpdateUserDataGroupBox";
            this.UpdateUserDataGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.UpdateUserDataGroupBox.Size = new System.Drawing.Size(462, 442);
            this.UpdateUserDataGroupBox.TabIndex = 41;
            this.UpdateUserDataGroupBox.TabStop = false;
            this.UpdateUserDataGroupBox.Text = "Update User Data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "User ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 246);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Login Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 296);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password";
            // 
            // DeleteUserTextBoxID
            // 
            this.DeleteUserTextBoxID.Location = new System.Drawing.Point(144, 37);
            this.DeleteUserTextBoxID.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteUserTextBoxID.Name = "DeleteUserTextBoxID";
            this.DeleteUserTextBoxID.Size = new System.Drawing.Size(124, 31);
            this.DeleteUserTextBoxID.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "User ID";
            // 
            // DeleteDataGroupBox
            // 
            this.DeleteDataGroupBox.Controls.Add(this.DeleteUserButton);
            this.DeleteDataGroupBox.Controls.Add(this.DeleteUserTextBoxID);
            this.DeleteDataGroupBox.Controls.Add(this.label14);
            this.DeleteDataGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeleteDataGroupBox.Location = new System.Drawing.Point(12, 419);
            this.DeleteDataGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteDataGroupBox.Name = "DeleteDataGroupBox";
            this.DeleteDataGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.DeleteDataGroupBox.Size = new System.Drawing.Size(462, 110);
            this.DeleteDataGroupBox.TabIndex = 40;
            this.DeleteDataGroupBox.TabStop = false;
            this.DeleteDataGroupBox.Text = "Delete User";
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(284, 35);
            this.DeleteUserButton.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(166, 44);
            this.DeleteUserButton.TabIndex = 35;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.Delete_User_Button_Click);
            // 
            // SelectAllUserDataGridView
            // 
            this.SelectAllUserDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SelectAllUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectAllUserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.First_Name,
            this.Last_Name,
            this.Login_Name,
            this.Password,
            this.E_mail,
            this.Phone});
            this.SelectAllUserDataGridView.Location = new System.Drawing.Point(482, 15);
            this.SelectAllUserDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.SelectAllUserDataGridView.Name = "SelectAllUserDataGridView";
            this.SelectAllUserDataGridView.RowHeadersWidth = 82;
            this.SelectAllUserDataGridView.Size = new System.Drawing.Size(1274, 908);
            this.SelectAllUserDataGridView.TabIndex = 50;
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "User ID";
            this.User_ID.MinimumWidth = 10;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            this.User_ID.Width = 49;
            // 
            // First_Name
            // 
            this.First_Name.HeaderText = "First Name";
            this.First_Name.MinimumWidth = 10;
            this.First_Name.Name = "First_Name";
            this.First_Name.ReadOnly = true;
            this.First_Name.Width = 82;
            // 
            // Last_Name
            // 
            this.Last_Name.HeaderText = "Last Name";
            this.Last_Name.MinimumWidth = 10;
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.ReadOnly = true;
            this.Last_Name.Width = 83;
            // 
            // Login_Name
            // 
            this.Login_Name.HeaderText = "Login Name";
            this.Login_Name.MinimumWidth = 10;
            this.Login_Name.Name = "Login_Name";
            this.Login_Name.ReadOnly = true;
            this.Login_Name.Width = 89;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 10;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 70;
            // 
            // E_mail
            // 
            this.E_mail.HeaderText = "E-mail";
            this.E_mail.MinimumWidth = 10;
            this.E_mail.Name = "E_mail";
            this.E_mail.ReadOnly = true;
            this.E_mail.Width = 120;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 10;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1764, 989);
            this.Controls.Add(this.SelectAllUserDataGridView);
            this.Controls.Add(this.SelectAllUserDataButton);
            this.Controls.Add(this.NewUserGroupBox);
            this.Controls.Add(this.UpdateUserDataGroupBox);
            this.Controls.Add(this.DeleteDataGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1790, 1060);
            this.MinimumSize = new System.Drawing.Size(1790, 1060);
            this.Name = "Form1";
            this.Text = "User Manager";
            this.NewUserGroupBox.ResumeLayout(false);
            this.NewUserGroupBox.PerformLayout();
            this.UpdateUserDataGroupBox.ResumeLayout(false);
            this.UpdateUserDataGroupBox.PerformLayout();
            this.DeleteDataGroupBox.ResumeLayout(false);
            this.DeleteDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectAllUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NewUserTextBoxLoginName;
        private System.Windows.Forms.Button UpdateUserDataButton;
        private System.Windows.Forms.Button UpdateUserDataButtonGetUserData;
        private System.Windows.Forms.TextBox UpdateUserDataTextBoxPhone;
        private System.Windows.Forms.TextBox UpdateUserDataTextBoxEmail;
        private System.Windows.Forms.TextBox UpdateUserDataTextBoxLastName;
        private System.Windows.Forms.TextBox UpdateUserDataTextBoxFirstName;
        private System.Windows.Forms.TextBox UpdateUserDataTextBoxPassword;
        private System.Windows.Forms.TextBox UpdateUserDataTextBoxLoginName;
        private System.Windows.Forms.TextBox UpdateUserDataTextBoxID;
        private System.Windows.Forms.Button NewUserButtonSignUp;
        private System.Windows.Forms.TextBox NewUserTextBoxPhone;
        private System.Windows.Forms.TextBox NewUserTextBoxEmail;
        private System.Windows.Forms.TextBox NewUserTextBoxLastName;
        private System.Windows.Forms.TextBox NewUserTextBoxFirstName;
        private System.Windows.Forms.TextBox NewUserTextBoxPassword;
        private System.Windows.Forms.Button SelectAllUserDataButton;
        private System.Windows.Forms.GroupBox NewUserGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox UpdateUserDataGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DeleteUserTextBoxID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox DeleteDataGroupBox;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.DataGridView SelectAllUserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}

