namespace BAOBAB_RIDGE_PROJECT_2781
{
    partial class Form1
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
            this.summaryBtn = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.AddAnimals = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Seach = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(270, 317);
            this.summaryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(144, 62);
            this.summaryBtn.TabIndex = 0;
            this.summaryBtn.Text = "Generate Sumary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(16, 228);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(179, 22);
            this.txtStatus.TabIndex = 11;
            this.txtStatus.Text = "Status";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(16, 170);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(179, 22);
            this.txtAge.TabIndex = 10;
            this.txtAge.Text = "Age";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(16, 106);
            this.txtSpecies.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(179, 22);
            this.txtSpecies.TabIndex = 9;
            this.txtSpecies.Text = "Species";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 22);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(16, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(179, 22);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "Animal ID";
            // 
            // AddAnimals
            // 
            this.AddAnimals.Location = new System.Drawing.Point(16, 297);
            this.AddAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.AddAnimals.Name = "AddAnimals";
            this.AddAnimals.Size = new System.Drawing.Size(236, 82);
            this.AddAnimals.TabIndex = 6;
            this.AddAnimals.Text = "Add";
            this.AddAnimals.UseVisualStyleBackColor = true;
            this.AddAnimals.Click += new System.EventHandler(this.AddAnimals_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 216);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Seach
            // 
            this.Seach.Location = new System.Drawing.Point(16, 267);
            this.Seach.Name = "Seach";
            this.Seach.Size = new System.Drawing.Size(75, 23);
            this.Seach.TabIndex = 16;
            this.Seach.Text = "Search";
            this.Seach.UseVisualStyleBackColor = true;
            this.Seach.Click += new System.EventHandler(this.Seach_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(600, 317);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(127, 62);
            this.clear.TabIndex = 17;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(767, 317);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(104, 62);
            this.saveChanges.TabIndex = 18;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 267);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 528);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Seach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.AddAnimals);
            this.Controls.Add(this.summaryBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button AddAnimals;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Seach;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

