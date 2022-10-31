using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ContactCreation : Form
    {
        public ContactCreation()
        {
            InitializeComponent();
            if (DBConn.Connect("localhost", "FirstDatabase") == false)
            {
                MessageBox.Show("Could not establish connection to database");

            }
        }
        private ConnectorClass DBConn = new ConnectorClass();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxName.Text = textBoxName.Text.Replace("'", "''");
            textBoxNumber.Text = textBoxNumber.Text.Replace("'", "''");
            textBoxEmail.Text = textBoxEmail.Text.Replace("'", "''");
            textBoxAddress.Text = textBoxAddress.Text.Replace("'", "''");
            textBoxNotes.Text = textBoxNotes.Text.Replace("'", "''");
            DBConn.Create("ContactTable", "(ContactName, Phone, Email, ContactAddress, Notes)", $"('{textBoxName.Text}', '{textBoxNumber.Text}', '{textBoxEmail.Text}', '{textBoxAddress.Text}', '{textBoxNotes.Text}')");
            this.Close();
        }
    }
}
