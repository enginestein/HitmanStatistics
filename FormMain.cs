using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;

namespace HitmanStatistics {
    public partial class FormMain : Form {
        // Base address value for pointers.
        const int baseAddress = 0x00400000;

        // All the possible Silent Assassin combinations for Hitman 2
        SACombination[] validSACombinationH2 = {
            new SACombination(0, 1, 0, 0, 1, 2, 0, 0), new SACombination(0, 1, 0, 0, 0, 5, 0, 0), new SACombination(0, 1, 0, 0, 0, 2, 0, 1), new SACombination(0, 0, 0, 1, 2, 0, 0, 0), new SACombination(0, 0, 0, 1, 1, 3, 0, 0), 
            new SACombination(0, 0, 0, 1, 1, 0, 0, 1), new SACombination(0, 0, 0, 1, 0, 6, 0, 0), new SACombination(0, 0, 0, 1, 0, 3, 0, 1), new SACombination(0, 0, 0, 1, 0, 0, 1, 0), new SACombination(0, 0, 0, 1, 0, 0, 0, 2), 
            new SACombination(0, 0, 0, 0, 1, 0, 0, 1), new SACombination(1, 1, 1, 0, 0, 2, 0, 0), new SACombination(1, 1, 0, 0, 1, 0, 0, 0), new SACombination(1, 1, 0, 0, 0, 3, 0, 0), new SACombination(1, 1, 0, 0, 0, 0, 0, 1),
            new SACombination(1, 0, 1, 1, 1, 0, 0, 0), new SACombination(1, 0, 1, 1, 0, 3, 0, 0), new SACombination(1, 0, 1, 1, 0, 0, 0, 1), new SACombination(1, 0, 0, 1, 1, 1, 0, 0), new SACombination(1, 0, 0, 1, 0, 4, 0, 0),
            new SACombination(1, 0, 0, 1, 0, 1, 0, 1), new SACombination(1, 0, 0, 0, 1, 1, 0, 0), new SACombination(2, 1, 1, 0, 0, 0, 0, 0), new SACombination(2, 1, 0, 0, 0, 1, 0, 0), new SACombination(2, 0, 2, 1, 0, 0, 0, 0),
            new SACombination(2, 0, 1, 1, 0, 1, 0, 0), new SACombination(3, 0, 0, 1, 0, 0, 0, 0)};

        // All the possible Silent Assassin combinations for Hitman Contracts
        SACombination[] validSACombinationHC = {
            new SACombination(999, 0, 999, 1, 0, 0, 0, 0),  new SACombination(2, 1, 1, 0, 0, 0, 0, 0), new SACombination(2, 1, 0, 0, 0, 1, 0, 0), new SACombination(2, 0, 1, 1, 0, 1, 0, 0), new SACombination(2, 0, 0, 0, 0, 2, 0, 0), new SACombination(1, 1, 1, 0, 0, 2, 0, 0),
            new SACombination(1, 1, 0, 0, 1, 0, 0, 0),      new SACombination(1, 1, 0, 0, 0, 3, 0, 0), new SACombination(1, 0, 1, 1, 1, 0, 0, 0), new SACombination(1, 0, 1, 1, 0, 3, 0, 0), new SACombination(1, 0, 0, 1, 1, 1, 0, 0),
            new SACombination(1, 0, 0, 1, 0, 4, 0, 0),      new SACombination(0, 1, 0, 0, 1, 2, 0, 0), new SACombination(0, 1, 0, 0, 0, 5, 0, 0), new SACombination(0, 0, 0, 1, 1, 3, 0, 0), new SACombination(0, 0, 0, 1, 2, 0, 0, 0),
            new SACombination(0, 0, 0, 1, 0, 6, 0, 0)};

        // Most values are accessed with 3-levels pointers and the second offset is different depending on the current mission.
        // All second offsets are stored here to be accessed according to the correct mission.
        int[] secondOffset = { 0x838, 0xB24, 0x8A0, 0x138, 0xB88, 0xBB8, 0xB48, 0xCE8, 0x136C, 0xAD0, 0xF50, 0x8D4, 0x9EC, 0x400, 0x9EC, 0x644, 0xB08, 0x96C, 0xB00, 0x8 };

        // Dictionary used to convert the raw map names into easily readable names and a map number to access the second offsets declared previously.
        Dictionary<string, Tuple<string, int>> mapValues = new Dictionary<string, Tuple<string, int>>() {
            // Hitman 2
            { "C1-1__MA", new Tuple<string, int>("Anathema", 1) },                  { "C2-1__MA", new Tuple<string, int>("St. Petersburg Stakeout", 2) },   { "C2-2__MA", new Tuple<string, int>("Kirov Park Meeting", 3) },    { "C2-3__MA", new Tuple<string, int>("Tubeway Torpedo", 4) },               { "C2-4__MA", new Tuple<string, int>("Invitation to a Party", 5) },
            { "C3-1__MA", new Tuple<string, int>("Tracking Hayamoto", 6) },         { "\\C3-2a__", new Tuple<string, int>("Hidden Valley", 7) },            { "\\C3-2b__", new Tuple<string, int>("At the Gates", 8) },         { "C3-3__MA", new Tuple<string, int>("Shogun Showdown", 9) },               { "C4-1__MA", new Tuple<string, int>("Basement Killing", 10) },
            { "C4-2__MA", new Tuple<string, int>("The Graveyard Shift", 11) },      { "C4-3__MA", new Tuple<string, int>("The Jacuzzi Job", 12) },          { "C5-1__MA", new Tuple<string, int>("Murder At The Bazaar", 13) }, { "C5-2__MA", new Tuple<string, int>("The Motorcade Interception", 14) },   { "C5-3__MA", new Tuple<string, int>("Tunnel Rat", 15) },
            { "C6-1__MA", new Tuple<string, int>("Temple City Ambush", 16) },       { "C6-2__MA", new Tuple<string, int>("The Death of Hannelore", 17) },   { "C6-3__MA", new Tuple<string, int>("Terminal Hospitality", 18) }, { "C7-1__MA", new Tuple<string, int>("St. Petersburg Revisited", 19) },     { "C8-1__MA", new Tuple<string, int>("Redemption at Gontranno", 20) },
            // Hitman Contracts
            { "C01-1_MA", new Tuple<string, int>("Asylum Aftermath", 1) },          { "C01-2_MA", new Tuple<string, int>("The Meat King's Party", 2) },     { "C02-1_MA", new Tuple<string, int>("The Bjarkhov Bomb", 3) },     { "C03-1_MA", new Tuple<string, int>("Beldingford Manor", 4) },             { "C06-1_MA", new Tuple<string, int>("Rendezvous in Rotterdam", 5) },
            { "C06-2_MA", new Tuple<string, int>("Deadly Cargo", 6) },              { "C07-1_MA", new Tuple<string, int>("Traditions of the Trade", 7) },   { "C08-1_MA", new Tuple<string, int>("Slaying a Dragon", 8) },      { "C08-2_MA", new Tuple<string, int>("The Wang Fou Incident", 9) },         { "C08-3_MA", new Tuple<string, int>("The Seafood Massacre", 10) },
            { "C08-4_MA", new Tuple<string, int>("Lee Hong Assassination", 11) },   { "C09-1_MA", new Tuple<string, int>("Hunter and Hunted", 12) }};

        // Map pointers for HC
        Pointer[] HCmapPointers = {
            new Pointer(0x00393D58, new int[2] { 0x234, 0xBDE }), new Pointer(0x00394598, new int[3] { 0x10, 0x194, 0xC0E }), new Pointer(0x00394598, new int[2] { 0x214, 0xC0E }), new Pointer(0x00394578, new int[2] { 0x1EC0, 0x49FA }), new Pointer(0x00394578, new int[3] { 0x1E00, 0xBC, 0x49FA }), new Pointer(0x00394578, new int[4] { 0x1D80, 0x7C, 0xBC, 0x49FA }),
            new Pointer(0x00394578, new int[5] { 0x1D00, 0x7C, 0x7C, 0xBC, 0x49FA }), new Pointer(0x0039457C, new int[2] { 0x1E40, 0x49FA }), new Pointer(0x0039457C, new int[3] { 0x1D80, 0xBC, 0x49FA }), new Pointer(0x0039457C, new int[4] { 0x1D00, 0x7C, 0xBC, 0x49FA }), new Pointer(0x0039457C, new int[5] { 0x1C80, 0x7C, 0x7C, 0xBC, 0x49FA })};

        // Other variables.
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Image imgSA, imgNotSA;
        Process[] myProcess;
        String mapName;
        float missionTime;
        bool isMissionActive;
        string gameName;
        int gameNumber, mapNumber, nbShotsFired, nbCloseEncounters, nbHeadshots, nbAlerts, nbEnemiesK, nbEnemiesH, nbInnocentsK, nbInnocentsH, HCpointerNumber;

        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public FormMain() {
            InitializeComponent();
            imgSA = Properties.Resources.Yes;
            imgNotSA = Properties.Resources.No;
            HCpointerNumber = 0;
            gameNumber = 2;
            gameName = "HITMAN 2";
            ResetValues();
        }

        /*------------------
        -- MEMORY READING --
        ------------------*/
        private void Timer_Tick(object sender, EventArgs e) {
            // Attempt to find if the game is currently running
            if (myProcess == null || myProcess.Length == 0) {
                switch (gameNumber) {
                    case 2:
                        myProcess = Process.GetProcessesByName("hitman2");
                        break;
                    case 3:
                        myProcess = Process.GetProcessesByName("HitmanContracts");
                        break;
                }

                if (myProcess.Length != 0) {
                    LB_Running.Text = gameName + " IS RUNNING";
                    LB_Running.ForeColor = Color.Green;
                    Timer.Interval = 50;
                }
            }

            if (myProcess.Length != 0) {
                // Reading the raw name of the current mission as an array of bytes and converting it to a string
                byte[] mapBytes = null;

                switch (gameNumber) {
                    case 2:
                        mapBytes = BitConverter.GetBytes(Trainer.ReadPointerDouble(myProcess, baseAddress + 0x2A6C5C, new int[2] { 0x98, 0xBC7 }));
                        break;
                    case 3:
                        mapBytes = BitConverter.GetBytes(Trainer.ReadPointerDouble(myProcess, baseAddress + HCmapPointers[HCpointerNumber].address, HCmapPointers[HCpointerNumber].offsets));
                        break;
                }

                string mapBytesStr = enc.GetString(mapBytes);

                if (mapBytesStr == "\0\0\0\0\0\0\0\0") {
                    // The game is no longer running
                    ResetGame();
                } else if (mapValues.ContainsKey(mapBytesStr)) {
                    // Get the clean mission name and the mission number from the dictionary
                    isMissionActive = true;
                    mapName = mapValues[mapBytesStr].Item1;
                    mapNumber = mapValues[mapBytesStr].Item2;
                } else {
                    // The mission name isn't included in the dictionary, meaning that a mission is not active at this moment
                    // The current screen is something like the main menu, the briefing or a cutscene
                    isMissionActive = false;

                    // Change the map pointer for Contracts, because I'm not sure which one is working at the moment
                    // TODO: Find a working pointer
                    HCpointerNumber++;
                    if (HCpointerNumber > 10)
                        HCpointerNumber = 0;
                }

                if (isMissionActive) {
                    // A mission is currently active, ready to read memory
                    switch (gameNumber) {
                        case 2:
                            // Reading the timer
                            missionTime = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C58, new int[5] { 0x118, 0xB38, 0x8, 0x1084, 0x24 });

                            // Reading every other value if the mission has started
                            if (missionTime > 0) {
                                nbShotsFired = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x39419, new int[2] { 0xBD, 0x11C7 });
                                nbCloseEncounters = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x220 });
                                nbHeadshots = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x208 });
                                nbAlerts = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x21C });
                                nbEnemiesK = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x210 });
                                nbEnemiesH = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x20C });
                                nbInnocentsK = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x218 });
                                nbInnocentsH = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x2A6C50, new int[3] { 0x28, secondOffset[mapNumber - 1], 0x214 });
                            }
                            break;
                        case 3:
                            // Reading the timer
                            missionTime = Trainer.ReadPointerFloat(myProcess, baseAddress + 0x39457C, new int[1] { 0x24 });

                            // Reading every other value if the mission has started
                            if (missionTime > 0) {
                                nbShotsFired = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947B0, new int[3] { 0xBA0, 0x104, 0x82F });
                                nbCloseEncounters = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947C0, new int[1] { 0xB2F });
                                nbHeadshots = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947C0, new int[1] { 0xB17 });
                                nbAlerts = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947C0, new int[1] { 0xB2B });
                                nbEnemiesK = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947C0, new int[1] { 0xB1F });
                                nbEnemiesH = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947C0, new int[1] { 0xB1B });
                                nbInnocentsK = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947C0, new int[1] { 0xB27 });
                                nbInnocentsH = Trainer.ReadPointerInteger(myProcess, baseAddress + 0x3947C0, new int[1] { 0xB23 });
                            }
                            break;
                    }

                    // Checking if the actual rating is SA according to the current stats
                    if (IsSilentAssassin()) {
                        IMG_SA.BackgroundImage = imgSA;
                        LB_SilentAssassin.ForeColor = Color.Green;
                    } else {
                        IMG_SA.BackgroundImage = imgNotSA;
                        LB_SilentAssassin.ForeColor = Color.Red;
                    }

                    // Displaying the values
                    LB_MapName.Text = "#" + mapNumber + " " + mapName;
                    LB_Time.Text = ((int)missionTime / 3600).ToString("D2") + ":" + ((missionTime / 60) % 60).ToString("00.000");
                    NB_ShotsFired.Text = nbShotsFired.ToString();
                    NB_CloseEncounters.Text = nbCloseEncounters.ToString();
                    NB_Headshots.Text = nbHeadshots.ToString();
                    NB_Alerts.Text = nbAlerts.ToString();
                    NB_EnemiesKilled.Text = nbEnemiesK.ToString();
                    NB_EnemiesHarmed.Text = nbEnemiesH.ToString();
                    NB_InnocentsKilled.Text = nbInnocentsK.ToString();
                    NB_InnocentsHarmed.Text = nbInnocentsH.ToString();
                } else {
                    // No mission is active, reseting values
                    ResetValues();
                }
            }
        }

   
        private void ResetValues() {
            isMissionActive = false;
            LB_MapName.Text = "No mission currently";
            missionTime = 0;
            LB_Time.Text = "00:00,000";
            nbShotsFired = 0;
            NB_ShotsFired.Text = "0";
            nbCloseEncounters = 0;
            NB_CloseEncounters.Text = "0";
            nbHeadshots = 0;
            NB_Headshots.Text = "0";
            nbAlerts = 0;
            NB_Alerts.Text = "0";
            nbEnemiesK = 0;
            NB_EnemiesKilled.Text = "0";
            nbEnemiesH = 0;
            NB_EnemiesHarmed.Text = "0";
            nbInnocentsK = 0;
            NB_InnocentsKilled.Text = "0";
            nbInnocentsH = 0;
            NB_InnocentsHarmed.Text = "0";

            if (IMG_SA.BackgroundImage != imgSA) {
                IMG_SA.BackgroundImage = imgSA;
                LB_SilentAssassin.ForeColor = Color.Green;
            }
        }


        private void ResetGame() {
            myProcess = null;
            gameName = "HITMAN " + gameNumber;
            LB_Running.Text = gameName + " IS NOT RUNNING";
            LB_Running.ForeColor = Color.Red;
            Timer.Interval = 500;
            ResetValues();
        }


        private bool IsSilentAssassin() {
            SACombination[] validSACombination = null;
            switch (gameNumber) {
                case 2:
                    validSACombination = validSACombinationH2;
                    break;
                case 3:
                    if (mapName == "Asylum Aftermath" && nbCloseEncounters > 0)
                        return false;
                    validSACombination = validSACombinationHC;
                    break;
            }

            foreach (SACombination combination in validSACombination) {
              
                if (combination.isSACombination(nbShotsFired, nbCloseEncounters, nbHeadshots, nbAlerts, nbEnemiesK, nbEnemiesH, nbInnocentsK, nbInnocentsH)) {
                    return true;
                }
            }
            return false;
        }

        private void Menu_Game_H2_Click(object sender, EventArgs e) {
            gameNumber = 2;
            ResetGame();
        }
        private void Menu_Game_H3_Click(object sender, EventArgs e) {
            gameNumber = 3;
            ResetGame();
        }

        private void Menu_Update_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/enginestein/HitmanStatistics/releases/latest");
        }


    }
}
