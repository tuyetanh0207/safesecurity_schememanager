using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_SS.UserControls
{
    public partial class UC_DeAn : UserControl
    {
        public UC_DeAn()
        {
            InitializeComponent();
            list_Scheme();
        }
        private void list_Scheme()
        {
            string query = "SELECT * FROM DEAN;";
            dgv_List_Scheme.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        
        private void dgv_List_Scheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
