namespace DriveCataloger
{
    partial class SearchForm
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
            this.fileNameGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameTxt = new System.Windows.Forms.TextBox();
            this.fileNameChk = new System.Windows.Forms.CheckBox();
            this.fileExtensionGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileExtensionTxt = new System.Windows.Forms.TextBox();
            this.fileExtensionChk = new System.Windows.Forms.CheckBox();
            this.fileSizeGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileSizeTxt = new System.Windows.Forms.TextBox();
            this.fileSizeCombo = new System.Windows.Forms.ComboBox();
            this.fileSizeChk = new System.Windows.Forms.CheckBox();
            this.fileAttributiesGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fileAttributiesCombo = new System.Windows.Forms.ComboBox();
            this.fileAttributesChk = new System.Windows.Forms.CheckBox();
            this.fileCreationDateGroup = new System.Windows.Forms.GroupBox();
            this.fileCDateCombo = new System.Windows.Forms.ComboBox();
            this.fileCDateTxt = new System.Windows.Forms.TextBox();
            this.fileCDateChk = new System.Windows.Forms.CheckBox();
            this.fileModificationDateGroup = new System.Windows.Forms.GroupBox();
            this.fileMDateCombo = new System.Windows.Forms.ComboBox();
            this.fileMDateTxt = new System.Windows.Forms.TextBox();
            this.fileMDateChk = new System.Windows.Forms.CheckBox();
            this.fileCreationTimeGroup = new System.Windows.Forms.GroupBox();
            this.fileCTimeCombo = new System.Windows.Forms.ComboBox();
            this.fileCTimeTxt = new System.Windows.Forms.TextBox();
            this.fileCTimeChk = new System.Windows.Forms.CheckBox();
            this.fileModificationTimeGroup = new System.Windows.Forms.GroupBox();
            this.fileMTimeCombo = new System.Windows.Forms.ComboBox();
            this.fileMTimeTxt = new System.Windows.Forms.TextBox();
            this.fileMTimeChk = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.fileNameGroup.SuspendLayout();
            this.fileExtensionGroup.SuspendLayout();
            this.fileSizeGroup.SuspendLayout();
            this.fileAttributiesGroup.SuspendLayout();
            this.fileCreationDateGroup.SuspendLayout();
            this.fileModificationDateGroup.SuspendLayout();
            this.fileCreationTimeGroup.SuspendLayout();
            this.fileModificationTimeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(203, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Database";
            // 
            // fileNameGroup
            // 
            this.fileNameGroup.Controls.Add(this.label2);
            this.fileNameGroup.Controls.Add(this.fileNameTxt);
            this.fileNameGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileNameGroup.Location = new System.Drawing.Point(12, 111);
            this.fileNameGroup.Name = "fileNameGroup";
            this.fileNameGroup.Size = new System.Drawing.Size(285, 58);
            this.fileNameGroup.TabIndex = 2;
            this.fileNameGroup.TabStop = false;
            this.fileNameGroup.Text = "File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Name:";
            // 
            // fileNameTxt
            // 
            this.fileNameTxt.Location = new System.Drawing.Point(87, 22);
            this.fileNameTxt.Name = "fileNameTxt";
            this.fileNameTxt.Size = new System.Drawing.Size(183, 23);
            this.fileNameTxt.TabIndex = 1;
            // 
            // fileNameChk
            // 
            this.fileNameChk.AutoSize = true;
            this.fileNameChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileNameChk.Location = new System.Drawing.Point(12, 85);
            this.fileNameChk.Name = "fileNameChk";
            this.fileNameChk.Size = new System.Drawing.Size(113, 20);
            this.fileNameChk.TabIndex = 2;
            this.fileNameChk.Text = "Use File Name";
            this.fileNameChk.UseVisualStyleBackColor = true;
            this.fileNameChk.CheckedChanged += new System.EventHandler(this.fileNameChk_CheckedChanged);
            // 
            // fileExtensionGroup
            // 
            this.fileExtensionGroup.Controls.Add(this.label3);
            this.fileExtensionGroup.Controls.Add(this.fileExtensionTxt);
            this.fileExtensionGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileExtensionGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileExtensionGroup.Location = new System.Drawing.Point(12, 222);
            this.fileExtensionGroup.Name = "fileExtensionGroup";
            this.fileExtensionGroup.Size = new System.Drawing.Size(285, 58);
            this.fileExtensionGroup.TabIndex = 3;
            this.fileExtensionGroup.TabStop = false;
            this.fileExtensionGroup.Text = "File Extension";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "File Extension:";
            // 
            // fileExtensionTxt
            // 
            this.fileExtensionTxt.Location = new System.Drawing.Point(111, 22);
            this.fileExtensionTxt.Name = "fileExtensionTxt";
            this.fileExtensionTxt.Size = new System.Drawing.Size(72, 23);
            this.fileExtensionTxt.TabIndex = 1;
            // 
            // fileExtensionChk
            // 
            this.fileExtensionChk.AutoSize = true;
            this.fileExtensionChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileExtensionChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileExtensionChk.Location = new System.Drawing.Point(12, 196);
            this.fileExtensionChk.Name = "fileExtensionChk";
            this.fileExtensionChk.Size = new System.Drawing.Size(140, 20);
            this.fileExtensionChk.TabIndex = 2;
            this.fileExtensionChk.Text = "Use File Extension";
            this.fileExtensionChk.UseVisualStyleBackColor = true;
            this.fileExtensionChk.CheckedChanged += new System.EventHandler(this.fileExtensionChk_CheckedChanged);
            // 
            // fileSizeGroup
            // 
            this.fileSizeGroup.Controls.Add(this.label5);
            this.fileSizeGroup.Controls.Add(this.fileSizeTxt);
            this.fileSizeGroup.Controls.Add(this.fileSizeCombo);
            this.fileSizeGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileSizeGroup.Location = new System.Drawing.Point(12, 444);
            this.fileSizeGroup.Name = "fileSizeGroup";
            this.fileSizeGroup.Size = new System.Drawing.Size(285, 64);
            this.fileSizeGroup.TabIndex = 4;
            this.fileSizeGroup.TabStop = false;
            this.fileSizeGroup.Text = "File Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(242, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KB";
            // 
            // fileSizeTxt
            // 
            this.fileSizeTxt.Location = new System.Drawing.Point(157, 22);
            this.fileSizeTxt.Name = "fileSizeTxt";
            this.fileSizeTxt.Size = new System.Drawing.Size(79, 23);
            this.fileSizeTxt.TabIndex = 2;
            // 
            // fileSizeCombo
            // 
            this.fileSizeCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileSizeCombo.FormattingEnabled = true;
            this.fileSizeCombo.Items.AddRange(new object[] {
            "Specific Size:",
            "Greater than:",
            "Less than:"});
            this.fileSizeCombo.Location = new System.Drawing.Point(12, 22);
            this.fileSizeCombo.Name = "fileSizeCombo";
            this.fileSizeCombo.Size = new System.Drawing.Size(113, 24);
            this.fileSizeCombo.TabIndex = 0;
            // 
            // fileSizeChk
            // 
            this.fileSizeChk.AutoSize = true;
            this.fileSizeChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileSizeChk.Location = new System.Drawing.Point(12, 418);
            this.fileSizeChk.Name = "fileSizeChk";
            this.fileSizeChk.Size = new System.Drawing.Size(104, 20);
            this.fileSizeChk.TabIndex = 7;
            this.fileSizeChk.Text = "Use File Size";
            this.fileSizeChk.UseVisualStyleBackColor = true;
            this.fileSizeChk.CheckedChanged += new System.EventHandler(this.fileSizeChk_CheckedChanged);
            // 
            // fileAttributiesGroup
            // 
            this.fileAttributiesGroup.Controls.Add(this.label4);
            this.fileAttributiesGroup.Controls.Add(this.fileAttributiesCombo);
            this.fileAttributiesGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAttributiesGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileAttributiesGroup.Location = new System.Drawing.Point(12, 333);
            this.fileAttributiesGroup.Name = "fileAttributiesGroup";
            this.fileAttributiesGroup.Size = new System.Drawing.Size(285, 58);
            this.fileAttributiesGroup.TabIndex = 5;
            this.fileAttributiesGroup.TabStop = false;
            this.fileAttributiesGroup.Text = "File Attributes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "File Attributies:";
            // 
            // fileAttributiesCombo
            // 
            this.fileAttributiesCombo.FormattingEnabled = true;
            this.fileAttributiesCombo.Items.AddRange(new object[] {
            "ReadOnly",
            "Hidden",
            "System",
            "Directory",
            "Archive",
            "Device",
            "Normal",
            "Temporary",
            "Sparse File",
            "Reparse Point",
            "Compressed",
            "NotContentIndexed",
            "Encrypted"});
            this.fileAttributiesCombo.Location = new System.Drawing.Point(123, 22);
            this.fileAttributiesCombo.Name = "fileAttributiesCombo";
            this.fileAttributiesCombo.Size = new System.Drawing.Size(147, 24);
            this.fileAttributiesCombo.TabIndex = 3;
            // 
            // fileAttributesChk
            // 
            this.fileAttributesChk.AutoSize = true;
            this.fileAttributesChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileAttributesChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileAttributesChk.Location = new System.Drawing.Point(12, 307);
            this.fileAttributesChk.Name = "fileAttributesChk";
            this.fileAttributesChk.Size = new System.Drawing.Size(146, 20);
            this.fileAttributesChk.TabIndex = 2;
            this.fileAttributesChk.Text = "Use File Attributes";
            this.fileAttributesChk.UseVisualStyleBackColor = true;
            this.fileAttributesChk.CheckedChanged += new System.EventHandler(this.fileAttributesChk_CheckedChanged);
            // 
            // fileCreationDateGroup
            // 
            this.fileCreationDateGroup.Controls.Add(this.fileCDateCombo);
            this.fileCreationDateGroup.Controls.Add(this.fileCDateTxt);
            this.fileCreationDateGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCreationDateGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileCreationDateGroup.Location = new System.Drawing.Point(321, 111);
            this.fileCreationDateGroup.Name = "fileCreationDateGroup";
            this.fileCreationDateGroup.Size = new System.Drawing.Size(285, 64);
            this.fileCreationDateGroup.TabIndex = 6;
            this.fileCreationDateGroup.TabStop = false;
            this.fileCreationDateGroup.Text = "File Creation Date";
            // 
            // fileCDateCombo
            // 
            this.fileCDateCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCDateCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileCDateCombo.FormattingEnabled = true;
            this.fileCDateCombo.Items.AddRange(new object[] {
            "Specific Date:",
            "Before:",
            "After:"});
            this.fileCDateCombo.Location = new System.Drawing.Point(15, 25);
            this.fileCDateCombo.Name = "fileCDateCombo";
            this.fileCDateCombo.Size = new System.Drawing.Size(113, 24);
            this.fileCDateCombo.TabIndex = 2;
            // 
            // fileCDateTxt
            // 
            this.fileCDateTxt.Location = new System.Drawing.Point(152, 26);
            this.fileCDateTxt.Name = "fileCDateTxt";
            this.fileCDateTxt.Size = new System.Drawing.Size(112, 23);
            this.fileCDateTxt.TabIndex = 1;
            // 
            // fileCDateChk
            // 
            this.fileCDateChk.AutoSize = true;
            this.fileCDateChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCDateChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileCDateChk.Location = new System.Drawing.Point(321, 85);
            this.fileCDateChk.Name = "fileCDateChk";
            this.fileCDateChk.Size = new System.Drawing.Size(168, 20);
            this.fileCDateChk.TabIndex = 7;
            this.fileCDateChk.Text = "Use File Creation Date";
            this.fileCDateChk.UseVisualStyleBackColor = true;
            this.fileCDateChk.CheckedChanged += new System.EventHandler(this.fileCDateChk_CheckedChanged);
            // 
            // fileModificationDateGroup
            // 
            this.fileModificationDateGroup.Controls.Add(this.fileMDateCombo);
            this.fileModificationDateGroup.Controls.Add(this.fileMDateTxt);
            this.fileModificationDateGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileModificationDateGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileModificationDateGroup.Location = new System.Drawing.Point(321, 222);
            this.fileModificationDateGroup.Name = "fileModificationDateGroup";
            this.fileModificationDateGroup.Size = new System.Drawing.Size(285, 64);
            this.fileModificationDateGroup.TabIndex = 7;
            this.fileModificationDateGroup.TabStop = false;
            this.fileModificationDateGroup.Text = "File Modification Date";
            // 
            // fileMDateCombo
            // 
            this.fileMDateCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMDateCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileMDateCombo.FormattingEnabled = true;
            this.fileMDateCombo.Items.AddRange(new object[] {
            "Specific Date:",
            "Before:",
            "After:"});
            this.fileMDateCombo.Location = new System.Drawing.Point(12, 28);
            this.fileMDateCombo.Name = "fileMDateCombo";
            this.fileMDateCombo.Size = new System.Drawing.Size(113, 24);
            this.fileMDateCombo.TabIndex = 4;
            // 
            // fileMDateTxt
            // 
            this.fileMDateTxt.Location = new System.Drawing.Point(149, 28);
            this.fileMDateTxt.Name = "fileMDateTxt";
            this.fileMDateTxt.Size = new System.Drawing.Size(112, 23);
            this.fileMDateTxt.TabIndex = 3;
            // 
            // fileMDateChk
            // 
            this.fileMDateChk.AutoSize = true;
            this.fileMDateChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMDateChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileMDateChk.Location = new System.Drawing.Point(321, 196);
            this.fileMDateChk.Name = "fileMDateChk";
            this.fileMDateChk.Size = new System.Drawing.Size(191, 20);
            this.fileMDateChk.TabIndex = 7;
            this.fileMDateChk.Text = "Use File Modification Date";
            this.fileMDateChk.UseVisualStyleBackColor = true;
            this.fileMDateChk.CheckedChanged += new System.EventHandler(this.fileMDateChk_CheckedChanged);
            // 
            // fileCreationTimeGroup
            // 
            this.fileCreationTimeGroup.Controls.Add(this.fileCTimeCombo);
            this.fileCreationTimeGroup.Controls.Add(this.fileCTimeTxt);
            this.fileCreationTimeGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCreationTimeGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileCreationTimeGroup.Location = new System.Drawing.Point(321, 333);
            this.fileCreationTimeGroup.Name = "fileCreationTimeGroup";
            this.fileCreationTimeGroup.Size = new System.Drawing.Size(285, 64);
            this.fileCreationTimeGroup.TabIndex = 8;
            this.fileCreationTimeGroup.TabStop = false;
            this.fileCreationTimeGroup.Text = "File Creation Time";
            // 
            // fileCTimeCombo
            // 
            this.fileCTimeCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCTimeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileCTimeCombo.FormattingEnabled = true;
            this.fileCTimeCombo.Items.AddRange(new object[] {
            "Specific Date:",
            "Before:",
            "After:"});
            this.fileCTimeCombo.Location = new System.Drawing.Point(12, 23);
            this.fileCTimeCombo.Name = "fileCTimeCombo";
            this.fileCTimeCombo.Size = new System.Drawing.Size(113, 24);
            this.fileCTimeCombo.TabIndex = 6;
            // 
            // fileCTimeTxt
            // 
            this.fileCTimeTxt.Location = new System.Drawing.Point(149, 23);
            this.fileCTimeTxt.Name = "fileCTimeTxt";
            this.fileCTimeTxt.Size = new System.Drawing.Size(112, 23);
            this.fileCTimeTxt.TabIndex = 5;
            // 
            // fileCTimeChk
            // 
            this.fileCTimeChk.AutoSize = true;
            this.fileCTimeChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCTimeChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileCTimeChk.Location = new System.Drawing.Point(321, 307);
            this.fileCTimeChk.Name = "fileCTimeChk";
            this.fileCTimeChk.Size = new System.Drawing.Size(166, 20);
            this.fileCTimeChk.TabIndex = 7;
            this.fileCTimeChk.Text = "Use File Creation Time";
            this.fileCTimeChk.UseVisualStyleBackColor = true;
            this.fileCTimeChk.CheckedChanged += new System.EventHandler(this.fileCTimeChk_CheckedChanged);
            // 
            // fileModificationTimeGroup
            // 
            this.fileModificationTimeGroup.Controls.Add(this.fileMTimeCombo);
            this.fileModificationTimeGroup.Controls.Add(this.fileMTimeTxt);
            this.fileModificationTimeGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileModificationTimeGroup.ForeColor = System.Drawing.Color.Navy;
            this.fileModificationTimeGroup.Location = new System.Drawing.Point(321, 444);
            this.fileModificationTimeGroup.Name = "fileModificationTimeGroup";
            this.fileModificationTimeGroup.Size = new System.Drawing.Size(285, 64);
            this.fileModificationTimeGroup.TabIndex = 9;
            this.fileModificationTimeGroup.TabStop = false;
            this.fileModificationTimeGroup.Text = "File Modification Time";
            // 
            // fileMTimeCombo
            // 
            this.fileMTimeCombo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMTimeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileMTimeCombo.FormattingEnabled = true;
            this.fileMTimeCombo.Items.AddRange(new object[] {
            "Specific Date:",
            "Before:",
            "After:"});
            this.fileMTimeCombo.Location = new System.Drawing.Point(12, 25);
            this.fileMTimeCombo.Name = "fileMTimeCombo";
            this.fileMTimeCombo.Size = new System.Drawing.Size(113, 24);
            this.fileMTimeCombo.TabIndex = 6;
            // 
            // fileMTimeTxt
            // 
            this.fileMTimeTxt.Location = new System.Drawing.Point(149, 25);
            this.fileMTimeTxt.Name = "fileMTimeTxt";
            this.fileMTimeTxt.Size = new System.Drawing.Size(112, 23);
            this.fileMTimeTxt.TabIndex = 5;
            // 
            // fileMTimeChk
            // 
            this.fileMTimeChk.AutoSize = true;
            this.fileMTimeChk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMTimeChk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.fileMTimeChk.Location = new System.Drawing.Point(321, 418);
            this.fileMTimeChk.Name = "fileMTimeChk";
            this.fileMTimeChk.Size = new System.Drawing.Size(189, 20);
            this.fileMTimeChk.TabIndex = 7;
            this.fileMTimeChk.Text = "Use File Modification Time";
            this.fileMTimeChk.UseVisualStyleBackColor = true;
            this.fileMTimeChk.CheckedChanged += new System.EventHandler(this.fileMTimeChk_CheckedChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(312, 535);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(94, 30);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(214, 535);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 30);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 590);
            this.Controls.Add(this.fileCTimeChk);
            this.Controls.Add(this.fileMTimeChk);
            this.Controls.Add(this.fileMDateChk);
            this.Controls.Add(this.fileSizeChk);
            this.Controls.Add(this.fileCDateChk);
            this.Controls.Add(this.fileExtensionChk);
            this.Controls.Add(this.fileAttributesChk);
            this.Controls.Add(this.fileNameChk);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.fileModificationTimeGroup);
            this.Controls.Add(this.fileCreationTimeGroup);
            this.Controls.Add(this.fileModificationDateGroup);
            this.Controls.Add(this.fileCreationDateGroup);
            this.Controls.Add(this.fileAttributiesGroup);
            this.Controls.Add(this.fileSizeGroup);
            this.Controls.Add(this.fileExtensionGroup);
            this.Controls.Add(this.fileNameGroup);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Database";
            this.fileNameGroup.ResumeLayout(false);
            this.fileNameGroup.PerformLayout();
            this.fileExtensionGroup.ResumeLayout(false);
            this.fileExtensionGroup.PerformLayout();
            this.fileSizeGroup.ResumeLayout(false);
            this.fileSizeGroup.PerformLayout();
            this.fileAttributiesGroup.ResumeLayout(false);
            this.fileAttributiesGroup.PerformLayout();
            this.fileCreationDateGroup.ResumeLayout(false);
            this.fileCreationDateGroup.PerformLayout();
            this.fileModificationDateGroup.ResumeLayout(false);
            this.fileModificationDateGroup.PerformLayout();
            this.fileCreationTimeGroup.ResumeLayout(false);
            this.fileCreationTimeGroup.PerformLayout();
            this.fileModificationTimeGroup.ResumeLayout(false);
            this.fileModificationTimeGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox fileNameGroup;
        private System.Windows.Forms.TextBox fileNameTxt;
        private System.Windows.Forms.GroupBox fileExtensionGroup;
        private System.Windows.Forms.CheckBox fileExtensionChk;
        private System.Windows.Forms.TextBox fileExtensionTxt;
        private System.Windows.Forms.GroupBox fileSizeGroup;
        private System.Windows.Forms.CheckBox fileSizeChk;
        private System.Windows.Forms.GroupBox fileAttributiesGroup;
        private System.Windows.Forms.ComboBox fileAttributiesCombo;
        private System.Windows.Forms.CheckBox fileAttributesChk;
        private System.Windows.Forms.GroupBox fileCreationDateGroup;
        private System.Windows.Forms.CheckBox fileCDateChk;
        private System.Windows.Forms.TextBox fileCDateTxt;
        private System.Windows.Forms.GroupBox fileModificationDateGroup;
        private System.Windows.Forms.CheckBox fileMDateChk;
        private System.Windows.Forms.GroupBox fileCreationTimeGroup;
        private System.Windows.Forms.CheckBox fileCTimeChk;
        private System.Windows.Forms.GroupBox fileModificationTimeGroup;
        private System.Windows.Forms.CheckBox fileMTimeChk;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.CheckBox fileNameChk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileSizeTxt;
        private System.Windows.Forms.ComboBox fileSizeCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fileCDateCombo;
        private System.Windows.Forms.ComboBox fileMDateCombo;
        private System.Windows.Forms.TextBox fileMDateTxt;
        private System.Windows.Forms.ComboBox fileMTimeCombo;
        private System.Windows.Forms.TextBox fileMTimeTxt;
        private System.Windows.Forms.ComboBox fileCTimeCombo;
        private System.Windows.Forms.TextBox fileCTimeTxt;
    }
}