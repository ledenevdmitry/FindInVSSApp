using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindInVSSApp
{
    public partial class MainForm : Form
    {
        Finder finder;

        public MainForm()
        {
            finder = new Finder();
            InitializeComponent();
        }

        private void BtAddRoot_Click(object sender, EventArgs e)
        {
            AddRootsForm arf = new AddRootsForm();
            arf.ShowDialog();
        }

        private void BtFindOne_Click(object sender, EventArgs e)
        {
            finder.FindOne(TbPattern.Text, Convert.ToInt32(NUDDepth.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finder.FindMany(TbPattern.Text, Convert.ToInt32(NUDDepth.Value));
        }
    }
}
