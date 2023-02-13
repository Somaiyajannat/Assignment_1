using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public interface ICamera
    {
        public void TakePhoto(int width, int height);
        public void TakePhoto(int width, int width);
        public void TakePhoto(int height, int width, int length);
    }
    public class Cannon: ICamera
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public void TakePhoto(int width, int height)
        {
            Console.WriteLine($"Took photo of size: {width}x{height}");
        }
        public void TakePhoto(int width, int width)
        {
            Console.WriteLine($"Took photo of total width: {width}+{width}");
        }
        public void TakePhoto(int height, int width, int length)
        {
            Console.WriteLine($"Took photo of total Size: {height}*{width}*{length}");
        }
    }
}
