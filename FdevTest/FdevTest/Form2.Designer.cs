namespace FdevTest
{
    partial class Form2
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
            this.btnViewJobList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewJobList
            // 
            this.btnViewJobList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewJobList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewJobList.Location = new System.Drawing.Point(54, 73);
            this.btnViewJobList.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewJobList.Name = "btnViewJobList";
            this.btnViewJobList.Size = new System.Drawing.Size(214, 93);
            this.btnViewJobList.TabIndex = 0;
            this.btnViewJobList.Text = "View Job List";
            this.btnViewJobList.UseVisualStyleBackColor = false;
            this.btnViewJobList.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnViewJobList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewJobList;
    }
}