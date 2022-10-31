
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird:Animal
    {
        
        public bool canfly { get; set; }
        public bool chirp { get; set; } 

        public bool candance { get; set; }  

        public bool isabletoflylongdistance { get; set; }


        public void Print(int age, bool chirp, string name, bool fly)
        {
            Console.WriteLine($"Hi my name is {name} and I am a hummingbird and it is  {fly} that I can fly. It is also {chirp} that I can make a chirping sound with my tail. I am just {age} years old ");

        }




    }
}
