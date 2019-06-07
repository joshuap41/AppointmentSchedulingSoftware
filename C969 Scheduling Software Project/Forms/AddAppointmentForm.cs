using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace C969_Scheduling_Software_Project.Forms
{
    public partial class AddAppointmentForm : Form
    {
        int overlappingAppointment = -1;


        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            CustomerIdTextBox.Text = MainScreenForm.currentCustomerId.ToString();
        }


        //checking for overlap
        //newApptStartTime, newApptEndTime, dbApptStartTime, dbApptEndTime
        bool Overlap(TimeSpan a1, TimeSpan a2, TimeSpan a3, TimeSpan a4)
        {

            //string s = a1.ToString() + "     " +

            //    a2.ToString() + "     " +

            //    a3.ToString() + "     " +

            //    a4.ToString();

            //MessageBox.Show(s);


            //if newApptStart is between dbApptStart and dbApptEnd then Overlap
            // a3     a1     a4

            if (a3 <= a1 && a1 <= a4)
            {
                overlappingAppointment = 1;
                return true;
            }
            else if (a3 <= a2 && a2 <= a4)
            {
                overlappingAppointment = 1;
                return true;
            }
            else
            {
                overlappingAppointment = 0;
                return false;
            }
        }




        private void SaveButton_Click(object sender, EventArgs e)
        {
            //gives me the current time to input into the DB
            DateTime dateTimeNow = DateTime.Now;
            string strMaxFormat = dateTimeNow.ToString("yyyy-MM-dd HH:mm:ss tt");//24 hours format hh gets 12 format


            try
            {
                DateTime newApptStart = Convert.ToDateTime(StartTimePicker.Text);
                DateTime xyz = newApptStart.ToUniversalTime(); //datetime to adjust date
                var s = xyz.ToString("yyyy-MM-dd");


                DateTime newApptEnd = Convert.ToDateTime(EndTimePicker.Text);
                var newApptStartTime = newApptStart - newApptStart.Date;
                var newApptEndTime = newApptEnd - newApptEnd.Date;

                string query = "SELECT * from appointment where customerId = " + MainScreenForm.currentCustomerId
                    + " and start >= '" + s + " 00:00:00' and start < '" +
                    s + " 23:59:59'";

                string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;

                DataTable dt = new DataTable();

                using (MySqlConnection con = new MySqlConnection(CS))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter adaptToMySQL = new MySqlDataAdapter(selectCommand: cmd);
                    adaptToMySQL.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //changes the database time and date to local time
                        DateTime dbApptStart = (DateTime)dt.Rows[i]["start"];
                        dbApptStart = dbApptStart.ToLocalTime();
                        DateTime dbApptEnd = (DateTime)dt.Rows[i]["end"];
                        dbApptEnd = dbApptEnd.ToLocalTime();

                        var dbApptStartTime = dbApptStart - dbApptStart.Date;
                        var dbApptEndTime = dbApptEnd - dbApptEnd.Date;

                        if (Overlap(newApptStartTime, newApptEndTime, dbApptStartTime, dbApptEndTime))
                        {
                            //MessageBox.Show("The Appointment times cannot overlap", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                if (CustomerIdTextBox.Text == "" || DescriptionTextBox.Text == "" || TypeListBox.Text == "" || StartTimePicker.Text == "" || EndTimePicker.Text == "")
                {
                    MessageBox.Show("Please enter values for all fields", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (StartTimePicker.Value >= EndTimePicker.Value)
                {
                    MessageBox.Show("Start time must be before the end time", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (overlappingAppointment == 1)
                {
                    MessageBox.Show("The Appointment times cannot overlap", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    overlappingAppointment = 0;
                }
                else
                {
                    //string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;
                    using (MySqlConnection con = new MySqlConnection(CS))
                    {
                        MySqlCommand cmd = new MySqlCommand();

                        cmd.CommandText = "INSERT INTO appointment (customerId, description, type, start, end, createDate, createdBy, lastUpdateBy, userId) " +
                                          "VALUES (@CustomerIdTextBox, @DescriptionTextBox, @TypeListBox, @StartTimePicker, @EndTimePicker, @createDate, @CreatedBy, @lastUpdateBy, @UserId);";
                        cmd.Connection = con;
                        con.Open();
                        cmd.Parameters.AddWithValue("@CustomerIdTextBox", MainScreenForm.currentCustomerId);
                        cmd.Parameters.AddWithValue("@DescriptionTextBox", DescriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("@TypeListBox", TypeListBox.Text);
                        cmd.Parameters.AddWithValue("@StartTimePicker", Convert.ToDateTime(StartTimePicker.Value).ToUniversalTime());
                        cmd.Parameters.AddWithValue("@EndTimePicker", Convert.ToDateTime(EndTimePicker.Value).ToUniversalTime());
                        cmd.Parameters.AddWithValue("@CreateDate", Convert.ToDateTime(strMaxFormat).ToUniversalTime());
                        cmd.Parameters.AddWithValue("@CreatedBy", MainScreenForm.currentUser);
                        cmd.Parameters.AddWithValue("@LastUpdateBy", MainScreenForm.currentUser);
                        cmd.Parameters.AddWithValue("@UserId", MainScreenForm.currentUserId);
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
            this.Close();
            MyMainScreenForm.Show();
        }

        //catch user input for out of office hours
        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var min = new TimeSpan(9, 00, 00);
            if (StartTimePicker.Value.TimeOfDay < min)
            {
                MessageBox.Show("Office hours start at 9:00 am.");
                StartTimePicker.Value = StartTimePicker.Value.Date + min;
            }
        }

        private void EndTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var max = new TimeSpan(17, 00, 00);
            if (EndTimePicker.Value.TimeOfDay > max)
            {
                MessageBox.Show("Office hour are until 5:00 pm.");
                EndTimePicker.Value = EndTimePicker.Value.Date + max;
            }
        }

        private void TypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
