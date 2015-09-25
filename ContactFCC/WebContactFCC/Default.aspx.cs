using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebContactFCC
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImportContacts();
        }

        List<Member> MemberList = new List<Member>(); 
        string success; // string containing list of members the email went to without an issue


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
                        success += "\n" + leadername;
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error sending email on " + url);
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

                using (StreamReader file = new StreamReader(Server.MapPath(@"ContactInfo.csv")))
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
                //MessageBox.Show("Error reading ContactInfo.csv, ensure the file is not in use and in the root program directory");
                return false;
            }
            
        }

        /// <summary>
        /// Populates checkboxlist with members that are imported
        /// </summary>
        private void PopulateCheckBoxList()
        {
            if (MemberCheckedListBox.Items.Count < 1)
            {
                foreach (var x in MemberList)
                {
                    MemberCheckedListBox.Items.Add(x.MemberName);
                }
            }

            //for(int i = 0; i < MemberCheckedListBox.Items.Count; i++)
               //MemberCheckedListBox.SetItemChecked (i, true);
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
          
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string name = fullNameTextBox.Text;
            string message = messageTextBox.Text;

            if (email == "" || email == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('email must be entered');", true);
                //MessageBox.Show("email must be entered");
                return;
            }
            else if (name == "" || name == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('name must be entered');", true);
                //MessageBox.Show("email must be entered");
                return;
            }
            else if (message == "" || message == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('message must be entered');", true);
                //MessageBox.Show("email must be entered");
                return;
            }

            // Iterate through the Items collection of the CheckBoxList 
            // control and display the selected items.
            for (int i = 0; i < MemberCheckedListBox.Items.Count; i++)
            {
                if (MemberCheckedListBox.Items[i].Selected)
                {
                    var mem = MemberList.Find(x => x.MemberName == MemberCheckedListBox.Items[i].Text);
                    SendEmail(mem.URL, mem.MemberName, name, email, message);
                }
            }

            SentMessageLabel.Text = "Send to the following people: " + success +" Sent at time:"+ DateTime.Now.ToString();
            SentMessageLabel.Visible = true;
           // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Sent sucessfully to the following leaders \n" + success + "');", true);

            //MessageBox.Show("Sucessfully sent to the following leaders \n" + success);
        }

        protected void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Member
    {
        public string MemberName { get; set; }
        public string URL { get; set; }

        public Member(string name, string URL)
        {
            MemberName = name;
            this.URL = URL;
        }

    }
}