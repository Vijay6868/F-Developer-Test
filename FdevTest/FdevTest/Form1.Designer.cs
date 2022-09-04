namespace FdevTest
{
    partial class frmJobMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstJobDetails = new System.Windows.Forms.ListBox();
            this.lblJonbID = new System.Windows.Forms.Label();
            this.lblJobID = new System.Windows.Forms.Label();
            this.lblJobsStatus = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClientDetails = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblJobDetails = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.RichTextBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.lblJobList = new System.Windows.Forms.Label();
            this.cbSortJoblist = new System.Windows.Forms.ComboBox();
            this.txtJobStatus = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lstJobDetails
            // 
            this.lstJobDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJobDetails.FormattingEnabled = true;
            this.lstJobDetails.ItemHeight = 25;
            this.lstJobDetails.Location = new System.Drawing.Point(29, 90);
            this.lstJobDetails.Margin = new System.Windows.Forms.Padding(4);
            this.lstJobDetails.Name = "lstJobDetails";
            this.lstJobDetails.Size = new System.Drawing.Size(120, 354);
            this.lstJobDetails.TabIndex = 0;
            this.lstJobDetails.SelectedIndexChanged += new System.EventHandler(this.lstJobDetails_SelectedIndexChanged);
            // 
            // lblJonbID
            // 
            this.lblJonbID.AutoSize = true;
            this.lblJonbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJonbID.Location = new System.Drawing.Point(336, 93);
            this.lblJonbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJonbID.Name = "lblJonbID";
            this.lblJonbID.Size = new System.Drawing.Size(71, 25);
            this.lblJonbID.TabIndex = 1;
            this.lblJonbID.Text = "Job id:";
            // 
            // lblJobID
            // 
            this.lblJobID.AutoSize = true;
            this.lblJobID.Location = new System.Drawing.Point(424, 104);
            this.lblJobID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobID.Name = "lblJobID";
            this.lblJobID.Size = new System.Drawing.Size(0, 16);
            this.lblJobID.TabIndex = 2;
            // 
            // lblJobsStatus
            // 
            this.lblJobsStatus.AutoSize = true;
            this.lblJobsStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobsStatus.Location = new System.Drawing.Point(296, 128);
            this.lblJobsStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobsStatus.Name = "lblJobsStatus";
            this.lblJobsStatus.Size = new System.Drawing.Size(112, 25);
            this.lblJobsStatus.TabIndex = 3;
            this.lblJobsStatus.Text = "Job Status:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreated.Location = new System.Drawing.Point(276, 164);
            this.lblDateCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(134, 25);
            this.lblDateCreated.TabIndex = 4;
            this.lblDateCreated.Text = "Date Created:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(786, 97);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(70, 25);
            this.lblClientName.TabIndex = 5;
            this.lblClientName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(701, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phone Number:";
            // 
            // lblClientDetails
            // 
            this.lblClientDetails.AutoSize = true;
            this.lblClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientDetails.Location = new System.Drawing.Point(698, 58);
            this.lblClientDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientDetails.Name = "lblClientDetails";
            this.lblClientDetails.Size = new System.Drawing.Size(147, 25);
            this.lblClientDetails.TabIndex = 7;
            this.lblClientDetails.Text = "Client Details:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(790, 181);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 25);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblJobDetails
            // 
            this.lblJobDetails.AutoSize = true;
            this.lblJobDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobDetails.Location = new System.Drawing.Point(277, 58);
            this.lblJobDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobDetails.Name = "lblJobDetails";
            this.lblJobDetails.Size = new System.Drawing.Size(127, 25);
            this.lblJobDetails.TabIndex = 9;
            this.lblJobDetails.Text = "Job Details:";
            // 
            // txtJobID
            // 
            this.txtJobID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobID.Location = new System.Drawing.Point(432, 90);
            this.txtJobID.Margin = new System.Windows.Forms.Padding(4);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.ReadOnly = true;
            this.txtJobID.Size = new System.Drawing.Size(44, 29);
            this.txtJobID.TabIndex = 10;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCreated.Location = new System.Drawing.Point(432, 162);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(103, 29);
            this.txtDateCreated.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(876, 95);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(228, 29);
            this.txtName.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(876, 132);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(192, 29);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(876, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(316, 29);
            this.txtEmail.TabIndex = 15;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(764, 218);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(91, 25);
            this.lblAdress.TabIndex = 16;
            this.lblAdress.Text = "Address:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(276, 248);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(69, 25);
            this.lblNotes.TabIndex = 18;
            this.lblNotes.Text = "Notes:";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.Location = new System.Drawing.Point(876, 218);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(316, 81);
            this.txtAdress.TabIndex = 20;
            this.txtAdress.Text = "";
            // 
            // dgvNotes
            // 
            this.dgvNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotes.ColumnHeadersHeight = 29;
            this.dgvNotes.Location = new System.Drawing.Point(359, 248);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.RowHeadersWidth = 51;
            this.dgvNotes.RowTemplate.Height = 24;
            this.dgvNotes.Size = new System.Drawing.Size(343, 230);
            this.dgvNotes.TabIndex = 21;
            this.dgvNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellContentClick);
            // 
            // lblJobList
            // 
            this.lblJobList.AutoSize = true;
            this.lblJobList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobList.Location = new System.Drawing.Point(35, 58);
            this.lblJobList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobList.Name = "lblJobList";
            this.lblJobList.Size = new System.Drawing.Size(95, 25);
            this.lblJobList.TabIndex = 23;
            this.lblJobList.Text = "Job List:";
            // 
            // cbSortJoblist
            // 
            this.cbSortJoblist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortJoblist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortJoblist.FormattingEnabled = true;
            this.cbSortJoblist.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.cbSortJoblist.Location = new System.Drawing.Point(78, 464);
            this.cbSortJoblist.Name = "cbSortJoblist";
            this.cbSortJoblist.Size = new System.Drawing.Size(71, 30);
            this.cbSortJoblist.TabIndex = 25;
            this.cbSortJoblist.SelectedIndexChanged += new System.EventHandler(this.cbSortJoblist_SelectedIndexChanged);
            // 
            // txtJobStatus
            // 
            this.txtJobStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtJobStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobStatus.FormattingEnabled = true;
            this.txtJobStatus.Items.AddRange(new object[] {
            "to priced",
            "pending",
            "invoicing",
            "completed",
            "pricing"});
            this.txtJobStatus.Location = new System.Drawing.Point(432, 128);
            this.txtJobStatus.Name = "txtJobStatus";
            this.txtJobStatus.Size = new System.Drawing.Size(121, 30);
            this.txtJobStatus.TabIndex = 26;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(24, 469);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(54, 25);
            this.lblSort.TabIndex = 27;
            this.lblSort.Text = "Sort:";
            // 
            // frmJobMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 667);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.txtJobStatus);
            this.Controls.Add(this.cbSortJoblist);
            this.Controls.Add(this.lblJobList);
            this.Controls.Add(this.dgvNotes);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtJobID);
            this.Controls.Add(this.lblJobDetails);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblClientDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblJobsStatus);
            this.Controls.Add(this.lblJobID);
            this.Controls.Add(this.lblJonbID);
            this.Controls.Add(this.lstJobDetails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJobMenu";
            this.Text = "JobMenu";
            this.Load += new System.EventHandler(this.frmJobMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstJobDetails;
        private System.Windows.Forms.Label lblJonbID;
        private System.Windows.Forms.Label lblJobID;
        private System.Windows.Forms.Label lblJobsStatus;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblJobDetails;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox txtAdress;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Label lblJobList;
        private System.Windows.Forms.ComboBox cbSortJoblist;
        private System.Windows.Forms.ComboBox txtJobStatus;
        private System.Windows.Forms.Label lblSort;
    }
}

