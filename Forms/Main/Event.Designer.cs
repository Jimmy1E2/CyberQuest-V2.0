namespace CyberQuest_Innovations.Forms
{
    partial class Event
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
            this.cal1 = new System.Windows.Forms.MonthCalendar();
            this.lblSel = new System.Windows.Forms.Label();
            this.tbSelected = new System.Windows.Forms.TextBox();
            this.lblStu = new System.Windows.Forms.Label();
            this.tbStu = new System.Windows.Forms.TextBox();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.btnCRemove = new System.Windows.Forms.Button();
            this.cbCAttend = new System.Windows.Forms.CheckBox();
            this.btnCSubmit = new System.Windows.Forms.Button();
            this.tbCEventDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cal1
            // 
            this.cal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal1.Location = new System.Drawing.Point(18, 18);
            this.cal1.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.cal1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.cal1.Name = "cal1";
            this.cal1.TabIndex = 0;
            this.cal1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal1_DateChanged);
            // 
            // lblSel
            // 
            this.lblSel.AutoSize = true;
            this.lblSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSel.Location = new System.Drawing.Point(288, 18);
            this.lblSel.Name = "lblSel";
            this.lblSel.Size = new System.Drawing.Size(101, 17);
            this.lblSel.TabIndex = 1;
            this.lblSel.Text = "Selected Date:";
            // 
            // tbSelected
            // 
            this.tbSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSelected.Location = new System.Drawing.Point(291, 39);
            this.tbSelected.Multiline = true;
            this.tbSelected.Name = "tbSelected";
            this.tbSelected.ReadOnly = true;
            this.tbSelected.Size = new System.Drawing.Size(159, 20);
            this.tbSelected.TabIndex = 2;
            this.tbSelected.TextChanged += new System.EventHandler(this.tbSelected_TextChanged);
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStu.Location = new System.Drawing.Point(288, 86);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(78, 17);
            this.lblStu.TabIndex = 3;
            this.lblStu.Text = "Student ID:";
            // 
            // tbStu
            // 
            this.tbStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStu.Location = new System.Drawing.Point(291, 106);
            this.tbStu.Multiline = true;
            this.tbStu.Name = "tbStu";
            this.tbStu.Size = new System.Drawing.Size(159, 20);
            this.tbStu.TabIndex = 4;
            // 
            // btnCAdd
            // 
            this.btnCAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAdd.Location = new System.Drawing.Point(18, 193);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(75, 68);
            this.btnCAdd.TabIndex = 5;
            this.btnCAdd.Text = "Add a new Event";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCUpdate.Location = new System.Drawing.Point(99, 193);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(75, 68);
            this.btnCUpdate.TabIndex = 6;
            this.btnCUpdate.Text = "Update a Event";
            this.btnCUpdate.UseVisualStyleBackColor = true;
            this.btnCUpdate.Click += new System.EventHandler(this.btnCUpdate_Click);
            // 
            // btnCRemove
            // 
            this.btnCRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRemove.Location = new System.Drawing.Point(180, 192);
            this.btnCRemove.Name = "btnCRemove";
            this.btnCRemove.Size = new System.Drawing.Size(75, 68);
            this.btnCRemove.TabIndex = 7;
            this.btnCRemove.Text = "Remove a Event";
            this.btnCRemove.UseVisualStyleBackColor = true;
            this.btnCRemove.Click += new System.EventHandler(this.btnCRemove_Click);
            // 
            // cbCAttend
            // 
            this.cbCAttend.AutoSize = true;
            this.cbCAttend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCAttend.Location = new System.Drawing.Point(291, 153);
            this.cbCAttend.Name = "cbCAttend";
            this.cbCAttend.Size = new System.Drawing.Size(148, 21);
            this.cbCAttend.TabIndex = 8;
            this.cbCAttend.Text = "Attended the Event";
            this.cbCAttend.UseVisualStyleBackColor = true;
            // 
            // btnCSubmit
            // 
            this.btnCSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSubmit.Location = new System.Drawing.Point(326, 192);
            this.btnCSubmit.Name = "btnCSubmit";
            this.btnCSubmit.Size = new System.Drawing.Size(124, 68);
            this.btnCSubmit.TabIndex = 9;
            this.btnCSubmit.Text = "Submit Entry";
            this.btnCSubmit.UseVisualStyleBackColor = true;
            // 
            // tbCEventDescription
            // 
            this.tbCEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCEventDescription.Location = new System.Drawing.Point(18, 279);
            this.tbCEventDescription.Multiline = true;
            this.tbCEventDescription.Name = "tbCEventDescription";
            this.tbCEventDescription.ReadOnly = true;
            this.tbCEventDescription.Size = new System.Drawing.Size(432, 79);
            this.tbCEventDescription.TabIndex = 10;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCEventDescription);
            this.Controls.Add(this.btnCSubmit);
            this.Controls.Add(this.cbCAttend);
            this.Controls.Add(this.btnCRemove);
            this.Controls.Add(this.btnCUpdate);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.tbStu);
            this.Controls.Add(this.lblStu);
            this.Controls.Add(this.tbSelected);
            this.Controls.Add(this.lblSel);
            this.Controls.Add(this.cal1);
            this.Name = "Event";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal1;
        private System.Windows.Forms.Label lblSel;
        private System.Windows.Forms.TextBox tbSelected;
        private System.Windows.Forms.Label lblStu;
        private System.Windows.Forms.TextBox tbStu;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCRemove;
        private System.Windows.Forms.CheckBox cbCAttend;
        private System.Windows.Forms.Button btnCSubmit;
        private System.Windows.Forms.TextBox tbCEventDescription;
    }
}