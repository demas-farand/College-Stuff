using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ImageCapture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VideoCaptureDevice VideoCapture;
        FilterInfoCollection FilterInfo;

        void StartCamera()
        {
            try
            {
                FilterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                VideoCapture = new VideoCaptureDevice(FilterInfo[0].MonikerString);
                VideoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                VideoCapture.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            try
            {
                VideoCapture.Stop();
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
            string fileName = @"C:\Users\Administrator\Pictures\ImageCapture\" + textBox1.Text + ".jpg";
            var bitmap = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(bitmap, pictureBox2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(fileName, imageFormat);
        }
    }
}
