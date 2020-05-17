using System;
using System.Windows.Forms;

namespace Shoppinglist
{
    public partial class MainForm : Form
    {

        ItemManager itemManager = new ItemManager();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = false;

            // Read data for the new item
            // if error ReadInput provides messages to the user
            // item is created in the ReadInput

            ShoppingItem item ReadInput (out success);

            if (success)
            {
                itemManager.AddItem(item);
                UpdateGUI();
            }
        }

        private void UpdateGUI()
        {
            throw new NotImplementedException();
        }

        private ShoppingItem ReadInput(out bool success)
        {
            success = false;

            ShoppingItem item = new ShoppingItem();

            // Read description
            item.Description = ReadDescription(out success);
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
            // Not developed yet.
            throw new NotImplementedException();
        }

        private double ReadAmount(out bool success)
        {
            double amount = 0.0;
            success = false;

            if (!double.TryParse(AmountTXTBox.Text, out amount))
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
            
            string description;
            success = false;

            DescriptionTXTBox.Focus();
            description = DescriptionTXTBox.Text;

            success = true;
            return description;
        }
    }
}
