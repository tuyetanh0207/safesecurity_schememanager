using DAO_HotelManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SS.UserControls
{
	public partial class UC_DeAn : UserControl
	{
		public UC_DeAn()
		{
			InitializeComponent();
            //dgv_ListDeAn.DataSource();
            list_Scheme();

        }
        private void list_Scheme()
        {
            string query = "SELECT * FROM QLCONGTY.DEAN";
            int res = DataProvider.Instance.ExecuteNonQuery(query);
        }
		private void dgv_ListScheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            //string query = "SELECT * FROM QLCONGTY.DEAN";
            //int res = DataProvider.Instance.ExecuteNonQuery(query);
            //        string query = "SELECT * FROM QLCONGTY.DEAN";
            //DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            //string query = "SELECT * FROM QLCONGTY.DEAN";
            //dgv_ListScheme.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //var senderGrid = (DataGridView)sender;
            //string schemaid = dgv_ListScheme.Rows[e.RowIndex].Cells["SchemaID"].Value.ToString();
            //string empid = dgv_ListScheme.Rows[e.RowIndex].Cells["EmpID"].Value.ToString();
            ////currTime = dgv_ListScheme.Rows[e.RowIndex].Cells["Time"].Value.ToString();
            //int count = dgv_ListScheme.ColumnCount;
            //int count1 = e.ColumnIndex;
            //newEmpid = empid;
            //newSchemaid = schemaid;
            //newTime = currTime;
        }
	}
}
