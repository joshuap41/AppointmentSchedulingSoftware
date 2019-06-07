using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace C969_Scheduling_Software_Project.Forms
{
    public partial class AddCustomersForm : Form
    {

        public static int currentCityId = -1;
        public static string selectedCountry = "";



        public AddCustomersForm()
        {
            InitializeComponent();
        }


        private void AddCustomersForm_Load(object sender, EventArgs e)
        {

        }

        #region Textboxes
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostalCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCustomerInformationGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion

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
            DateTime dateTimeNow = DateTime.Now;
            string strMaxFormat = dateTimeNow.ToString("yyyy-MM-dd HH:mm:ss tt");//24 hours format hh gets 12 format

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

                        cmd.CommandText = "INSERT INTO address (address, address2, cityId, postalCode, phone ) " +
                                                       "VALUES (@AddressTextBox, @Address2TextBox, @CityId, @PostalCodeTextBox, @PhoneNumberTextBox);";
                        cmd.Connection = con;
                        con.Open();
                        cmd.Parameters.AddWithValue("@AddressTextBox", AddressTextBox.Text);
                        cmd.Parameters.AddWithValue("@Address2TextBox", Address2TextBox.Text);
                        cmd.Parameters.AddWithValue("@CityId", currentCityId);
                        cmd.Parameters.AddWithValue("@PostalCodeTextBox", PostalCodeTextBox.Text);
                        cmd.Parameters.AddWithValue("@PhoneNumberTextBox", PhoneNumberTextBox.Text);
                        cmd.ExecuteNonQuery();


                        cmd.CommandText = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy) " +
                                                        "VALUES (@NameTextBox,@AddressId, @Active, @createDate, @createdBy, @lastUpdateBy);";
                        //gets the ID of the last inserted item.
                        long lastAddressId = cmd.LastInsertedId;

                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@NameTextBox", NameTextBox.Text);
                        cmd.Parameters.AddWithValue("@AddressId", lastAddressId);
                        cmd.Parameters.AddWithValue("@Active", 1);
                        cmd.Parameters.AddWithValue("@CreateDate", Convert.ToDateTime(strMaxFormat).ToUniversalTime());
                        cmd.Parameters.AddWithValue("@CreatedBy", MainScreenForm.currentUser);
                        cmd.Parameters.AddWithValue("@LastUpdateBy", MainScreenForm.currentUser);
                        cmd.ExecuteNonQuery();

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


        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainScreenForm MyMainScreenForm = new MainScreenForm();
            this.Hide();
            MyMainScreenForm.Show();
        }



        //validates correct user input for name
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Please enter a valid name without numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
