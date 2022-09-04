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
    public partial class frmJobMenu : Form
    {
        private DataModule DM;
        private Form2 frm2;
        
        
        private bool loaded=false;

        public frmJobMenu(DataModule dm, Form2 frm2)
        {

            InitializeComponent();
            DM = dm;
            
            this.frm2 = frm2;    

        
            BindControls();
            loaded = true;

            
            
            displayNotes();
        }


        public void BindControls()
        {
            txtJobID.DataBindings.Add("Text", DM.dsJobDetails, "jobDetails.jobID");
            lstJobDetails.DataSource = DM.dsJobDetails;
            lstJobDetails.DisplayMember = "jobDetails.jobID";
            lstJobDetails.ValueMember = "jobDetails.jobID";
            txtAdress.DataBindings.Add("Text", DM.dsJobDetails, "jobDetails.cAddress");
            txtDateCreated.DataBindings.Add("Text", DM.dsJobDetails,"jobDetails.creation");
            txtEmail.DataBindings.Add("Text", DM.dsJobDetails, "jobDetails.cEmail");
            txtJobStatus.DataBindings.Add("Text", DM.dsJobDetails, "jobDetails.status");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsJobDetails, "jobDetails.cPhoneNumber");
            txtName.DataBindings.Add("Text", DM.dsJobDetails, "jobDetails.cName");

        }

        private void dgvNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstJobDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (loaded)
            {
                displayNotes();
            }

        }

        private void cbSortJoblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortJoblist.Text == "Desc")
            {
               
                OleDbCommand command = new OleDbCommand("Select * from jobDetails order by jobid desc" , DM.ctnJobDetails);
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                
                DataSet ds = new DataSet();
                da.Fill(ds);
                lstJobDetails.DataSource = ds;
                lstJobDetails.DisplayMember = "jobDetails.jobID";
                lstJobDetails.ValueMember = "jobDetails.jobID";
            }
        }
        private void displayNotes()
        {
            OleDbCommand command = new OleDbCommand("Select * from notes where jobid=" + lstJobDetails.Text, DM.ctnJobDetails);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNotes.DataSource = dt;
            dgvNotes.Columns[0].Visible = false;
            dgvNotes.Columns[1].Visible = false;
        }

        private void frmJobMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
