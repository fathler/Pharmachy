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
    public partial class Prescription : Form
    {
        int paraustu;
        public Prescription()
        {
            InitializeComponent();
        }
        private void Prescription_Load(object sender, EventArgs e)
        {
            
            ilaceklemelistview.Items.Clear();
            ilaceklemelistview.GridLines=true;
            ilaceklemelistview.View = View.Details;
            ListView item = new ListView();

            SqlDataReader asd= HelperSql.SqlOkuyucuDondurWithSp("sp_ilactablodoldurma",true,null);
            {
                
                if(asd.HasRows)
                {
                    while(asd.Read())
                    {
                        ReceteİlacCombo.Items.Add(asd["ilacAd"].ToString());
                    }
                }
                asd.Close();
            }
          // sPanel1.Enabled = false;
        }

        private void İlacSatisButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@musteriAd", musteriAdıText.Text);
            parameters[1] = new SqlParameter("@musteriSoyad", musteriSoyadıtext.Text);
            parameters[2] = new SqlParameter("@musteriTC", musteriTctext.Text);
            parameters[3] = new SqlParameter("@musteriAdres", musteriAdrestext.Text);
            parameters[4] = new SqlParameter("@musteriBakiye", musteriBakiyetext.Text);
            parameters[5] = new SqlParameter("@musteriTelefon", musteriTelefontext.Text);
            parameters[6] = new SqlParameter("@MusteriEPosta", MusteriEPostatext.Text);
            int ess = Convert.ToInt32(HelperSql.SqlNesneDondurWithSP("sp_MusteriKayit",true, parameters));
            paraustu = Convert.ToInt32(musteriBakiyetext.Text);
            MessageBox.Show(ess > 0 ? "Musteri Basariyla Eklendi " : "Bir şeyler yolunda gitmedi");
            //string Rdr = (HelperSql.SqlNesneDondurWithSP("select musteriID from [dbo].[tblMusteriler] where @musteriTc = " + musteriTctext.Text,false,null).ToString());
            //if(Rdr.HasRows)
            //{
            //    ReceteMusteriIDtxt.Text = (Rdr["musteriID"].ToString());
                //while (Rdr.Read())
                //{
                //    ReceteMusteriIDtxt. = (Rdr["musteriID"].ToString());
                //}
            //}
            sPanel1.Enabled = true;
        }

        
        private void musteriAdıText_Click(object sender, EventArgs e)
        {
           musteriAdıText.Clear();
        }
        private void musteriSoyadıtext_Click(object sender, EventArgs e)
        {
            musteriSoyadıtext.Clear();
        }

        private void musteriTctext_Click(object sender, EventArgs e)
        {
            musteriTctext.Clear();
        }

        private void musteriAdrestext_Click(object sender, EventArgs e)
        {
            musteriAdrestext.Clear();
        }

        private void musteriBakiyetext_Click(object sender, EventArgs e)
        {
            musteriBakiyetext.Clear();
        }

        private void musteriTelefontext_Click(object sender, EventArgs e)
        {
            musteriTelefontext.Clear();
        }

        private void MusteriEPostatext_Click(object sender, EventArgs e)
        {
            MusteriEPostatext.Clear();
        }
        private void receteNotext_Click_1(object sender, EventArgs e)
        {
            receteNotext.Clear();
        }

        private void receteDoktortext_Click_1(object sender, EventArgs e)
        {
            receteDoktortext.Clear();
        }

        private void receteTutartext_Click(object sender, EventArgs e)
        {
            receteTutartext.Clear();
        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ilacSatisBUTTON_Click_1(object sender, EventArgs e)
        {
            SqlParameter[] parameters1 = new SqlParameter[6];
            parameters1[0] = new SqlParameter("@receteNo", receteNotext.Text);
            parameters1[1] = new SqlParameter("@receteDoktor", receteDoktortext.Text);
            parameters1[2] = new SqlParameter("@receteTarih", recetetarihpicker.Value);
            parameters1[3] = new SqlParameter("@musteriID", ReceteMusteriIDtxt.Text);
            parameters1[4] = new SqlParameter("@ilacID", ReceteİlacCombo.SelectedIndex);
            parameters1[5] = new SqlParameter("@receteTutar", receteTutartext.Text);
            int ess = Convert.ToInt32(HelperSql.SqlNesneDondurWithSP("sp_YeniReceteKayit", true, parameters1));
            MessageBox.Show(ess > 0 ? "Done " : "Someting went wrong");
            int paraustu = (Convert.ToInt32(musteriBakiyetext.Text)) - (Convert.ToInt32(receteTutartext.Text));
            ParaustuLabel.Text = paraustu.ToString();
        }

        private void ilaclwekleme_Click(object sender, EventArgs e)
        {
           SqlDataReader okuyucu = HelperSql.SqlOkuyucuDondurWithSp("Select * from tbl_ilaclar where ilacAd = "+(ReceteİlacCombo.SelectedItem).ToString(), false, null);
            if (okuyucu.HasRows)
            {
                while (okuyucu.Read())
                {
                    ListViewItem item = new ListViewItem("ilacID");
                    item.SubItems.Add("ilacBarkod");

                }
            }
            //ilaceklemelistview.Items.Add
            //    (ReceteİlacCombo.SelectedItem.ToString())
        }
    }
}
