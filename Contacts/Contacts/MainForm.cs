using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        ContactEntry entry;
        private ConnectorClass DBConn = new ConnectorClass();
        List<ContactEntry> results = new List<ContactEntry>();
        public static int updateID;
        public static string[] updateStrValues;
        List<object[]> testDB;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (DBConn.Connect("localhost", "FirstDatabase") == false)
            {
                MessageBox.Show("Could not establish connection to database");
            }
            testDB = DBConn.Read("ContactTable");
            foreach (object[] test in testDB)
            {
                results.Add(new ContactEntry() { ContactID = (int)test[0], ContactName = (string)test[1], ContactPhone = (string)test[2], ContactEmail = (string)test[3], ContactAddress = (string)test[4], ContactNotes = (string)test[5] });
            }
            foreach(ContactEntry result in results)
            {
                listBox1.Items.Add(result.ContactName);
            }
        }
        public void listBoxRefresh()
        {
            listBox1.Items.Clear();
            testDB.Clear();
            testDB = DBConn.Read("ContactTable");
            results.Clear();
            foreach (object[] test in testDB)
            {
                results.Add(new ContactEntry() { ContactID = (int)test[0], ContactName = (string)test[1], ContactPhone = (string)test[2], ContactEmail = (string)test[3], ContactAddress = (string)test[4], ContactNotes = (string)test[5] });
            }
            foreach (ContactEntry result in results)
            {
                listBox1.Items.Add(result.ContactName);
            }
        }
        public void contactDetailsReset()
        {
            label1Val.Text = "-";
            label2Val.Text = "-";
            label3Val.Text = "-";
            label4Val.Text = "-";
            label5Val.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ContactCreation frm = new ContactCreation();
            frm.ShowDialog();
            listBoxRefresh();
        }
        public void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            entry = results[listBox1.SelectedIndex];
            label1Val.Text = entry.ContactName;
            label2Val.Text = entry.ContactPhone;
            label3Val.Text = entry.ContactEmail;
            label4Val.Text = entry.ContactAddress;
            label5Val.Text = entry.ContactNotes;
            updateID = entry.ContactID;
            updateStrValues = new string[] { entry.ContactName, entry.ContactPhone, entry.ContactEmail, entry.ContactAddress, entry.ContactNotes };
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                if (MessageBox.Show("Are you sure you wish to delete this contact?", "Delete Window", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DBConn.Delete("ContactTable", "ContactID", $"{entry.ContactID}");
                    listBoxRefresh();
                    contactDetailsReset();
                }
            }
            else
            {
                MessageBox.Show("Please select a contact first");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                UpdateContact uContact = new UpdateContact();
                uContact.ShowDialog();
                listBoxRefresh();
                contactDetailsReset();
            }
            else
            {
                MessageBox.Show("Please select a contact first");
            }
        }
    } //End of Class
} //End of Namespace