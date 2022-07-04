using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExtensionPractice
{
    class car 
    {
        public static int speed;


        static car()
        {
            speed = 500;
            Console.WriteLine(speed);
        }
    }
}
