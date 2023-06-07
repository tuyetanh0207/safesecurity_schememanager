using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace Project_SS
{
    public partial class Login : Form
    {
        ConnectionString str = new ConnectionString();
        string username;
        string password;

        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Pass.Checked == true)
            {
                tb_Pass.UseSystemPasswordChar = false;
            }
            else
                tb_Pass.UseSystemPasswordChar = true;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            tb_User.Text = "QLCONGTY"; 
            tb_Pass.Text = "DOAN";

            if (isFormValid())
            {
                str.setConStr(tb_User.Text, tb_Pass.Text);
                OracleConnection con = new OracleConnection(str.getString());
                username = str.getUser();
                password = str.getPass();

                try
                {
                    con.Open();
                    con.Close();

                    MessageBox.Show(username);
                    Dashboard dashboardForm = new Dashboard();
                    dashboardForm.Show();
                    this.Hide();

                    /*
                    if (username == "QLCONGTY")
                    {
                        MessageBox.Show(username);
                        F_Dashboard dashboardForm = new F_Dashboard();
                        dashboardForm.Show();
                        this.Hide();
                    }
                    */
                }
                catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show("Invalid name or password.");
                    //MessageBox.Show(ex.ToString());
                }
            }
        }

        private bool isFormValid()
        {
            if (tb_User.Text.Trim() == string.Empty || tb_Pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username and Password both are required.", "Enter Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
