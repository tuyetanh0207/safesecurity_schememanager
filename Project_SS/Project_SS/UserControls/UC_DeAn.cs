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
		}

		private void dgv_ListScheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
				string query = "SELECT * FROM DEAN";
				DataTable dt = DataProvider.Instance.ExecuteQuery(query);			
		}
	}
}
