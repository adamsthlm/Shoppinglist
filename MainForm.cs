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
            // set defaul to piece
            cmbUnit.SelectedIndex = (int)UnitTypes.piece;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


    }
}
