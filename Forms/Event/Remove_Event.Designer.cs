namespace CyberQuest_Innovations.Forms
{
    partial class Remove_Event
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
            this.btnEBack = new System.Windows.Forms.Button();
            this.btnERemove = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(45, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Remove a Event";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(212, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Event ID of the Event to remove:";
            // 
            // btnEBack
            // 
            this.btnEBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEBack.Location = new System.Drawing.Point(12, 168);
            this.btnEBack.Name = "btnEBack";
            this.btnEBack.Size = new System.Drawing.Size(69, 50);
            this.btnEBack.TabIndex = 10;
            this.btnEBack.Text = "Back";
            this.btnEBack.UseVisualStyleBackColor = true;
            this.btnEBack.Click += new System.EventHandler(this.btnEBack_Click);
            // 
            // btnERemove
            // 
            this.btnERemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnERemove.Location = new System.Drawing.Point(170, 168);
            this.btnERemove.Name = "btnERemove";
            this.btnERemove.Size = new System.Drawing.Size(69, 50);
            this.btnERemove.TabIndex = 12;
            this.btnERemove.Text = "Remove";
            this.btnERemove.UseVisualStyleBackColor = true;
            this.btnERemove.Click += new System.EventHandler(this.btnERemove_Click);
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(15, 103);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(224, 23);
            this.tb1.TabIndex = 13;
            // 
            // Remove_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 236);
            this.ControlBox = false;
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnERemove);
            this.Controls.Add(this.btnEBack);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Remove_Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove_Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnEBack;
        private System.Windows.Forms.Button btnERemove;
        private System.Windows.Forms.TextBox tb1;
    }
}