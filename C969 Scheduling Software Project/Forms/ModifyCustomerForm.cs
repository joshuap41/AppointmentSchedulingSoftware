using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Scheduling_Software_Project.Forms
{
    public partial class ModifyCustomerForm : Form
    {
        //for save button
        int currentCityId = -2;
        string selectedCountry = "";
        int currentAddressId = -1;



        public ModifyCustomerForm()
        {
            InitializeComponent();
        }
        
        private void ModifyCustomerForm_Load(object sender, EventArgs e)
        {

            string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer WHERE customerId='" + MainScreenForm.currentCustomerId + "'", con);
                con.Open();
                MySqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    NameTextBox.Text = re["customerName"].ToString();
                }
                else
                {
                    MessageBox.Show("Something went wrong in customer query!");
                }
            }


            using (MySqlConnection con = new MySqlConnection(CS))
            {
                int currentSelectedCityId = -0;

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM address WHERE addressId='" + MainScreenForm.currentAddressId + "'", con);
                con.Open();
                MySqlDataReader re = cmd.ExecuteReader();
                if (re.Read())
                {
                    AddressTextBox.Text = re["address"].ToString();
                    Address2TextBox.Text = re["address2"].ToString();                   
                    currentSelectedCityId = Convert.ToInt32(re["cityId"].ToString());
                    PostalCodeTextBox.Text = re["postalCode"].ToString();
                    PhoneNumberTextBox.Text = re["phone"].ToString();

                    if (currentSelectedCityId == 1)
                    {
                        CityListBox.Text = "New York";
                        selectedCountry = "US";
                    }
                    else
                    {
                        CityListBox.Text = "Toronto";
                        selectedCountry = "Canada";
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong in address query!");
                }
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainScreenForm MyMainScreenForm = new MainScreenForm();
            this.Hide();
            MyMainScreenForm.Show();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CityListBox.SelectedItem.Equals("New York"))
            {
                currentCityId = 1;
                selectedCountry = "US";
            }
            else
            {
                currentCityId = 8;
                selectedCountry = "Canada";
            }
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text == "" || AddressTextBox.Text == "" || CityListBox.Text == "" ||
                    PostalCodeTextBox.Text == "" || PhoneNumberTextBox.Text == "")
                {
                    MessageBox.Show("Please enter values for all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;
                    using (MySqlConnection con = new MySqlConnection(CS))
                    {
                        MySqlCommand cmd = new MySqlCommand();

                        
                        cmd.CommandText = "UPDATE customer SET customerName = @NameTextBox, addressId = @AddressId WHERE customerId = @CustomerId;";
                        cmd.Connection = con;
                        con.Open();
                        cmd.Parameters.AddWithValue("@CustomerId", MainScreenForm.currentCustomerId);
                        cmd.Parameters.AddWithValue("@addressId", MainScreenForm.currentAddressId);
                        cmd.Parameters.AddWithValue("@NameTextBox", NameTextBox.Text);
                        cmd.ExecuteNonQuery();


                        // SET FOREIGN_KEY_CHECKS = 0 and 1 at the end is to fix "Access denied to user" for the uCertify DB
                        cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0;UPDATE address SET address = @AddressTextBox, address2 = @Address2TextBox, cityId = @CurrentCityId, postalCode = @PostalCodeTextBox, phone = @PhoneNumberTextBox WHERE addressId = @AddressId; SET FOREIGN_KEY_CHECKS = 1;";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@AddressTextBox", AddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@Address2TextBox", Address2TextBox.Text);
                        cmd.Parameters.AddWithValue("@CurrentCityId", currentCityId);
                        cmd.Parameters.AddWithValue("@PostalCodeTextBox", PostalCodeTextBox.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumberTextBox", PhoneNumberTextBox.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    this.Close();
                    MainScreenForm myMainScreenForm = new MainScreenForm();
                    myMainScreenForm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //validates correct user Name input
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


    }
}
