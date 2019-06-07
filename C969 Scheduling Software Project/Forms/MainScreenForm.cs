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
using System.Globalization;

namespace C969_Scheduling_Software_Project.Forms
{
    public partial class MainScreenForm : Form
    {
        public static int currentUserId = 1;
        public static string currentUser = "test";

        public static int currentCustomerId = -1;
        public static int currentAddressId = -1;
        public static int currentAppointmentId = -1;


        public static string today3 = DateTime.Now.Date.ToString("yyyy-MM-dd");
        

        public MainScreenForm()
        {
            InitializeComponent();
        }



        public void MainScreenForm_Load(object sender, EventArgs e)
        {

            //Fills the CustomersDataGridView
            MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString); //Creates the connection and passes in the connection string parameter
            MySqlCommand cmd = new MySqlCommand("SELECT customerName, customerId, addressId FROM customer ;", con); //Creates the command and passes it in the parameters (Cmd, connection)
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);   //instantiates the connection and passes in the Sql cmd
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            CustomersDataGridView.DataSource = ds;
            CustomersDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            con.Close();
            CustomersDataGridView.ClearSelection();
            CustomersDataGridView.CurrentCell = null;

            //Fills the AppointmentsDataGridView
            AllAppointmentsRadioButton.Checked = true;
        }



        #region DataGridViews

        private void CustomersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentCustomerId = (int)CustomersDataGridView.Rows[e.RowIndex].Cells[1].Value;
                currentAddressId = (int)CustomersDataGridView.Rows[e.RowIndex].Cells[2].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a valid customer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currentAppointmentId = (int)AppointmentsDataGridView.Rows[e.RowIndex].Cells[0].Value;
                currentCustomerId = (int)AppointmentsDataGridView.Rows[e.RowIndex].Cells[1].Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a valid appointment.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion


        #region Customer AMD

        private void CustomersAddButton_Click_1(object sender, EventArgs e)
        {
            AddCustomersForm MyAddCustomersForm = new AddCustomersForm();
            this.Hide();
            MyAddCustomersForm.Show();
        }

        private void CustomersModifyButton_Click_1(object sender, EventArgs e)
        {
            if (CustomersDataGridView.CurrentCell == null)
            {
                MessageBox.Show("Please select a customer to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ModifyCustomerForm MyModifyCustomerForm = new ModifyCustomerForm();
                this.Hide();
                MyModifyCustomerForm.Show();
            }
        }

        private void CustomersDeleteButton_Click(object sender, EventArgs e)
        {

            if (CustomersDataGridView.CurrentCell == null)
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(CS))
                {
                    MySqlCommand cmd = new MySqlCommand();

                    //Set Foreign Key Checks to correct uCertify DB issues
                    cmd.CommandText = "SET FOREIGN_KEY_CHECKS = 0;DELETE FROM customer WHERE customerId = @customerId;SET FOREIGN_KEY_CHECKS = 1;";
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@customerId", currentCustomerId);
                    cmd.ExecuteNonQuery();
                }
                MainScreenForm myMainScreenForm = new MainScreenForm();
                this.Hide();
                myMainScreenForm.Show();
            }

        }
        #endregion


        #region Appointment AMD

        private void AppointmentsAddButton_Click(object sender, EventArgs e)
        {
            if (CustomersDataGridView.CurrentCell == null)
            {
                MessageBox.Show("Please select a customer to add an appointment to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                AddAppointmentForm MyAddAppointmentsForm = new AddAppointmentForm();
                this.Hide();
                MyAddAppointmentsForm.Show();
            }
        }

        private void AppointmentsModifyButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDataGridView.CurrentCell == null)
            {
                MessageBox.Show("Please select an appointment to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ModifyAppointmentForm MyModifyAPpointmentsForm = new ModifyAppointmentForm();
                this.Hide();
                MyModifyAPpointmentsForm.Show();
            }
        }

        private void AppointmentsDeleteButton_Click(object sender, EventArgs e)
        {
            if (AppointmentsDataGridView.CurrentCell == null)
            {
                MessageBox.Show("Please select an appointment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;
                using (MySqlConnection con = new MySqlConnection(CS))
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
                    cmd.Connection = con;
                    con.Open();
                    cmd.Parameters.AddWithValue("@appointmentId", currentAppointmentId);
                    cmd.ExecuteNonQuery();
                }
                MainScreenForm myMainScreenForm = new MainScreenForm();
                this.Hide();
                myMainScreenForm.Show();
            }
        }
        #endregion

        

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            ReportsForm myReportsForm = new ReportsForm();
            this.Hide();
            myReportsForm.Show();
        }

        #region Appointment Radio Buttons

        //https://stackoverflow.com/questions/4097127/getting-date-or-time-only-from-a-datetime-object



        private void AllAppointmentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString);

            MySqlCommand cmd1 = new MySqlCommand("SELECT appointmentId, customerId, start, end, type FROM appointment", con1);
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

        private void CurrentMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var nextMonth = DateTime.Now.AddDays(31).ToString("yyyy-MM-dd");

            //var today = DateTime.Now.Date.ToString("yyyy-MM-dd");

            String Query = "SELECT appointmentId, customerId, start, end, type FROM appointment WHERE start BETWEEN '" + today3 + "' AND '" + nextMonth + "';";

            MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString);
            MySqlCommand cmd1 = new MySqlCommand(Query, con1);
            con1.Open();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);

            DataTable ds1 = new DataTable();
            adapter1.Fill(ds1);
            AppointmentsDataGridView.DataSource = ds1;
            AppointmentsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            con1.Close();
            AppointmentsDataGridView.ClearSelection();
            AppointmentsDataGridView.CurrentCell = null;

            AppointmentsDataGridView.Update();
            AppointmentsDataGridView.Refresh();
        }

        private void CurrentWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            var nextWeek = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");

            //var today = DateTime.Now.Date.ToString("yyyy-MM-dd");

            String Query = "SELECT appointmentId, customerId, start, end, type FROM appointment WHERE start BETWEEN '" + today3 + "' AND '" + nextWeek + "';";

            MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString);
            MySqlCommand cmd1 = new MySqlCommand(Query, con1);
            con1.Open();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);

            DataTable ds1 = new DataTable();
            adapter1.Fill(ds1);
            AppointmentsDataGridView.DataSource = ds1;
            AppointmentsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            con1.Close();
            AppointmentsDataGridView.ClearSelection();
            AppointmentsDataGridView.CurrentCell = null;

            AppointmentsDataGridView.Update();
            AppointmentsDataGridView.Refresh();
        }
        #endregion


        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Click OK to confirm exit.", "Main Screen Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void AppointmentsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) 
        {
            if (e.Value is DateTime)
            {
                DateTime dateValue = (DateTime)e.Value;
                switch (dateValue.Kind)
                {
                    case DateTimeKind.Local:
                        break;
                    case DateTimeKind.Unspecified:
                        e.Value = DateTime.SpecifyKind(dateValue, DateTimeKind.Utc).ToLocalTime();
                        break;
                    case DateTimeKind.Utc:
                        e.Value = dateValue.ToLocalTime();
                        break;
                }
            }
        }

        private void AppointmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
