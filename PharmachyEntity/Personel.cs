using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmachyEntity
{
    internal class Personel
    {
        public string personelAdı { get; set; }
        public string personelSoyadı { get; set; }
        public string personelTc { get; set; }
        public string personelAdres { get; set; }
        public decimal personelSaatUcreti { get; set; }
        public string personelTelefon { get; set; }
        public string personelEPosta { get; set; }  
        public DateTime personelIseBaslamaTarihi { get; set; }
        public DateTime personelIstenCıkmaTarihi { get; set; }
        public decimal personelMaas { get; set; }
        public string personelBankaHesapNo { get; set; }
        public string personelAciklama { get; set; }


    }
}
