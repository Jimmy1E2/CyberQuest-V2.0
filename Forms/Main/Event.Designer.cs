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
            this.lblStu = new System.Windows.Forms.Label();
            this.tbStu = new System.Windows.Forms.TextBox();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.btnCUpdate = new System.Windows.Forms.Button();
            this.btnCRemove = new System.Windows.Forms.Button();
            this.cbCAttend = new System.Windows.Forms.CheckBox();
            this.btnCSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStu.Location = new System.Drawing.Point(15, 18);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(78, 17);
            this.lblStu.TabIndex = 3;
            this.lblStu.Text = "Student ID:";
            // 
            // tbStu
            // 
            this.tbStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStu.Location = new System.Drawing.Point(18, 39);
            this.tbStu.Multiline = true;
            this.tbStu.Name = "tbStu";
            this.tbStu.Size = new System.Drawing.Size(159, 20);
            this.tbStu.TabIndex = 4;
            // 
            // btnCAdd
            // 
            this.btnCAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAdd.Location = new System.Drawing.Point(232, 12);
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
            this.btnCUpdate.Location = new System.Drawing.Point(232, 86);
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
            this.btnCRemove.Location = new System.Drawing.Point(232, 160);
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
            this.cbCAttend.Location = new System.Drawing.Point(640, 38);
            this.cbCAttend.Name = "cbCAttend";
            this.cbCAttend.Size = new System.Drawing.Size(148, 21);
            this.cbCAttend.TabIndex = 8;
            this.cbCAttend.Text = "Attended the Event";
            this.cbCAttend.UseVisualStyleBackColor = true;
            // 
            // btnCSubmit
            // 
            this.btnCSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSubmit.Location = new System.Drawing.Point(18, 160);
            this.btnCSubmit.Name = "btnCSubmit";
            this.btnCSubmit.Size = new System.Drawing.Size(159, 68);
            this.btnCSubmit.TabIndex = 9;
            this.btnCSubmit.Text = "Submit Entry";
            this.btnCSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID:";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(18, 110);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(159, 21);
            this.cb1.TabIndex = 11;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCSubmit);
            this.Controls.Add(this.cbCAttend);
            this.Controls.Add(this.btnCRemove);
            this.Controls.Add(this.btnCUpdate);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.tbStu);
            this.Controls.Add(this.lblStu);
            this.Name = "Event";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStu;
        private System.Windows.Forms.TextBox tbStu;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCRemove;
        private System.Windows.Forms.CheckBox cbCAttend;
        private System.Windows.Forms.Button btnCSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
    }
}