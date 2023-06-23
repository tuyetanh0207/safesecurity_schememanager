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
        }
		
		private void dgv_UC_DeAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//DataTable dataTable = new DataTable();
			//string query = "select pc.MAda as \"SchemaID\", da.TENDA as \"Schema\", nv.manv as EmpID, nv.tennv as Emp, pc.thoigian as Time from QLCONGTY.phancong pc join QLCONGTY.dean da on pc.mada = da.mada join QLCONGTY.nhanvien nv on pc.manv=nv.manv";
			////string query = "SELECT * FROM QLCONGTY.NHANVIEN";
			//dgv_UC_DeAn.DataSource = DataProvider.Instance.ExecuteQuery(query);
			//for (int i = 0; i < dgv_UC_DeAn.Rows.Count; i++)
			//{
			//	dgv_UC_DeAn.Rows[i].HeaderCell.Value = (i + 1).ToString();
			//}
		}

	}
}
