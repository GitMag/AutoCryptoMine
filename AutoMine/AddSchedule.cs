using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoMine
{
    public partial class AddSchedule : Form
    {
        string ActiveDaysStore;
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddDays_Click(object sender, EventArgs e)
        {
            listboxActiveDays.Items.Add(listBoxAvailableDays.GetItemText(listBoxAvailableDays.SelectedItem)); //add selected day to active days listbox
            listBoxAvailableDays.Items.Remove(listBoxAvailableDays.SelectedItem); //remove day from listbox 1 to 2
        }

        private void buttonRemoveDays_Click(object sender, EventArgs e)
        {
            listBoxAvailableDays.Items.Add(listboxActiveDays.GetItemText(listboxActiveDays.SelectedItem));  //return selected day to available days listbox
            listboxActiveDays.Items.Remove(listboxActiveDays.SelectedItem); //remove day from listbox 2 to 1
        }
        void ReadActiveDays()
        {
            foreach (var item in listboxActiveDays.Items)
            {
                ActiveDaysStore += item.ToString();
            }
        }

        private void buttonSaveProfile_Click(object sender, EventArgs e)
        {
            ReadActiveDays(); //Reads selected days to string
            using (StreamWriter Profile = new StreamWriter(GlobalVariables.AppConfigLoc + @"\profiles\" + textBoxProfileName.Text + ".txt"))
            {
                //write profile to txt file
                Profile.WriteLine(ActiveDaysStore);
                Profile.WriteLine(comboBoxTimeStart.Text);
                Profile.WriteLine(comboBoxTimeStop.Text);
                Profile.WriteLine(textBoxMinerLoc.Text);
                Profile.WriteLine(textBoxConfigLoc.Text);
                Profile.WriteLine(textBoxCustomRun.Text);
                Profile.WriteLine(textBoxCustomClose.Text);
                this.Close();
            }
        }

        private void DialogButton1_Click(object sender, EventArgs e)
        {
            if //Get miner loc to text file
         (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxMinerLoc.Text = openFileDialog1.FileName;                              
            }
        }

        private void DialogButton2_Click(object sender, EventArgs e)
        {
            if //Get config file to textbox
       (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxConfigLoc.Text = openFileDialog1.FileName;
            }
        }

        private void DialogButton3_Click(object sender, EventArgs e)
        {
            if //Get custom run loc to textbox
       (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCustomRun.Text = openFileDialog1.FileName;
            }
        }

        private void DialogButton4_Click(object sender, EventArgs e)
        {
            if //Get custom close to textbox
       (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxCustomClose.Text = openFileDialog1.FileName;
            }
        }
    }
}
