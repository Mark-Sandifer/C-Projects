namespace ATM
{
    public partial class StartupForm : Form
    {
        private ConnectorClass DBConn = new ConnectorClass();
        List<object[]> verifyAccount;
        int currentAccount;
        int accountBalance;
        public StartupForm()
        {
            InitializeComponent();
            //Checks to see if database connection can be established
            if (DBConn.Connect("localhost", "ATMDB") == false)
            {
                MessageBox.Show("Could not establish connection to database");
            }
            //Pulls all data from database into list
            verifyAccount = DBConn.Read("Accounts");
        }

        public int calcBalance(int inputNum)
        {
            if (accountBalance < inputNum)
            {
                MessageBox.Show("Current Account does not have sufficient balance to complete transaction");
            }
            else
            {
                accountBalance -= inputNum;
                DBConn.Update("Accounts", "Balance", $"'{accountBalance}'", "AccountNumber", $"'{currentAccount}'");
                BalanceLabelTwo.Text = accountBalance.ToString();
                MessageBox.Show($"Transaction complete, new balance is: {accountBalance}");
                WithdrawPanel.Visible = false;
                ControlPanel.Visible = true;
            }
            return accountBalance;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
        }
        private void BackToStartupButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
        }
        private void RegisterFinalizedButton_Click(object sender, EventArgs e)
        {
            //A random account number and PIN will be generated and given to the account on registration
            Random gen = new Random();
            int accountNumber = gen.Next(100000, 999999);
            int accountPIN = gen.Next(1000, 9999);
            //Current account numbers are retrieved from database and inserted into a list
            List<int> ints = new List<int>();
            foreach (object[] i in verifyAccount)
            {
                ints.Add((int)i[4]);
            }
            //Random generated account number is compared against existing numbers to prevent duplication
            while (true)
            {
                if (!ints.Contains(accountNumber))
                {
                    break;
                }
                accountNumber = gen.Next(100000, 999999);
            }
            DBConn.Create("Accounts", "(FirstName, LastName, DOB, AccountNumber, PIN, Balance)", $"('{textBoxFirstName.Text}', '{textBoxLastName.Text}', '{dateTimePicker1.Text}', {accountNumber}, {accountPIN}, 25000)");
            MessageBox.Show($"Account has been created.\n" +
                $"Your account number is:{accountNumber}\n" +
                $"Your PIN is:{accountPIN}");
            verifyAccount = DBConn.Read("Accounts");
            RegisterPanel.Visible = false;
        }
        private void BackFromRegister_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = false;
        }
        private void LoginFinalizedButton_Click(object sender, EventArgs e)
        {
            if (LoginAN.Text == string.Empty || LoginPIN.Text == string.Empty)
            {
                MessageBox.Show("Please enter your credentials");
                return;
            }
            int loginToken = 0;
            foreach (object[] i in verifyAccount)
            {
                if (Convert.ToInt32(LoginAN.Text) == (int)i[4] && Convert.ToInt32(LoginPIN.Text) == (int)i[5])
                {
                    loginToken++;
                    BalanceLabelTwo.Text = i[6].ToString();
                    accountBalance = (int)i[6];
                    currentAccount = (int)i[4];
                    WelcomeMessageLabel.Text = $"Welcome {i[1]}";
                }
            }
            if (loginToken == 1)
            {
                MessageBox.Show("Sign in successful");
                LoginPanel.Visible = false;
                LoginAN.Text = "";
                LoginPIN.Text = "";
                ControlPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Account does not exist");
            }
        }
        //Below code prevents anything but numerical figures from being used
        private void LoginAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoginPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ExitToStartButton_Click(object sender, EventArgs e)
        {
            ControlPanel.Visible = false;
        }
        private void BackToWelcomeButton_Click(object sender, EventArgs e)
        {
            BalancePanel.Visible = false;
            ControlPanel.Visible = true;
        }
        private void BalanceButton_Click(object sender, EventArgs e)
        {
            ControlPanel.Visible = false;
            BalancePanel.Visible = true;
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            ControlPanel.Visible = false;
            WithdrawPanel.Visible = true;
        }

        private void BackFromWithdrawButton_Click(object sender, EventArgs e)
        {
            WithdrawPanel.Visible = false;
            ControlPanel.Visible = true;
        }

        private void TenWithdrawButton_Click(object sender, EventArgs e)
        {
            calcBalance(10);
        }

        private void TwentyWithdrawButton_Click(object sender, EventArgs e)
        {
            calcBalance(20);
        }

        private void FiftyWithdrawButton_Click(object sender, EventArgs e)
        {
            calcBalance(50);
        }

        private void HundredWithdrawButton_Click(object sender, EventArgs e)
        {
            calcBalance(100);
        }

        private void OtherAmountWithdrawButton_Click(object sender, EventArgs e)
        {
            CustomWithdrawPanel.Visible = true;
            WithdrawPanel.Visible = false;
        }

        private void FinalizedCustomWithdrawButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(CustomInputBox.Text)% 10 != 0)
            {
                MessageBox.Show("Error, amount does not end in 0");
                return;
            }
            calcBalance(Convert.ToInt32(CustomInputBox.Text));
            CustomWithdrawPanel.Visible = false;
        }

        private void BackToWithdrawButton_Click(object sender, EventArgs e)
        {
            CustomWithdrawPanel.Visible = false;
            WithdrawPanel.Visible = true;
        }
        //Below code prevents anything but numerical figures from being used
        private void CustomInputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Below code prevents numerical figures from being used on account creation
        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}