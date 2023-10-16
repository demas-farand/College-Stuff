using System;
using System.Drawing;
using System.Windows.Forms;

namespace InversePicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Height; x++)
                    {
                        Color redColor = Color.FromArgb(255, 0, 0);
                        image.SetPixel(x, y, redColor);
                    }
                }


                pictureBox1.Image = image;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Height; x++)
                    {
                        Color greenColor = Color.FromArgb(0, 255, 0);
                        image.SetPixel(x, y, greenColor);
                    }
                }


                pictureBox2.Image = image;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Height; x++)
                    {
                        Color blueColor = Color.FromArgb(0, 0, 255);
                        image.SetPixel(x, y, blueColor);
                    }
                }


                pictureBox3.Image = image;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != null)
            {
                Bitmap image = new Bitmap(pictureBox1.Image);

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Height; x++)
                    {
                        Color yellowColor = Color.FromArgb(255, 255, 0);
                        image.SetPixel(x, y, yellowColor);
                    }
                }


                pictureBox4.Image = image;
            }
        }
    }
}



