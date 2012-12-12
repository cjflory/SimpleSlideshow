using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleSlideshow
{
    public partial class SimpleSlideshow : Form
    {
        public SimpleSlideshow()
        {
            InitializeComponent();
        }

        private void SimpleSlideshow_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.ImageFolderPath;
            textBox2.Text = Properties.Settings.Default.Interval.ToString();
        }

        private void startSlideshowButton_Click(object sender, EventArgs e)
        {
            var imageFolderPath = textBox1.Text;
            var intervalText = textBox2.Text;

            // Save the settings
            if (Directory.Exists(imageFolderPath))
            {
                Properties.Settings.Default.ImageFolderPath = imageFolderPath;
            }
            else
                MessageBox.Show("The path you entered is not a valid folder");
            try
            {
                var interval = int.Parse(intervalText);
                Properties.Settings.Default.Interval = interval;
            }
            catch
            {
                MessageBox.Show("You must enter a number");
            }
            Properties.Settings.Default.Save();




            
            // Get the image list
            var images = Directory.EnumerateFiles(imageFolderPath, "*.jpg", SearchOption.AllDirectories).ToList();
            foreach (var i in Directory.EnumerateFiles(imageFolderPath, "*.png", SearchOption.AllDirectories))
                images.Add(i);
            foreach (var i in Directory.EnumerateFiles(imageFolderPath, "*.gif", SearchOption.AllDirectories))
                images.Add(i);
            foreach (var i in Directory.EnumerateFiles(imageFolderPath, "*.bmp", SearchOption.AllDirectories))
                images.Add(i);

            var viewer = new Viewer(images, Properties.Settings.Default.Interval);
            viewer.FormBorderStyle = FormBorderStyle.None;
            viewer.WindowState = FormWindowState.Maximized;
            viewer.Show();
        }
    }
}
