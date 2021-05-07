using System;//Write a program for creating a Car in which Engine, Tyre, Sound System should be defined in a base class. Your program should inherit all the functionality and gives custom color to a car using interface

namespace OopsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.CarType();
            Console.ReadKey();

        }
    }

    //creating a base class
    class Tyre
    {
        protected void TyreType()

        {
            Console.WriteLine("Tubeless Tyre");

        } }

    class Sound
    {
        public void SoundType()
        {
            Console.WriteLine("Electric Music");

        }


    }

    class color
    {
        protected void ColorType()
        {
            Console.WriteLine("Grey");
        }
    }


    //creating child class
    class Car : Tyre
    {
        public void CarType()
        {
            Console.WriteLine("Car Type: Mercdez");
            CarType();
        }
        public void SoundType()
        {
            Console.WriteLine("SoundType:Electric");
            SoundType();
        }
    }
}

  
