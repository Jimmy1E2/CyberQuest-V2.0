namespace CyberQuest_Innovations.Forms
{
    partial class Corri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbCor_Description = new System.Windows.Forms.TextBox();
            this.btnDescription = new System.Windows.Forms.Button();
            this.btnRAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(644, 293);
            this.dataGridView1.TabIndex = 2;
            // 
            // tbCor_Description
            // 
            this.tbCor_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCor_Description.Location = new System.Drawing.Point(15, 327);
            this.tbCor_Description.Margin = new System.Windows.Forms.Padding(4);
            this.tbCor_Description.Multiline = true;
            this.tbCor_Description.Name = "tbCor_Description";
            this.tbCor_Description.Size = new System.Drawing.Size(644, 102);
            this.tbCor_Description.TabIndex = 5;
            // 
            // btnDescription
            // 
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescription.Location = new System.Drawing.Point(700, 327);
            this.btnDescription.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(213, 63);
            this.btnDescription.TabIndex = 6;
            this.btnDescription.Text = "Corridor Decription";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // btnRAdd
            // 
            this.btnRAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAdd.Location = new System.Drawing.Point(700, 15);
            this.btnRAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnRAdd.Name = "btnRAdd";
            this.btnRAdd.Size = new System.Drawing.Size(213, 63);
            this.btnRAdd.TabIndex = 7;
            this.btnRAdd.Text = "Add a Room";
            this.btnRAdd.UseVisualStyleBackColor = true;
            this.btnRAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(700, 97);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(213, 63);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove a Room";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Corri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRAdd);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.tbCor_Description);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Corri";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Corri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCor_Description;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.Button btnRAdd;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}