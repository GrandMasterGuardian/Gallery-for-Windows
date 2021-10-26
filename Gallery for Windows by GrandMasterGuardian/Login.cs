using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Gallery_for_Windows_by_GrandMasterGuardian
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        List<Person> persons = new List<Person>();
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

        }

        private void LoginName_Enter(object sender, EventArgs e)
        {
            if (LoginName.Text == "Name")
            {
                LoginName.Text = "";
            }
            LoginNameWarn.Visible = false;
        }

        private void LoginName_Leave(object sender, EventArgs e)
        {
            if (LoginName.Text == "")
            {
                LoginName.Text = "Name";
            }
        }

        private void LoginPassword_Enter(object sender, EventArgs e)
        {
            if(LoginPassword.Text == "Password")
            {
                LoginPassword.Text = "";
            }
            LoginPasswordWarn.Visible = false;
        }

        private void LoginPassword_Leave(object sender, EventArgs e)
        {
            {
                if (LoginPassword.Text == "")
                {
                    LoginPassword.Text = "Password";
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            RegPanel.Visible = true;
        }

        private void RegName_Leave(object sender, EventArgs e)
        {
            if (RegName.Text == "")
            {
                RegName.Text = "Name";
            }
        }

        private void RegName_Enter(object sender, EventArgs e)
        {
            if (RegNameWarn.Visible == true)
            {
                RegNameWarn.Visible = false;
            }
            if (RegName.Text == "Name")
            {
                RegName.Text = "";
            }
        }

        private void RegPassword_Enter(object sender, EventArgs e)
        {
            if (RegPasswordWarn.Visible == true)
            {
                RegPasswordWarn.Visible = false;
            }
            if (RegPassword.Text == "Password")
            {
                RegPassword.Text = "";
            }
        }

        private void RegPassword_Leave(object sender, EventArgs e)
        {
            if (RegPassword.Text == "")
            {
                RegPassword.Text = "Password";
            }
        }

        private void RegConfPassword_Enter(object sender, EventArgs e)
        {
            if (RegConfPassword.Text == "Confirm password")
            {
                RegConfPassword.Text = "";
            }
        }

        private void RegConfPassword_Leave(object sender, EventArgs e)
        {
            if (RegConfPassword.Text == "")
            {
                RegConfPassword.Text = "Confirm password";
            }
        }

        private void RegBack_Click(object sender, EventArgs e)
        {
            RegPanel.Visible = false;
            LoginPanel.Visible = true;
        }

        private void LoginReg_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            RegPanel.Visible = true;
            LoginNameWarn.Visible = false;
            LoginPasswordWarn.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            User u1 = new User(RegName.Text, RegPassword.Text);
            persons.Add(u1);
        }

        private void RegRegister_Click(object sender, EventArgs e)
        {
            bool RegPasswordIsSuitable = true;
            bool RegNameIsSuitable = true;
            if(RegPassword.Text.Any(char.IsDigit) != true)
            {
                RegPasswordIsSuitable = false;
                //MessageBox.Show("Password dosent have number", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegPasswordWarn.Text = "Password doesn't have number";
                RegPasswordWarn.Visible = true;
            }
            if(RegName.Text.Length < 3)
            {
                RegNameIsSuitable = false;
                //MessageBox.Show("The name may consist of 3-20 symbols", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RegNameWarn.Text = "The name may consist of 3-20 symbol";
                RegNameWarn.Visible = true;
            }
            if (RegPasswordIsSuitable == true && RegNameIsSuitable == true)
            {
                User u1 = new User(RegName.Text, RegPassword.Text);
                persons.Add(u1);
            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            OptShowUsers.Visible = !OptShowUsers.Visible;
        }

        private void OptShowUsers_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
            RegPanel.Visible = false;
            ShowUsPanel.Visible = true;
            for (int i = 0; i < persons.Count; i++)
            {
                int n = i + 1;
               ShowUsLabel.Text += "User N# " + n.ToString() + " name: " + persons[i].GetName() + "\n";
            }
            OptShowUsers.Visible = false;
            Options.Visible = false;
        }

        private void ShowUsBack_Click(object sender, EventArgs e)
        {
            ShowUsPanel.Visible = false;
            ShowUsLabel.Text = "Users: \n";
            OptShowUsers.Visible = false;
            LoginPanel.Visible = true;
            Options.Visible = true;
        }

        private void RegPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegName_Click(object sender, EventArgs e)
        {

        }

        private void RegPasswordWarn_Click(object sender, EventArgs e)
        {
            if (RegPasswordWarn.Visible == true)
            {
                RegPasswordWarn.Visible = false;
            }
        }

        private void LoginEnter_Click(object sender, EventArgs e)
        {
            bool name_is_valid = false;
            int persNum = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if(LoginName.Text == persons[i].GetName())
                {
                    name_is_valid = true;
                    persNum = i;
                    break;
                }
            }
            if(name_is_valid == false)
            {
                LoginNameWarn.Visible = true;
            }
            else if(name_is_valid == true)
            {
                if(LoginPassword.Text == persons[persNum].GetPassword())
                {

                }
            }
        }
    }
}
