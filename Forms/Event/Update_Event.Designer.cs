namespace CyberQuest_Innovations.Forms
{
    partial class Update_Event
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnEBack = new System.Windows.Forms.Button();
            this.btnEClear = new System.Windows.Forms.Button();
            this.btnESubmit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.event_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Event ID:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(288, 13);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(199, 17);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Enter new name for the Event:";
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventName.Location = new System.Drawing.Point(291, 39);
            this.tbEventName.Multiline = true;
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(227, 20);
            this.tbEventName.TabIndex = 5;
            this.tbEventName.TextChanged += new System.EventHandler(this.tbEventName_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(288, 92);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(202, 17);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Enter a new Event Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(291, 121);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(243, 80);
            this.tbDescription.TabIndex = 7;
            // 
            // btnEBack
            // 
            this.btnEBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEBack.Location = new System.Drawing.Point(291, 224);
            this.btnEBack.Name = "btnEBack";
            this.btnEBack.Size = new System.Drawing.Size(71, 50);
            this.btnEBack.TabIndex = 10;
            this.btnEBack.Text = "Back";
            this.btnEBack.UseVisualStyleBackColor = true;
            this.btnEBack.Click += new System.EventHandler(this.btnEBack_Click);
            // 
            // btnEClear
            // 
            this.btnEClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEClear.Location = new System.Drawing.Point(379, 224);
            this.btnEClear.Name = "btnEClear";
            this.btnEClear.Size = new System.Drawing.Size(71, 50);
            this.btnEClear.TabIndex = 11;
            this.btnEClear.Text = "Clear Fields";
            this.btnEClear.UseVisualStyleBackColor = true;
            this.btnEClear.Click += new System.EventHandler(this.btnEClear_Click);
            // 
            // btnESubmit
            // 
            this.btnESubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESubmit.Location = new System.Drawing.Point(468, 224);
            this.btnESubmit.Name = "btnESubmit";
            this.btnESubmit.Size = new System.Drawing.Size(66, 50);
            this.btnESubmit.TabIndex = 12;
            this.btnESubmit.Text = "Submit";
            this.btnESubmit.UseVisualStyleBackColor = true;
            this.btnESubmit.Click += new System.EventHandler(this.btnESubmit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Update a Event";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(12, 89);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(200, 20);
            this.tbID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select a Date to Edit";
            // 
            // event_DatePicker
            // 
            this.event_DatePicker.Location = new System.Drawing.Point(12, 172);
            this.event_DatePicker.Name = "event_DatePicker";
            this.event_DatePicker.Size = new System.Drawing.Size(200, 20);
            this.event_DatePicker.TabIndex = 16;
            // 
            // Update_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 285);
            this.ControlBox = false;
            this.Controls.Add(this.event_DatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnESubmit);
            this.Controls.Add(this.btnEClear);
            this.Controls.Add(this.btnEBack);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Update_Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnEBack;
        private System.Windows.Forms.Button btnEClear;
        private System.Windows.Forms.Button btnESubmit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker event_DatePicker;
    }
}