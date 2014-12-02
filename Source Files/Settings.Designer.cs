namespace PartsManager.Source_Files
{
    partial class Settings
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
			this.LibraryPathTextBox = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PartsPathTextBox = new System.Windows.Forms.TextBox();
			this.DatasheetPathChangeButton = new System.Windows.Forms.Button();
			this.LibraryPathChangeButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.DataBasePathTextBox = new System.Windows.Forms.TextBox();
			this.DataBaseFileChangeButton = new System.Windows.Forms.Button();
			this.NewDataBaseButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// LibraryPathTextBox
			// 
			this.LibraryPathTextBox.Location = new System.Drawing.Point(135, 17);
			this.LibraryPathTextBox.Name = "LibraryPathTextBox";
			this.LibraryPathTextBox.Size = new System.Drawing.Size(344, 21);
			this.LibraryPathTextBox.TabIndex = 2;
			this.LibraryPathTextBox.Text = global::PartsManager.Properties.Settings.Default.LibraryPath;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "KiCAD library path";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Datasheet folder path";
			// 
			// PartsPathTextBox
			// 
			this.PartsPathTextBox.Location = new System.Drawing.Point(135, 47);
			this.PartsPathTextBox.Name = "PartsPathTextBox";
			this.PartsPathTextBox.Size = new System.Drawing.Size(344, 21);
			this.PartsPathTextBox.TabIndex = 7;
			this.PartsPathTextBox.Text = global::PartsManager.Properties.Settings.Default.DatasheetPath;
			// 
			// DatasheetPathChangeButton
			// 
			this.DatasheetPathChangeButton.Location = new System.Drawing.Point(485, 46);
			this.DatasheetPathChangeButton.Name = "DatasheetPathChangeButton";
			this.DatasheetPathChangeButton.Size = new System.Drawing.Size(87, 23);
			this.DatasheetPathChangeButton.TabIndex = 8;
			this.DatasheetPathChangeButton.Text = "Change";
			this.DatasheetPathChangeButton.UseVisualStyleBackColor = true;
			this.DatasheetPathChangeButton.Click += new System.EventHandler(this.DatasheetPathChangeButton_Click);
			// 
			// LibraryPathChangeButton
			// 
			this.LibraryPathChangeButton.Location = new System.Drawing.Point(485, 16);
			this.LibraryPathChangeButton.Name = "LibraryPathChangeButton";
			this.LibraryPathChangeButton.Size = new System.Drawing.Size(87, 23);
			this.LibraryPathChangeButton.TabIndex = 9;
			this.LibraryPathChangeButton.Text = "Change";
			this.LibraryPathChangeButton.UseVisualStyleBackColor = true;
			this.LibraryPathChangeButton.Click += new System.EventHandler(this.LibraryPathChangeButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(497, 176);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 10;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(416, 176);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 11;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "Database file";
			// 
			// DataBasePathTextBox
			// 
			this.DataBasePathTextBox.Location = new System.Drawing.Point(135, 77);
			this.DataBasePathTextBox.Name = "DataBasePathTextBox";
			this.DataBasePathTextBox.Size = new System.Drawing.Size(344, 21);
			this.DataBasePathTextBox.TabIndex = 13;
			this.DataBasePathTextBox.Text = global::PartsManager.Properties.Settings.Default.DatabasePath;
			// 
			// DataBaseFileChangeButton
			// 
			this.DataBaseFileChangeButton.Location = new System.Drawing.Point(485, 76);
			this.DataBaseFileChangeButton.Name = "DataBaseFileChangeButton";
			this.DataBaseFileChangeButton.Size = new System.Drawing.Size(87, 23);
			this.DataBaseFileChangeButton.TabIndex = 14;
			this.DataBaseFileChangeButton.Text = "Change";
			this.DataBaseFileChangeButton.UseVisualStyleBackColor = true;
			this.DataBaseFileChangeButton.Click += new System.EventHandler(this.DataBaseFileChangeButton_Click);
			// 
			// NewDataBaseButton
			// 
			this.NewDataBaseButton.Location = new System.Drawing.Point(135, 104);
			this.NewDataBaseButton.Name = "NewDataBaseButton";
			this.NewDataBaseButton.Size = new System.Drawing.Size(344, 23);
			this.NewDataBaseButton.TabIndex = 15;
			this.NewDataBaseButton.Text = "Create new database";
			this.NewDataBaseButton.UseVisualStyleBackColor = true;
			this.NewDataBaseButton.Click += new System.EventHandler(this.NewDataBaseButton_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 211);
			this.Controls.Add(this.NewDataBaseButton);
			this.Controls.Add(this.DataBaseFileChangeButton);
			this.Controls.Add(this.DataBasePathTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.LibraryPathChangeButton);
			this.Controls.Add(this.DatasheetPathChangeButton);
			this.Controls.Add(this.PartsPathTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LibraryPathTextBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Settings";
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.TextBox LibraryPathTextBox;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PartsPathTextBox;
		private System.Windows.Forms.Button DatasheetPathChangeButton;
		private System.Windows.Forms.Button LibraryPathChangeButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox DataBasePathTextBox;
		private System.Windows.Forms.Button DataBaseFileChangeButton;
		private System.Windows.Forms.Button NewDataBaseButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

