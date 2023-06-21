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

namespace Project_SS.UserControls
{
    public partial class UC_PhanCong : UserControl
    {
        public UC_PhanCong()
        {
            InitializeComponent();
            getAssignment();
            dtgvDSPHANCONG.RowHeadersWidth = 50;


        }
        private void getAssignment()
        {

            DataTable dataTable = new DataTable();
            string query = "select pc.MAda as \"Schema ID\", da.TENDA as Schema, nv.manv as EmpID, nv.tennv as Emp, pc.thoigian as Time from QLCONGTY.phancong pc join QLCONGTY.dean da on pc.mada = da.mada join QLCONGTY.nhanvien nv on pc.manv=nv.manv";
            //string query = "SELECT * FROM QLCONGTY.NHANVIEN";
            dtgvDSPHANCONG.DataSource = DataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dtgvDSPHANCONG.Rows.Count; i++)
            {
                dtgvDSPHANCONG.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
           /* for (int i = 0; i < dtgvDSPHANCONG.Columns.Count - 1; i++)
            {
                dtgvDSPHANCONG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dtgvDSPHANCONG.Columns[dtgvDSPHANCONG.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
*/
            for (int i = 0; i < dtgvDSPHANCONG.Columns.Count; i++)
            {
                /*int colw = dtgvDSPHANCONG.Columns[i].Width;
                dtgvDSPHANCONG.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtgvDSPHANCONG.Columns[i].Width = colw;*/
                dtgvDSPHANCONG.Columns[i].ReadOnly = true;
            }
            DataGridViewButtonColumn doWork = new DataGridViewButtonColumn();
            doWork.HeaderText = "";
            doWork.Text = "Delete";
            doWork.Width = 50;
            dtgvDSPHANCONG.Columns.Insert(dtgvDSPHANCONG.Columns.Count, doWork);
            DataGridViewButtonColumn doWork1 = new DataGridViewButtonColumn();
            doWork1.HeaderText = "";
            doWork1.
            doWork1.Width = 50;
            dtgvDSPHANCONG.Columns.Insert(dtgvDSPHANCONG.Columns.Count, doWork1);
      
            //MessageBox.Show("hihi");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvDSPHANCONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
