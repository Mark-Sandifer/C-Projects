namespace ATM
{
    partial class StartupForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.BackToStartupButton = new System.Windows.Forms.Button();
            this.LoginFinalizedButton = new System.Windows.Forms.Button();
            this.LoginPIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.BackFromRegister = new System.Windows.Forms.Button();
            this.RegisterFinalizedButton = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.WelcomeMessageLabel = new System.Windows.Forms.Label();
            this.ExitToStartButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.BalanceButton = new System.Windows.Forms.Button();
            this.BalancePanel = new System.Windows.Forms.Panel();
            this.BalanceLabelTwo = new System.Windows.Forms.Label();
            this.BalanceLabelOne = new System.Windows.Forms.Label();
            this.BackToWelcomeButton = new System.Windows.Forms.Button();
            this.WithdrawPanel = new System.Windows.Forms.Panel();
            this.BackFromWithdrawButton = new System.Windows.Forms.Button();
            this.OtherAmountWithdrawButton = new System.Windows.Forms.Button();
            this.HundredWithdrawButton = new System.Windows.Forms.Button();
            this.FiftyWithdrawButton = new System.Windows.Forms.Button();
            this.TwentyWithdrawButton = new System.Windows.Forms.Button();
            this.TenWithdrawButton = new System.Windows.Forms.Button();
            this.CustomWithdrawPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomInputBox = new System.Windows.Forms.TextBox();
            this.BackToWithdrawButton = new System.Windows.Forms.Button();
            this.FinalizedCustomWithdrawButton = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.BalancePanel.SuspendLayout();
            this.WithdrawPanel.SuspendLayout();
            this.CustomWithdrawPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(118, 63);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(254, 12);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(118, 63);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.BackToStartupButton);
            this.LoginPanel.Controls.Add(this.LoginFinalizedButton);
            this.LoginPanel.Controls.Add(this.LoginPIN);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.LoginAN);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Location = new System.Drawing.Point(12, 12);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(360, 187);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Visible = false;
            // 
            // BackToStartupButton
            // 
            this.BackToStartupButton.Location = new System.Drawing.Point(257, 139);
            this.BackToStartupButton.Name = "BackToStartupButton";
            this.BackToStartupButton.Size = new System.Drawing.Size(100, 45);
            this.BackToStartupButton.TabIndex = 11;
            this.BackToStartupButton.Text = "Back";
            this.BackToStartupButton.UseVisualStyleBackColor = true;
            this.BackToStartupButton.Click += new System.EventHandler(this.BackToStartupButton_Click);
            // 
            // LoginFinalizedButton
            // 
            this.LoginFinalizedButton.Location = new System.Drawing.Point(3, 139);
            this.LoginFinalizedButton.Name = "LoginFinalizedButton";
            this.LoginFinalizedButton.Size = new System.Drawing.Size(100, 45);
            this.LoginFinalizedButton.TabIndex = 10;
            this.LoginFinalizedButton.Text = "Login";
            this.LoginFinalizedButton.UseVisualStyleBackColor = true;
            this.LoginFinalizedButton.Click += new System.EventHandler(this.LoginFinalizedButton_Click);
            // 
            // LoginPIN
            // 
            this.LoginPIN.Location = new System.Drawing.Point(51, 56);
            this.LoginPIN.MaxLength = 4;
            this.LoginPIN.Name = "LoginPIN";
            this.LoginPIN.ShortcutsEnabled = false;
            this.LoginPIN.Size = new System.Drawing.Size(100, 23);
            this.LoginPIN.TabIndex = 9;
            this.LoginPIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginPIN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "PIN:";
            // 
            // LoginAN
            // 
            this.LoginAN.Location = new System.Drawing.Point(124, 24);
            this.LoginAN.MaxLength = 6;
            this.LoginAN.Name = "LoginAN";
            this.LoginAN.ShortcutsEnabled = false;
            this.LoginAN.Size = new System.Drawing.Size(100, 23);
            this.LoginAN.TabIndex = 7;
            this.LoginAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginAN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Number:";
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.BackFromRegister);
            this.RegisterPanel.Controls.Add(this.RegisterFinalizedButton);
            this.RegisterPanel.Controls.Add(this.textBoxLastName);
            this.RegisterPanel.Controls.Add(this.textBoxFirstName);
            this.RegisterPanel.Controls.Add(this.dateTimePicker1);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Location = new System.Drawing.Point(12, 12);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(360, 187);
            this.RegisterPanel.TabIndex = 2;
            this.RegisterPanel.Visible = false;
            // 
            // BackFromRegister
            // 
            this.BackFromRegister.Location = new System.Drawing.Point(257, 139);
            this.BackFromRegister.Name = "BackFromRegister";
            this.BackFromRegister.Size = new System.Drawing.Size(100, 45);
            this.BackFromRegister.TabIndex = 15;
            this.BackFromRegister.Text = "Back";
            this.BackFromRegister.UseVisualStyleBackColor = true;
            this.BackFromRegister.Click += new System.EventHandler(this.BackFromRegister_Click);
            // 
            // RegisterFinalizedButton
            // 
            this.RegisterFinalizedButton.Location = new System.Drawing.Point(3, 139);
            this.RegisterFinalizedButton.Name = "RegisterFinalizedButton";
            this.RegisterFinalizedButton.Size = new System.Drawing.Size(100, 45);
            this.RegisterFinalizedButton.TabIndex = 14;
            this.RegisterFinalizedButton.Text = "Register";
            this.RegisterFinalizedButton.UseVisualStyleBackColor = true;
            this.RegisterFinalizedButton.Click += new System.EventHandler(this.RegisterFinalizedButton_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(79, 53);
            this.textBoxLastName.MaxLength = 50;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ShortcutsEnabled = false;
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 13;
            this.textBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastName_KeyPress);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(80, 18);
            this.textBoxFirstName.MaxLength = 50;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ShortcutsEnabled = false;
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 12;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFirstName_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 95);
            this.dateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 23);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "LastName:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "FirstName:";
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.WelcomeMessageLabel);
            this.ControlPanel.Controls.Add(this.ExitToStartButton);
            this.ControlPanel.Controls.Add(this.WithdrawButton);
            this.ControlPanel.Controls.Add(this.BalanceButton);
            this.ControlPanel.Location = new System.Drawing.Point(12, 12);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(360, 187);
            this.ControlPanel.TabIndex = 3;
            this.ControlPanel.Visible = false;
            // 
            // WelcomeMessageLabel
            // 
            this.WelcomeMessageLabel.AutoSize = true;
            this.WelcomeMessageLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeMessageLabel.Location = new System.Drawing.Point(140, 25);
            this.WelcomeMessageLabel.Name = "WelcomeMessageLabel";
            this.WelcomeMessageLabel.Size = new System.Drawing.Size(71, 20);
            this.WelcomeMessageLabel.TabIndex = 3;
            this.WelcomeMessageLabel.Text = "Welcome";
            // 
            // ExitToStartButton
            // 
            this.ExitToStartButton.Location = new System.Drawing.Point(257, 139);
            this.ExitToStartButton.Name = "ExitToStartButton";
            this.ExitToStartButton.Size = new System.Drawing.Size(100, 45);
            this.ExitToStartButton.TabIndex = 2;
            this.ExitToStartButton.Text = "Exit";
            this.ExitToStartButton.UseVisualStyleBackColor = true;
            this.ExitToStartButton.Click += new System.EventHandler(this.ExitToStartButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(3, 88);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.WithdrawButton.TabIndex = 1;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // BalanceButton
            // 
            this.BalanceButton.Location = new System.Drawing.Point(3, 139);
            this.BalanceButton.Name = "BalanceButton";
            this.BalanceButton.Size = new System.Drawing.Size(100, 45);
            this.BalanceButton.TabIndex = 0;
            this.BalanceButton.Text = "Balance";
            this.BalanceButton.UseVisualStyleBackColor = true;
            this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // BalancePanel
            // 
            this.BalancePanel.Controls.Add(this.BalanceLabelTwo);
            this.BalancePanel.Controls.Add(this.BalanceLabelOne);
            this.BalancePanel.Controls.Add(this.BackToWelcomeButton);
            this.BalancePanel.Location = new System.Drawing.Point(12, 12);
            this.BalancePanel.Name = "BalancePanel";
            this.BalancePanel.Size = new System.Drawing.Size(360, 187);
            this.BalancePanel.TabIndex = 4;
            this.BalancePanel.Visible = false;
            // 
            // BalanceLabelTwo
            // 
            this.BalanceLabelTwo.AutoSize = true;
            this.BalanceLabelTwo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceLabelTwo.Location = new System.Drawing.Point(126, 60);
            this.BalanceLabelTwo.Name = "BalanceLabelTwo";
            this.BalanceLabelTwo.Size = new System.Drawing.Size(52, 21);
            this.BalanceLabelTwo.TabIndex = 2;
            this.BalanceLabelTwo.Text = "label6";
            // 
            // BalanceLabelOne
            // 
            this.BalanceLabelOne.AutoSize = true;
            this.BalanceLabelOne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceLabelOne.Location = new System.Drawing.Point(3, 60);
            this.BalanceLabelOne.Name = "BalanceLabelOne";
            this.BalanceLabelOne.Size = new System.Drawing.Size(117, 21);
            this.BalanceLabelOne.TabIndex = 1;
            this.BalanceLabelOne.Text = "Your balance is:";
            // 
            // BackToWelcomeButton
            // 
            this.BackToWelcomeButton.Location = new System.Drawing.Point(257, 139);
            this.BackToWelcomeButton.Name = "BackToWelcomeButton";
            this.BackToWelcomeButton.Size = new System.Drawing.Size(100, 45);
            this.BackToWelcomeButton.TabIndex = 0;
            this.BackToWelcomeButton.Text = "Back";
            this.BackToWelcomeButton.UseVisualStyleBackColor = true;
            this.BackToWelcomeButton.Click += new System.EventHandler(this.BackToWelcomeButton_Click);
            // 
            // WithdrawPanel
            // 
            this.WithdrawPanel.Controls.Add(this.BackFromWithdrawButton);
            this.WithdrawPanel.Controls.Add(this.OtherAmountWithdrawButton);
            this.WithdrawPanel.Controls.Add(this.HundredWithdrawButton);
            this.WithdrawPanel.Controls.Add(this.FiftyWithdrawButton);
            this.WithdrawPanel.Controls.Add(this.TwentyWithdrawButton);
            this.WithdrawPanel.Controls.Add(this.TenWithdrawButton);
            this.WithdrawPanel.Location = new System.Drawing.Point(12, 12);
            this.WithdrawPanel.Name = "WithdrawPanel";
            this.WithdrawPanel.Size = new System.Drawing.Size(360, 187);
            this.WithdrawPanel.TabIndex = 4;
            this.WithdrawPanel.Visible = false;
            // 
            // BackFromWithdrawButton
            // 
            this.BackFromWithdrawButton.Location = new System.Drawing.Point(257, 139);
            this.BackFromWithdrawButton.Name = "BackFromWithdrawButton";
            this.BackFromWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.BackFromWithdrawButton.TabIndex = 5;
            this.BackFromWithdrawButton.Text = "Back";
            this.BackFromWithdrawButton.UseVisualStyleBackColor = true;
            this.BackFromWithdrawButton.Click += new System.EventHandler(this.BackFromWithdrawButton_Click);
            // 
            // OtherAmountWithdrawButton
            // 
            this.OtherAmountWithdrawButton.Location = new System.Drawing.Point(257, 73);
            this.OtherAmountWithdrawButton.Name = "OtherAmountWithdrawButton";
            this.OtherAmountWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.OtherAmountWithdrawButton.TabIndex = 4;
            this.OtherAmountWithdrawButton.Text = "Other";
            this.OtherAmountWithdrawButton.UseVisualStyleBackColor = true;
            this.OtherAmountWithdrawButton.Click += new System.EventHandler(this.OtherAmountWithdrawButton_Click);
            // 
            // HundredWithdrawButton
            // 
            this.HundredWithdrawButton.Location = new System.Drawing.Point(257, 3);
            this.HundredWithdrawButton.Name = "HundredWithdrawButton";
            this.HundredWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.HundredWithdrawButton.TabIndex = 3;
            this.HundredWithdrawButton.Text = "$100";
            this.HundredWithdrawButton.UseVisualStyleBackColor = true;
            this.HundredWithdrawButton.Click += new System.EventHandler(this.HundredWithdrawButton_Click);
            // 
            // FiftyWithdrawButton
            // 
            this.FiftyWithdrawButton.Location = new System.Drawing.Point(3, 139);
            this.FiftyWithdrawButton.Name = "FiftyWithdrawButton";
            this.FiftyWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.FiftyWithdrawButton.TabIndex = 2;
            this.FiftyWithdrawButton.Text = "$50";
            this.FiftyWithdrawButton.UseVisualStyleBackColor = true;
            this.FiftyWithdrawButton.Click += new System.EventHandler(this.FiftyWithdrawButton_Click);
            // 
            // TwentyWithdrawButton
            // 
            this.TwentyWithdrawButton.Location = new System.Drawing.Point(3, 73);
            this.TwentyWithdrawButton.Name = "TwentyWithdrawButton";
            this.TwentyWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.TwentyWithdrawButton.TabIndex = 1;
            this.TwentyWithdrawButton.Text = "$20";
            this.TwentyWithdrawButton.UseVisualStyleBackColor = true;
            this.TwentyWithdrawButton.Click += new System.EventHandler(this.TwentyWithdrawButton_Click);
            // 
            // TenWithdrawButton
            // 
            this.TenWithdrawButton.Location = new System.Drawing.Point(3, 3);
            this.TenWithdrawButton.Name = "TenWithdrawButton";
            this.TenWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.TenWithdrawButton.TabIndex = 0;
            this.TenWithdrawButton.Text = "$10";
            this.TenWithdrawButton.UseVisualStyleBackColor = true;
            this.TenWithdrawButton.Click += new System.EventHandler(this.TenWithdrawButton_Click);
            // 
            // CustomWithdrawPanel
            // 
            this.CustomWithdrawPanel.Controls.Add(this.label7);
            this.CustomWithdrawPanel.Controls.Add(this.label6);
            this.CustomWithdrawPanel.Controls.Add(this.CustomInputBox);
            this.CustomWithdrawPanel.Controls.Add(this.BackToWithdrawButton);
            this.CustomWithdrawPanel.Controls.Add(this.FinalizedCustomWithdrawButton);
            this.CustomWithdrawPanel.Location = new System.Drawing.Point(12, 12);
            this.CustomWithdrawPanel.Name = "CustomWithdrawPanel";
            this.CustomWithdrawPanel.Size = new System.Drawing.Size(360, 187);
            this.CustomWithdrawPanel.TabIndex = 5;
            this.CustomWithdrawPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(4, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amount inputted must end in 0.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(4, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Please enter an amount to withdraw";
            // 
            // CustomInputBox
            // 
            this.CustomInputBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomInputBox.Location = new System.Drawing.Point(4, 71);
            this.CustomInputBox.Name = "CustomInputBox";
            this.CustomInputBox.Size = new System.Drawing.Size(218, 43);
            this.CustomInputBox.TabIndex = 2;
            this.CustomInputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomInputBox_KeyPress);
            // 
            // BackToWithdrawButton
            // 
            this.BackToWithdrawButton.Location = new System.Drawing.Point(257, 139);
            this.BackToWithdrawButton.Name = "BackToWithdrawButton";
            this.BackToWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.BackToWithdrawButton.TabIndex = 1;
            this.BackToWithdrawButton.Text = "Back";
            this.BackToWithdrawButton.UseVisualStyleBackColor = true;
            this.BackToWithdrawButton.Click += new System.EventHandler(this.BackToWithdrawButton_Click);
            // 
            // FinalizedCustomWithdrawButton
            // 
            this.FinalizedCustomWithdrawButton.Location = new System.Drawing.Point(257, 3);
            this.FinalizedCustomWithdrawButton.Name = "FinalizedCustomWithdrawButton";
            this.FinalizedCustomWithdrawButton.Size = new System.Drawing.Size(100, 45);
            this.FinalizedCustomWithdrawButton.TabIndex = 0;
            this.FinalizedCustomWithdrawButton.Text = "Confirm";
            this.FinalizedCustomWithdrawButton.UseVisualStyleBackColor = true;
            this.FinalizedCustomWithdrawButton.Click += new System.EventHandler(this.FinalizedCustomWithdrawButton_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.CustomWithdrawPanel);
            this.Controls.Add(this.BalancePanel);
            this.Controls.Add(this.WithdrawPanel);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.Text = "StartupForm";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.BalancePanel.ResumeLayout(false);
            this.BalancePanel.PerformLayout();
            this.WithdrawPanel.ResumeLayout(false);
            this.CustomWithdrawPanel.ResumeLayout(false);
            this.CustomWithdrawPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Button LoginButton;
        private Button RegisterButton;
        private Panel LoginPanel;
        private Button BackToStartupButton;
        private Button LoginFinalizedButton;
        private TextBox LoginPIN;
        private Label label2;
        private TextBox LoginAN;
        private Label label1;
        private Panel RegisterPanel;
        private Button BackFromRegister;
        private Button RegisterFinalizedButton;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel ControlPanel;
        private Label WelcomeMessageLabel;
        private Button ExitToStartButton;
        private Button WithdrawButton;
        private Button BalanceButton;
        private Panel BalancePanel;
        private Label BalanceLabelTwo;
        private Label BalanceLabelOne;
        private Button BackToWelcomeButton;
        private Panel WithdrawPanel;
        private Button BackFromWithdrawButton;
        private Button OtherAmountWithdrawButton;
        private Button HundredWithdrawButton;
        private Button FiftyWithdrawButton;
        private Button TwentyWithdrawButton;
        private Button TenWithdrawButton;
        private Panel CustomWithdrawPanel;
        private Label label7;
        private Label label6;
        private TextBox CustomInputBox;
        private Button BackToWithdrawButton;
        private Button FinalizedCustomWithdrawButton;
    }
}