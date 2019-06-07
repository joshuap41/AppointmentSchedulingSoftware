using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace C969_Scheduling_Software_Project.Forms
{
    public partial class ReportsForm : Form
    {
        string newLine = Environment.NewLine;

        public ReportsForm()
        {
            InitializeComponent();

            TypesByMonthRadioButton.Checked = true;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }

        private void ReportsGroupBox_Enter(object sender, EventArgs e)
        {

        }



        #region Types by month report
        public List<string> AppointmentTypesForReport(int month)
        {
            List<string> appointments = new List<string>();

            string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT type FROM appointment WHERE MONTH(start) = @month";
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.ExecuteNonQuery();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(reader["type"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return appointments;
        }

        //Referenced the following code
        //https://docs.microsoft.com/en-us/dotnet/api/system.globalization.datetimeformatinfo.getmonthname?view=netframework-4.8

        private void TypesByMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.consultantTextBox.Hide();
            this.AppointmentsDataGridView.Hide();

            this.ReportsTextBox.Show();
            this.ReportsTextBox.Clear();
            var typesOutput = new StringBuilder();

            for (int m = 1; m <= 12; m++)
            {
                List<string> list = AppointmentTypesForReport(m);

                var j = from t in list
                        group t by t into g
                        let totalNumber = g.Count()
                        orderby totalNumber descending
                        select new { Returned = g.Key, Tally = totalNumber };


                typesOutput.AppendLine();
                typesOutput.AppendLine(DateTimeFormatInfo.CurrentInfo.GetMonthName(m));


                foreach (var t in j)
                {
                    typesOutput.AppendFormat("Type of appointment scheduled: {0} - Appointments of this type:  {1}\n", t.Returned, t.Tally);
                }



                ReportsTextBox.Text = typesOutput.ToString();

            }


        }
        #endregion





        #region Scheddule for each consultant



        private void ScheduleForConsultantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.ReportsTextBox.Hide();
            this.AppointmentsDataGridView.Show();
            this.consultantTextBox.Show();

            MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString);

            MySqlCommand cmd1 = new MySqlCommand("SELECT appointmentId, customerId, start, end FROM appointment", con1);
            con1.Open();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);

            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            AppointmentsDataGridView.DataSource = dt;

            AppointmentsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            con1.Close();

            AppointmentsDataGridView.ClearSelection();
            AppointmentsDataGridView.CurrentCell = null;

            AppointmentsDataGridView.Update();
            AppointmentsDataGridView.Refresh();
        }
        #endregion


        #region Appointment descriptions by month (My Choice)

        public List<string> AppointmentDescriptionsForReport(int month)
        {
            List<string> appointments = new List<string>();

            string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(CS))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT description FROM appointment WHERE MONTH(start) = @month";
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.ExecuteNonQuery();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(reader["description"].ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return appointments;
        }


        private void DescriptionsByMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.consultantTextBox.Hide();
            this.AppointmentsDataGridView.Hide();

            this.ReportsTextBox.Show();
            this.ReportsTextBox.Clear();

            var typesOutput = new StringBuilder();

            for (int m = 1; m <= 12; m++)
            {
                List<string> list = AppointmentDescriptionsForReport(m);

                var j = from t in list
                        group t by t into g
                        let totalNumber = g.Count()
                        orderby totalNumber descending
                        select new { Returned = g.Key, Tally = totalNumber };

                typesOutput.AppendLine();
                typesOutput.AppendLine(DateTimeFormatInfo.CurrentInfo.GetMonthName(m));


                foreach (var t in j)
                {
                    typesOutput.AppendFormat("Description of appointment scheduled: {0} - Appointments of this type:  {1}\n", t.Returned, t.Tally);

                }
            }
            ReportsTextBox.Text = typesOutput.ToString();

        }

        #endregion



        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainScreenForm myMainScreenForm = new MainScreenForm();
            this.Hide();
            myMainScreenForm.Show();
        }

    }
}
