namespace PartsManager.Source_Files
{
	partial class UrlEdit
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.MPartTextBox = new System.Windows.Forms.TextBox();
			this.ProviderTextBox = new System.Windows.Forms.TextBox();
			this.UrlTextBox = new System.Windows.Forms.TextBox();
			this.CancelButton = new System.Windows.Forms.Button();
			this.OkButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Manufacturer\'s Part ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Provider Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "URL";
			// 
			// MPartTextBox
			// 
			this.MPartTextBox.Location = new System.Drawing.Point(13, 40);
			this.MPartTextBox.Name = "MPartTextBox";
			this.MPartTextBox.Size = new System.Drawing.Size(259, 21);
			this.MPartTextBox.TabIndex = 3;
			// 
			// ProviderTextBox
			// 
			this.ProviderTextBox.Location = new System.Drawing.Point(13, 100);
			this.ProviderTextBox.Name = "ProviderTextBox";
			this.ProviderTextBox.Size = new System.Drawing.Size(259, 21);
			this.ProviderTextBox.TabIndex = 4;
			// 
			// UrlTextBox
			// 
			this.UrlTextBox.Location = new System.Drawing.Point(13, 160);
			this.UrlTextBox.Name = "UrlTextBox";
			this.UrlTextBox.Size = new System.Drawing.Size(259, 21);
			this.UrlTextBox.TabIndex = 5;
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(197, 210);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 6;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(116, 210);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 7;
			this.OkButton.Text = "OK";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// UrlEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 245);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.UrlTextBox);
			this.Controls.Add(this.ProviderTextBox);
			this.Controls.Add(this.MPartTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "UrlEdit";
			this.Text = "URL";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox MPartTextBox;
		private System.Windows.Forms.TextBox ProviderTextBox;
		private System.Windows.Forms.TextBox UrlTextBox;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button OkButton;
	}
}