using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ARM_Engineer.Parts
{
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void Parts_Load(object sender, EventArgs e)
        {

        }

        private void Add_parts_Click(object sender, EventArgs e)
        {
            AddParts addParts = new AddParts();
            addParts.Show();
        }
    }
}
