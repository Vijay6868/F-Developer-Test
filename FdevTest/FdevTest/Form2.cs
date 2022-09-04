using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FdevTest
{
    public partial class Form2 : Form
    {
        private DataModule DM;
        private frmJobMenu JobMenuForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (JobMenuForm == null)
            {
                JobMenuForm= new frmJobMenu(DM,this);
            }
            JobMenuForm.ShowDialog();
        }
    }
}
