namespace HitmanStatistics {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.LB_ShotsFired = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LB_Running = new System.Windows.Forms.Label();
            this.NB_ShotsFired = new System.Windows.Forms.Label();
            this.NB_CloseEncounters = new System.Windows.Forms.Label();
            this.LB_CloseEncounters = new System.Windows.Forms.Label();
            this.NB_Alerts = new System.Windows.Forms.Label();
            this.LB_Alerts = new System.Windows.Forms.Label();
            this.NB_EnemiesKilled = new System.Windows.Forms.Label();
            this.LB_EnemiesKilled = new System.Windows.Forms.Label();
            this.NB_InnocentsKilled = new System.Windows.Forms.Label();
            this.LB_InnocentsKilled = new System.Windows.Forms.Label();
            this.LB_Time = new System.Windows.Forms.Label();
            this.LB_MapName = new System.Windows.Forms.Label();
            this.NB_Headshots = new System.Windows.Forms.Label();
            this.LB_Headshots = new System.Windows.Forms.Label();
            this.NB_EnemiesHarmed = new System.Windows.Forms.Label();
            this.LB_EnemiesHarmed = new System.Windows.Forms.Label();
            this.NB_InnocentsHarmed = new System.Windows.Forms.Label();
            this.LB_InnocentsHarmed = new System.Windows.Forms.Label();
            this.LB_Timer = new System.Windows.Forms.Label();
            this.LB_SilentAssassin = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.Menu_Game = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Game_H2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Game_H3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IMG_SA = new System.Windows.Forms.Panel();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_ShotsFired
            // 
            this.LB_ShotsFired.AutoSize = true;
            this.LB_ShotsFired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ShotsFired.Location = new System.Drawing.Point(46, 127);
            this.LB_ShotsFired.Name = "LB_ShotsFired";
            this.LB_ShotsFired.Size = new System.Drawing.Size(86, 20);
            this.LB_ShotsFired.TabIndex = 0;
            this.LB_ShotsFired.Text = "Shots fired";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LB_Running
            // 
            this.LB_Running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Running.ForeColor = System.Drawing.Color.Red;
            this.LB_Running.Location = new System.Drawing.Point(0, 32);
            this.LB_Running.Name = "LB_Running";
            this.LB_Running.Size = new System.Drawing.Size(302, 24);
            this.LB_Running.TabIndex = 1;
            this.LB_Running.Text = "HITMAN 2 IS NOT RUNNING";
            this.LB_Running.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NB_ShotsFired
            // 
            this.NB_ShotsFired.AutoSize = true;
            this.NB_ShotsFired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_ShotsFired.ForeColor = System.Drawing.Color.Blue;
            this.NB_ShotsFired.Location = new System.Drawing.Point(12, 127);
            this.NB_ShotsFired.Name = "NB_ShotsFired";
            this.NB_ShotsFired.Size = new System.Drawing.Size(19, 20);
            this.NB_ShotsFired.TabIndex = 7;
            this.NB_ShotsFired.Tag = "Value";
            this.NB_ShotsFired.Text = "0";
            // 
            // NB_CloseEncounters
            // 
            this.NB_CloseEncounters.AutoSize = true;
            this.NB_CloseEncounters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_CloseEncounters.ForeColor = System.Drawing.Color.Blue;
            this.NB_CloseEncounters.Location = new System.Drawing.Point(12, 147);
            this.NB_CloseEncounters.Name = "NB_CloseEncounters";
            this.NB_CloseEncounters.Size = new System.Drawing.Size(19, 20);
            this.NB_CloseEncounters.TabIndex = 9;
            this.NB_CloseEncounters.Tag = "Value";
            this.NB_CloseEncounters.Text = "0";
            // 
            // LB_CloseEncounters
            // 
            this.LB_CloseEncounters.AutoSize = true;
            this.LB_CloseEncounters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CloseEncounters.Location = new System.Drawing.Point(46, 147);
            this.LB_CloseEncounters.Name = "LB_CloseEncounters";
            this.LB_CloseEncounters.Size = new System.Drawing.Size(133, 20);
            this.LB_CloseEncounters.TabIndex = 8;
            this.LB_CloseEncounters.Text = "Close encounters";
            // 
            // NB_Alerts
            // 
            this.NB_Alerts.AutoSize = true;
            this.NB_Alerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_Alerts.ForeColor = System.Drawing.Color.Blue;
            this.NB_Alerts.Location = new System.Drawing.Point(12, 187);
            this.NB_Alerts.Name = "NB_Alerts";
            this.NB_Alerts.Size = new System.Drawing.Size(19, 20);
            this.NB_Alerts.TabIndex = 13;
            this.NB_Alerts.Tag = "Value";
            this.NB_Alerts.Text = "0";
            // 
            // LB_Alerts
            // 
            this.LB_Alerts.AutoSize = true;
            this.LB_Alerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Alerts.Location = new System.Drawing.Point(46, 187);
            this.LB_Alerts.Name = "LB_Alerts";
            this.LB_Alerts.Size = new System.Drawing.Size(50, 20);
            this.LB_Alerts.TabIndex = 12;
            this.LB_Alerts.Text = "Alerts";
            // 
            // NB_EnemiesKilled
            // 
            this.NB_EnemiesKilled.AutoSize = true;
            this.NB_EnemiesKilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_EnemiesKilled.ForeColor = System.Drawing.Color.Blue;
            this.NB_EnemiesKilled.Location = new System.Drawing.Point(12, 207);
            this.NB_EnemiesKilled.Name = "NB_EnemiesKilled";
            this.NB_EnemiesKilled.Size = new System.Drawing.Size(19, 20);
            this.NB_EnemiesKilled.TabIndex = 15;
            this.NB_EnemiesKilled.Tag = "Value";
            this.NB_EnemiesKilled.Text = "0";
            // 
            // LB_EnemiesKilled
            // 
            this.LB_EnemiesKilled.AutoSize = true;
            this.LB_EnemiesKilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnemiesKilled.Location = new System.Drawing.Point(46, 207);
            this.LB_EnemiesKilled.Name = "LB_EnemiesKilled";
            this.LB_EnemiesKilled.Size = new System.Drawing.Size(112, 20);
            this.LB_EnemiesKilled.TabIndex = 14;
            this.LB_EnemiesKilled.Text = "Enemies Killed";
            // 
            // NB_InnocentsKilled
            // 
            this.NB_InnocentsKilled.AutoSize = true;
            this.NB_InnocentsKilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_InnocentsKilled.ForeColor = System.Drawing.Color.Blue;
            this.NB_InnocentsKilled.Location = new System.Drawing.Point(12, 247);
            this.NB_InnocentsKilled.Name = "NB_InnocentsKilled";
            this.NB_InnocentsKilled.Size = new System.Drawing.Size(19, 20);
            this.NB_InnocentsKilled.TabIndex = 17;
            this.NB_InnocentsKilled.Tag = "Value";
            this.NB_InnocentsKilled.Text = "0";
            // 
            // LB_InnocentsKilled
            // 
            this.LB_InnocentsKilled.AutoSize = true;
            this.LB_InnocentsKilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_InnocentsKilled.Location = new System.Drawing.Point(46, 247);
            this.LB_InnocentsKilled.Name = "LB_InnocentsKilled";
            this.LB_InnocentsKilled.Size = new System.Drawing.Size(121, 20);
            this.LB_InnocentsKilled.TabIndex = 16;
            this.LB_InnocentsKilled.Text = "Innocents Killed";
            // 
            // LB_Time
            // 
            this.LB_Time.AutoSize = true;
            this.LB_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.ForeColor = System.Drawing.Color.DimGray;
            this.LB_Time.Location = new System.Drawing.Point(61, 95);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(90, 22);
            this.LB_Time.TabIndex = 21;
            this.LB_Time.Text = "00:00,000";
            // 
            // LB_MapName
            // 
            this.LB_MapName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MapName.Location = new System.Drawing.Point(0, 63);
            this.LB_MapName.Name = "LB_MapName";
            this.LB_MapName.Size = new System.Drawing.Size(302, 32);
            this.LB_MapName.TabIndex = 22;
            this.LB_MapName.Text = "No mission currently oi,jerlmkg,qmelrk,glmq";
            this.LB_MapName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NB_Headshots
            // 
            this.NB_Headshots.AutoSize = true;
            this.NB_Headshots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_Headshots.ForeColor = System.Drawing.Color.Blue;
            this.NB_Headshots.Location = new System.Drawing.Point(12, 167);
            this.NB_Headshots.Name = "NB_Headshots";
            this.NB_Headshots.Size = new System.Drawing.Size(19, 20);
            this.NB_Headshots.TabIndex = 24;
            this.NB_Headshots.Tag = "Value";
            this.NB_Headshots.Text = "0";
            // 
            // LB_Headshots
            // 
            this.LB_Headshots.AutoSize = true;
            this.LB_Headshots.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Headshots.Location = new System.Drawing.Point(46, 167);
            this.LB_Headshots.Name = "LB_Headshots";
            this.LB_Headshots.Size = new System.Drawing.Size(87, 20);
            this.LB_Headshots.TabIndex = 23;
            this.LB_Headshots.Text = "Headshots";
            // 
            // NB_EnemiesHarmed
            // 
            this.NB_EnemiesHarmed.AutoSize = true;
            this.NB_EnemiesHarmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_EnemiesHarmed.ForeColor = System.Drawing.Color.Blue;
            this.NB_EnemiesHarmed.Location = new System.Drawing.Point(12, 227);
            this.NB_EnemiesHarmed.Name = "NB_EnemiesHarmed";
            this.NB_EnemiesHarmed.Size = new System.Drawing.Size(19, 20);
            this.NB_EnemiesHarmed.TabIndex = 26;
            this.NB_EnemiesHarmed.Tag = "Value";
            this.NB_EnemiesHarmed.Text = "0";
            // 
            // LB_EnemiesHarmed
            // 
            this.LB_EnemiesHarmed.AutoSize = true;
            this.LB_EnemiesHarmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnemiesHarmed.Location = new System.Drawing.Point(46, 227);
            this.LB_EnemiesHarmed.Name = "LB_EnemiesHarmed";
            this.LB_EnemiesHarmed.Size = new System.Drawing.Size(132, 20);
            this.LB_EnemiesHarmed.TabIndex = 25;
            this.LB_EnemiesHarmed.Text = "Enemies Harmed";
            // 
            // NB_InnocentsHarmed
            // 
            this.NB_InnocentsHarmed.AutoSize = true;
            this.NB_InnocentsHarmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB_InnocentsHarmed.ForeColor = System.Drawing.Color.Blue;
            this.NB_InnocentsHarmed.Location = new System.Drawing.Point(12, 267);
            this.NB_InnocentsHarmed.Name = "NB_InnocentsHarmed";
            this.NB_InnocentsHarmed.Size = new System.Drawing.Size(19, 20);
            this.NB_InnocentsHarmed.TabIndex = 28;
            this.NB_InnocentsHarmed.Tag = "Value";
            this.NB_InnocentsHarmed.Text = "0";
            // 
            // LB_InnocentsHarmed
            // 
            this.LB_InnocentsHarmed.AutoSize = true;
            this.LB_InnocentsHarmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_InnocentsHarmed.Location = new System.Drawing.Point(46, 267);
            this.LB_InnocentsHarmed.Name = "LB_InnocentsHarmed";
            this.LB_InnocentsHarmed.Size = new System.Drawing.Size(141, 20);
            this.LB_InnocentsHarmed.TabIndex = 27;
            this.LB_InnocentsHarmed.Text = "Innocents Harmed";
            // 
            // LB_Timer
            // 
            this.LB_Timer.AutoSize = true;
            this.LB_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Timer.Location = new System.Drawing.Point(12, 96);
            this.LB_Timer.Name = "LB_Timer";
            this.LB_Timer.Size = new System.Drawing.Size(52, 20);
            this.LB_Timer.TabIndex = 30;
            this.LB_Timer.Text = "Time:";
            // 
            // LB_SilentAssassin
            // 
            this.LB_SilentAssassin.AutoSize = true;
            this.LB_SilentAssassin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SilentAssassin.ForeColor = System.Drawing.Color.Green;
            this.LB_SilentAssassin.Location = new System.Drawing.Point(45, 302);
            this.LB_SilentAssassin.Name = "LB_SilentAssassin";
            this.LB_SilentAssassin.Size = new System.Drawing.Size(132, 20);
            this.LB_SilentAssassin.TabIndex = 32;
            this.LB_SilentAssassin.Text = "Silent Assassin";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Game,
            this.Menu_Update,
            this.Menu_About});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(302, 24);
            this.MainMenu.TabIndex = 34;
            this.MainMenu.Text = "menuStrip1";
            // 
            // Menu_Game
            // 
            this.Menu_Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Game_H2,
            this.Menu_Game_H3});
            this.Menu_Game.Name = "Menu_Game";
            this.Menu_Game.Size = new System.Drawing.Size(50, 20);
            this.Menu_Game.Text = "Game";
            // 
            // Menu_Game_H2
            // 
            this.Menu_Game_H2.Name = "Menu_Game_H2";
            this.Menu_Game_H2.Size = new System.Drawing.Size(205, 22);
            this.Menu_Game_H2.Text = "Hitman 2: Silent Assassin";
            this.Menu_Game_H2.Click += new System.EventHandler(this.Menu_Game_H2_Click);
            // 
            // Menu_Game_H3
            // 
            this.Menu_Game_H3.Name = "Menu_Game_H3";
            this.Menu_Game_H3.Size = new System.Drawing.Size(205, 22);
            this.Menu_Game_H3.Text = "Hitman Contracts";
            this.Menu_Game_H3.Click += new System.EventHandler(this.Menu_Game_H3_Click);
            // 
            // Menu_Update
            // 
            this.Menu_Update.Name = "Menu_Update";
            this.Menu_Update.Size = new System.Drawing.Size(57, 20);
            this.Menu_Update.Text = "Update";
            this.Menu_Update.Click += new System.EventHandler(this.Menu_Update_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::HitmanStatistics.Properties.Resources.Bar;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 7);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HitmanStatistics.Properties.Resources.Bar;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 7);
            this.panel1.TabIndex = 35;
            // 
            // IMG_SA
            // 
            this.IMG_SA.BackgroundImage = global::HitmanStatistics.Properties.Resources.Yes;
            this.IMG_SA.Location = new System.Drawing.Point(13, 304);
            this.IMG_SA.Name = "IMG_SA";
            this.IMG_SA.Size = new System.Drawing.Size(16, 16);
            this.IMG_SA.TabIndex = 33;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 329);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IMG_SA);
            this.Controls.Add(this.LB_SilentAssassin);
            this.Controls.Add(this.LB_Timer);
            this.Controls.Add(this.NB_InnocentsHarmed);
            this.Controls.Add(this.LB_InnocentsHarmed);
            this.Controls.Add(this.NB_EnemiesHarmed);
            this.Controls.Add(this.LB_EnemiesHarmed);
            this.Controls.Add(this.NB_Headshots);
            this.Controls.Add(this.LB_Headshots);
            this.Controls.Add(this.LB_MapName);
            this.Controls.Add(this.LB_Time);
            this.Controls.Add(this.NB_InnocentsKilled);
            this.Controls.Add(this.LB_InnocentsKilled);
            this.Controls.Add(this.NB_EnemiesKilled);
            this.Controls.Add(this.LB_EnemiesKilled);
            this.Controls.Add(this.NB_Alerts);
            this.Controls.Add(this.LB_Alerts);
            this.Controls.Add(this.NB_CloseEncounters);
            this.Controls.Add(this.LB_CloseEncounters);
            this.Controls.Add(this.NB_ShotsFired);
            this.Controls.Add(this.LB_Running);
            this.Controls.Add(this.LB_ShotsFired);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Hitman Statistics";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ShotsFired;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LB_Running;
        private System.Windows.Forms.Label NB_ShotsFired;
        private System.Windows.Forms.Label NB_CloseEncounters;
        private System.Windows.Forms.Label LB_CloseEncounters;
        private System.Windows.Forms.Label NB_Alerts;
        private System.Windows.Forms.Label LB_Alerts;
        private System.Windows.Forms.Label NB_EnemiesKilled;
        private System.Windows.Forms.Label LB_EnemiesKilled;
        private System.Windows.Forms.Label NB_InnocentsKilled;
        private System.Windows.Forms.Label LB_InnocentsKilled;
        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.Label LB_MapName;
        private System.Windows.Forms.Label NB_Headshots;
        private System.Windows.Forms.Label LB_Headshots;
        private System.Windows.Forms.Label NB_EnemiesHarmed;
        private System.Windows.Forms.Label LB_EnemiesHarmed;
        private System.Windows.Forms.Label NB_InnocentsHarmed;
        private System.Windows.Forms.Label LB_InnocentsHarmed;
        private System.Windows.Forms.Label LB_Timer;
        private System.Windows.Forms.Label LB_SilentAssassin;
        private System.Windows.Forms.Panel IMG_SA;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game_H2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Game_H3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Update;
        private System.Windows.Forms.ToolStripMenuItem Menu_About;
    }
}

