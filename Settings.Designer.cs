namespace DotaMap
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
			this.nudXPos = new System.Windows.Forms.NumericUpDown();
			this.lblxPos = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nudYPos = new System.Windows.Forms.NumericUpDown();
			this.lblWidth = new System.Windows.Forms.Label();
			this.nudWidth = new System.Windows.Forms.NumericUpDown();
			this.lblHeight = new System.Windows.Forms.Label();
			this.nudHeight = new System.Windows.Forms.NumericUpDown();
			this.lblTimer = new System.Windows.Forms.Label();
			this.nudFramerate = new System.Windows.Forms.NumericUpDown();
			this.grpSettings = new System.Windows.Forms.GroupBox();
			this.btnDefaults = new System.Windows.Forms.Button();
			this.bntAccept = new System.Windows.Forms.Button();
			this.bntCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudXPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudYPos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFramerate)).BeginInit();
			this.grpSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// nudXPos
			// 
			this.nudXPos.Location = new System.Drawing.Point(132, 20);
			this.nudXPos.Name = "nudXPos";
			this.nudXPos.Size = new System.Drawing.Size(120, 20);
			this.nudXPos.TabIndex = 0;
			// 
			// lblxPos
			// 
			this.lblxPos.AutoSize = true;
			this.lblxPos.Location = new System.Drawing.Point(10, 22);
			this.lblxPos.Name = "lblxPos";
			this.lblxPos.Size = new System.Drawing.Size(116, 13);
			this.lblxPos.TabIndex = 1;
			this.lblxPos.Text = "Horizontal start position";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Vertical start position";
			// 
			// nudYPos
			// 
			this.nudYPos.Location = new System.Drawing.Point(132, 46);
			this.nudYPos.Name = "nudYPos";
			this.nudYPos.Size = new System.Drawing.Size(120, 20);
			this.nudYPos.TabIndex = 2;
			// 
			// lblWidth
			// 
			this.lblWidth.AutoSize = true;
			this.lblWidth.Location = new System.Drawing.Point(91, 74);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(35, 13);
			this.lblWidth.TabIndex = 5;
			this.lblWidth.Text = "Width";
			// 
			// nudWidth
			// 
			this.nudWidth.Location = new System.Drawing.Point(132, 72);
			this.nudWidth.Name = "nudWidth";
			this.nudWidth.Size = new System.Drawing.Size(120, 20);
			this.nudWidth.TabIndex = 4;
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(91, 100);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(38, 13);
			this.lblHeight.TabIndex = 7;
			this.lblHeight.Text = "Height";
			// 
			// nudHeight
			// 
			this.nudHeight.Location = new System.Drawing.Point(132, 98);
			this.nudHeight.Name = "nudHeight";
			this.nudHeight.Size = new System.Drawing.Size(120, 20);
			this.nudHeight.TabIndex = 6;
			// 
			// lblTimer
			// 
			this.lblTimer.AutoSize = true;
			this.lblTimer.Location = new System.Drawing.Point(61, 126);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(65, 13);
			this.lblTimer.TabIndex = 9;
			this.lblTimer.Text = "Refresh rate";
			// 
			// nudFramerate
			// 
			this.nudFramerate.Location = new System.Drawing.Point(132, 124);
			this.nudFramerate.Name = "nudFramerate";
			this.nudFramerate.Size = new System.Drawing.Size(120, 20);
			this.nudFramerate.TabIndex = 8;
			// 
			// grpSettings
			// 
			this.grpSettings.Controls.Add(this.btnDefaults);
			this.grpSettings.Controls.Add(this.nudFramerate);
			this.grpSettings.Controls.Add(this.lblTimer);
			this.grpSettings.Controls.Add(this.nudXPos);
			this.grpSettings.Controls.Add(this.lblxPos);
			this.grpSettings.Controls.Add(this.lblHeight);
			this.grpSettings.Controls.Add(this.nudYPos);
			this.grpSettings.Controls.Add(this.nudHeight);
			this.grpSettings.Controls.Add(this.label2);
			this.grpSettings.Controls.Add(this.lblWidth);
			this.grpSettings.Controls.Add(this.nudWidth);
			this.grpSettings.Location = new System.Drawing.Point(12, 12);
			this.grpSettings.Name = "grpSettings";
			this.grpSettings.Size = new System.Drawing.Size(262, 184);
			this.grpSettings.TabIndex = 10;
			this.grpSettings.TabStop = false;
			this.grpSettings.Text = "Settings";
			// 
			// btnDefaults
			// 
			this.btnDefaults.Location = new System.Drawing.Point(132, 150);
			this.btnDefaults.Name = "btnDefaults";
			this.btnDefaults.Size = new System.Drawing.Size(120, 23);
			this.btnDefaults.TabIndex = 13;
			this.btnDefaults.Text = "Defaults";
			this.btnDefaults.UseVisualStyleBackColor = true;
			this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
			// 
			// bntAccept
			// 
			this.bntAccept.Location = new System.Drawing.Point(12, 202);
			this.bntAccept.Name = "bntAccept";
			this.bntAccept.Size = new System.Drawing.Size(78, 34);
			this.bntAccept.TabIndex = 11;
			this.bntAccept.Text = "Accept";
			this.bntAccept.UseVisualStyleBackColor = true;
			this.bntAccept.Click += new System.EventHandler(this.bntAccept_Click);
			// 
			// bntCancel
			// 
			this.bntCancel.Location = new System.Drawing.Point(191, 202);
			this.bntCancel.Name = "bntCancel";
			this.bntCancel.Size = new System.Drawing.Size(83, 34);
			this.bntCancel.TabIndex = 12;
			this.bntCancel.Text = "Cancel";
			this.bntCancel.UseVisualStyleBackColor = true;
			this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 245);
			this.Controls.Add(this.bntCancel);
			this.Controls.Add(this.bntAccept);
			this.Controls.Add(this.grpSettings);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Settings";
			((System.ComponentModel.ISupportInitialize)(this.nudXPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudYPos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFramerate)).EndInit();
			this.grpSettings.ResumeLayout(false);
			this.grpSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudXPos;
		private System.Windows.Forms.Label lblxPos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudYPos;
		private System.Windows.Forms.Label lblWidth;
		private System.Windows.Forms.NumericUpDown nudWidth;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.NumericUpDown nudHeight;
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.NumericUpDown nudFramerate;
		private System.Windows.Forms.GroupBox grpSettings;
		private System.Windows.Forms.Button bntAccept;
		private System.Windows.Forms.Button bntCancel;
		private System.Windows.Forms.Button btnDefaults;
	}
}