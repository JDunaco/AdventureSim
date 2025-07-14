using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureSim
{
    public partial class Main : Form
    {
        int startingGold = 10;
        int roundsLeftNum = 0;
        int gold = 0;
        string playerName = "Jordan";
        int playerWarriorNum = 0;
        int playerArcherNum = 0;
        int playerMageNum = 0;
        int bossWarriorNum = 0;
        int bossArcherNum = 0;
        int bossMageNum = 0;
        int playerWarriorStr = 1;
        int playerArcherStr = 1;
        int playerMageStr = 1;
        bool warriorStartFight = false;
        bool archerStartFight = false;
        bool mageStartFight = false;
        int enemyWarriorsToFight = 0;
        int enemyArchersToFight = 0;
        int enemyMagesToFight = 0;
        bool bossFought = false;






        public Main()
        {
            InitializeComponent();
            InitialStartup();
        }
        // Startup control
        private void InitialStartup() 
        {
            gold = startingGold;
            GoldNum.Text = gold.ToString();
            roundsLeftNum=10;
            RoundsLeftNum.Text = roundsLeftNum.ToString();
            playerWarriorNum = 5;
            playerArcherNum = 5;
            playerMageNum = 5;
            MageStrDisplay.Text = playerMageStr.ToString() + "x";
            ArcherStrDisplay.Text = playerArcherStr.ToString() + "x";
            WarriorStrDisplay.Text = playerWarriorStr.ToString() + "x";
            PlayerWarriorNum.Text = playerWarriorNum.ToString();
            PlayerArcherNum.Text = playerArcherNum.ToString();
            PlayerMageNum.Text = playerMageNum.ToString();
            BossStartup();
            HideBossUI();
            HideRecruitUI();
            HideShopUI();
            HideFightUI();
        }







        //Show/hide particular UI elements
        private void HideMainUI()
        {
            // Hide all UI assocaited with the Main Setup
            ShopButton.Hide();
            RecruitButton.Hide();
            TrainButton.Hide();
            ChoiceAskLabel.Hide();
        }
        private void ShowMainUI()
        {
            // Show all UI assocaited with the Main Setup
            ShopButton.Show();
            RecruitButton.Show();
            TrainButton.Show();
            ChoiceAskLabel.Show();
        }

        private void HideShopUI() 
        {
            // Hide all shop UI
            DoneShoppingButton.Hide();
            SelectShop1Button.Hide();
            SelectShop2Button.Hide();
            SelectShop3Button.Hide();
        }

        private void ShowShopUI()
        {
            // Show Shop UI
            DoneShoppingButton.Show();
            SelectShop1Button.Show();
            SelectShop2Button.Show();
            SelectShop3Button.Show();
        }

        private void HideRecruitUI()
        {
            // Hide all Recruit UI
            RecruitArchersButton.Hide();
            RecruitMagesButton.Hide();
            RecruitWarriorButton.Hide();
            RecruitArcherPicture.Hide();
            RecruitWarriorPicture.Hide();
            RecruitMagePicture.Hide();
        }
        private void ShowRecruitUI()
        {
            // Show Recruit UI
            RecruitArchersButton.Show();
            RecruitMagesButton.Show();
            RecruitWarriorButton.Show();
            RecruitArcherPicture.Show();
            RecruitWarriorPicture.Show();
            RecruitMagePicture.Show();
        }

        private void HideFightUI()
        {
            // Hide all Training UI
            TrainArchersButton.Hide();
            TrainWarriorsButton.Hide();
            TrainMagesButton.Hide();
            CombatQuestion.Hide();
            CombatQuestionArcherButton.Hide();
            CombatQuestionWarriorButton.Hide();
            CombatQuestionMageButton.Hide();
        }
        private void ShowFightUI()
        {
            // Show Training UI
            TrainArchersButton.Show();
            TrainWarriorsButton.Show();
            TrainMagesButton.Show();
        }

        private void HideBossUI()
        {
            // Hide BossUI
        }
        private void ShowBossUI()
        {
            // Show BossfightUI
        }
        //Assigns a random value between 100-200 and distributes it across the boss's army
        private void BossStartup()
        {
            int archerNum = 0;
            int unitNums = RandomNumGenerate(100, 200);
            int warriorNum = RandomNumGenerate(0, unitNums);
            int leftOverNum = unitNums - warriorNum;
            if (leftOverNum > 0) 
            { 
                archerNum = RandomNumGenerate(0, leftOverNum); 
            }
            leftOverNum -= archerNum;
            int mageNum = leftOverNum;

            bossWarriorNum=warriorNum;
            bossArcherNum = archerNum;
            bossMageNum = mageNum;

            BossWarriorNum.Text = bossWarriorNum.ToString();
            BossArcherNum.Text = bossArcherNum.ToString();
            BossMageNum.Text = bossMageNum.ToString();
            // TODO: Randomize between 100-200 units for the boss.
        }
        // Generate a random number based on parameters passed
        private int RandomNumGenerate(int min, int max)
        {
            int randomNum;
            Random rand1 = new Random();
            randomNum = rand1.Next(min, max);
            return randomNum;
        }







        // Main Functions (MainlyUI)


        private void ShopButton_Click(object sender, EventArgs e)
        {
            HideMainUI();
            ShowShopUI();
        }

        private void RecruitButton_Click(object sender, EventArgs e)
        {
            HideMainUI();
            ShowRecruitUI();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            HideMainUI();
            ShowFightUI();
        }






        // Shopping Functions

        // Buy Better Armor/Weapons for Warriors
        private void SelectShop1Button_Click(object sender, EventArgs e)
        {
            // Check Price if can buy
            if(gold > 9)
            {
                playerWarriorStr = playerWarriorStr + 1;
                gold -= 10;
            }
            WarriorStrDisplay.Text = playerWarriorStr.ToString() + "x";
            GoldNum.Text = gold.ToString();
        }

        // Buy Better Bow/Ammo for Archers
        private void SelectShop2Button_Click(object sender, EventArgs e)
        {
            if (gold > 9)
            {
                playerArcherStr = playerArcherStr + 1;
                gold -= 10;
            }
            ArcherStrDisplay.Text = playerArcherStr.ToString() + "x";
            GoldNum.Text = gold.ToString();
        }


        // Buy Mage Strength (Better Wands??)
        private void SelectShop3Button_Click(object sender, EventArgs e)
        {
            if (gold > 9)
            {
                playerMageStr = playerMageStr + 1;
                gold -= 10;
            }
            MageStrDisplay.Text = playerMageStr.ToString() + "x";
            GoldNum.Text = gold.ToString();
        }

        // Done Shopping
        private void DoneShoppingButton_Click(object sender, EventArgs e)
        {
            ShowMainUI();
            HideShopUI();
            DecreaseRounds();
        }

        // Decrease Roudn Control Function
        private void DecreaseRounds()
        {
            if (roundsLeftNum > 0)
            {
                roundsLeftNum--;
                RoundsLeftNum.Text = roundsLeftNum.ToString();
            }
            if (roundsLeftNum <= 0)
            {
                HideMainUI();
                enemyArchersToFight = bossArcherNum;
                enemyWarriorsToFight = bossWarriorNum;
                enemyMagesToFight = bossMageNum;
                //Boss Time
                bossFought=true;
                DisplayPlayerCombatChoiceUI();
            }
        }






        // Fighting Functions
        //Fight Mages
        private void TrainMagesButton_Click(object sender, EventArgs e)
        {
            HideFightUI();
            enemyArchersToFight = 0;
            enemyWarriorsToFight = 0;
            enemyMagesToFight = 10;
            DisplayPlayerCombatChoiceUI();
        }
        //Fight Archers
        private void TrainArchersButton_Click(object sender, EventArgs e)
        {
            enemyArchersToFight = 10;
            enemyWarriorsToFight = 0;
            enemyMagesToFight = 0;
            HideFightUI();
            DisplayPlayerCombatChoiceUI();
        }
        //Fight Warriors
        private void TrainWarriorsButton_Click(object sender, EventArgs e)
        {
            HideFightUI();
            enemyArchersToFight = 0;
            enemyWarriorsToFight = 10;
            enemyMagesToFight = 0;
            DisplayPlayerCombatChoiceUI();
        }
        // Function to Handle Combat
        private void NormalCombat(int enemyWarriors, int enemyArchers, int enemyMages)
        {
            // Code Normal Combat (2x for Archer->mage->Warrior->Archer)
            // Ask player which unit type strikes first.
            // Code For each class starting the fight
            // Added modifiers from the shop to stregthen units in battle.
            if (warriorStartFight)
            {
                //While Loop warrior v warrior 1 to 1
                //While Loop warrior v archer 1 to 2
                //While Loop warrior v mage 2 to 1
                while(playerWarriorNum > 0)
                {
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 1 * playerWarriorStr;
                        playerWarriorNum--;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 2 * playerWarriorStr ;
                        playerWarriorNum--;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages = 1 * playerWarriorStr;
                        playerWarriorNum -= 2;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
                //While Loop archer v warrior 2 to 1
                //While Loop archer v archer 1 to 1
                //While Loop archer v mage 1 to 2
                while (playerArcherNum > 0)
                {
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 1 * playerArcherStr;
                        playerArcherNum-=2;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 1 * playerArcherStr;
                        playerArcherNum--;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 2 * playerArcherStr;
                        playerArcherNum--;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }

                }
                //While Loop mage v warrior 1 to 2
                //While Loop mage v archer 2 to 1
                //While Loop mage v mage 1 to 1
                while (playerMageNum > 0)
                {
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors-= 2 * playerMageStr;
                        playerMageNum--;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 1 * playerMageStr;
                        playerMageNum-=2;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 1 * playerMageStr;
                        playerMageNum--;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
            }
            else if (archerStartFight)
            {
                while (playerArcherNum > 0)
                {
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 1 * playerArcherStr;
                        playerArcherNum--;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 2 * playerArcherStr;
                        playerArcherNum--;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 1 * playerArcherStr;
                        playerArcherNum-=2;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
                while (playerMageNum > 0)
                {
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 2 * playerMageStr;
                        playerMageNum--;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 1 * playerMageStr;
                        playerMageNum-=2;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 1 * playerMageStr;
                        playerMageNum--;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
                while (playerWarriorNum > 0)
                {
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 1 * playerWarriorStr; ;
                        playerWarriorNum--;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 2 * playerWarriorStr; ;
                        playerWarriorNum--;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 1 * playerWarriorStr; ;
                        playerWarriorNum -= 2;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
            }
            else if(mageStartFight)
            {
                while (playerMageNum > 0)
                {
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 2 * playerMageStr;
                        playerMageNum--;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 1 * playerMageStr;
                        playerMageNum-=2;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 1 * playerMageStr;
                        playerMageNum--;
                        PlayerMageNum.Text = playerMageNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
                while (playerWarriorNum > 0)
                {
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 1 * playerWarriorStr; ;
                        playerWarriorNum--;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 2 * playerWarriorStr; ;
                        playerWarriorNum--;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 1 * playerWarriorStr;
                        playerWarriorNum -= 2;
                        PlayerWarriorNum.Text = playerWarriorNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
                while (playerArcherNum > 0)
                {
                    if (enemyArchers > 0)
                    {
                        enemyArchers -= 1 * playerArcherStr;
                        playerArcherNum--;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyMages > 0)
                    {
                        enemyMages -= 2 * playerArcherStr;
                        playerArcherNum--;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyWarriors > 0)
                    {
                        enemyWarriors -= 1 * playerArcherStr;
                        playerArcherNum-=2;
                        PlayerArcherNum.Text = playerArcherNum.ToString();
                    }
                    if (enemyWarriors <= 0 && enemyArchers <= 0 && enemyMages <= 0) { break; }
                }
            }
            CheckDeath();
            GainGold();
            ShowMainUI();
            HideFightUI();
            
        }

        // Check if Dead or if facing the boss
        private void CheckDeath()
        {
            if (playerWarriorNum <= 0 && playerArcherNum <= 0 && playerMageNum <= 0)
            {
                //gg's game over
                this.Hide();
                Defeat defeat = new Defeat();
                defeat.Show();
            }
            if (playerWarriorNum <= 0)
            {
                playerWarriorNum = 0;
                PlayerWarriorNum.Text = playerWarriorNum.ToString();
            }
            if (playerArcherNum <= 0)
            {
                playerArcherNum = 0;
                PlayerArcherNum.Text = playerArcherNum.ToString();
            }
            if (playerMageNum <= 0)
            {
                playerMageNum = 0;
                PlayerMageNum.Text = playerMageNum.ToString();
            }
            if (bossFought)
            {
                this.Hide();
                Victory victory = new Victory();
                victory.Show();
            }
        }
        // Gain Gold on Fight Win
        private void GainGold()
        {
            gold += 10;
            GoldNum.Text = gold.ToString();
        }

        private void DisplayPlayerCombatChoiceUI()
        {
            CombatQuestion.Show();
            CombatQuestionWarriorButton.Show();
            CombatQuestionArcherButton.Show();
            CombatQuestionMageButton.Show();
        }
        // Hides the UI for army type starting the battle
        private void HideCombatChoiceUI()
        {
            CombatQuestion.Hide();
            CombatQuestionWarriorButton.Hide();
            CombatQuestionArcherButton.Hide();
            CombatQuestionMageButton.Hide();
        }
        // Warriors start battle first
        private void CombatQuestionWarriorButton_Click(object sender, EventArgs e)
        {
            warriorStartFight = true;
            archerStartFight = false;
            mageStartFight = false;
            HideCombatChoiceUI();
            NormalCombat(enemyWarriorsToFight, enemyArchersToFight, enemyMagesToFight);
        }
        // Archers start battle first
        private void CombatQuestionArcherButton_Click(object sender, EventArgs e)
        {
            warriorStartFight = false;
            archerStartFight = true;
            mageStartFight = false;
            HideCombatChoiceUI();
            NormalCombat(enemyWarriorsToFight, enemyArchersToFight, enemyMagesToFight);
        }
        // Mage starts the battle first
        private void CombatQuestionMageButton_Click(object sender, EventArgs e)
        {
            warriorStartFight = false;
            archerStartFight = false;
            mageStartFight = true;
            HideCombatChoiceUI();
            NormalCombat(enemyWarriorsToFight,enemyArchersToFight,enemyMagesToFight);
        }













        // Recruitment Functions
        // Recruits 10 warriors to player's army
        private void RecruitWarriorButton_Click(object sender, EventArgs e)
        {
            ShowMainUI();
            HideRecruitUI();
            DecreaseRounds();
            playerWarriorNum += 10;
            PlayerWarriorNum.Text = playerWarriorNum.ToString();
        }
        // Recruits 10 Archers to player's army

        private void RecruitArchersButton_Click(object sender, EventArgs e)
        {
            ShowMainUI();
            HideRecruitUI();
            DecreaseRounds();
            playerArcherNum += 10;
            PlayerArcherNum.Text = playerArcherNum.ToString();
        }

        // Recruits 10 Mages to the player's Army
        private void RecruitMagesButton_Click(object sender, EventArgs e)
        {
            ShowMainUI();
            HideRecruitUI();
            DecreaseRounds();
            playerMageNum += 10;
            PlayerMageNum.Text = playerMageNum.ToString();
        }









        // Not used Functions |
        //                    V
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void PlayerWarriorNum_Click(object sender, EventArgs e)
        {

        }

        private void PlayerWarriorLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlayerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlayerArcherLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlayerArcherNum_Click(object sender, EventArgs e)
        {

        }

        private void PlayerMageLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlayerMageNum_Click(object sender, EventArgs e)
        {

        }

        private void GoldNum_Click(object sender, EventArgs e)
        {

        }

        private void GoldLabel_Click(object sender, EventArgs e)
        {

        }

        private void RoundsLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void RoundsLeftNum_Click(object sender, EventArgs e)
        {

        }

        private void BossName_Click(object sender, EventArgs e)
        {

        }

        private void BossWarriorLabel_Click(object sender, EventArgs e)
        {

        }

        private void BossWarriorNum_Click(object sender, EventArgs e)
        {

        }

        private void BossArcherNum_Click(object sender, EventArgs e)
        {

        }

        private void BossArchersLabel_Click(object sender, EventArgs e)
        {

        }

        private void BossMageNum_Click(object sender, EventArgs e)
        {

        }

        private void BossMagesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShopLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChoiceAskLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
