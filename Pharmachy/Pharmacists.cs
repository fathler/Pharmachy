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
    
    public partial class Pharmacists : Form
    {
        public Pharmacists()
        {
            InitializeComponent();
        }

        private void personelAdıText_Click(object sender, EventArgs e)
        {
            personelAdıText.Clear();
        }

        private void personelSoyadıtext_Click(object sender, EventArgs e)
        {
            personelSoyadıtext.Clear();
        }

        private void personelTctext_Click(object sender, EventArgs e)
        {
            personelTctext.Clear();
        }

        private void personelAdrestext_Click(object sender, EventArgs e)
        {
            personelAdrestext.Clear();
        }

        private void personelsaatlikucrettext_Click(object sender, EventArgs e)
        {
            personelsaatlikucrettext.Clear();
        }

        private void personelTelefontext_Click(object sender, EventArgs e)
        {
            personelTelefontext.Clear();
        }

        private void personelEPostatext_Click(object sender, EventArgs e)
        {
            personelEPostatext.Clear();
        }

        private void personelMaastext_Click(object sender, EventArgs e)
        {
            personelMaastext.Clear();
        }

        private void personelBankaHesapNoText_Click(object sender, EventArgs e)
        {
            personelBankaHesapNoText.Clear();
        }

        private void personelAciklamatext_Click(object sender, EventArgs e)
        {
            personelAciklamatext.Clear();
        }

        private void PersonelKayitButton_Click(object sender, EventArgs e)
        {
            SqlParameter[] Degerler = new SqlParameter[12];
            Degerler[0] = new SqlParameter("@personelAdı", personelAdıText.Text);
            Degerler[1] = new SqlParameter("@personelSoyadı", personelSoyadıtext.Text);
            Degerler[2] = new SqlParameter("@personelTc", personelTctext.Text);
            Degerler[3] = new SqlParameter("@personelAdres", personelAdrestext.Text);
            Degerler[4] = new SqlParameter("@personelSaatUcreti", personelsaatlikucrettext.Text);
            Degerler[5] = new SqlParameter("@personelTelefon", personelTelefontext.Text);
            Degerler[6] = new SqlParameter("@personelEPosta", personelEPostatext.Text);
            Degerler[7] = new SqlParameter("@personelIseBaslamaTarihi", personelIseBaslamaTarihitimepicker.Value);
            Degerler[8] = new SqlParameter("@personelIstenCıkmaTarihi", personelIstenCıkmaTarihitimepicker.Value);
            Degerler[9] = new SqlParameter("@personelMaas", personelMaastext.Text);
            Degerler[10] = new SqlParameter("@personelBankaHesapNo", personelBankaHesapNoText.Text);
            Degerler[11] = new SqlParameter("@personelAciklama", personelAciklamatext.Text);
            PersonelKayitButton.Enabled = true;
            int ess = HelperSql.SqlGeriDondurmezWithSp("sp_personelekleme", true, Degerler);
            MessageBox.Show(ess > 0 ? "Personel Başarı İle Eklenmiştir" : "Bir şeyler ters gitti");
            PersonelKayitButton.Enabled = false;
        }

    }
}
