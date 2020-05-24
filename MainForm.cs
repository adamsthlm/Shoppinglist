/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/

using System;
using System.Windows.Forms;

namespace Shoppinglist
{
    public partial class MainForm : Form
    {
        readonly ItemManager itemManager = new ItemManager();

        public MainForm()
        {
            InitializeComponent(); // made by VS

            // initialize controls
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // fill combo-box with options
            cmbUnit.Items.AddRange(Enum.GetNames(typeof(UnitTypes)));
            // set default to piece
            cmbUnit.SelectedIndex = (int)UnitTypes.piece;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            // Read data for the new item
            // if error ReadInput provides messages to the user
            // item is created in the ReadInput
            // took me 4 days to find i had missed the '=' sign! whaaaaw!
            ShoppingItem item = ReadInput(out bool success);

            if (success)
            {
                itemManager.AddItem(item);
                UpdateGUI();
            }
        }

        private void UpdateGUI()
        {
            listOfItems.Items.Clear();
            listOfItems.Items.AddRange(itemManager.GetItemsInfoStrings());
        }

        private ShoppingItem ReadInput(out bool success)
        {

            ShoppingItem item = new ShoppingItem
            {

                // Read description
                Description = ReadDescription(out success)
            };
            if (!success)
            {
                return null;
            }

            // Read amount
            item.Amount = ReadAmount(out success);
            if (!success)
            {
                return null;
            }

            // Read Unit
            item.Units = ReadUnit(out success);

            return item;

        }

        private UnitTypes ReadUnit(out bool success)
        {
            success = false;
            UnitTypes unit = UnitTypes.lb;
            if (cmbUnit.SelectedIndex >= 0)
            {
                success = true;
                unit = (UnitTypes)cmbUnit.SelectedIndex;
            }
            else
                GiveMessage("Wrong unit");
            return unit;

        }

        private double ReadAmount(out bool success)
        {
            success = false;

            if (!double.TryParse(AmountTXTBox.Text, out double amount))
            {
                GiveMessage("Wrong amount!");
                AmountTXTBox.Focus();
                AmountTXTBox.SelectionStart = 0;
                AmountTXTBox.SelectionLength = AmountTXTBox.TextLength;
            }
            else
                success = true;

            return amount;
        }

        private void GiveMessage(string v)
        {
            MessageBox.Show(v, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string ReadDescription(out bool success)
        {

            string text = DescriptionTXTBox.Text.Trim();
            success = false;
            if (!string.IsNullOrEmpty(text))
            {
                success = true;
            }
            else
                GiveMessage("Enter a description");
            return text;

        }

        private void ListOfItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfItems.SelectedIndex < 0)
                return;

            ShoppingItem item = itemManager.GetItem(listOfItems.SelectedIndex);
            AmountTXTBox.Text = item.Amount.ToString();
            DescriptionTXTBox.Text = item.Description;
            cmbUnit.SelectedIndex = (int)item.Units;
        }

        private void CmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            int index = listOfItems.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Please select an item");
                return;
            }
            else
            {
                itemManager.DeleteItem(index);
                listOfItems.Items.Clear();
               

                foreach (ShoppingItem index2 in itemManager.itemList)
                {
                    listOfItems.Items.Add(index2);
                }
            }

            UpdateGUI();


        }

    } // end main
} // end namespace


