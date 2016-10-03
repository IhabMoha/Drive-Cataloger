namespace DriveCataloger
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCurrentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrentDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogADriverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentDatabaseInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(140, 109);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(132, 127);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 127);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 127);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(275, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 127);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(274, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 127);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.catalogingToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDatabaseToolStripMenuItem,
            this.changeDatabaseToolStripMenuItem,
            this.showCurrentDatabaseInformationToolStripMenuItem,
            this.resetCurrentDatabaseToolStripMenuItem,
            this.deleteCurrentDatabaseToolStripMenuItem,
            this.setDefaultDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // newDatabaseToolStripMenuItem
            // 
            this.newDatabaseToolStripMenuItem.Name = "newDatabaseToolStripMenuItem";
            this.newDatabaseToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.newDatabaseToolStripMenuItem.Text = "Create New Database";
            this.newDatabaseToolStripMenuItem.Click += new System.EventHandler(this.newDatabaseToolStripMenuItem_Click);
            // 
            // changeDatabaseToolStripMenuItem
            // 
            this.changeDatabaseToolStripMenuItem.Name = "changeDatabaseToolStripMenuItem";
            this.changeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.changeDatabaseToolStripMenuItem.Text = "Change Current Database";
            this.changeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.changeDatabaseToolStripMenuItem_Click);
            // 
            // setDefaultDatabaseToolStripMenuItem
            // 
            this.setDefaultDatabaseToolStripMenuItem.Name = "setDefaultDatabaseToolStripMenuItem";
            this.setDefaultDatabaseToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.setDefaultDatabaseToolStripMenuItem.Text = "Set Default Database";
            this.setDefaultDatabaseToolStripMenuItem.Click += new System.EventHandler(this.setDefaultDatabaseToolStripMenuItem_Click);
            // 
            // resetCurrentDatabaseToolStripMenuItem
            // 
            this.resetCurrentDatabaseToolStripMenuItem.Name = "resetCurrentDatabaseToolStripMenuItem";
            this.resetCurrentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.resetCurrentDatabaseToolStripMenuItem.Text = "Reset Current Database";
            this.resetCurrentDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetCurrentDatabaseToolStripMenuItem_Click);
            // 
            // deleteCurrentDatabaseToolStripMenuItem
            // 
            this.deleteCurrentDatabaseToolStripMenuItem.Name = "deleteCurrentDatabaseToolStripMenuItem";
            this.deleteCurrentDatabaseToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.deleteCurrentDatabaseToolStripMenuItem.Text = "Delete Current Database";
            this.deleteCurrentDatabaseToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrentDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // catalogingToolStripMenuItem
            // 
            this.catalogingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogADriverToolStripMenuItem});
            this.catalogingToolStripMenuItem.Name = "catalogingToolStripMenuItem";
            this.catalogingToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.catalogingToolStripMenuItem.Text = "Cataloging";
            // 
            // catalogADriverToolStripMenuItem
            // 
            this.catalogADriverToolStripMenuItem.Name = "catalogADriverToolStripMenuItem";
            this.catalogADriverToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.catalogADriverToolStripMenuItem.Text = "Catalog a Driver";
            this.catalogADriverToolStripMenuItem.Click += new System.EventHandler(this.catalogADriverToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchDatabaseToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchDatabaseToolStripMenuItem
            // 
            this.searchDatabaseToolStripMenuItem.Name = "searchDatabaseToolStripMenuItem";
            this.searchDatabaseToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.searchDatabaseToolStripMenuItem.Text = "Search Database";
            this.searchDatabaseToolStripMenuItem.Click += new System.EventHandler(this.searchDatabaseToolStripMenuItem_Click);
            // 
            // showCurrentDatabaseInformationToolStripMenuItem
            // 
            this.showCurrentDatabaseInformationToolStripMenuItem.Name = "showCurrentDatabaseInformationToolStripMenuItem";
            this.showCurrentDatabaseInformationToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.showCurrentDatabaseInformationToolStripMenuItem.Text = "Show Current Database Information";
            this.showCurrentDatabaseInformationToolStripMenuItem.Click += new System.EventHandler(this.showCurrentDatabaseInformationToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 320);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver Cataloger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogADriverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetCurrentDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrentDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentDatabaseInformationToolStripMenuItem;
    }
}

