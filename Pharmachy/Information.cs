using PharmachyDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmachy
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            //informationlistview.Clear();
            //informationlistview.GridLines = true;
            //informationlistview.View = View.Details;
           // informationlistview.Columns.Add()
        }
        private void pharmacistsinfotext_Click(object sender, EventArgs e)
        {
            pharmacistsinfotext.Clear();
        }
        private void PrescriptionNoinfotext_Click(object sender, EventArgs e)
        {
            PrescriptionNoinfotext.Clear();

        }

        private void MedicineNoinfoText_Click(object sender, EventArgs e)
        {
            MedicineNoinfoText.Clear();
        }

        private void PatienceIDinfotext_Click(object sender, EventArgs e)
        {
            PatienceIDinfotext.Clear();
        }

        private void MedicineinfoButton_Click(object sender, EventArgs e)

        {
            

            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@ilacBarkod", MedicineNoinfoText.Text);
            SqlDataReader reader = HelperSql.SqlOkuyucuDondurWithSp("sp_ilacbilgibarkodile", true, prm );
            //informationDatagridview.AutoGenerateColumns = true;
            DataTable table = new DataTable();
            table.Load(reader);
            informationDatagridview.DataSource = table;

            //if (reader.HasRows)
            //{
            //    while(reader.Read())
            //    {
            //        binder1.DataSource = reader;
            //        informationDatagridview.DataSource = binder1;
            //    }
            //}
            

        }
        
        private void prescriptioninfobutton_Click(object sender, EventArgs e)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@receteNo", PrescriptionNoinfotext.Text);
            SqlDataReader reader = HelperSql.SqlOkuyucuDondurWithSp("sp_prescriptioninfo", true, prm);
            //informationDatagridview.AutoGenerateColumns = true;
            DataTable table = new DataTable();
            table.Load(reader);
            informationDatagridview.DataSource = table;
        }

        private void patienceİnfoButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@musteriTc", PatienceIDinfotext.Text);
            SqlDataReader reader = HelperSql.SqlOkuyucuDondurWithSp("sp_tcileMusteriGetirme", true, prm);
            //informationDatagridview.AutoGenerateColumns = true;
            DataTable table = new DataTable();
            table.Load(reader);
            informationDatagridview.DataSource = table; 
        }

        private void pharmacistinfoButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@personelAdı", pharmacistsinfotext.Text);
            SqlDataReader reader = HelperSql.SqlOkuyucuDondurWithSp("sp_ismegörepersonel", true, prm);
            //informationDatagridview.AutoGenerateColumns = true;
            DataTable table = new DataTable();
            table.Load(reader);
            informationDatagridview.DataSource = table;
        }

       
    }
}
