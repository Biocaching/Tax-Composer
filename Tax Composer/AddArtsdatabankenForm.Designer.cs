namespace Tax_Composer
{
    partial class addArtsdatabankenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.resultContainer = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.sNameLbl = new System.Windows.Forms.Label();
            this.nNameLbl = new System.Windows.Forms.Label();
            this.resultContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search: ";
            // 
            // searchBox
            // 
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.Location = new System.Drawing.Point(65, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(229, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            this.searchBox.Leave += new System.EventHandler(this.searchBox_Leave);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(300, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // resultContainer
            // 
            this.resultContainer.Controls.Add(this.saveBtn);
            this.resultContainer.Controls.Add(this.idLbl);
            this.resultContainer.Controls.Add(this.sNameLbl);
            this.resultContainer.Controls.Add(this.nNameLbl);
            this.resultContainer.Location = new System.Drawing.Point(15, 32);
            this.resultContainer.Name = "resultContainer";
            this.resultContainer.Size = new System.Drawing.Size(360, 159);
            this.resultContainer.TabIndex = 3;
            this.resultContainer.TabStop = false;
            this.resultContainer.Text = "Result";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(279, 130);
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
            // sNameLbl
            // 
            this.sNameLbl.AutoSize = true;
            this.sNameLbl.Location = new System.Drawing.Point(9, 42);
            this.sNameLbl.Name = "sNameLbl";
            this.sNameLbl.Size = new System.Drawing.Size(88, 13);
            this.sNameLbl.TabIndex = 1;
            this.sNameLbl.Text = "Scientific name : ";
            // 
            // nNameLbl
            // 
            this.nNameLbl.AutoSize = true;
            this.nNameLbl.Location = new System.Drawing.Point(9, 16);
            this.nNameLbl.Name = "nNameLbl";
            this.nNameLbl.Size = new System.Drawing.Size(90, 13);
            this.nNameLbl.TabIndex = 0;
            this.nNameLbl.Text = "Norwegian name:";
            // 
            // addArtsdatabankenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 210);
            this.Controls.Add(this.resultContainer);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "addArtsdatabankenForm";
            this.Text = "Artsdatabanken";
            this.resultContainer.ResumeLayout(false);
            this.resultContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox resultContainer;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label sNameLbl;
        private System.Windows.Forms.Label nNameLbl;
        private System.Windows.Forms.Button saveBtn;
    }
}