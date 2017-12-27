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
namespace AutoMine
{
    public partial class MainForm : Form
    {
        int MinuteAmount; //variable to store how many seconds is needed to open miner
        int oldXloc; // old location of x mouse
        int newXloc; // new location of x mouse
        bool minerRunning = false; //varibale if miner is running or not
        string noextnesion; //Miner filename whitout extension
        string whereexec = AppDomain.CurrentDomain.BaseDirectory; //gets the directory from where this app is executed
        public MainForm()
        
        {
            InitializeComponent();
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
                noextnesion = Path.GetFileNameWithoutExtension(MinerTextBox.Text); // get filename whitout extension .exe
                Properties.Settings.Default["AppName"] = noextnesion; //store name in settings             
            }
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
            //runs every seconds
            newXloc = Cursor.Position.X; // get current location
            Console.WriteLine("NewXloc=" + newXloc.ToString() + "OldXLoc=" + oldXloc.ToString()); //debug info
            if (newXloc == oldXloc)
            {
                MinuteAmount++; //increment by 1 
                
                if (MinuteAmount.ToString() == InactivityTimeTextBox.Text) //check if target reached
                {
                    StartMiner(); // tartget reached, start miner
                    minerRunning = true; //set value to true
                }
            }
            else
            {
                MinuteAmount = 0; // set MinuteAmount to zero because movement was detected
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
    }
}


