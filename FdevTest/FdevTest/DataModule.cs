using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FdevTest
{
    public partial class DataModule : Form
    {
        public DataTable dtJobDetails;
        public DataTable dtNotes;
        public DataModule()
        {
            InitializeComponent();
            dsJobDetails.EnforceConstraints = false;
            daJobDetails.Fill(dsJobDetails);
            dtJobDetails=dsJobDetails.Tables["jobDetails"];

            daNotes.Fill(dsJobDetails);
            dtNotes = dsJobDetails.Tables["notes"];


            dsJobDetails.EnforceConstraints=true;
        }

        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void ctnJobDetails_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }

        private void daJobDetails_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }
    }
}
