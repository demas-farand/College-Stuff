using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProjectName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(100, 100, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }

            pictureBox1.Image = bmp;
            //D
            bmp.SetPixel(10, 20, Color.Black);
            bmp.SetPixel(10, 21, Color.Black);
            bmp.SetPixel(10, 22, Color.Black);
            bmp.SetPixel(10, 23, Color.Black);
            bmp.SetPixel(10, 24, Color.Black);
            bmp.SetPixel(10, 25, Color.Black);
            bmp.SetPixel(10, 26, Color.Black);
            bmp.SetPixel(10, 27, Color.Black);
            bmp.SetPixel(11, 20, Color.Black);
            bmp.SetPixel(12, 20, Color.Black);
            bmp.SetPixel(11, 27, Color.Black);
            bmp.SetPixel(12, 27, Color.Black);
            bmp.SetPixel(13, 21, Color.Black);
            bmp.SetPixel(13, 22, Color.Black);
            bmp.SetPixel(13, 23, Color.Black);
            bmp.SetPixel(13, 24, Color.Black);
            bmp.SetPixel(13, 25, Color.Black);
            bmp.SetPixel(13, 26, Color.Black);

            //E
            bmp.SetPixel(15, 20, Color.Black);
            bmp.SetPixel(15, 21, Color.Black);
            bmp.SetPixel(15, 22, Color.Black);
            bmp.SetPixel(15, 23, Color.Black);
            bmp.SetPixel(15, 24, Color.Black);
            bmp.SetPixel(15, 25, Color.Black);
            bmp.SetPixel(15, 26, Color.Black);
            bmp.SetPixel(15, 27, Color.Black);
            bmp.SetPixel(15, 20, Color.Black);
            bmp.SetPixel(16, 20, Color.Black);
            bmp.SetPixel(17, 20, Color.Black);
            bmp.SetPixel(18, 20, Color.Black);
            bmp.SetPixel(19, 20, Color.Black);
            bmp.SetPixel(16, 24, Color.Black);
            bmp.SetPixel(17, 24, Color.Black);
            bmp.SetPixel(18, 24, Color.Black);
            bmp.SetPixel(19, 24, Color.Black);
            bmp.SetPixel(16, 27, Color.Black);
            bmp.SetPixel(17, 27, Color.Black);
            bmp.SetPixel(18, 27, Color.Black);
            bmp.SetPixel(19, 27, Color.Black);

            //M
            bmp.SetPixel(21, 20, Color.Black);
            bmp.SetPixel(21, 21, Color.Black);
            bmp.SetPixel(21, 22, Color.Black);
            bmp.SetPixel(21, 23, Color.Black);
            bmp.SetPixel(21, 24, Color.Black);
            bmp.SetPixel(21, 25, Color.Black);
            bmp.SetPixel(21, 26, Color.Black);
            bmp.SetPixel(21, 27, Color.Black);
            bmp.SetPixel(22, 20, Color.Black);
            bmp.SetPixel(23, 21, Color.Black);
            bmp.SetPixel(24, 22, Color.Black);
            bmp.SetPixel(25, 22, Color.Black);
            bmp.SetPixel(26, 21, Color.Black);
            bmp.SetPixel(27, 20, Color.Black);
            bmp.SetPixel(28, 20, Color.Black);
            bmp.SetPixel(28, 21, Color.Black);
            bmp.SetPixel(28, 22, Color.Black);
            bmp.SetPixel(28, 23, Color.Black);
            bmp.SetPixel(28, 24, Color.Black);
            bmp.SetPixel(28, 25, Color.Black);
            bmp.SetPixel(28, 26, Color.Black);
            bmp.SetPixel(28, 27, Color.Black);

            //A
            bmp.SetPixel(30, 20, Color.Black);
            bmp.SetPixel(30, 21, Color.Black);
            bmp.SetPixel(30, 22, Color.Black);
            bmp.SetPixel(30, 23, Color.Black);
            bmp.SetPixel(30, 24, Color.Black);
            bmp.SetPixel(30, 25, Color.Black);
            bmp.SetPixel(30, 26, Color.Black);
            bmp.SetPixel(30, 27, Color.Black);
            bmp.SetPixel(31, 20, Color.Black);
            bmp.SetPixel(32, 20, Color.Black);
            bmp.SetPixel(33, 20, Color.Black);
            bmp.SetPixel(34, 20, Color.Black);
            bmp.SetPixel(35, 20, Color.Black);
            bmp.SetPixel(36, 20, Color.Black);
            bmp.SetPixel(31, 25, Color.Black);
            bmp.SetPixel(32, 25, Color.Black);
            bmp.SetPixel(33, 25, Color.Black);
            bmp.SetPixel(34, 25, Color.Black);
            bmp.SetPixel(35, 25, Color.Black);
            bmp.SetPixel(36, 25, Color.Black);
            bmp.SetPixel(36, 20, Color.Black);
            bmp.SetPixel(36, 21, Color.Black);
            bmp.SetPixel(36, 22, Color.Black);
            bmp.SetPixel(36, 23, Color.Black);
            bmp.SetPixel(36, 24, Color.Black);
            bmp.SetPixel(36, 25, Color.Black);
            bmp.SetPixel(36, 26, Color.Black);
            bmp.SetPixel(36, 27, Color.Black);

            //S
            bmp.SetPixel(38, 20, Color.Black);
            bmp.SetPixel(39, 20, Color.Black);
            bmp.SetPixel(40, 20, Color.Black);
            bmp.SetPixel(41, 20, Color.Black);
            bmp.SetPixel(42, 20, Color.Black);
            bmp.SetPixel(43, 20, Color.Black);
            bmp.SetPixel(44, 20, Color.Black);
            bmp.SetPixel(38, 21, Color.Black);
            bmp.SetPixel(38, 22, Color.Black);
            bmp.SetPixel(38, 23, Color.Black);
            bmp.SetPixel(38, 24, Color.Black);
            bmp.SetPixel(39, 24, Color.Black);
            bmp.SetPixel(40, 24, Color.Black);
            bmp.SetPixel(41, 24, Color.Black);
            bmp.SetPixel(42, 24, Color.Black);
            bmp.SetPixel(43, 24, Color.Black);
            bmp.SetPixel(44, 24, Color.Black);
            bmp.SetPixel(44, 25, Color.Black);
            bmp.SetPixel(44, 26, Color.Black);
            bmp.SetPixel(44, 27, Color.Black);
            bmp.SetPixel(43, 27, Color.Black);
            bmp.SetPixel(42, 27, Color.Black);
            bmp.SetPixel(41, 27, Color.Black);
            bmp.SetPixel(40, 27, Color.Black);
            bmp.SetPixel(39, 27, Color.Black);
            bmp.SetPixel(38, 27, Color.Black);



            BitmapData data = bmp.LockBits(new Rectangle(0, 0, 100, 100), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            IntPtr pointer = data.Scan0;
            int length = Math.Abs(data.Stride);
            byte[] values = new byte[length];
            Marshal.Copy(pointer, values, 0, length);

            values[0] = 0;
            values[1] = 0;
            values[2] = 0;


            Marshal.Copy(values, 0, pointer, length);
            bmp.UnlockBits(data);

            pictureBox1.Image = bmp;
        }
    }
}
