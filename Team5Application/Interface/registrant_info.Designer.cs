namespace Team5Application.Interface
{
    partial class registrant_info
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
            this.btnAddChild = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.waivercb = new System.Windows.Forms.CheckBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.editMyInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAddAdult = new System.Windows.Forms.Button();
            this.current_owe = new System.Windows.Forms.Label();
            this.lblAmtOwed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(6, 115);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(188, 33);
            this.btnAddChild.TabIndex = 18;
            this.btnAddChild.Text = "Add Child";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 95);
            this.listBox1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.waivercb);
            this.groupBox1.Controls.Add(this.lblGroup);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Controls.Add(this.editMyInfo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 168);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Information";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(253, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 32);
            this.label11.TabIndex = 39;
            this.label11.Text = "\"I agree to release all harm for event organizers and the City of Chicago.\"";
            // 
            // waivercb
            // 
            this.waivercb.AutoSize = true;
            this.waivercb.Enabled = false;
            this.waivercb.Location = new System.Drawing.Point(232, 128);
            this.waivercb.Name = "waivercb";
            this.waivercb.Size = new System.Drawing.Size(15, 14);
            this.waivercb.TabIndex = 38;
            this.waivercb.UseVisualStyleBackColor = true;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(6, 127);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(50, 18);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "Group";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 91);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 18);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 18);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(6, 55);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(80, 18);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(6, 37);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(81, 18);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // editMyInfo
            // 
            this.editMyInfo.AutoSize = true;
            this.editMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMyInfo.Location = new System.Drawing.Point(366, 15);
            this.editMyInfo.Name = "editMyInfo";
            this.editMyInfo.Size = new System.Drawing.Size(120, 16);
            this.editMyInfo.TabIndex = 0;
            this.editMyInfo.TabStop = true;
            this.editMyInfo.Text = "Edit My Information";
            this.editMyInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editMyInfo_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btnAddChild);
            this.groupBox2.Location = new System.Drawing.Point(36, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 154);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Children";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.btnAddAdult);
            this.groupBox3.Location = new System.Drawing.Point(285, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 154);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Additional Adults";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 95);
            this.listBox2.TabIndex = 26;
            // 
            // btnAddAdult
            // 
            this.btnAddAdult.Location = new System.Drawing.Point(6, 109);
            this.btnAddAdult.Name = "btnAddAdult";
            this.btnAddAdult.Size = new System.Drawing.Size(188, 33);
            this.btnAddAdult.TabIndex = 25;
            this.btnAddAdult.Text = "Add Adult";
            this.btnAddAdult.UseVisualStyleBackColor = true;
            this.btnAddAdult.Click += new System.EventHandler(this.btnAddAdult_Click);
            // 
            // current_owe
            // 
            this.current_owe.AutoSize = true;
            this.current_owe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_owe.Location = new System.Drawing.Point(11, 368);
            this.current_owe.Name = "current_owe";
            this.current_owe.Size = new System.Drawing.Size(163, 20);
            this.current_owe.TabIndex = 23;
            this.current_owe.Text = "You Currently Owe:";
            this.current_owe.Click += new System.EventHandler(this.current_owe_Click);
            // 
            // lblAmtOwed
            // 
            this.lblAmtOwed.AutoSize = true;
            this.lblAmtOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmtOwed.Location = new System.Drawing.Point(180, 368);
            this.lblAmtOwed.Name = "lblAmtOwed";
            this.lblAmtOwed.Size = new System.Drawing.Size(40, 20);
            this.lblAmtOwed.TabIndex = 24;
            this.lblAmtOwed.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Payment is due on day of event!";
            // 
            // registrant_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAmtOwed);
            this.Controls.Add(this.current_owe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "registrant_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Registrant Information";
            this.Load += new System.EventHandler(this.registrant_info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel editMyInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAddAdult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox waivercb;
        private System.Windows.Forms.Label current_owe;
        private System.Windows.Forms.Label lblAmtOwed;
        private System.Windows.Forms.Label label1;
    }
}