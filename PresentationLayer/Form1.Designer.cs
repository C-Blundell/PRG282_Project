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
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ReportBox = new System.Windows.Forms.GroupBox();
            this.RecLabel = new System.Windows.Forms.Label();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.StableLabel = new System.Windows.Forms.Label();
            this.SeriousLabel = new System.Windows.Forms.Label();
            this.CriticalLabel = new System.Windows.Forms.Label();
            this.AveRecLabel = new System.Windows.Forms.Label();
            this.AveAgeLabel = new System.Windows.Forms.Label();
            this.TotalAniLabel = new System.Windows.Forms.Label();
            this.genLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAnimalName = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ReportBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(202, 258);
            this.summaryBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(108, 50);
            this.summaryBtn.TabIndex = 0;
            this.summaryBtn.Text = "Generate Sumary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 185);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(135, 20);
            this.txtStatus.TabIndex = 11;
            this.txtStatus.Text = "Status";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 138);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(135, 20);
            this.txtAge.TabIndex = 10;
            this.txtAge.Text = "Age";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(12, 97);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(135, 20);
            this.txtSpecies.TabIndex = 9;
            this.txtSpecies.Text = "Species";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(135, 20);
            this.txtID.TabIndex = 7;
            this.txtID.Text = "Animal ID";
            // 
            // AddAnimals
            // 
            this.AddAnimals.Location = new System.Drawing.Point(12, 241);
            this.AddAnimals.Name = "AddAnimals";
            this.AddAnimals.Size = new System.Drawing.Size(177, 67);
            this.AddAnimals.TabIndex = 6;
            this.AddAnimals.Text = "Add";
            this.AddAnimals.UseVisualStyleBackColor = true;
            this.AddAnimals.Click += new System.EventHandler(this.AddAnimals_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(506, 176);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Seach
            // 
            this.Seach.Location = new System.Drawing.Point(151, 217);
            this.Seach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Seach.Name = "Seach";
            this.Seach.Size = new System.Drawing.Size(56, 19);
            this.Seach.TabIndex = 16;
            this.Seach.Text = "Search";
            this.Seach.UseVisualStyleBackColor = true;
            this.Seach.Click += new System.EventHandler(this.Seach_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(444, 258);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(95, 50);
            this.clear.TabIndex = 17;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(560, 258);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(78, 50);
            this.saveChanges.TabIndex = 18;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 216);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "Search";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(327, 258);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 50);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(649, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ReportBox
            // 
            this.ReportBox.Controls.Add(this.RecLabel);
            this.ReportBox.Controls.Add(this.ReleaseLabel);
            this.ReportBox.Controls.Add(this.StableLabel);
            this.ReportBox.Controls.Add(this.SeriousLabel);
            this.ReportBox.Controls.Add(this.CriticalLabel);
            this.ReportBox.Controls.Add(this.AveRecLabel);
            this.ReportBox.Controls.Add(this.AveAgeLabel);
            this.ReportBox.Controls.Add(this.TotalAniLabel);
            this.ReportBox.Controls.Add(this.genLabel);
            this.ReportBox.Controls.Add(this.label9);
            this.ReportBox.Controls.Add(this.label8);
            this.ReportBox.Controls.Add(this.label7);
            this.ReportBox.Controls.Add(this.label6);
            this.ReportBox.Controls.Add(this.label5);
            this.ReportBox.Controls.Add(this.label4);
            this.ReportBox.Controls.Add(this.label3);
            this.ReportBox.Controls.Add(this.label2);
            this.ReportBox.Controls.Add(this.label1);
            this.ReportBox.Location = new System.Drawing.Point(12, 323);
            this.ReportBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportBox.Size = new System.Drawing.Size(712, 188);
            this.ReportBox.TabIndex = 22;
            this.ReportBox.TabStop = false;
            this.ReportBox.Text = "ANIMAL SUMMARY REPORT";
            this.ReportBox.Visible = false;
            // 
            // RecLabel
            // 
            this.RecLabel.AutoSize = true;
            this.RecLabel.Location = new System.Drawing.Point(482, 119);
            this.RecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecLabel.Name = "RecLabel";
            this.RecLabel.Size = new System.Drawing.Size(41, 13);
            this.RecLabel.TabIndex = 17;
            this.RecLabel.Text = "label17";
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.Location = new System.Drawing.Point(482, 148);
            this.ReleaseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.Size = new System.Drawing.Size(41, 13);
            this.ReleaseLabel.TabIndex = 16;
            this.ReleaseLabel.Text = "label18";
            // 
            // StableLabel
            // 
            this.StableLabel.AutoSize = true;
            this.StableLabel.Location = new System.Drawing.Point(482, 89);
            this.StableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StableLabel.Name = "StableLabel";
            this.StableLabel.Size = new System.Drawing.Size(41, 13);
            this.StableLabel.TabIndex = 15;
            this.StableLabel.Text = "label16";
            // 
            // SeriousLabel
            // 
            this.SeriousLabel.AutoSize = true;
            this.SeriousLabel.Location = new System.Drawing.Point(482, 58);
            this.SeriousLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeriousLabel.Name = "SeriousLabel";
            this.SeriousLabel.Size = new System.Drawing.Size(41, 13);
            this.SeriousLabel.TabIndex = 14;
            this.SeriousLabel.Text = "label15";
            // 
            // CriticalLabel
            // 
            this.CriticalLabel.AutoSize = true;
            this.CriticalLabel.Location = new System.Drawing.Point(482, 28);
            this.CriticalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CriticalLabel.Name = "CriticalLabel";
            this.CriticalLabel.Size = new System.Drawing.Size(41, 13);
            this.CriticalLabel.TabIndex = 13;
            this.CriticalLabel.Text = "label14";
            // 
            // AveRecLabel
            // 
            this.AveRecLabel.AutoSize = true;
            this.AveRecLabel.Location = new System.Drawing.Point(150, 140);
            this.AveRecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AveRecLabel.Name = "AveRecLabel";
            this.AveRecLabel.Size = new System.Drawing.Size(41, 13);
            this.AveRecLabel.TabIndex = 12;
            this.AveRecLabel.Text = "label13";
            // 
            // AveAgeLabel
            // 
            this.AveAgeLabel.AutoSize = true;
            this.AveAgeLabel.Location = new System.Drawing.Point(150, 104);
            this.AveAgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AveAgeLabel.Name = "AveAgeLabel";
            this.AveAgeLabel.Size = new System.Drawing.Size(41, 13);
            this.AveAgeLabel.TabIndex = 11;
            this.AveAgeLabel.Text = "label12";
            // 
            // TotalAniLabel
            // 
            this.TotalAniLabel.AutoSize = true;
            this.TotalAniLabel.Location = new System.Drawing.Point(150, 67);
            this.TotalAniLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalAniLabel.Name = "TotalAniLabel";
            this.TotalAniLabel.Size = new System.Drawing.Size(41, 13);
            this.TotalAniLabel.TabIndex = 10;
            this.TotalAniLabel.Text = "label11";
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Location = new System.Drawing.Point(150, 28);
            this.genLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(41, 13);
            this.genLabel.TabIndex = 9;
            this.genLabel.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Release-Ready:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Recovering:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Stable:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Serious:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Critical:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average recovery score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average age (years):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total animals:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generated:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 4);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(49, 13);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "AnimalID";
            // 
            // lblAnimalName
            // 
            this.lblAnimalName.AutoSize = true;
            this.lblAnimalName.Location = new System.Drawing.Point(12, 45);
            this.lblAnimalName.Name = "lblAnimalName";
            this.lblAnimalName.Size = new System.Drawing.Size(35, 13);
            this.lblAnimalName.TabIndex = 24;
            this.lblAnimalName.Text = "Name";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(12, 84);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(45, 13);
            this.lblSpecies.TabIndex = 25;
            this.lblSpecies.Text = "Species";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 26;
            this.lblAge.Text = "Age";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 521);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.lblAnimalName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.ReportBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ReportBox.ResumeLayout(false);
            this.ReportBox.PerformLayout();
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
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox ReportBox;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.Label StableLabel;
        private System.Windows.Forms.Label SeriousLabel;
        private System.Windows.Forms.Label CriticalLabel;
        private System.Windows.Forms.Label AveRecLabel;
        private System.Windows.Forms.Label AveAgeLabel;
        private System.Windows.Forms.Label TotalAniLabel;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RecLabel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAnimalName;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblStatus;
    }
}

