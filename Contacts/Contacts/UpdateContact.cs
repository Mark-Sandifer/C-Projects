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
    public partial class UpdateContact : Form
    {
        public UpdateContact()
        {
            InitializeComponent();
            if (DBConn.Connect("localhost", "FirstDatabase") == false)
            {
                MessageBox.Show("Could not establish connection to database");

            }
        }
        private ConnectorClass DBConn = new ConnectorClass();
        private void UpdateContract_Load(object sender, EventArgs e)
        {
            textBox1.Text = MainForm.updateStrValues[0];
            textBox2.Text = MainForm.updateStrValues[1];
            textBox3.Text = MainForm.updateStrValues[2];
            textBox4.Text = MainForm.updateStrValues[3];
            textBox5.Text = MainForm.updateStrValues[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConn.Update("ContactTable", "ContactName", $"'{textBox1.Text}'", "ContactID", $"{MainForm.updateID}");
            DBConn.Update("ContactTable", "Phone", $"'{textBox2.Text}'", "ContactID", $"{MainForm.updateID}");
            DBConn.Update("ContactTable", "Email", $"'{textBox3.Text}'", "ContactID", $"{MainForm.updateID}");
            DBConn.Update("ContactTable", "ContactAddress", $"'{textBox4.Text}'", "ContactID", $"{MainForm.updateID}");
            DBConn.Update("ContactTable", "Notes", $"'{textBox5.Text}'", "ContactID", $"{MainForm.updateID}");
            MessageBox.Show("Contact Updated");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
