using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ContactFCC
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Members are imported into this list
        /// </summary>
        List<Member> MemberList = new List<Member>(); 
        string success; // string containing list of members the email went to without an issue

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImportContacts();
        }

        /// <summary>
        /// Sends the email to selected representatives. Also populates the seccess string variable with the representatives that the email was sent to successfully.
        /// </summary>
        private void SendEmail(string url,string leadername, string realname, string email, string comments)
        {
            try
            {
                using (var webclient = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["realname"] = realname;
                    data["email"] = email;
                    data["comments"] = comments;
                    var response = webclient.UploadValues(new Uri(url), "POST", data);
                    string responsehtml = Encoding.UTF8.GetString(response, 0, response.Length);
                    if (responsehtml.Contains("Thank"))
                    {
                        //successList.Add(leadername);
                        success += "\n" + leadername;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error sending email on " + url);
            }
        }

        /// <summary>
        /// Imports contacts from ContactInfo.csv. Ensure it is with the .exe source file
        /// </summary>
        /// <returns>returns true if no errors during reading</returns>
        private bool ImportContacts()
        {

            try
            {
                using (StreamReader file = new StreamReader("ContactInfo.csv"))
                {
                    while (!file.EndOfStream)
                    {
                        var line = file.ReadLine();
                        string[] values = line.Split(',');
                        MemberList.Add(new Member(values[0], values[1]));
                    }
                }
                PopulateCheckBoxList();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading ContactInfo.csv, ensure the file is not in use and in the root program directory");
                return false;
            }
            
        }

        /// <summary>
        /// Populates checkboxlist with members that are imported
        /// </summary>
        private void PopulateCheckBoxList()
        {
            foreach (var x in MemberList)
            {
                MemberCheckedListBox.Items.Add(x.MemberName);
            }
            MemberCheckedListBox.CheckOnClick = true;

            for(int i = 0; i < MemberCheckedListBox.Items.Count; i++)
                MemberCheckedListBox.SetItemChecked (i, true);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string name = fullNameTextBox.Text;
            string message = messageTextBox.Text;

            if (email == "" || email == null)
            {
                MessageBox.Show("email must be entered");
                return;
            }
            else if (name == "" || name == null)
            {
                MessageBox.Show("email must be entered");
                return;
            }
            else if (message == "" || message == null)
            {
                MessageBox.Show("email must be entered");
                return;
            }

            foreach (var checkedmembers in MemberCheckedListBox.CheckedItems)
            {
                var mem = MemberList.Find(x => x.MemberName == (string)checkedmembers);
                SendEmail(mem.URL,mem.MemberName, name, email, message);
            }

            MessageBox.Show("Sucessfully sent to the following leaders \n" + success);
        }
    }
}
