using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to couresra Beginning Game Programming with C#.");
            Console.Write("Please enter initial angle in degree: ");
            float theta = float.Parse(Console.ReadLine());
            theta = theta * (float)Math.PI / 180;
            Console.Write("Please enter initial speed: ");
            float speed = float.Parse(Console.ReadLine());

            const float G = 9.8F;

            float vox = speed * (float)Math.Cos(theta);

            float voy = speed * (float)Math.Sin(theta);

            float t = voy / G;
            float h = (voy * voy) / 2 / G;
            float dx = vox * 2 * t;

            Console.WriteLine ("Maximum height of shell is: " + h);
            Console.WriteLine ("Distance shell travels horizontally is: " + dx);

            //wait for Enter
            Console.ReadLine();
        }
    }
}
