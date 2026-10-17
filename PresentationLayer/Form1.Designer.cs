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
            this.SuspendLayout();
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(230, 258);
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
            this.txtSpecies.Location = new System.Drawing.Point(12, 86);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(135, 20);
            this.txtSpecies.TabIndex = 9;
            this.txtSpecies.Text = "Species";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 20);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(12, 8);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 366);
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
    }
}

