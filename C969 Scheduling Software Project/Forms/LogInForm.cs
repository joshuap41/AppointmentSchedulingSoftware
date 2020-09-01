using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.IO;

namespace C969_Scheduling_Software_Project.Forms
{
    public partial class LogInForm : Form
    {
        public string DbUserName { get; private set; }
        public string DbPassword { get; private set; }


        String ErrorMessage = "";
        String FormType = "";

        private StreamWriter fileWriter;
        string fileName = "C969SchedulingSoftwareProjectLogin.txt";

        public LogInForm()
        {
            InitializeComponent();
        }



        private void LogInForm_Load(object sender, EventArgs e)
        {
            CorrectLanguage();

            string CS = ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(CS))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE userId= 1", con);
                    con.Open();
                    MySqlDataReader re = cmd.ExecuteReader();
                    if (re.Read())
                    {
                        DbUserName = re["userName"].ToString();
                        DbPassword = re["password"].ToString();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }



        #region Change Language on Signin form
        //Referenced this material for globalization
        //https://docs.microsoft.com/en-us/dotnet/api/system.globalization.regioninfo.displayname?view=netframework-4.8

        private void CorrectLanguage()
        {
            String RegionType = RegionInfo.CurrentRegion.EnglishName;

            try
            {
                if (RegionType == "United States")
                {
                    DisplayEnglish();
                }
                else if (RegionType == "France")
                {
                    LoginGroupBox.Text = "Informations de connexion";
                    SignInButton.Text = "Se connecter";
                    ExitButton.Text = "Sortie";
                    UsernameLabel.Text = "Nom d'utilisateur";
                    PasswordLabel.Text = "Mot de passe";
                    ErrorMessage = "Veuillez entrer le nom d'utilisateur et le mot de passe corrects";
                    FormType = "Formulaire de connexion";
                    this.Text = "S'identifier";
                }
                else
                {
                    DisplayEnglish();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DisplayEnglish()
        {
            LoginGroupBox.Text = "Login Information";
            SignInButton.Text = "Sign In";
            ExitButton.Text = "Exit";
            UsernameLabel.Text = "Username";
            PasswordLabel.Text = "Password";
            ErrorMessage = "Please enter the correct Username and Password";
            FormType = "Log In Form";
            this.Text = "Login";
        }
        #endregion

        
        private void SignInButton_Click(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.Now;
            string strMaxFormat = dateTimeNow.ToString("yyyy-MM-dd HH:mm:ss tt");//24 hours format hh gets 12 format
            
            try
            {
                if (UsernameTextBox.Text == DbUserName && PasswordTextBox.Text == DbPassword)
                {

                    try
                    {
                        //logs the login information
                        //saves for me at: C:\Users\joshu\Google Drive\Visual Studio Projects\C969 Scheduling Software Project_05312019\C969 Scheduling Software Project\bin\Debug\C969SchedulingSoftwareProjectLogin.txt
                        FileStream outp = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                        fileWriter = new StreamWriter(outp);
                        fileWriter.WriteLine("Time of login: " + strMaxFormat + ".   Current Logged in user: " + MainScreenForm.currentUser + ".   Login was a success!");
                        fileWriter.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot write to local file");
                    }

                    

                    //checks for an appointment within 15 minutes of login
                    MySqlConnection con1 = new MySqlConnection(ConfigurationManager.ConnectionStrings["U04i5a"].ConnectionString);

                    MySqlCommand cmd1 = new MySqlCommand("SELECT * from appointment;", con1);
                    con1.Open();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(cmd1);

                    DataTable dt = new DataTable();
                    adapter1.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //changes the database time and date to local time
                        DateTime dbApptStart = (DateTime)dt.Rows[i]["start"];
                        dbApptStart = dbApptStart.ToLocalTime();
                        
                        TimeSpan span = dbApptStart.Subtract(dateTimeNow);
                        Console.WriteLine("Time Difference (minutes): " + span.TotalMinutes);

                        if (span.TotalMinutes < 15 && span.TotalMinutes > 0)
                        {
                            MessageBox.Show("You have an appointment within 15 minutes.");
                            break;
                        }
                    }
                    MainScreenForm MyMainScreenForm = new MainScreenForm();
                    this.Hide();
                    MyMainScreenForm.Show();
                }
                else
                {
                    try
                    {
                        //logs the login information
                        //saves for me at: C:\Users\joshu\Google Drive\Visual Studio Projects\C969 Scheduling Software Project_05312019\C969 Scheduling Software Project\bin\Debug\C969SchedulingSoftwareProjectLogin.txt
                        FileStream outp = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                        fileWriter = new StreamWriter(outp);
                        fileWriter.WriteLine("Time of login: " + strMaxFormat + ".   Current Logged in user: " + MainScreenForm.currentUser + ".   Login was not a success!");
                        fileWriter.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot write to local file");
                    }


                    //login error information to the user
                    MessageBox.Show(ErrorMessage, FormType, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                    return;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
