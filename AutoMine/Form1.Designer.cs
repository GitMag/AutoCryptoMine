namespace AutoMine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DialogButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActiveProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinerLocationDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.DialogButton2 = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelProfileInfo = new System.Windows.Forms.RichTextBox();
            this.MinerTextBox = new System.Windows.Forms.TextBox();
            this.ConfigTextBox = new System.Windows.Forms.TextBox();
            this.InactivityTimeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBoxCloseProfile = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyProfile = new System.Windows.Forms.CheckBox();
            this.DialogButton4 = new System.Windows.Forms.Button();
            this.textBoxScriptClose = new System.Windows.Forms.TextBox();
            this.checkBoxCustomScriptClose = new System.Windows.Forms.CheckBox();
            this.checkBoxSchedule = new System.Windows.Forms.CheckBox();
            this.StartWithWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.DialogButton3 = new System.Windows.Forms.Button();
            this.textBoxScriptRun = new System.Windows.Forms.TextBox();
            this.checkBoxCustomScriptRun = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelProfileWarn = new System.Windows.Forms.Label();
            this.buttonProfileInfo = new System.Windows.Forms.Button();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxProfileList = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start mining after";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "of inactivity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miner location:";
            // 
            // DialogButton
            // 
            this.DialogButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogButton.Location = new System.Drawing.Point(280, 88);
            this.DialogButton.Name = "DialogButton";
            this.DialogButton.Size = new System.Drawing.Size(43, 31);
            this.DialogButton.TabIndex = 6;
            this.DialogButton.Text = "...";
            this.DialogButton.UseVisualStyleBackColor = true;
            this.DialogButton.Click += new System.EventHandler(this.DialogButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(229, 265);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 31);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "No profile available!";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Auto Crypto Miner";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.viewActiveProfileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 70);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewActiveProfileToolStripMenuItem
            // 
            this.viewActiveProfileToolStripMenuItem.Name = "viewActiveProfileToolStripMenuItem";
            this.viewActiveProfileToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewActiveProfileToolStripMenuItem.Text = "View active profile";
            this.viewActiveProfileToolStripMenuItem.Click += new System.EventHandler(this.viewActiveProfileToolStripMenuItem_Click);
            // 
            // MinerLocationDialog
            // 
            this.MinerLocationDialog.Title = "Select file:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // delay
            // 
            this.delay.Enabled = true;
            this.delay.Tick += new System.EventHandler(this.delay_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Miner config file location:";
            // 
            // DialogButton2
            // 
            this.DialogButton2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogButton2.Location = new System.Drawing.Point(280, 152);
            this.DialogButton2.Name = "DialogButton2";
            this.DialogButton2.Size = new System.Drawing.Size(43, 31);
            this.DialogButton2.TabIndex = 11;
            this.DialogButton2.Text = "...";
            this.DialogButton2.UseVisualStyleBackColor = true;
            this.DialogButton2.Click += new System.EventHandler(this.DialogButton2_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Controls.Add(this.tabPage3);
            this.tabControlSettings.Location = new System.Drawing.Point(6, 6);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(337, 253);
            this.tabControlSettings.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelProfileInfo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MinerTextBox);
            this.tabPage1.Controls.Add(this.ConfigTextBox);
            this.tabPage1.Controls.Add(this.DialogButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DialogButton2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.InactivityTimeTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(329, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelProfileInfo
            // 
            this.labelProfileInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileInfo.Location = new System.Drawing.Point(0, 1);
            this.labelProfileInfo.Name = "labelProfileInfo";
            this.labelProfileInfo.Size = new System.Drawing.Size(326, 220);
            this.labelProfileInfo.TabIndex = 13;
            this.labelProfileInfo.Text = "";
            this.labelProfileInfo.Visible = false;
            // 
            // MinerTextBox
            // 
            this.MinerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoMine.Properties.Settings.Default, "MinerLocationVALUE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinerTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinerTextBox.Location = new System.Drawing.Point(11, 88);
            this.MinerTextBox.Name = "MinerTextBox";
            this.MinerTextBox.Size = new System.Drawing.Size(262, 32);
            this.MinerTextBox.TabIndex = 5;
            this.MinerTextBox.Text = global::AutoMine.Properties.Settings.Default.MinerLocationVALUE;
            // 
            // ConfigTextBox
            // 
            this.ConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoMine.Properties.Settings.Default, "ConfigLocationVALUE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ConfigTextBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigTextBox.Location = new System.Drawing.Point(7, 152);
            this.ConfigTextBox.Name = "ConfigTextBox";
            this.ConfigTextBox.Size = new System.Drawing.Size(266, 32);
            this.ConfigTextBox.TabIndex = 12;
            this.ConfigTextBox.Text = global::AutoMine.Properties.Settings.Default.ConfigLocationVALUE;
            // 
            // InactivityTimeTextBox
            // 
            this.InactivityTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoMine.Properties.Settings.Default, "InactivityTimeVALUE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.InactivityTimeTextBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactivityTimeTextBox.Location = new System.Drawing.Point(154, 9);
            this.InactivityTimeTextBox.Name = "InactivityTimeTextBox";
            this.InactivityTimeTextBox.Size = new System.Drawing.Size(40, 29);
            this.InactivityTimeTextBox.TabIndex = 1;
            this.InactivityTimeTextBox.Text = global::AutoMine.Properties.Settings.Default.InactivityTimeVALUE;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBoxCloseProfile);
            this.tabPage2.Controls.Add(this.checkBoxNotifyProfile);
            this.tabPage2.Controls.Add(this.DialogButton4);
            this.tabPage2.Controls.Add(this.textBoxScriptClose);
            this.tabPage2.Controls.Add(this.checkBoxCustomScriptClose);
            this.tabPage2.Controls.Add(this.checkBoxSchedule);
            this.tabPage2.Controls.Add(this.StartWithWindowsCheckBox);
            this.tabPage2.Controls.Add(this.DialogButton3);
            this.tabPage2.Controls.Add(this.textBoxScriptRun);
            this.tabPage2.Controls.Add(this.checkBoxCustomScriptRun);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseProfile
            // 
            this.checkBoxCloseProfile.AutoSize = true;
            this.checkBoxCloseProfile.Checked = global::AutoMine.Properties.Settings.Default.ProfileCloseVALUE;
            this.checkBoxCloseProfile.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoMine.Properties.Settings.Default, "ProfileCloseVALUE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCloseProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCloseProfile.Location = new System.Drawing.Point(6, 161);
            this.checkBoxCloseProfile.Name = "checkBoxCloseProfile";
            this.checkBoxCloseProfile.Size = new System.Drawing.Size(230, 24);
            this.checkBoxCloseProfile.TabIndex = 10;
            this.checkBoxCloseProfile.Text = "Close app if no profile is selected";
            this.checkBoxCloseProfile.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyProfile
            // 
            this.checkBoxNotifyProfile.AutoSize = true;
            this.checkBoxNotifyProfile.Checked = global::AutoMine.Properties.Settings.Default.ProfileNotifyVALUE;
            this.checkBoxNotifyProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNotifyProfile.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoMine.Properties.Settings.Default, "ProfileNotifyVALUE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxNotifyProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNotifyProfile.Location = new System.Drawing.Point(6, 142);
            this.checkBoxNotifyProfile.Name = "checkBoxNotifyProfile";
            this.checkBoxNotifyProfile.Size = new System.Drawing.Size(201, 24);
            this.checkBoxNotifyProfile.TabIndex = 9;
            this.checkBoxNotifyProfile.Text = "Notify if no profile is selected";
            this.checkBoxNotifyProfile.UseVisualStyleBackColor = true;
            // 
            // DialogButton4
            // 
            this.DialogButton4.Location = new System.Drawing.Point(294, 71);
            this.DialogButton4.Name = "DialogButton4";
            this.DialogButton4.Size = new System.Drawing.Size(29, 23);
            this.DialogButton4.TabIndex = 5;
            this.DialogButton4.Text = "...";
            this.DialogButton4.UseVisualStyleBackColor = true;
            this.DialogButton4.Click += new System.EventHandler(this.DialogButton4_Click_1);
            // 
            // textBoxScriptClose
            // 
            this.textBoxScriptClose.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoMine.Properties.Settings.Default, "CloseScript", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxScriptClose.Location = new System.Drawing.Point(6, 74);
            this.textBoxScriptClose.Name = "textBoxScriptClose";
            this.textBoxScriptClose.Size = new System.Drawing.Size(282, 20);
            this.textBoxScriptClose.TabIndex = 4;
            this.textBoxScriptClose.Text = global::AutoMine.Properties.Settings.Default.CloseScript;
            // 
            // checkBoxCustomScriptClose
            // 
            this.checkBoxCustomScriptClose.AutoSize = true;
            this.checkBoxCustomScriptClose.Checked = global::AutoMine.Properties.Settings.Default.ExecCloseScript;
            this.checkBoxCustomScriptClose.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoMine.Properties.Settings.Default, "ExecCloseScript", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCustomScriptClose.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomScriptClose.Location = new System.Drawing.Point(6, 53);
            this.checkBoxCustomScriptClose.Name = "checkBoxCustomScriptClose";
            this.checkBoxCustomScriptClose.Size = new System.Drawing.Size(261, 24);
            this.checkBoxCustomScriptClose.TabIndex = 3;
            this.checkBoxCustomScriptClose.Text = "Execute custom script when closing miner";
            this.checkBoxCustomScriptClose.UseVisualStyleBackColor = true;
            // 
            // checkBoxSchedule
            // 
            this.checkBoxSchedule.AutoSize = true;
            this.checkBoxSchedule.Checked = global::AutoMine.Properties.Settings.Default.SchedulerENABLED;
            this.checkBoxSchedule.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoMine.Properties.Settings.Default, "SchedulerENABLED", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxSchedule.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSchedule.Location = new System.Drawing.Point(6, 121);
            this.checkBoxSchedule.Name = "checkBoxSchedule";
            this.checkBoxSchedule.Size = new System.Drawing.Size(118, 24);
            this.checkBoxSchedule.TabIndex = 8;
            this.checkBoxSchedule.Text = "Enable profiles";
            this.checkBoxSchedule.UseVisualStyleBackColor = true;
            this.checkBoxSchedule.CheckedChanged += new System.EventHandler(this.checkBoxSchedule_CheckedChanged);
            // 
            // StartWithWindowsCheckBox
            // 
            this.StartWithWindowsCheckBox.AutoSize = true;
            this.StartWithWindowsCheckBox.Checked = global::AutoMine.Properties.Settings.Default.StartWithWindowsVALUE;
            this.StartWithWindowsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoMine.Properties.Settings.Default, "StartWithWindowsVALUE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StartWithWindowsCheckBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartWithWindowsCheckBox.Location = new System.Drawing.Point(6, 100);
            this.StartWithWindowsCheckBox.Name = "StartWithWindowsCheckBox";
            this.StartWithWindowsCheckBox.Size = new System.Drawing.Size(135, 24);
            this.StartWithWindowsCheckBox.TabIndex = 7;
            this.StartWithWindowsCheckBox.Text = "Start with windows";
            this.StartWithWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // DialogButton3
            // 
            this.DialogButton3.Location = new System.Drawing.Point(294, 27);
            this.DialogButton3.Name = "DialogButton3";
            this.DialogButton3.Size = new System.Drawing.Size(29, 23);
            this.DialogButton3.TabIndex = 2;
            this.DialogButton3.Text = "...";
            this.DialogButton3.UseVisualStyleBackColor = true;
            this.DialogButton3.Click += new System.EventHandler(this.DialogButton3_Click);
            // 
            // textBoxScriptRun
            // 
            this.textBoxScriptRun.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoMine.Properties.Settings.Default, "RunScript", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxScriptRun.Location = new System.Drawing.Point(6, 27);
            this.textBoxScriptRun.Name = "textBoxScriptRun";
            this.textBoxScriptRun.Size = new System.Drawing.Size(282, 20);
            this.textBoxScriptRun.TabIndex = 1;
            this.textBoxScriptRun.Text = global::AutoMine.Properties.Settings.Default.RunScript;
            // 
            // checkBoxCustomScriptRun
            // 
            this.checkBoxCustomScriptRun.AutoSize = true;
            this.checkBoxCustomScriptRun.Checked = global::AutoMine.Properties.Settings.Default.ExecRunScript;
            this.checkBoxCustomScriptRun.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoMine.Properties.Settings.Default, "ExecRunScript", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCustomScriptRun.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomScriptRun.Location = new System.Drawing.Point(6, 6);
            this.checkBoxCustomScriptRun.Name = "checkBoxCustomScriptRun";
            this.checkBoxCustomScriptRun.Size = new System.Drawing.Size(261, 24);
            this.checkBoxCustomScriptRun.TabIndex = 0;
            this.checkBoxCustomScriptRun.Text = "Execute custom script when starting miner";
            this.checkBoxCustomScriptRun.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelProfileWarn);
            this.tabPage3.Controls.Add(this.buttonProfileInfo);
            this.tabPage3.Controls.Add(this.buttonEditProfile);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.buttonDeleteProfile);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.listBoxProfileList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(329, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profiles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelProfileWarn
            // 
            this.labelProfileWarn.AutoSize = true;
            this.labelProfileWarn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfileWarn.ForeColor = System.Drawing.Color.Red;
            this.labelProfileWarn.Location = new System.Drawing.Point(4, 158);
            this.labelProfileWarn.Name = "labelProfileWarn";
            this.labelProfileWarn.Size = new System.Drawing.Size(155, 20);
            this.labelProfileWarn.TabIndex = 12;
            this.labelProfileWarn.Text = "Profiles are not enabled!";
            // 
            // buttonProfileInfo
            // 
            this.buttonProfileInfo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfileInfo.Location = new System.Drawing.Point(3, 192);
            this.buttonProfileInfo.Name = "buttonProfileInfo";
            this.buttonProfileInfo.Size = new System.Drawing.Size(75, 32);
            this.buttonProfileInfo.TabIndex = 11;
            this.buttonProfileInfo.Text = "Info";
            this.buttonProfileInfo.UseVisualStyleBackColor = true;
            this.buttonProfileInfo.Click += new System.EventHandler(this.buttonProfileInfo_Click);
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditProfile.Location = new System.Drawing.Point(84, 192);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(75, 32);
            this.buttonEditProfile.TabIndex = 10;
            this.buttonEditProfile.Text = "Edit";
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Profiles:";
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProfile.Location = new System.Drawing.Point(165, 192);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(75, 32);
            this.buttonDeleteProfile.TabIndex = 2;
            this.buttonDeleteProfile.Text = "Delete";
            this.buttonDeleteProfile.UseVisualStyleBackColor = true;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxProfileList
            // 
            this.listBoxProfileList.FormattingEnabled = true;
            this.listBoxProfileList.Location = new System.Drawing.Point(6, 23);
            this.listBoxProfileList.Name = "listBoxProfileList";
            this.listBoxProfileList.Size = new System.Drawing.Size(313, 121);
            this.listBoxProfileList.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(109, 265);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 31);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Don\'t save";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 308);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoMine Settings";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InactivityTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinerTextBox;
        private System.Windows.Forms.Button DialogButton;
        private System.Windows.Forms.CheckBox StartWithWindowsCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog MinerLocationDialog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer delay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DialogButton2;
        private System.Windows.Forms.TextBox ConfigTextBox;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DialogButton4;
        private System.Windows.Forms.TextBox textBoxScriptClose;
        private System.Windows.Forms.CheckBox checkBoxCustomScriptClose;
        private System.Windows.Forms.Button DialogButton3;
        private System.Windows.Forms.TextBox textBoxScriptRun;
        private System.Windows.Forms.CheckBox checkBoxCustomScriptRun;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkBoxSchedule;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxProfileList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonProfileInfo;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.RichTextBox labelProfileInfo;
        private System.Windows.Forms.Label labelProfileWarn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem viewActiveProfileToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxCloseProfile;
        private System.Windows.Forms.CheckBox checkBoxNotifyProfile;
    }
}

