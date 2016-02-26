using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaMap
{
	public partial class Settings : Form
	{		
		string saveDir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DotaMap", "save.txt");
		public bool ShouldUpdate = false;
		Form parentForm;

		public Settings(Form parent)
		{
			InitializeComponent();
			this.MinimumSize = this.MaximumSize = this.Size;
			this.parentForm = parent;
			this.Location = parent.Location;

			//set value limits
			nudXPos.Minimum = 0;
			nudXPos.Maximum = 1920;
			nudYPos.Minimum = 0;
			nudYPos.Maximum = 1080;
			nudWidth.Minimum = 1;
			nudWidth.Maximum = 1920;
			nudHeight.Minimum = 1;
			nudHeight.Maximum = 1080;
			nudFramerate.Minimum = 1;
			nudFramerate.Maximum = 120;

			//saveDir = "save.txt";

			if (System.IO.File.Exists(saveDir)){
				loadFromSaveFile();
			}
			else
			{
				setDefaults();
			}	
		}

		void setDefaults()
		{
			//default values
			nudXPos.Value = 0;
			nudYPos.Value = 1080 - 300;
			nudWidth.Value = 300;
			nudHeight.Value = 300;
			nudFramerate.Value = 60;
		}

		void loadFromSaveFile()
		{
			string file = File.ReadAllText(saveDir);
			string[] lines = file.Replace("\r", "").Split('\n');
			
			nudXPos.Value = Decimal.Parse(lines[1].Split('=')[1]);
			nudYPos.Value = Decimal.Parse(lines[2].Split('=')[1]);
			nudWidth.Value = Decimal.Parse(lines[3].Split('=')[1]);
			nudHeight.Value = Decimal.Parse(lines[4].Split('=')[1]);
			nudFramerate.Value = Decimal.Parse(lines[5].Split('=')[1]);	
		}

		void saveSettingsToFile()
		{
			StringBuilder content = new StringBuilder();
			content.AppendLine("--DotaMap save--");
			content.AppendLine("xPosition=" + nudXPos.Value);
			content.AppendLine("yPosition=" + nudYPos.Value);
			content.AppendLine("width=" + nudWidth.Value);
			content.AppendLine("height=" + nudHeight.Value);
			content.AppendLine("framerate=" + nudFramerate.Value);			

			System.IO.Directory.CreateDirectory(saveDir.Substring(0,saveDir.Length-8));
			using (StreamWriter streamwriter = new StreamWriter(saveDir))
			{
				streamwriter.Write(content);
			}
		}

		public int[] GetSettings()
		{
			int[] settings = new int[5];
			settings[0] = (int)nudXPos.Value;
			settings[1] = (int)nudYPos.Value;
			settings[2] = (int)nudWidth.Value;
			settings[3] = (int)nudHeight.Value;
			settings[4] = (int)nudFramerate.Value;

			return settings;
		}

		private void bntCancel_Click(object sender, EventArgs e)
		{
			ShouldUpdate = false;
			this.Close();
		}

		private void bntAccept_Click(object sender, EventArgs e)
		{
			ShouldUpdate = true;
			saveSettingsToFile();
			this.Close();
		}

		public void Showow(){
			this.Location = new Point(parentForm.Location.X + parentForm.Width / 2 - this.Width / 2,
				parentForm.Location.Y + parentForm.Height / 2 - this.Height / 2);
			ShowDialog();
		}

		private void btnDefaults_Click(object sender, EventArgs e)
		{
			setDefaults();
		}
	}
}
