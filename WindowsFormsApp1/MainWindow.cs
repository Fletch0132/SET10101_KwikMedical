using System;
using System.Data;
using System.Windows.Forms;


using BusinessObject;
using BusinessTier;
using WindowsFormsApp1;

namespace MainWindow
{
    public partial class MainWindow : Form
    {
        public PatientBO pbo = new PatientBO();
        public PatientBT pbt = new PatientBT();

        DataTable dt = new DataTable();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //temp
            int nhs;

            #region Validate Input
            //NHS Registration Number
            try
            {
                //Test each character to make sure it is numeric
                int count = 0;
                foreach (char c in txtNHSReg.Text)
                {
                    count++;
                    if ((c < '0') || (c > '9'))
                    {
                        MessageBox.Show("Error: NHS Registration Number must be numeric. Please try again.");
                        return;
                    }
                }

                //NHS Reg num must be 6 digits
                if (txtNHSReg.Text.Length != 6)
                {
                    MessageBox.Show("Error: NHS Registration Number cannot be greater or less than 6 characters long");
                    return;
                }


                //Store input
                pbo.NHSRegNum = Int32.Parse(txtNHSReg.Text);
                nhs = Int32.Parse(txtNHSReg.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something wrong with NHS Registration Number.");
                return;
            }


            //First name
            try
            {
                //Validate First Name - Cannot be blank
                if (string.IsNullOrEmpty(txtFirstN.Text))
                {
                    MessageBox.Show("Error: First name cannot be blank.");
                    return;
                }
                else
                {
                    //store input
                    pbo.FirstName = txtFirstN.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with First Name.");
                return;
            }


            //Last Name
            try
            {
                //Validate Last Name - Cannot be blank
                if (string.IsNullOrEmpty(txtLastN.Text))
                {
                    MessageBox.Show("Error: Last name cannot be blank.");
                    return;
                }
                else
                {
                    //store input
                    pbo.LastName = txtLastN.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with Last Name.");
                return;
            }


            //Address
            try
            {
                //Validate Address - Cannot be blank
                if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Error: Address cannot be blank.");
                    return;
                }
                else
                {
                    //store input
                    pbo.Address = txtAddress.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with Address");
                return;
            }


            //Town
            try
            {
                if (string.IsNullOrEmpty(txtTown.Text))
                {
                    MessageBox.Show("Error: Town cannot be blank.");
                    return;
                }
                else
                {
                    //store input
                    pbo.Town = txtTown.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with Town");
                return;
            }


            //Postcode
            try
            {
                if (string.IsNullOrEmpty(txtPostcode.Text))
                {
                    MessageBox.Show("Error: Postcode cannot be blank.");
                    return;
                }
                else if (txtPostcode.Text.Length != 7)
                {
                    MessageBox.Show("Error: Postcode cannot be greater or less than 7 characters long");
                    return;
                }
                else
                {
                    //store input
                    pbo.Postcode = txtPostcode.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with Postcode");
                return;
            }


            //Medical Condition
            try
            {
                //validate MedCon - cannot be blank
                if (string.IsNullOrEmpty(txtMedical.Text))
                {
                    MessageBox.Show("Error: Medical Condition cannot be blank.");
                    return;
                }
                else
                {
                    pbo.MedicalCon = txtMedical.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with Medical Condition");
                return;
            }
            #endregion

            #region Found Data

            
            this.Hide();
            PatientDisplay pdy = new PatientDisplay();
            pdy.Show();
            

            #endregion
        }
    }
}
