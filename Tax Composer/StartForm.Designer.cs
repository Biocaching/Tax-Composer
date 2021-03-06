﻿namespace Tax_Composer
{
    partial class startForm
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsLbl = new System.Windows.Forms.Label();
            this.depthLbl = new System.Windows.Forms.Label();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.taxTreeView = new System.Windows.Forms.TreeView();
            this.treeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newChidContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSourceContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sNameLbl = new System.Windows.Forms.Label();
            this.sTypeLbl = new System.Windows.Forms.Label();
            this.sIdLbl = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.treeContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMainMenu,
            this.viewToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(502, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "Main menu";
            // 
            // fileMainMenu
            // 
            this.fileMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMainMenu,
            this.openFileMainMenu,
            this.saveFileMenuItem});
            this.fileMainMenu.Name = "fileMainMenu";
            this.fileMainMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMainMenu.Text = "File";
            // 
            // newFileMainMenu
            // 
            this.newFileMainMenu.Name = "newFileMainMenu";
            this.newFileMainMenu.Size = new System.Drawing.Size(103, 22);
            this.newFileMainMenu.Text = "New";
            this.newFileMainMenu.Click += new System.EventHandler(this.newFileMainMenu_Click);
            // 
            // openFileMainMenu
            // 
            this.openFileMainMenu.Name = "openFileMainMenu";
            this.openFileMainMenu.Size = new System.Drawing.Size(103, 22);
            this.openFileMainMenu.Text = "Open";
            this.openFileMainMenu.Click += new System.EventHandler(this.openFileMainMenu_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveFileMenuItem.Text = "Save";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collapseMenuItem,
            this.expandMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // collapseMenuItem
            // 
            this.collapseMenuItem.Name = "collapseMenuItem";
            this.collapseMenuItem.Size = new System.Drawing.Size(142, 22);
            this.collapseMenuItem.Text = "Collapse tree";
            this.collapseMenuItem.Click += new System.EventHandler(this.collapseMenuItem_Click);
            // 
            // expandMenuItem
            // 
            this.expandMenuItem.Name = "expandMenuItem";
            this.expandMenuItem.Size = new System.Drawing.Size(142, 22);
            this.expandMenuItem.Text = "Expand tree";
            this.expandMenuItem.Click += new System.EventHandler(this.expandMenuItem_Click);
            // 
            // itemsLbl
            // 
            this.itemsLbl.AutoSize = true;
            this.itemsLbl.Location = new System.Drawing.Point(325, 87);
            this.itemsLbl.Name = "itemsLbl";
            this.itemsLbl.Size = new System.Drawing.Size(44, 13);
            this.itemsLbl.TabIndex = 9;
            this.itemsLbl.Text = "Items: 0";
            // 
            // depthLbl
            // 
            this.depthLbl.AutoSize = true;
            this.depthLbl.Location = new System.Drawing.Point(325, 65);
            this.depthLbl.Name = "depthLbl";
            this.depthLbl.Size = new System.Drawing.Size(48, 13);
            this.depthLbl.TabIndex = 8;
            this.depthLbl.Text = "Depth: 0";
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(325, 43);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(47, 13);
            this.sourceLbl.TabIndex = 7;
            this.sourceLbl.Text = "Source: ";
            // 
            // taxTreeView
            // 
            this.taxTreeView.Location = new System.Drawing.Point(12, 34);
            this.taxTreeView.Name = "taxTreeView";
            this.taxTreeView.Size = new System.Drawing.Size(298, 376);
            this.taxTreeView.TabIndex = 5;
            this.taxTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.taxTreeView_NodeMouseClick);
            // 
            // treeContextMenu
            // 
            this.treeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newChidContextMenu,
            this.editContextMenu,
            this.removeContextMenu});
            this.treeContextMenu.Name = "treeContextMenu";
            this.treeContextMenu.Size = new System.Drawing.Size(125, 70);
            // 
            // newChidContextMenu
            // 
            this.newChidContextMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromSourceContextMenu,
            this.customContextMenu});
            this.newChidContextMenu.Name = "newChidContextMenu";
            this.newChidContextMenu.Size = new System.Drawing.Size(124, 22);
            this.newChidContextMenu.Text = "New chid";
            // 
            // fromSourceContextMenu
            // 
            this.fromSourceContextMenu.Name = "fromSourceContextMenu";
            this.fromSourceContextMenu.Size = new System.Drawing.Size(140, 22);
            this.fromSourceContextMenu.Text = "From source";
            this.fromSourceContextMenu.Click += new System.EventHandler(this.fromSourceContextMenu_Click);
            // 
            // customContextMenu
            // 
            this.customContextMenu.Name = "customContextMenu";
            this.customContextMenu.Size = new System.Drawing.Size(140, 22);
            this.customContextMenu.Text = "Custom";
            this.customContextMenu.Click += new System.EventHandler(this.customContextMenu_Click);
            // 
            // editContextMenu
            // 
            this.editContextMenu.Name = "editContextMenu";
            this.editContextMenu.Size = new System.Drawing.Size(124, 22);
            this.editContextMenu.Text = "Edit";
            this.editContextMenu.Click += new System.EventHandler(this.editContextMenu_Click);
            // 
            // removeContextMenu
            // 
            this.removeContextMenu.Name = "removeContextMenu";
            this.removeContextMenu.Size = new System.Drawing.Size(124, 22);
            this.removeContextMenu.Text = "Remove";
            this.removeContextMenu.Click += new System.EventHandler(this.removeContextMenu_Click);
            // 
            // sNameLbl
            // 
            this.sNameLbl.AutoSize = true;
            this.sNameLbl.Location = new System.Drawing.Point(325, 316);
            this.sNameLbl.Name = "sNameLbl";
            this.sNameLbl.Size = new System.Drawing.Size(41, 13);
            this.sNameLbl.TabIndex = 10;
            this.sNameLbl.Text = "Name: ";
            // 
            // sTypeLbl
            // 
            this.sTypeLbl.AutoSize = true;
            this.sTypeLbl.Location = new System.Drawing.Point(325, 339);
            this.sTypeLbl.Name = "sTypeLbl";
            this.sTypeLbl.Size = new System.Drawing.Size(37, 13);
            this.sTypeLbl.TabIndex = 11;
            this.sTypeLbl.Text = "Type: ";
            // 
            // sIdLbl
            // 
            this.sIdLbl.AutoSize = true;
            this.sIdLbl.Location = new System.Drawing.Point(325, 361);
            this.sIdLbl.Name = "sIdLbl";
            this.sIdLbl.Size = new System.Drawing.Size(24, 13);
            this.sIdLbl.TabIndex = 12;
            this.sIdLbl.Text = "ID: ";
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 444);
            this.Controls.Add(this.sIdLbl);
            this.Controls.Add(this.sTypeLbl);
            this.Controls.Add(this.sNameLbl);
            this.Controls.Add(this.itemsLbl);
            this.Controls.Add(this.depthLbl);
            this.Controls.Add(this.sourceLbl);
            this.Controls.Add(this.taxTreeView);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "startForm";
            this.Text = "Tax Composer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startForm_KeyDown);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.treeContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMainMenu;
        private System.Windows.Forms.Label itemsLbl;
        private System.Windows.Forms.Label depthLbl;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.TreeView taxTreeView;
        private System.Windows.Forms.ContextMenuStrip treeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newChidContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem fromSourceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem customContextMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandMenuItem;
        private System.Windows.Forms.Label sNameLbl;
        private System.Windows.Forms.Label sTypeLbl;
        private System.Windows.Forms.Label sIdLbl;
    }
}

