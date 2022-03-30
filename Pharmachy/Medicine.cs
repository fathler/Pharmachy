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
using System.Data.SqlClient;
using PharmachyDAL;

namespace Pharmachy
{
    public partial class Medicine : Form
    {
        
        public Medicine()
        {
            InitializeComponent();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_eczane_denemeDataSet.tblilaclar' table. You can move, or remove it, as needed.
            this.tblilaclarTableAdapter1.Fill(this.db_eczane_denemeDataSet.tblilaclar);
            //SqlConnection con = new SqlConnection("Server=Z36-02\\SQLEXPRESS;Database=db_eczane_deneme;Integrated Security=true");
            //SqlCommand com = new SqlCommand("select depoAdı from [dbo].[tblIlacDepoları]", con);
            //SqlCommand cmd = new SqlCommand("select FirmaAd from [dbo].[ilacUreticiFirma]", con);
            SqlDataReader Okuyucu = HelperSql.SqlOkuyucuDondurWithSp("sp_depotablodoldurma",true,null);
            SqlDataReader Okuyucu1 = HelperSql.SqlOkuyucuDondurWithSp("sp_ureticifirmatablodoldurma",true, null);
            if (Okuyucu.HasRows)
            {
                while (Okuyucu.Read())
                {
                    ilacdepocombo.Items.Add(Okuyucu["depoAdı"].ToString());
                }
            }
            Okuyucu.Close();
            if (Okuyucu1.HasRows)
            {
                while (Okuyucu1.Read())
                {
                    ureticiFirmaCombo.Items.Add(Okuyucu1["FirmaAd"].ToString());
                }
            }
            Okuyucu1.Close();
            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //    SqlDataReader reader = com.ExecuteReader();
            //    if(reader.HasRows)
            //    {
            //        while(reader.Read())
            //        {
            //            ilacdepocombo.Items.Add(reader["depoAdı"].ToString());
            //        }
            //    }
            //    reader.Close();
            //    SqlDataReader reader2 = cmd.ExecuteReader();
            //    if(reader2.HasRows)
            //    {
            //        while(reader2.Read())
            //        {
            //            ureticiFirmaCombo.Items.Add(reader2["FirmaAd"].ToString());
            //        }
            //    }
            //}
            //else if(con.State == ConnectionState.Open)
            //{
            //    con.Close();
            //}
            //listView1.Items.Clear();
            //listView1.GridLines = true;
            //listView1.FullRowSelect = true;
            //listView1.View = View.Details;
            //listView1.Columns.Add("ID", 30);
            //listView1.Columns.Add("Ad", 100);
            //listView1.Columns.Add("Fiyat", 80);
            //listView1.Columns.Add("Stok", 80);
            //listView1.Columns.Add("Türü", 80);
            //listView1.Columns.Add("Aciklama", 80);
            //listView1.Columns.Add("Reçetelimi?",100);

            //(dataGridView1.DataSource).Rows.Clear();
            //this.dataGridView1.Rows.Clear();

        }

        private void ilacbarkodText_Click(object sender, EventArgs e)
        {
            ilacbarkodText.Clear();
        }

        private void ilacadtext_Click(object sender, EventArgs e)
        {
            ilacadtext.Clear();
        }

        private void ilacfiyattext_Click(object sender, EventArgs e)
        {
            ilacfiyattext.Clear();
        }
        private void kdvtext_Click(object sender, EventArgs e)
        {
            kdvtext.Clear();
        }
        private void stoktext_Click(object sender, EventArgs e)
        {
            stoktext.Clear();
        }

        private void ilacturutext_Click(object sender, EventArgs e)
        {
            ilacturutext.Clear();
        }

        private void aciklamatext_Click(object sender, EventArgs e)
        {
            aciklamatext.Clear();
        }

        private void ilacbarkodsorgutext_Click(object sender, EventArgs e)
        {
            ilacbarkodsorgutext.Clear();
        }

        private void ilaceklebutton_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection("Server=Z36-02\\SQLEXPRESS;Database=db_eczane;Integrated Security=true");
            //SqlCommand com = new SqlCommand("INSERT INTO [dbo].[tblilaclar]([ilacBarkod],[ilacAd],[ilacFiyat],[UreticiFirmaID],[ilacKDVOran],[ilacStokAdet],[TurID],[ilacReceteliMi],[ilacAcıklama],[ilacDepoFirma]) VALUES (@ilacBarkod, @ilacAd, @ilacFiyat, @UreticiFirmaID, @ilacKDVOran, @ilacStokAdet, @TurID, @ilacReceteliMi, @ilacAcıklama, @ilacDepoFirma)",con);
            SqlParameter[] Degerler = new SqlParameter[10];
            Degerler[0] = new SqlParameter("@ilacBarkod",ilacbarkodText.Text);
            Degerler[1] = new SqlParameter("@ilacAd",ilacadtext.Text);
            Degerler[2] = new SqlParameter("@ilacFiyat",ilacfiyattext.Text);
            Degerler[3] = new SqlParameter("@UreticiFirmaID",ureticiFirmaCombo.SelectedIndex);
            Degerler[4] = new SqlParameter("@ilacKDVOran",kdvtext.Text);
            Degerler[5] = new SqlParameter("@ilacStokAdet",stoktext.Text);
            Degerler[6] = new SqlParameter("@TurID",ilacturutext.Text);
            Degerler[7] = new SqlParameter("@ilacReceteliMi",recetelimicheckBox1.Checked);
            Degerler[8] = new SqlParameter("@ilacAcıklama",aciklamatext.Text);
            Degerler[9] = new SqlParameter("@ilacDepoFirma",ilacdepocombo.SelectedIndex);
            int ess = HelperSql.SqlGeriDondurmezWithSp("sp_ilacekleme",true, Degerler);
            //if (con.State == ConnectionState.Closed)
            //{
            //    con.Open();
            //    var gelen = com.ExecuteNonQuery();
            //    MessageBox.Show(gelen > 0 ? "İlaç ekleme başarıyla tamamlandı" : "Bir şeyler ters gitti.");
            //}
            //else if (con.State == ConnectionState.Open)
            //{
            //    con.Close();
            //}

        }

        private void ilacbilgibutton_Click(object sender, EventArgs e)
        {
            SqlParameter[] Degerler = new SqlParameter[1];
            Degerler[0] = new SqlParameter("@ilacBarkod",ilacbarkodsorgutext.Text);
            SqlDataReader Okuyucu = HelperSql.SqlOkuyucuDondurWithSp("sp_ilacbilgigetirme", true, Degerler);
            if (Okuyucu.HasRows)
            {
                while(Okuyucu.Read())
                {
                    DataTable dt = new DataTable();
                    dt.Load(Okuyucu);
                    İlacgoruntulemeDatagridview.DataSource = dt;
                }
            }
            //SqlConnection con = new SqlConnection("Server=Z36-02\\SQLEXPRESS;Database=db_eczane_deneme;Integrated Security=true");
            ////SqlCommand cmd = new SqlCommand("select ilacID , ilacAd , ilacFiyat , ilacStokAdet , TurID , ilacAcıklama , ilacReceteliMi  from [dbo].[tblilaclar] where ilacBarkod='" + ilacbarkodsorgutext.Text+"'", con);
           // SqlDataAdapter Adapter = new SqlDataAdapter("select ilacID , ilacAd , ilacFiyat , ilacStokAdet , TurID , ilacAcıklama , ilacReceteliMi  from [dbo].[tblilaclar] where ilacBarkod='" + ilacbarkodsorgutext.Text + "'",con);

            //if(con.State==ConnectionState.Closed)
            //{ con.Open();
            //    DataSet ds = new DataSet();
            //    Adapter.Fill(ds);
            //    dataGridView1.DataSource = ds.Tables[0];
            //}
            //else if (con.State==ConnectionState.Open)
            //con.Close();
        }

        private void ilacguncellebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
