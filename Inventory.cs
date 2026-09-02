using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lopputyo
{
    public partial class Inventory : Form
    {
        private Form1 mainForm;
        private List<string> inventoryItems;

        public Inventory(Form1 form, List<string> items)
        {
            InitializeComponent();
            mainForm = form;
            inventoryItems = items;
            itemsList.SelectedIndexChanged += itemsList_SelectedIndexChanged;
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            PopulateInventoryList();
            UpdateTotalWorth();
            UpdateSelectedWorth();
            UpdateBalanceUI();
        }

        private void PopulateInventoryList()
        {
            itemsList.Items.Clear();

            foreach (string item in inventoryItems)
            {
                itemsList.Items.Add(item);
            }
        }

        private void UpdateBalanceUI()
        {
            balance.Text = "Balance: " + mainForm.Coins;
        }

        private int GetItemPrice(string itemName)
        {
            foreach (var item in Form1.AvailableItems)
            {
                if (item.Item1 == itemName)
                {
                    return item.Item3;
                }
            }
            return 0;
        }

        private void sellbtn_Click(object sender, EventArgs e)
        {
            if (itemsList.SelectedItem == null)
            {
                MessageBox.Show("Please select an item to sell first!");
                return;
            }

            string selectedItem = itemsList.SelectedItem.ToString();
            int sellPrice = GetItemPrice(selectedItem);

            mainForm.Coins += sellPrice;

            inventoryItems.Remove(selectedItem);
            itemsList.Items.Remove(selectedItem);

            MessageBox.Show($"Sold {selectedItem} for {sellPrice} coins!");
            UpdateTotalWorth();
            UpdateSelectedWorth();
            UpdateBalanceUI();
        }

        private void sellallbtn_Click(object sender, EventArgs e)
        {
            if (inventoryItems.Count == 0)
            {
                MessageBox.Show("Your inventory is already empty!");
                return;
            }

            int totalEarned = 0;

            foreach (string item in inventoryItems)
            {
                totalEarned += GetItemPrice(item);
            }

            mainForm.Coins += totalEarned;
            inventoryItems.Clear();
            itemsList.Items.Clear();

            MessageBox.Show($"Sold all items for a total of {totalEarned} coins!");
            UpdateTotalWorth();
            UpdateSelectedWorth();
            UpdateBalanceUI();
        }

        private void UpdateTotalWorth()
        {
            int total = 0;

            foreach (string item in inventoryItems)
            {
                total += GetItemPrice(item);
            }

            worth.Text = "Inventory worth: " + total;
        }

        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedWorth();
        }

        private void UpdateSelectedWorth()
        {
            if (itemsList.SelectedItem == null)
            {
                itemworth.Text = "Selected Item worth: -";
                return;
            }

            string selectedItem = itemsList.SelectedItem.ToString();
            int sellPrice = GetItemPrice(selectedItem);

            itemworth.Text = "Selected Item worth: " + sellPrice;
        }
    }
}