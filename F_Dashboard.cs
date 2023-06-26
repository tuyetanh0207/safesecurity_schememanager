using DAO_HotelManagement;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace project_ATBM_HTTT
{
    public partial class F_Dashboard : Form
    {
        // có provider r nên bỏ này
        //public string usernameF;
        //public string passwordF;
        //OracleConnection con;

        public F_Dashboard()
        {
            InitializeComponent();
            display();
            setData();
            display_Information();
        }
        private void display()
        {
            //cái này set mấy cái khung, làm biến nói quá nên thôi nha
            //Background
            Color backgroundColor = ColorTranslator.FromHtml("#d4e6f2");

            //Label
            //UserID
            UserID.Font = new Font(UserID.Font.FontFamily, 10, UserID.Font.Style);
            UserID.BackColor = Color.FromArgb(44, 121, 195);
            Color labelColorUserId = Color.FromArgb(255, 255, 255);
            UserID.ForeColor = labelColorUserId;

            //Username
            Username.Font = new Font(Username.Font.FontFamily, 10, Username.Font.Style);
            Username.BackColor = Color.FromArgb(44, 121, 195);
            Color labelColorUsername = Color.FromArgb(255, 255, 255);
            Username.ForeColor = labelColorUsername;

            //UserBirthday
            UserBirthday.Font = new Font(UserBirthday.Font.FontFamily, 10, UserBirthday.Font.Style);
            UserBirthday.BackColor = Color.FromArgb(44, 121, 195);
            Color labelColorUserBirthday = Color.FromArgb(255, 255, 255);
            UserBirthday.ForeColor = labelColorUserBirthday;

            //UserGender
            UserGender.Font = new Font(UserGender.Font.FontFamily, 10, UserGender.Font.Style);
            UserGender.BackColor = Color.FromArgb(44, 121, 195);
            Color labelColorUserGender = Color.FromArgb(255, 255, 255);
            UserGender.ForeColor = labelColorUserGender;

            //UserPhone
            UserPhone.Font = new Font(UserPhone.Font.FontFamily, 10, UserPhone.Font.Style);
            UserPhone.BackColor = Color.FromArgb(44, 121, 195);
            Color labelColorUserPhone = Color.FromArgb(255, 255, 255);
            UserPhone.ForeColor = labelColorUserPhone;

            //UserAddress
            UserAddress.Font = new Font(UserAddress.Font.FontFamily, 10, UserAddress.Font.Style);
            UserAddress.BackColor = Color.FromArgb(44, 121, 195);
            Color labelColorUserAddress = Color.FromArgb(255, 255, 255);
            UserAddress.ForeColor = labelColorUserAddress;

            //Dashboard label
            Color labelColorDashboard = Color.FromArgb(44, 121, 195);
            Dashboard.ForeColor = labelColorDashboard;
            Dashboard.Font = new Font(Dashboard.Font.FontFamily, 40, FontStyle.Bold);
            Dashboard.Location = new Point((this.Width - Dashboard.Width) / 2, 70);

            //Textbox
            //UserID
            Color textColorUserID = Color.FromArgb(255, 255, 255);
            Text_ID.BackColor = textColorUserID;

            //Username
            Color textColorUsername = Color.FromArgb(255, 255, 255);
            Text_Username.BackColor = textColorUsername;

            //Gender
            Color textColorGender = Color.FromArgb(255, 255, 255);
            Text_Gender.BackColor = textColorGender;

            //Birthday
            Color textColorBirthday = Color.FromArgb(255, 255, 255);
            Text_Birthday.BackColor = textColorBirthday;

            //Phone
            Color textColorPhone = Color.FromArgb(255, 255, 255);
            Text_Phone.BackColor = textColorPhone;

            //Address
            Color textColorAddress = Color.FromArgb(255, 255, 255);
            Text_Address.BackColor = textColorAddress;

            //Button
            //Edit
            Color textColorEdit = Color.FromArgb(108, 215, 195);
            Button_Edit_Confirm.BackColor = textColorEdit;
            Button_Edit_Confirm.Font = new Font(Button_Edit_Confirm.Font.FontFamily, 18, Button_Edit_Confirm.Font.Style);

            //Logout
            Color textColorLogout = Color.FromArgb(108, 215, 195);
            Button_Logout.BackColor = textColorLogout;
            Button_Logout.Font = new Font(Button_Logout.Font.FontFamily, 18, Button_Logout.Font.Style);
        }
        //này là lấy data cho 1 dòng ở 1 cột cố định
        private void setData()
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT MANV FROM QLCONGTY.NHANVIEN WHERE MANV = '" + DataProvider.Instance.getUsername()+"'");
            string id = "";
            foreach (DataRow dr in dt.Rows)
            {
                id = dr["MANV"].ToString();
                break;
            }
            MessageBox.Show(id);
            Text_ID.Text = id;
        }
        //này thì set nguyên cái datagrid luôn
        private void display_Information()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM QLCONGTY.NHANVIEN";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool isEditing = true;
        private void Button_Edit_Confirm_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                // Chuyển từ trạng thái "Edit" sang "Confirm"
                Button_Edit_Confirm.Text = "Confirm";

                Text_Birthday.Enabled = true;
                Text_Birthday.ReadOnly = false;

                Text_Phone.Enabled = true;
                Text_Phone.ReadOnly = false;

                Text_Address.Enabled = true;
                Text_Address.ReadOnly = false;
            }
            else
            {
                // Chuyển từ trạng thái "Confirm" sang "Edit"
                Button_Edit_Confirm.Text = "Edit";

                Text_Birthday.Enabled = false;
                Text_Birthday.ReadOnly = true;

                Text_Phone.Enabled = false;
                Text_Phone.ReadOnly = true;

                Text_Address.Enabled = false;
                Text_Address.ReadOnly = true;
            }
            // Đảo ngược trạng thái
            isEditing = !isEditing;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
