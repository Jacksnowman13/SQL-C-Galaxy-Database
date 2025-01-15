using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nah
{
    public partial class Navigation : Form
    {
        //navigation
        public Navigation()
        {
            InitializeComponent();
            //initialize
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go to new star page 
            Form frm = new NewStar();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //go to search star page
            Form frm = new SearchStar();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close out of program
            this.Close();

        }
    }
}
