namespace DotaMap
{
    partial class DotaMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DotaMap));
			this.pbMap = new System.Windows.Forms.PictureBox();
			this.ssSettings = new System.Windows.Forms.StatusStrip();
			this.tsslFramerate = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslInterval = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslXPosition = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslYPos = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslWidth = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslHeight = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
			this.ssSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbMap
			// 
			this.pbMap.BackColor = System.Drawing.Color.SteelBlue;
			this.pbMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMap.Image")));
			this.pbMap.Location = new System.Drawing.Point(0, 0);
			this.pbMap.Name = "pbMap";
			this.pbMap.Size = new System.Drawing.Size(754, 547);
			this.pbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbMap.TabIndex = 0;
			this.pbMap.TabStop = false;
			// 
			// ssSettings
			// 
			this.ssSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFramerate,
            this.tsslInterval,
            this.tsslXPosition,
            this.tsslYPos,
            this.tsslWidth,
            this.tsslHeight});
			this.ssSettings.Location = new System.Drawing.Point(0, 525);
			this.ssSettings.Name = "ssSettings";
			this.ssSettings.Size = new System.Drawing.Size(754, 22);
			this.ssSettings.TabIndex = 1;
			this.ssSettings.Text = "statusStrip1";
			// 
			// tsslFramerate
			// 
			this.tsslFramerate.Name = "tsslFramerate";
			this.tsslFramerate.Size = new System.Drawing.Size(76, 17);
			this.tsslFramerate.Text = "framerate: 60";
			// 
			// tsslInterval
			// 
			this.tsslInterval.Name = "tsslInterval";
			this.tsslInterval.Size = new System.Drawing.Size(64, 17);
			this.tsslInterval.Text = "interval: 16";
			// 
			// tsslXPosition
			// 
			this.tsslXPosition.Name = "tsslXPosition";
			this.tsslXPosition.Size = new System.Drawing.Size(55, 17);
			this.tsslXPosition.Text = "xPos: 100";
			// 
			// tsslYPos
			// 
			this.tsslYPos.Name = "tsslYPos";
			this.tsslYPos.Size = new System.Drawing.Size(56, 17);
			this.tsslYPos.Text = "yPos: 200";
			// 
			// tsslWidth
			// 
			this.tsslWidth.Name = "tsslWidth";
			this.tsslWidth.Size = new System.Drawing.Size(61, 17);
			this.tsslWidth.Text = "width: 300";
			// 
			// tsslHeight
			// 
			this.tsslHeight.Name = "tsslHeight";
			this.tsslHeight.Size = new System.Drawing.Size(65, 17);
			this.tsslHeight.Text = "height: 400";
			// 
			// DotaMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 547);
			this.Controls.Add(this.ssSettings);
			this.Controls.Add(this.pbMap);
			this.KeyPreview = true;
			this.Name = "DotaMap";
			this.Text = "DotaMap";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DotaMap_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
			this.ssSettings.ResumeLayout(false);
			this.ssSettings.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
		private System.Windows.Forms.StatusStrip ssSettings;
		private System.Windows.Forms.ToolStripStatusLabel tsslFramerate;
		private System.Windows.Forms.ToolStripStatusLabel tsslInterval;
		private System.Windows.Forms.ToolStripStatusLabel tsslXPosition;
		private System.Windows.Forms.ToolStripStatusLabel tsslYPos;
		private System.Windows.Forms.ToolStripStatusLabel tsslWidth;
		private System.Windows.Forms.ToolStripStatusLabel tsslHeight;

    }
}

