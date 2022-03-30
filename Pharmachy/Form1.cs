using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmachy
{
    public partial class Form1 : Form
    {
        List<Panel> list = new List<Panel>();
        int index=0;
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MedicinePanel.Controls.Add(childForm);
            MedicinePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //list.Add(MedicinePanel); 
            //list.Add(PatiencePanel);
            //list[index].BringToFront();
        }

        private void MedicineButton_Click(object sender, EventArgs e)
        {

            openChildForm(new Medicine());

        }
        private void prescriptionbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new Prescription());
        }

        private void Patiencebutton_Click(object sender, EventArgs e)
        {
            openChildForm(new Information());   
        }

        private void Staffbutton_Click(object sender, EventArgs e)
        {
            openChildForm(new Pharmacists());
        }
    }
}
