using Project_SS;
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
            //list_Scheme();

        }
        private void list_Scheme()
        {
            string query = "SELECT * FROM QLCONGTY.DEAN";
            dgv_ListScheme.DataSource = DataProvider.Instance.ExecuteNonQuery(query);
            list_Scheme();

        }
		private void dgv_ListScheme_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
                      
        }
	}
}
