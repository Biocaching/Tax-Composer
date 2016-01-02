namespace Tax_Composer
{
    partial class addEolForm
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
            this.resultContainer = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.eolNameLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.eolSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultContainer
            // 
            this.resultContainer.Controls.Add(this.saveBtn);
            this.resultContainer.Controls.Add(this.idLbl);
            this.resultContainer.Controls.Add(this.eolNameLbl);
            this.resultContainer.Location = new System.Drawing.Point(10, 38);
            this.resultContainer.Name = "resultContainer";
            this.resultContainer.Size = new System.Drawing.Size(360, 125);
            this.resultContainer.TabIndex = 7;
            this.resultContainer.TabStop = false;
            this.resultContainer.Text = "Result";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(279, 91);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(9, 67);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(24, 13);
            this.idLbl.TabIndex = 2;
            this.idLbl.Text = "ID: ";
            // 
            // eolNameLbl
            // 
            this.eolNameLbl.AutoSize = true;
            this.eolNameLbl.Location = new System.Drawing.Point(9, 42);
            this.eolNameLbl.Name = "eolNameLbl";
            this.eolNameLbl.Size = new System.Drawing.Size(34, 13);
            this.eolNameLbl.TabIndex = 1;
            this.eolNameLbl.Text = "EOL: ";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(295, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // eolSearchBox
            // 
            this.eolSearchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.eolSearchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.eolSearchBox.Location = new System.Drawing.Point(60, 12);
            this.eolSearchBox.Name = "eolSearchBox";
            this.eolSearchBox.Size = new System.Drawing.Size(229, 20);
            this.eolSearchBox.TabIndex = 1;
            this.eolSearchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.eolSearchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search: ";
            // 
            // addEolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 172);
            this.Controls.Add(this.resultContainer);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.eolSearchBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "addEolForm";
            this.Text = "Encyclopedia of Life";
            this.resultContainer.ResumeLayout(false);
            this.resultContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox resultContainer;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label eolNameLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox eolSearchBox;
        private System.Windows.Forms.Label label1;
    }
}