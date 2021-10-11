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
            this.btnCSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.dbView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStu
            // 
            this.lblStu.AutoSize = true;
            this.lblStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStu.Location = new System.Drawing.Point(591, 18);
            this.lblStu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(93, 20);
            this.lblStu.TabIndex = 3;
            this.lblStu.Text = "Student ID:";
            // 
            // tbStu
            // 
            this.tbStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStu.Location = new System.Drawing.Point(591, 43);
            this.tbStu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStu.Multiline = true;
            this.tbStu.Name = "tbStu";
            this.tbStu.Size = new System.Drawing.Size(211, 24);
            this.tbStu.TabIndex = 4;
            // 
            // btnCAdd
            // 
            this.btnCAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAdd.Location = new System.Drawing.Point(863, 43);
            this.btnCAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(144, 84);
            this.btnCAdd.TabIndex = 5;
            this.btnCAdd.Text = "Add a new Event";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // btnCUpdate
            // 
            this.btnCUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCUpdate.Location = new System.Drawing.Point(863, 167);
            this.btnCUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCUpdate.Name = "btnCUpdate";
            this.btnCUpdate.Size = new System.Drawing.Size(144, 84);
            this.btnCUpdate.TabIndex = 6;
            this.btnCUpdate.Text = "Update a Event";
            this.btnCUpdate.UseVisualStyleBackColor = true;
            this.btnCUpdate.Click += new System.EventHandler(this.btnCUpdate_Click);
            // 
            // btnCRemove
            // 
            this.btnCRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRemove.Location = new System.Drawing.Point(863, 302);
            this.btnCRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCRemove.Name = "btnCRemove";
            this.btnCRemove.Size = new System.Drawing.Size(144, 84);
            this.btnCRemove.TabIndex = 7;
            this.btnCRemove.Text = "Remove a Event";
            this.btnCRemove.UseVisualStyleBackColor = true;
            this.btnCRemove.Click += new System.EventHandler(this.btnCRemove_Click);
            // 
            // btnCSubmit
            // 
            this.btnCSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSubmit.Location = new System.Drawing.Point(591, 302);
            this.btnCSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCSubmit.Name = "btnCSubmit";
            this.btnCSubmit.Size = new System.Drawing.Size(212, 84);
            this.btnCSubmit.TabIndex = 9;
            this.btnCSubmit.Text = "Attend Event";
            this.btnCSubmit.UseVisualStyleBackColor = true;
            this.btnCSubmit.Click += new System.EventHandler(this.btnCSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selected Event:";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(591, 102);
            this.cb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(211, 24);
            this.cb1.TabIndex = 11;
            // 
            // dbView
            // 
            this.dbView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbView.Location = new System.Drawing.Point(17, 16);
            this.dbView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dbView.Name = "dbView";
            this.dbView.RowHeadersWidth = 51;
            this.dbView.Size = new System.Drawing.Size(565, 369);
            this.dbView.TabIndex = 12;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dbView);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCSubmit);
            this.Controls.Add(this.btnCRemove);
            this.Controls.Add(this.btnCUpdate);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.tbStu);
            this.Controls.Add(this.lblStu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Event";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStu;
        private System.Windows.Forms.TextBox tbStu;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCUpdate;
        private System.Windows.Forms.Button btnCRemove;
        private System.Windows.Forms.Button btnCSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.DataGridView dbView;
    }
}