using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System.Drawing;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat pic = new Mat();
            pic = CvInvoke.Imread(@"C:\Users\User\source\repos\ConsoleApp6\ConsoleApp6");
            Mat gaussianBlur = new Mat();

            CvInvoke.GaussianBlur(pic, gaussianBlur, new System.Drawing.Size(pic.Row, pic.Cols),6,6);

            CvInvoke.Imshow("st n", pic);
            CvInvoke.Imshow("bl n", gaussianBlur);
            CvInvoke.WaitKey();
        }
    }
}
