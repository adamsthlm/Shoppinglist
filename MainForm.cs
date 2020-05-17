using System;
using System.Windows.Forms;

namespace Shoppinglist
{
    public partial class MainForm : Form
    {

        ItemManager 
            itemManager = new ItemManager();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      
    }
}
