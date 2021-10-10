namespace CyberQuest_Innovations.Forms
{
    partial class Add_Event
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnESubmit = new System.Windows.Forms.Button();
            this.btnEClear = new System.Windows.Forms.Button();
            this.btnEBack = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(181, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add a new Event";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(187, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Select a new Date for Event:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 270);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(170, 17);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Enter name for the Event:";
            // 
            // tbEventName
            // 
            this.tbEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEventName.Location = new System.Drawing.Point(15, 291);
            this.tbEventName.Multiline = true;
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(227, 20);
            this.tbEventName.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(294, 61);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(173, 17);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Enter a Event Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(297, 87);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(243, 101);
            this.tbDescription.TabIndex = 6;
            // 
            // btnESubmit
            // 
            this.btnESubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESubmit.Location = new System.Drawing.Point(463, 260);
            this.btnESubmit.Name = "btnESubmit";
            this.btnESubmit.Size = new System.Drawing.Size(77, 50);
            this.btnESubmit.TabIndex = 7;
            this.btnESubmit.Text = "Submit";
            this.btnESubmit.UseVisualStyleBackColor = true;
            this.btnESubmit.Click += new System.EventHandler(this.btnESubmit_Click);
            // 
            // btnEClear
            // 
            this.btnEClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEClear.Location = new System.Drawing.Point(380, 260);
            this.btnEClear.Name = "btnEClear";
            this.btnEClear.Size = new System.Drawing.Size(77, 50);
            this.btnEClear.TabIndex = 8;
            this.btnEClear.Text = "Clear Fields";
            this.btnEClear.UseVisualStyleBackColor = true;
            this.btnEClear.Click += new System.EventHandler(this.btnEClear_Click);
            // 
            // btnEBack
            // 
            this.btnEBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEBack.Location = new System.Drawing.Point(297, 261);
            this.btnEBack.Name = "btnEBack";
            this.btnEBack.Size = new System.Drawing.Size(77, 50);
            this.btnEBack.TabIndex = 9;
            this.btnEBack.Text = "Back";
            this.btnEBack.UseVisualStyleBackColor = true;
            this.btnEBack.Click += new System.EventHandler(this.btnEBack_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // Add_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 329);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEBack);
            this.Controls.Add(this.btnEClear);
            this.Controls.Add(this.btnESubmit);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnESubmit;
        private System.Windows.Forms.Button btnEClear;
        private System.Windows.Forms.Button btnEBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}