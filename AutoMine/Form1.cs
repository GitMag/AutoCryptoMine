using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using Utilities;
namespace AutoMine
{
    public partial class MainForm : Form // int day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
    {
        globalKeyboardHook gkh = new globalKeyboardHook();
        //Keyboardhook
     
        int oldXloc; // old location of x mouse
        int newXloc; // new location of x mouse
        bool minerRunning = false; //varibale if miner is running or not
        string noextnesion; //Miner filename whitout extension
        string whereexec = AppDomain.CurrentDomain.BaseDirectory; //gets the directory from where this app is executed
        //PROFILE STUFF
        string StopTime; //used by profile checking
        bool allowread = true; //variable that tells if file read is allowed by profile checker
        string _ActiveDays;
        string _startTime;
        string _stopTime;
        string _MinerLoc;
        string _ConfigLoc;
        string _RunLoc;
        string _CloseLoc;
        //END PROFILE STUFF
        public MainForm()

        {
            InitializeComponent();
            gkh.hook();
            this.Opacity = 0; // set form to invisivble
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save(); // Saves settings in config file
            this.Hide();
        }

        private void DialogButton_Click(object sender, EventArgs e)
        {
            if //Get file to textbox
             (MinerLocationDialog.ShowDialog() == DialogResult.OK)
            {
                MinerTextBox.Text = MinerLocationDialog.FileName; // set textbox to display selected program
                GetKillName();
            }     
        }
        void GetKillName()
        {
            noextnesion = Path.GetFileNameWithoutExtension(MinerTextBox.Text); // get filename whitout extension .exe
            Properties.Settings.Default["AppName"] = noextnesion; //store name in settings    
        }
        private void DialogButton2_Click(object sender, EventArgs e)
        {
            if //Get config file to textbox
           (MinerLocationDialog.ShowDialog() == DialogResult.OK)
            {
                ConfigTextBox.Text = MinerLocationDialog.FileName; // set textbox to display selected program
                Properties.Settings.Default["ConfigLocationVALUE"] = ConfigTextBox.Text; //Store name in settings
                Properties.Settings.Default["ConfigName"] = MinerLocationDialog.SafeFileName; //Store only filename in settings                                    
            }
        }
        private void DialogButton3_Click(object sender, EventArgs e)
        {
            if //Get script location to textbox
          (MinerLocationDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxScriptRun.Text = MinerLocationDialog.FileName; // set textbox to display selected program
                Properties.Settings.Default["RunScript"] = textBoxScriptRun.Text; //Store name in settings                               
            }
        }
        private void DialogButton4_Click_1(object sender, EventArgs e)
        {
            if //Get script location to textbox
        (MinerLocationDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxScriptClose.Text = MinerLocationDialog.FileName; // set textbox to display selected program
                Properties.Settings.Default["CloseScript"] = textBoxScriptClose.Text; //Store name in settings                               
            }
        }
        private void DialogButton4_Click(object sender, EventArgs e)
        {
            if //Get script location to textbox
          (MinerLocationDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxScriptClose.Text = MinerLocationDialog.FileName; // set textbox to display selected program
                Properties.Settings.Default["CloseScript"] = textBoxScriptClose.Text; //Store name in settings                               
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //runs every second
            newXloc = Cursor.Position.X; // get current location
            Console.WriteLine("NewXloc=" + newXloc.ToString() + "OldXLoc=" + oldXloc.ToString()); //debug info
            if (newXloc == oldXloc)
            {
                GlobalVariables.MinuteAmount++; //increment by 1 

                if (GlobalVariables.MinuteAmount.ToString() == InactivityTimeTextBox.Text) //check if target reached
                {
                    StartMiner(); // tartget reached, start miner
                    minerRunning = true; //set value to true
                }
            }
            else
            {
                GlobalVariables.MinuteAmount = 0; // set MinuteAmount to zero because movement was detected
                Console.WriteLine("MinuteAmount Reset");
                if (minerRunning == true) //check if miner is running
                {
                    KillMiner(); //kill
                    minerRunning = false; //set value to false
                }
            }
            oldXloc = Cursor.Position.X; //old location
        }
        public void StartMiner()
        {
            System.IO.File.Copy(ConfigTextBox.Text, whereexec + @"\" + Properties.Settings.Default["ConfigName"], true); //copy config file to the directory
            //where app was executed from, this ensurest that the latest config file is being used
            Process.Start(MinerTextBox.Text); //start process from MinerLocation
            if (checkBoxCustomScriptRun.Checked == true) //checks if user wants to run custom script
            {
                Process.Start(textBoxScriptRun.Text);
            }
        }
        public void KillMiner()
        {
            Process[] processList = Process.GetProcessesByName(Properties.Settings.Default["AppName"].ToString()); //get process name from settings
            if (processList.Length > 0)
            {
                processList[0].Kill(); //kill process
            }
            if (checkBoxCustomScriptClose.Checked == true) //checks if user wants to run custom script
            {
                Process.Start(textBoxScriptClose.Text);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            //dealy is needed or otherwise form will note hide
            this.Hide();
            this.Opacity = 100;
            delay.Dispose(); //free memory
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddSchedule AddSchedlueForm = new AddSchedule())
            {
                AddSchedlueForm.ShowDialog(this);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(GlobalVariables.AppConfigLoc + @"\profiles"); //create directory where profiles are saved
            GetKillName();
            if (checkBoxSchedule.Checked == true)
            {
                LoadProfile();// Loads profile
                LoadAllProfile(); //Loads all profiles to listbox
                labelProfileWarn.Hide(); //hide warning, profiles are enabled
            }
        }
        void LoadAllProfile()
        {
            DirectoryInfo d = new DirectoryInfo(GlobalVariables.AppConfigLoc + @"profiles");
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                listBoxProfileList.Items.Add(file.Name.Replace(".txt", ""));
            }
        }


        void LoadProfile()
        {
            int day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek; //get current day of week in numbers
            string dayText = "";
            if (day == 1) //get current day in string
            {
                dayText = "Monday";
            }
            if (day == 2)
            {
                dayText = "Tuesday";
            }
            if (day == 3)
            {
                dayText = "Wednesday";
            }
            if (day == 4)
            {
                dayText = "Thursday";
            }
            if (day == 5)
            {
                dayText = "Friday";
            }
            if (day == 6)
            {
                dayText = "Saturday";
            }
            if (day == 7)
            {
                dayText = "Sunday";
            }
            foreach (string file in Directory.EnumerateFiles(GlobalVariables.AppConfigLoc + @"profiles\", "*.txt")) //read all profiles
            {
                if (allowread == true)
                {

                    string FileDays = File.ReadLines(file).Skip(0).Take(1).First(); //read what day
                    if (FileDays.Contains(dayText)) //if correct day continue
                    {
                        string StartTime = File.ReadLines(file).Skip(1).Take(1).First(); //read profile start time
                        StartTime = StartTime.Replace(":", ""); //replace : with nothing
                        StopTime = File.ReadLines(file).Skip(2).Take(1).First(); //read profile stop time
                        StopTime = StopTime.Replace(":", ""); //replace : with nothing
                       if (Enumerable.Range(Int32.Parse(StartTime), Int32.Parse(StopTime)).Contains(Int32.Parse(DateTime.Now.ToString("HHmm")))) 
                        //compare if current time is between profile values
                        {
                            //matching profile found, load settings
                            MinerTextBox.Text = File.ReadLines(file).Skip(3).Take(1).First(); //get Miner loc
                            ConfigTextBox.Text = File.ReadLines(file).Skip(4).Take(1).First(); //get config loc
                            textBoxScriptRun.Text = File.ReadLines(file).Skip(5).Take(1).First(); //get start script loc
                            textBoxScriptClose.Text = File.ReadLines(file).Skip(6).Take(1).First(); //get stop script loc
                            allowread = false; //dont allow read
                            labelProfileInfo.Show();
                            labelProfileInfo.Text = "Profile loaded: " + file + "\nProfile info: \n" + "Start time: " + StartTime + "\n" + "Stop time:" + StopTime + "\nMiner location: " + MinerTextBox.Text +
                            "\nConfig location:" + ConfigTextBox.Text + "\nStart script:" + textBoxScriptRun.Text + "\nClose script:" + textBoxScriptClose.Text;
                            //show info to user about profile  
                            timer2.Start(); //start timer to check when profile ends                    
                        }
                    }
                }
            }
            if (allowread == true)
            {
                //No profile found even tough profiles are enabled
                viewActiveProfileToolStripMenuItem.Enabled = false;
                if (checkBoxNotifyProfile.Checked == true) //tell user about problem
                {
                    MessageBox.Show("You have profiles enabled but no profile matches: " + dayText + ", " + DateTime.Now.ToString("HH:mm"), "Info");
                }
                if (checkBoxCloseProfile.Checked == true) //close app
                {
                    Application.Exit();
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBoxSchedule_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSchedule.Checked == false) //disply user warning , profiles not enabled
            {
                labelProfileWarn.Show();
            }
            else
            {
                labelProfileWarn.Hide();
            }
        }

        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you delete this profile it can not be restored.\nAre you sure?", "Delete profile?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(GlobalVariables.AppConfigLoc + @"profiles\" + listBoxProfileList.GetItemText(listBoxProfileList.SelectedItem) + ".txt");
                listBoxProfileList.Items.Remove(listBoxProfileList.SelectedItem);
            }
        }

        private void buttonProfileInfo_Click(object sender, EventArgs e)
        {
            GatherProfileInfo(); //Gather info about selected profile
            MessageBox.Show("Profile info:\nActive days:" + _ActiveDays + "\nStart time:" + _startTime + 
            "\nStop time:" + _stopTime + "\nMiner location:" + _MinerLoc + "\nConfig location:" + _ConfigLoc +
             "\nStart script location:" + _RunLoc + "\nStop script location:" + _CloseLoc, "Profile information");
        }
        void GatherProfileInfo()
        {
            string file = GlobalVariables.AppConfigLoc + @"profiles\" + listBoxProfileList.GetItemText(listBoxProfileList.SelectedItem + ".txt"); //read profile
            _ActiveDays = File.ReadLines(file).Skip(0).Take(1).First();
            _startTime = File.ReadLines(file).Skip(1).Take(1).First();
            _stopTime = File.ReadLines(file).Skip(2).Take(1).First();
            _MinerLoc = File.ReadLines(file).Skip(3).Take(1).First();
            _ConfigLoc = File.ReadLines(file).Skip(4).Take(1).First();
            _RunLoc = File.ReadLines(file).Skip(5).Take(1).First();
            _CloseLoc = File.ReadLines(file).Skip(6).Take(1).First();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //Profile checker timer
            //runs every minute      
                if (Int32.Parse(StopTime) == Int32.Parse(DateTime.Now.ToString("HHmm")))
                {
                    LoadProfile();
                }
        }

        private void viewActiveProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GatherProfileInfo(); //Gather info about selected profile
            MessageBox.Show("Profile info:\nActive days:" + _ActiveDays + "\nStart time:" + _startTime +
            "\nStop time:" + _stopTime + "\nMiner location:" + _MinerLoc + "\nConfig location:" + _ConfigLoc +
             "\nStart script location:" + _RunLoc + "\nStop script location:" + _CloseLoc, "Profile information");
        }
    }

}
public static class GlobalVariables
{
    public static string AppConfigLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\AutoCryptoMine\";
    public static int MinuteAmount; //variable to store how many seconds is needed to open miner
}


