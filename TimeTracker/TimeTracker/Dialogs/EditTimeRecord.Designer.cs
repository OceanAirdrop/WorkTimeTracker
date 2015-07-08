namespace TimeTracker.Dialogs
{
    partial class EditTimeRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTimeRecord));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTimeAccrued = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPMONumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWorkEndTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWorkStartDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWorkId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxFriendlyTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBoxFriendlyTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxTimeAccrued);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxPMONumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxWorkEndTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxWorkStartDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxWorkId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 288);
            this.panel1.TabIndex = 1;
            // 
            // textBoxTimeAccrued
            // 
            this.textBoxTimeAccrued.Enabled = false;
            this.textBoxTimeAccrued.Location = new System.Drawing.Point(116, 182);
            this.textBoxTimeAccrued.Name = "textBoxTimeAccrued";
            this.textBoxTimeAccrued.Size = new System.Drawing.Size(176, 20);
            this.textBoxTimeAccrued.TabIndex = 15;
            this.textBoxTimeAccrued.TextChanged += new System.EventHandler(this.textBoxTimeAccrued_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Location = new System.Drawing.Point(26, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time Accrued";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Enabled = false;
            this.textBoxDescription.Location = new System.Drawing.Point(117, 102);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(175, 20);
            this.textBoxDescription.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PMO Description";
            // 
            // textBoxPMONumber
            // 
            this.textBoxPMONumber.Location = new System.Drawing.Point(117, 76);
            this.textBoxPMONumber.Name = "textBoxPMONumber";
            this.textBoxPMONumber.Size = new System.Drawing.Size(175, 20);
            this.textBoxPMONumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PMO Number";
            // 
            // textBoxWorkEndTime
            // 
            this.textBoxWorkEndTime.Location = new System.Drawing.Point(116, 154);
            this.textBoxWorkEndTime.Name = "textBoxWorkEndTime";
            this.textBoxWorkEndTime.Size = new System.Drawing.Size(177, 20);
            this.textBoxWorkEndTime.TabIndex = 9;
            this.textBoxWorkEndTime.TextChanged += new System.EventHandler(this.textBoxWorkEndTime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Work End Time";
            // 
            // textBoxWorkStartDate
            // 
            this.textBoxWorkStartDate.Location = new System.Drawing.Point(116, 128);
            this.textBoxWorkStartDate.Name = "textBoxWorkStartDate";
            this.textBoxWorkStartDate.Size = new System.Drawing.Size(176, 20);
            this.textBoxWorkStartDate.TabIndex = 7;
            this.textBoxWorkStartDate.TextChanged += new System.EventHandler(this.textBoxWorkStartDate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Work Start Time";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(116, 50);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(176, 20);
            this.textBoxDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // textBoxWorkId
            // 
            this.textBoxWorkId.Enabled = false;
            this.textBoxWorkId.Location = new System.Drawing.Point(116, 24);
            this.textBoxWorkId.Name = "textBoxWorkId";
            this.textBoxWorkId.Size = new System.Drawing.Size(176, 20);
            this.textBoxWorkId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work Id";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(221, 249);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(302, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxFriendlyTime
            // 
            this.textBoxFriendlyTime.Enabled = false;
            this.textBoxFriendlyTime.Location = new System.Drawing.Point(116, 208);
            this.textBoxFriendlyTime.Name = "textBoxFriendlyTime";
            this.textBoxFriendlyTime.Size = new System.Drawing.Size(176, 20);
            this.textBoxFriendlyTime.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Location = new System.Drawing.Point(26, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Friendly Time";
            // 
            // EditTimeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 288);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTimeRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Time Record";
            this.Load += new System.EventHandler(this.EditTimeRecord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.TextBox textBoxTimeAccrued;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxPMONumber;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxWorkEndTime;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxWorkStartDate;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxWorkId;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxFriendlyTime;
        private System.Windows.Forms.Label label8;
    }
}