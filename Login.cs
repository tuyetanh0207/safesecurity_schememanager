using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO_HotelManagement;
using Oracle.ManagedDataAccess.Client;

namespace project_ATBM_HTTT
{
    public partial class Login : Form
    {
        string username;
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // 2 dòng này lấy username pass nè
            username = tb_User.Text;
            password = tb_Pass.Text;
            MessageBox.Show(username, password);
            try
            {
                if (username.IndexOf("QL") >= 0 ||
                                  username.IndexOf("NS") >= 0 ||
                                  username.IndexOf("TP") >= 0 ||
                                  username.IndexOf("TDA") >= 0 ||
                                  username.IndexOf("TC") >= 0 ||
                                  username.IndexOf("GD") >= 0)
                {
                    // set username pass vào dataprovider nè. cái instance có thể xem như là một bản sao của dataprovider, nên là nó sẽ giữ giá trị và sử dụng được cho mọi class
                    // nên không cần tạo new nè
                    DataProvider.Instance.setUserPass(username, password);
                    //test lấy tên thôi, nên là cmt lại 
                    MessageBox.Show(DataProvider.Instance.getUsername());

                    //gọi form mới
                    F_Dashboard f_Dashboard = new F_Dashboard();
                    f_Dashboard.Show();
                    this.Hide();
                }

                else if (username == "QLCONGTY")
                {
                    //something
                }
                else
                {
                    //something
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show("Invalid name or password.");
                //MessageBox.Show(ex.ToString());
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
