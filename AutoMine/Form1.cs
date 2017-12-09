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
        int MinuteAmount = 0; //variable to store how many seconds is needed to open miner
        int oldXloc = 0; // old location of x mouse
        int newXloc = 0; // new location of x mouse
        string noextnesion = ""; //Miner filename whitout extension
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //runs every 60 seconds
            newXloc = Cursor.Position.X; // get current location
            Console.WriteLine("NewXloc=" + newXloc.ToString() + "OldXLoc=" + oldXloc.ToString());
            if (newXloc == oldXloc)
            {
                MinuteAmount++; //increment by 1 
                
                if (MinuteAmount.ToString() == InactivityTimeTextBox.Text) //check if target reached
                {
                    StartMiner(); // tartget reached, start miner
                }
            }
            else
            {
                MinuteAmount = 0; // set MinuteAmount to zero because movement was detected
                KillMiner(); //kill Miner if it is running
                Console.WriteLine("MinuteAmount Reset");
            }
            oldXloc = Cursor.Position.X; //old location
        }
        public void StartMiner()
        {
           Process.Start(MinerTextBox.Text); //start process from MinerLocation
        }
        public void KillMiner()
        {
            Console.WriteLine("Attempting to kill " + Properties.Settings.Default["AppName"].ToString());
            Process[] processList = Process.GetProcessesByName(Properties.Settings.Default["AppName"].ToString()); //get process name from settings

            if (processList.Length > 0)
            {
                processList[0].Kill(); //kill process
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
            this.Hide();
            this.Opacity = 100;
            delay.Dispose();
        }
    }
}

