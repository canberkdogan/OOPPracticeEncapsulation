using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticeEncapsulation
{
    public class Car
    {
        private string brand;
        private string model;
        private string colour;
        private int doorCount;

        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public int DoorCount
        {
            get { return doorCount; }

            set
            {
                if (value == 2 || value == 4)
                {

                    doorCount = value;

                }
                else
                {
                    doorCount = -1;
                    Console.WriteLine("The car has only 2 or 4 doors. ");
                }
            }

        } 
        
        public Car(string brand, string model, string colour, int doorCount)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            DoorCount = doorCount;

        }

        public Car() 
        {
        
        }

        public void Display()
        {
            Console.WriteLine($"Car Brand {brand}, Model {model}, Colour {colour}, Door Count {doorCount}");
        }
        


    }
}
