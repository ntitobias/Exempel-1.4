using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel_1._4
{
    public partial class Form1 : Form
    {
        List<Account> accounts = new List<Account>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Account.CheckPassword(tbxPassword.Text))
            {
                Account newAccount = new Account(tbxUser.Text, tbxPassword.Text);
                accounts.Add(newAccount);
                lbxUsers.Items.Add(newAccount);
            }
            else MessageBox.Show("Lösenordet måste innehålla minst 8 tecken.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (Account account in accounts)
            {
                if(account.Username == tbxUser.Text && account.Password == tbxPassword.Text)
                {
                    lblInfo.Text = "Välkommen\r\n" + account.Username;
                    lblInfo.Visible = true;
                    found = true;
                }
            }

            if (!found)
            {
                lblInfo.Visible = false;
                MessageBox.Show("Felaktigt användarnamn eller lösenord.");
            }

        }
    }

    
}
