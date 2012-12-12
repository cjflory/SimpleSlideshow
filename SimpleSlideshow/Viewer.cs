using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace SimpleSlideshow
{
    public partial class Viewer : Form
    {
        private int interval;
        private bool paused = false;
        private List<string> images;
        private string currentImage;
        private System.Timers.Timer timer;

        public Viewer(List<string> images, int interval)
        {
            InitializeComponent();
            this.interval = interval * 1000; // Convert seconds to milliseconds
            this.images = images;
            Properties.Resources.NextArrow.MakeTransparent(Properties.Resources.NextArrow.GetPixel(0, 0));
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            this.setCurrentImage(this.images.First());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            closeApp();
        }

        private void closeApp()
        {
            this.Close();
            Application.Exit();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextImage();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            prevImage();
        }

        private void nextImage()
        {
            this.disposeTimer();
            var index = images.IndexOf(this.currentImage);
            if (index + 1 >= images.Count)
                this.setCurrentImage(images[0]);
            else
                this.setCurrentImage(images[index + 1]);
        }

        private void prevImage()
        {
            this.disposeTimer();
            var index = images.IndexOf(this.currentImage);
            if (index == 0)
                this.setCurrentImage(images.Last());
            else
                this.setCurrentImage(images[index - 1]);
        }

        private void disposeTimer()
        {
            this.timer.Stop();
        }

        private void setCurrentImage(string path)
        {
            this.currentImage = path;
            pictureBox1.ImageLocation = this.currentImage;
            this.timer = new System.Timers.Timer(this.interval);
            this.timer.Elapsed += new ElapsedEventHandler(nextButton_Click);
            this.timer.Interval = this.interval;
            if (!this.paused)
                this.timer.Start();
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            playPause();
        }

        private void playPause()
        {
            this.paused = !this.paused;
            if (this.paused)
            {
                playPauseButton.Image = Properties.Resources.PlayButton;
                this.timer.Stop();
            }
            else
            {
                playPauseButton.Image = Properties.Resources.PauseButton;
                nextImage();
            }
        }

        private void Viewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                prevImage();
            else if (e.KeyCode == Keys.Right)
                nextImage();
            else if (e.KeyCode == Keys.Escape)
                closeApp();
            else if (e.KeyCode == Keys.Space)
                playPause();
        }
    }
}
