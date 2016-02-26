using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;

namespace DotaMap
{
    public partial class DotaMap : Form
    {
		int screenWidth = 1920;
		int screenHeight = 1080;		
		int xPosition = 100;
        int yPosition = 200;
        int width = 300;
        int height = 400;
        int interval = 1000/60;

		Timer timer;
		Settings settingsForm;
		Bitmap bitmap;

        public DotaMap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			//initialise 
			timer = new Timer();
			settingsForm = new Settings(this);
			LoadSettings(settingsForm.GetSettings());

			//start timer            
            timer.Interval = interval;
			timer.Tick += showScreenshot;
			timer.Start();
        }
       
        void showScreenshot(object sender, EventArgs e)
        {
			//taking screenshot
			bitmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(xPosition, yPosition, 0, 0, new Size(width, height));

			//storing screenshot		
			if (interval > 500 && false)
			{
				string path = "saves/test" + DateTime.Now.Ticks + ".bmp";
				bitmap.Save(path, ImageFormat.Bmp);
			}			

			//showing screenshot and collecting garbage
			if (pbMap.Image != null)
			{
				pbMap.Image.Dispose();
			}
			pbMap.Image = bitmap;
			GC.Collect();
        }

		private void DotaMap_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) //enter
			{
				timer.Stop();
				this.
				settingsForm.Showow();
				if (settingsForm.ShouldUpdate)
				{
					LoadSettings(settingsForm.GetSettings());
				}
				timer.Start();
			}			
		}

		void LoadSettings(int[] settings)
		{			
			xPosition = settings[0];
			yPosition = settings[1];
			width = settings[2];
			height = settings[3];
			timer.Interval = 960 / settings[4];
			UpdateStatusStrip(settings);					
		}

		void UpdateStatusStrip(int[] settings)
		{
			tsslXPosition.Text = "xPos: " + settings[0];
			tsslYPos.Text = "yPos: " + settings[1];
			tsslWidth.Text = "width:" + settings[2];
			tsslHeight.Text = "height: " + settings[3];
			tsslInterval.Text = "interval: " + 960 / settings[4];
			tsslFramerate.Text = "framerate: " + settings[4];
		}
    }
}
