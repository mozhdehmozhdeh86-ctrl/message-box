using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا از خروج خود اطمینان دارید؟", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
