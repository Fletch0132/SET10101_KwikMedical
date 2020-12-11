using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using BusinessTier;

namespace WindowsFormsApp1
{
    public partial class PatientDisplay : Form
    {
        public PatientBT pbt = new PatientBT();
        public PatientBO pbo = new PatientBO();

        public PatientDisplay()
        {
            InitializeComponent();
        }

        private void PatientDisplay_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            
            dt = pbt.PatientDisplay(pbo);

            if (dt.Rows.Count > 0)
            {
                dgvPatientDisplay.DataSource = dt;
                this.Show();
            }
            else
            {
                MessageBox.Show("Patient not found!");
                return;
            }
        }
    }
}
