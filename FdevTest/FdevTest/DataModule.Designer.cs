namespace FdevTest
{
    partial class DataModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModule));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnJobDetails = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daNotes = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daJobDetails = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            this.dsJobDetails = new FdevTest.DSJob();
            ((System.ComponentModel.ISupportInitialize)(this.dsJobDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT     noteId, jobId, [note]\r\nFROM        notes\r\nORDER BY noteId DESC";
            this.oleDbSelectCommand1.Connection = this.ctnJobDetails;
            // 
            // ctnJobDetails
            // 
            this.ctnJobDetails.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\saroy\\Desktop\\version2\\Fde" +
    "vTest\\job.accdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `notes` (`jobId`, `note`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.ctnJobDetails;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("jobId", System.Data.OleDb.OleDbType.Integer, 0, "jobId"),
            new System.Data.OleDb.OleDbParameter("note", System.Data.OleDb.OleDbType.LongVarWChar, 0, "note")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `notes` SET `jobId` = ?, `note` = ? WHERE ((`noteId` = ?) AND ((? = 1 AND " +
    "`jobId` IS NULL) OR (`jobId` = ?)))";
            this.oleDbUpdateCommand1.Connection = this.ctnJobDetails;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("jobId", System.Data.OleDb.OleDbType.Integer, 0, "jobId"),
            new System.Data.OleDb.OleDbParameter("note", System.Data.OleDb.OleDbType.LongVarWChar, 0, "note"),
            new System.Data.OleDb.OleDbParameter("Original_noteId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "noteId", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_jobId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "jobId", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_jobId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "jobId", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `notes` WHERE ((`noteId` = ?) AND ((? = 1 AND `jobId` IS NULL) OR (`j" +
    "obId` = ?)))";
            this.oleDbDeleteCommand1.Connection = this.ctnJobDetails;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_noteId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "noteId", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_jobId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "jobId", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_jobId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "jobId", System.Data.DataRowVersion.Original, null)});
            // 
            // daNotes
            // 
            this.daNotes.DeleteCommand = this.oleDbDeleteCommand1;
            this.daNotes.InsertCommand = this.oleDbInsertCommand1;
            this.daNotes.SelectCommand = this.oleDbSelectCommand1;
            this.daNotes.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "notes", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("noteId", "noteId"),
                        new System.Data.Common.DataColumnMapping("jobId", "jobId"),
                        new System.Data.Common.DataColumnMapping("note", "note")})});
            this.daNotes.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT     jobID, status, creation, cName, cAddress, cPhoneNumber, cEmail\r\nFROM  " +
    "      jobDetails\r\nORDER BY jobID";
            this.oleDbSelectCommand2.Connection = this.ctnJobDetails;
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnJobDetails;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_jobID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "jobID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_creation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cPhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cPhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cPhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cPhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cEmail", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cEmail", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cEmail", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cEmail", System.Data.DataRowVersion.Original, null)});
            // 
            // daJobDetails
            // 
            this.daJobDetails.DeleteCommand = this.oleDbDeleteCommand2;
            this.daJobDetails.InsertCommand = this.oleDbInsertCommand;
            this.daJobDetails.SelectCommand = this.oleDbSelectCommand2;
            this.daJobDetails.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "jobDetails", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("jobID", "jobID"),
                        new System.Data.Common.DataColumnMapping("status", "status"),
                        new System.Data.Common.DataColumnMapping("creation", "creation"),
                        new System.Data.Common.DataColumnMapping("cName", "cName"),
                        new System.Data.Common.DataColumnMapping("cAddress", "cAddress"),
                        new System.Data.Common.DataColumnMapping("cPhoneNumber", "cPhoneNumber"),
                        new System.Data.Common.DataColumnMapping("cEmail", "cEmail")})});
            this.daJobDetails.UpdateCommand = this.oleDbUpdateCommand;
            this.daJobDetails.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daJobDetails_RowUpdated);
            // 
            // oleDbInsertCommand
            // 
            this.oleDbInsertCommand.CommandText = "INSERT INTO `jobDetails` (`status`, `creation`, `cName`, `cAddress`, `cPhoneNumbe" +
    "r`, `cEmail`) VALUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand.Connection = this.ctnJobDetails;
            this.oleDbInsertCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status"),
            new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Date, 0, "creation"),
            new System.Data.OleDb.OleDbParameter("cName", System.Data.OleDb.OleDbType.VarWChar, 0, "cName"),
            new System.Data.OleDb.OleDbParameter("cAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "cAddress"),
            new System.Data.OleDb.OleDbParameter("cPhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "cPhoneNumber"),
            new System.Data.OleDb.OleDbParameter("cEmail", System.Data.OleDb.OleDbType.VarWChar, 0, "cEmail")});
            // 
            // oleDbUpdateCommand
            // 
            this.oleDbUpdateCommand.CommandText = resources.GetString("oleDbUpdateCommand.CommandText");
            this.oleDbUpdateCommand.Connection = this.ctnJobDetails;
            this.oleDbUpdateCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("status", System.Data.OleDb.OleDbType.VarWChar, 0, "status"),
            new System.Data.OleDb.OleDbParameter("creation", System.Data.OleDb.OleDbType.Date, 0, "creation"),
            new System.Data.OleDb.OleDbParameter("cName", System.Data.OleDb.OleDbType.VarWChar, 0, "cName"),
            new System.Data.OleDb.OleDbParameter("cAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "cAddress"),
            new System.Data.OleDb.OleDbParameter("cPhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "cPhoneNumber"),
            new System.Data.OleDb.OleDbParameter("cEmail", System.Data.OleDb.OleDbType.VarWChar, 0, "cEmail"),
            new System.Data.OleDb.OleDbParameter("Original_jobID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "jobID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_creation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_creation", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "creation", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cPhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cPhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cPhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cPhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cEmail", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cEmail", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cEmail", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cEmail", System.Data.DataRowVersion.Original, null)});
            // 
            // dsJobDetails
            // 
            this.dsJobDetails.DataSetName = "DSJob";
            this.dsJobDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataModule";
            this.Text = "DataModule";
            this.Load += new System.EventHandler(this.DataModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsJobDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daNotes;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daJobDetails;
        public DSJob dsJobDetails;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand;
        public System.Data.OleDb.OleDbConnection ctnJobDetails;
    }
}