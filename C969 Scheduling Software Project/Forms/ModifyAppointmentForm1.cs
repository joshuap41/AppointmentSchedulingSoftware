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
    public partial class ModifyAppointmentForm : Form
    {
        int overlappingAppointment = 0;

        string tempStartTime = "";
        string tempEndTime = "";

        public ModifyAppointmentForm()
        {
            InitializeComponent();
        }



        private void ModifyAppointmentForm_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(CS))
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment WHERE appointmentId='" + MainScreenForm.currentAppointmentId + "'", con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    CustomerIdTextBox.Text = reader["customerId"].ToString();
                    DescriptionTextBox.Text = reader["description"].ToString();
                    TypeListBox.Text = reader["type"].ToString();

                    DateTime current = (DateTime)reader["start"];
                    current = current.ToLocalTime();
                    StartTimePicker.Text = current.ToString();
                    tempStartTime = StartTimePicker.Text;


                    DateTime curEnd = (DateTime)reader["end"];
                    curEnd = curEnd.ToLocalTime();
                    EndTimePicker.Text = curEnd.ToString();
                    tempEndTime = EndTimePicker.Text;

                }
                else
                {
                    MessageBox.Show("Something went wrong in address!");
                }
            }
        }





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
            //if newApptEnd is between dbApptStart and dbApptEnd then Overlap

        }



        private void SaveButton_Click(object sender, EventArgs e)
        {
            //gives me the current time to input into the DB
            DateTime dateTimeNow = DateTime.Now;
            string strMaxFormat = dateTimeNow.ToString("yyyy-MM-dd HH:mm:ss tt");//24 hours format hh gets 12 format
            try
            {
                try
                {
                    if (tempStartTime == StartTimePicker.Text && tempEndTime == EndTimePicker.Text)
                    {

                    }
                    else
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
                                int appId = (int)dt.Rows[i]["appointmentId"];

                                if (appId == MainScreenForm.currentAppointmentId)
                                {

                                }
                                else
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
                                        overlappingAppointment = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
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
                    string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;

                    using (MySqlConnection con = new MySqlConnection(CS))
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0; UPDATE appointment SET appointmentId = @AppointmentId, customerId = @CustomerId, description = @Description, type = @TypeListBox, start = @StartTimePicker, end = @EndTimePicker WHERE appointmentId = @AppointmentId; SET FOREIGN_KEY_CHECKS = 1;";
                        cmd.Connection = con;
                        con.Open();
                        cmd.Parameters.AddWithValue("@AppointmentId", MainScreenForm.currentAppointmentId);
                        cmd.Parameters.AddWithValue("@CustomerId", CustomerIdTextBox.Text);
                        cmd.Parameters.AddWithValue("@Description", DescriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("@TypeListBox", TypeListBox.Text);
                        cmd.Parameters.AddWithValue("@StartTimePicker", Convert.ToDateTime(StartTimePicker.Value).ToUniversalTime());
                        cmd.Parameters.AddWithValue("@EndTimePicker", Convert.ToDateTime(EndTimePicker.Value).ToUniversalTime());
                        cmd.Parameters.AddWithValue("@CreateDate", MainScreenForm.today3);
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


        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainScreenForm MyMainScreen = new MainScreenForm();
            this.Hide();
            MyMainScreen.Show();
        }

        private void TypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
    }
}
