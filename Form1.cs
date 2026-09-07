using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lopputyo
{
    public partial class Form1 : Form
    {
        public int coins = 10;
        private Random random = new Random();
        private List<string> playerInventory = new List<string>();

        // Turvallinen tallennuspolku käyttäjän AppData-kansioon
        private static readonly string saveDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "LootBoxSimulator"
        );
        private static readonly string saveFilePath = Path.Combine(saveDirectory, "savegame.txt");

        // 1. ILMAINEN LAATIKKO
        private static readonly List<Tuple<string, int, int>> FreeBoxItems = new List<Tuple<string, int, int>>
        {
            Tuple.Create("[Junk] Gravel Chunk", 50, 1),
            Tuple.Create("[Junk] Granite Shard", 45, 1),
            Tuple.Create("[Junk] Limestone Pebble", 40, 1),
            Tuple.Create("[Junk] Sandstone Rock", 35, 2),
            Tuple.Create("[Common] Copper Ore", 20, 5),
            Tuple.Create("[Common] Tin Ore", 15, 6),
            Tuple.Create("[Common] Coal Chunk", 10, 8),
            Tuple.Create("[Common] Raw Iron", 10, 10),
            Tuple.Create("[Uncommon] Silver Nugget", 5, 20),
            Tuple.Create("[Uncommon] Quartz Crystal", 4, 25),
            Tuple.Create("[Rare] Pure Gold Nugget", 2, 75),
            Tuple.Create("[Epic] Cut Blood Ruby", 1, 250),
            Tuple.Create("[Legendary] Heart of the Earth Core", 1, 2500)
        };

        // 2. KESKITASON LAATIKKO
        private static readonly List<Tuple<string, int, int>> MediumBoxItems = new List<Tuple<string, int, int>>
        {
            Tuple.Create("[Junk] Limestone Pebble", 15, 1),
            Tuple.Create("[Junk] Sandstone Rock", 15, 2),
            Tuple.Create("[Common] Coal Chunk", 25, 8),
            Tuple.Create("[Common] Raw Iron", 25, 10),
            Tuple.Create("[Uncommon] Silver Nugget", 30, 20),
            Tuple.Create("[Uncommon] Quartz Crystal", 25, 25),
            Tuple.Create("[Uncommon] Amethyst Geode", 20, 30),
            Tuple.Create("[Uncommon] Raw Gold Ore", 20, 35),
            Tuple.Create("[Rare] Pure Gold Nugget", 15, 75),
            Tuple.Create("[Rare] Flawless Topaz", 12, 90),
            Tuple.Create("[Rare] Deep Sea Aquamarine", 10, 110),
            Tuple.Create("[Epic] Cut Blood Ruby", 6, 250),
            Tuple.Create("[Epic] Radiant Emerald", 4, 350),
            Tuple.Create("[Legendary] Glowing Uranium Crystal", 2, 1200),
            Tuple.Create("[Legendary] Pink Star Diamond", 2, 1000)
        };

        // 3. KALLIS LAATIKKO
        private static readonly List<Tuple<string, int, int>> PremiumBoxItems = new List<Tuple<string, int, int>>
        {
            Tuple.Create("[Common] Coal Chunk", 10, 8),
            Tuple.Create("[Common] Raw Iron", 10, 10),
            Tuple.Create("[Uncommon] Quartz Crystal", 15, 25),
            Tuple.Create("[Uncommon] Raw Gold Ore", 15, 35),
            Tuple.Create("[Rare] Pure Gold Nugget", 25, 75),
            Tuple.Create("[Rare] Flawless Topaz", 25, 90),
            Tuple.Create("[Rare] Deep Sea Aquamarine", 20, 110),
            Tuple.Create("[Rare] Rough Ruby", 20, 130),
            Tuple.Create("[Epic] Cut Blood Ruby", 20, 250),
            Tuple.Create("[Epic] Royal Sapphire", 18, 300),
            Tuple.Create("[Epic] Radiant Emerald", 15, 350),
            Tuple.Create("[Epic] Pure Diamond", 12, 450),
            Tuple.Create("[Legendary] Pink Star Diamond", 8, 1000),
            Tuple.Create("[Legendary] Glowing Uranium Crystal", 7, 1200),
            Tuple.Create("[Legendary] Starlight Meteorite Shard", 6, 1500),
            Tuple.Create("[Legendary] Heart of the Earth Core", 5, 2500)
        };

        public static readonly List<Tuple<string, int, int>> AvailableItems = new List<Tuple<string, int, int>>();

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;

            AvailableItems.Clear();
            foreach (var item in FreeBoxItems) AvailableItems.Add(item);
            foreach (var item in MediumBoxItems)
                if (!AvailableItems.Exists(x => x.Item1 == item.Item1)) AvailableItems.Add(item);
            foreach (var item in PremiumBoxItems)
                if (!AvailableItems.Exists(x => x.Item1 == item.Item1)) AvailableItems.Add(item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlayerData();
            UpdateBalanceUI();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SavePlayerData();
        }

        public void UpdateBalanceUI()
        {
            balance.Text = "Balance: " + coins;
        }

        public void SavePlayerData()
        {
            try
            {
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                List<string> lines = new List<string>();
                lines.Add(coins.ToString());
                lines.AddRange(playerInventory);

                File.WriteAllLines(saveFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving failed: " + ex.Message);
            }
        }

        public void LoadPlayerData()
        {
            try
            {
                if (File.Exists(saveFilePath))
                {
                    string[] lines = File.ReadAllLines(saveFilePath);
                    if (lines.Length > 0)
                    {
                        int.TryParse(lines[0], out int loadedCoins);
                        this.coins = loadedCoins;

                        playerInventory.Clear();
                        for (int i = 1; i < lines.Length; i++)
                        {
                            playerInventory.Add(lines[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading data failed: " + ex.Message);
            }
        }

        private void OpenBox(int boxPrice, List<Tuple<string, int, int>> itemList)
        {
            if (coins < boxPrice)
            {
                MessageBox.Show("You don't have enough coins to open a box!");
                return;
            }

            coins -= boxPrice;

            int totalWeight = 0;
            foreach (var item in itemList)
            {
                totalWeight += item.Item2;
            }

            int roll = random.Next(totalWeight);
            string droppedItem = "";
            int currentSum = 0;

            foreach (var item in itemList)
            {
                currentSum += item.Item2;
                if (roll < currentSum)
                {
                    droppedItem = item.Item1;
                    break;
                }
            }

            playerInventory.Add(droppedItem);
            opened.Text = "Opened: " + droppedItem;
            UpdateBalanceUI();
            SavePlayerData();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenBox(0, FreeBoxItems);
        }

        private void OpenBox1Btn_Click(object sender, EventArgs e)
        {
            OpenBox(20, MediumBoxItems);
        }

        private void OpenBox2Btn_Click(object sender, EventArgs e)
        {
            OpenBox(50, PremiumBoxItems);
        }

        private void InvBtn_Click(object sender, EventArgs e)
        {
            Inventory inventoryForm = new Inventory(this, playerInventory);
            inventoryForm.ShowDialog();

            UpdateBalanceUI();
            SavePlayerData();
        }
    }
}