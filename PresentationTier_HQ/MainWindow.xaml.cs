//Author: Fletcher Thomas Moore
//Name: MainWindow.xaml.cs
//Description: HQ UI that validates input patient data
//Start Date: 29/11/2020
//Last Edit:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentationTier_HQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Search button clicked
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = new Patient();

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
                patient.NHSRegNum = Int32.Parse(txtNHSReg.Text);
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
                    patient.FirstName = txtFirstN.Text;
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
                    patient.LastName = txtLastN.Text;
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
                    patient.Address = txtAddress.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with Address");
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
                    patient.MedicalCon = txtMedical.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Something went wrong with Medical Condition");
                return;
            }
        }
    }
}
