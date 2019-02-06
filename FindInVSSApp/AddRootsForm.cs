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
    public partial class AddRootsForm : Form
    {
        public AddRootsForm()
        {
            InitializeComponent();
            TbRoots.Text = IniUtils.GetConfig("Settings", "Roots");
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            IniUtils.SetConfig("Settings", "Roots", TbRoots.Text.Replace(Environment.NewLine, "|"));      
            Close();
        }
    }
}
