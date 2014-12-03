namespace PartsManager.Source_Files
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.libraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.partsDataGridView = new System.Windows.Forms.DataGridView();
			this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
			this.DescriptionTextBox = new System.Windows.Forms.TextBox();
			this.StockTextBox = new System.Windows.Forms.TextBox();
			this.DatasheetLink = new System.Windows.Forms.LinkLabel();
			this.ModuleLabel = new System.Windows.Forms.Label();
			this.PackageNameLabel = new System.Windows.Forms.Label();
			this.PartNumberLabel = new System.Windows.Forms.Label();
			this.PartNameLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.UrlComboBox = new System.Windows.Forms.ComboBox();
			this.AddUrlButton = new System.Windows.Forms.Button();
			this.EditUrlButton = new System.Windows.Forms.Button();
			this.DeleteUrlButton = new System.Windows.Forms.Button();
			this.GoUrlButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
			this.DetailsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.libraryToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(924, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
			this.toolStripMenuItem1.Text = "Start";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// libraryToolStripMenuItem
			// 
			this.libraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
			this.libraryToolStripMenuItem.Name = "libraryToolStripMenuItem";
			this.libraryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.libraryToolStripMenuItem.Text = "Library";
			// 
			// reloadToolStripMenuItem
			// 
			this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
			this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.reloadToolStripMenuItem.Text = "Reload";
			this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// partsDataGridView
			// 
			this.partsDataGridView.AllowUserToOrderColumns = true;
			this.partsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.partsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.partsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.partsDataGridView.Location = new System.Drawing.Point(13, 28);
			this.partsDataGridView.MultiSelect = false;
			this.partsDataGridView.Name = "partsDataGridView";
			this.partsDataGridView.ReadOnly = true;
			this.partsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.partsDataGridView.Size = new System.Drawing.Size(593, 401);
			this.partsDataGridView.TabIndex = 1;
			this.partsDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
			// 
			// DetailsGroupBox
			// 
			this.DetailsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DetailsGroupBox.Controls.Add(this.GoUrlButton);
			this.DetailsGroupBox.Controls.Add(this.DeleteUrlButton);
			this.DetailsGroupBox.Controls.Add(this.EditUrlButton);
			this.DetailsGroupBox.Controls.Add(this.AddUrlButton);
			this.DetailsGroupBox.Controls.Add(this.UrlComboBox);
			this.DetailsGroupBox.Controls.Add(this.label8);
			this.DetailsGroupBox.Controls.Add(this.DescriptionTextBox);
			this.DetailsGroupBox.Controls.Add(this.StockTextBox);
			this.DetailsGroupBox.Controls.Add(this.DatasheetLink);
			this.DetailsGroupBox.Controls.Add(this.ModuleLabel);
			this.DetailsGroupBox.Controls.Add(this.PackageNameLabel);
			this.DetailsGroupBox.Controls.Add(this.PartNumberLabel);
			this.DetailsGroupBox.Controls.Add(this.PartNameLabel);
			this.DetailsGroupBox.Controls.Add(this.label7);
			this.DetailsGroupBox.Controls.Add(this.SaveButton);
			this.DetailsGroupBox.Controls.Add(this.label6);
			this.DetailsGroupBox.Controls.Add(this.label5);
			this.DetailsGroupBox.Controls.Add(this.label4);
			this.DetailsGroupBox.Controls.Add(this.label3);
			this.DetailsGroupBox.Controls.Add(this.label2);
			this.DetailsGroupBox.Controls.Add(this.label1);
			this.DetailsGroupBox.Enabled = false;
			this.DetailsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DetailsGroupBox.Location = new System.Drawing.Point(612, 28);
			this.DetailsGroupBox.Name = "DetailsGroupBox";
			this.DetailsGroupBox.Size = new System.Drawing.Size(300, 401);
			this.DetailsGroupBox.TabIndex = 2;
			this.DetailsGroupBox.TabStop = false;
			this.DetailsGroupBox.Text = "Details";
			// 
			// DescriptionTextBox
			// 
			this.DescriptionTextBox.Location = new System.Drawing.Point(10, 192);
			this.DescriptionTextBox.Multiline = true;
			this.DescriptionTextBox.Name = "DescriptionTextBox";
			this.DescriptionTextBox.Size = new System.Drawing.Size(284, 80);
			this.DescriptionTextBox.TabIndex = 14;
			// 
			// StockTextBox
			// 
			this.StockTextBox.Location = new System.Drawing.Point(83, 142);
			this.StockTextBox.Name = "StockTextBox";
			this.StockTextBox.Size = new System.Drawing.Size(70, 21);
			this.StockTextBox.TabIndex = 13;
			// 
			// DatasheetLink
			// 
			this.DatasheetLink.AutoSize = true;
			this.DatasheetLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DatasheetLink.Location = new System.Drawing.Point(80, 95);
			this.DatasheetLink.Name = "DatasheetLink";
			this.DatasheetLink.Size = new System.Drawing.Size(0, 15);
			this.DatasheetLink.TabIndex = 12;
			this.DatasheetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DatasheetLink_LinkClicked);
			// 
			// ModuleLabel
			// 
			this.ModuleLabel.AutoSize = true;
			this.ModuleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ModuleLabel.Location = new System.Drawing.Point(80, 120);
			this.ModuleLabel.Name = "ModuleLabel";
			this.ModuleLabel.Size = new System.Drawing.Size(0, 15);
			this.ModuleLabel.TabIndex = 11;
			// 
			// PackageNameLabel
			// 
			this.PackageNameLabel.AutoSize = true;
			this.PackageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageNameLabel.Location = new System.Drawing.Point(80, 70);
			this.PackageNameLabel.Name = "PackageNameLabel";
			this.PackageNameLabel.Size = new System.Drawing.Size(0, 15);
			this.PackageNameLabel.TabIndex = 10;
			// 
			// PartNumberLabel
			// 
			this.PartNumberLabel.AutoSize = true;
			this.PartNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PartNumberLabel.Location = new System.Drawing.Point(80, 45);
			this.PartNumberLabel.Name = "PartNumberLabel";
			this.PartNumberLabel.Size = new System.Drawing.Size(0, 15);
			this.PartNumberLabel.TabIndex = 9;
			// 
			// PartNameLabel
			// 
			this.PartNameLabel.AutoSize = true;
			this.PartNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PartNameLabel.Location = new System.Drawing.Point(80, 20);
			this.PartNameLabel.Name = "PartNameLabel";
			this.PartNameLabel.Size = new System.Drawing.Size(0, 15);
			this.PartNameLabel.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 15);
			this.label7.TabIndex = 7;
			this.label7.Text = "Datasheet";
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(10, 372);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(284, 23);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save Details";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 145);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "In stock";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Module";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Description";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Package";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Number";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 280);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 15);
			this.label8.TabIndex = 15;
			this.label8.Text = "URLs";
			// 
			// UrlComboBox
			// 
			this.UrlComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.UrlComboBox.Location = new System.Drawing.Point(10, 300);
			this.UrlComboBox.Name = "UrlComboBox";
			this.UrlComboBox.Size = new System.Drawing.Size(243, 23);
			this.UrlComboBox.TabIndex = 16;
			// 
			// AddUrlButton
			// 
			this.AddUrlButton.Location = new System.Drawing.Point(10, 330);
			this.AddUrlButton.Name = "AddUrlButton";
			this.AddUrlButton.Size = new System.Drawing.Size(90, 23);
			this.AddUrlButton.TabIndex = 17;
			this.AddUrlButton.Text = "Add";
			this.AddUrlButton.UseVisualStyleBackColor = true;
			this.AddUrlButton.Click += new System.EventHandler(this.AddUrlButton_Click);
			// 
			// EditUrlButton
			// 
			this.EditUrlButton.Location = new System.Drawing.Point(108, 330);
			this.EditUrlButton.Name = "EditUrlButton";
			this.EditUrlButton.Size = new System.Drawing.Size(90, 23);
			this.EditUrlButton.TabIndex = 18;
			this.EditUrlButton.Text = "Edit";
			this.EditUrlButton.UseVisualStyleBackColor = true;
			// 
			// DeleteUrlButton
			// 
			this.DeleteUrlButton.Location = new System.Drawing.Point(204, 330);
			this.DeleteUrlButton.Name = "DeleteUrlButton";
			this.DeleteUrlButton.Size = new System.Drawing.Size(90, 23);
			this.DeleteUrlButton.TabIndex = 19;
			this.DeleteUrlButton.Text = "Delete";
			this.DeleteUrlButton.UseVisualStyleBackColor = true;
			// 
			// GoUrlButton
			// 
			this.GoUrlButton.Location = new System.Drawing.Point(259, 300);
			this.GoUrlButton.Name = "GoUrlButton";
			this.GoUrlButton.Size = new System.Drawing.Size(35, 23);
			this.GoUrlButton.TabIndex = 20;
			this.GoUrlButton.Text = "Go";
			this.GoUrlButton.UseVisualStyleBackColor = true;
			this.GoUrlButton.Click += new System.EventHandler(this.GoUrlButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 441);
			this.Controls.Add(this.DetailsGroupBox);
			this.Controls.Add(this.partsDataGridView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Parts Manager";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
			this.DetailsGroupBox.ResumeLayout(false);
			this.DetailsGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem libraryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
		private System.Windows.Forms.DataGridView partsDataGridView;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.GroupBox DetailsGroupBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Label PartNameLabel;
		private System.Windows.Forms.Label PartNumberLabel;
		private System.Windows.Forms.Label PackageNameLabel;
		private System.Windows.Forms.LinkLabel DatasheetLink;
		private System.Windows.Forms.Label ModuleLabel;
		private System.Windows.Forms.TextBox DescriptionTextBox;
		private System.Windows.Forms.TextBox StockTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox UrlComboBox;
		private System.Windows.Forms.Button GoUrlButton;
		private System.Windows.Forms.Button DeleteUrlButton;
		private System.Windows.Forms.Button EditUrlButton;
		private System.Windows.Forms.Button AddUrlButton;
	}
}