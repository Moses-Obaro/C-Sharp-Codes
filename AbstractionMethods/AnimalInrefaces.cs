using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_WORKS
{
    /*
     * While a user can't just have a random animal i.e. the animal type must be specific, 
     * The user's animal inherits the AnimalRules interface 
     * which defines the basic things an a created animal-type
     * must be able to do
     */
    interface IAnimalRules
    {
        public void MakeSound();
        public  void Feed();
        public  void Move();

    }
    class Dogs: IAnimalRules
    {
        public void MakeSound()
        {
            Console.WriteLine("Wooph, wooph!! I can bark");
        }
        public void Feed()
        {
            Console.WriteLine("I eat meat");
        }
        public void Move()
        {
            Console.WriteLine("I rotary gallop");
        }
    }

    class Cats : IAnimalRules
    {
        public  void MakeSound()
        {
            Console.WriteLine("Meow, Meow!! I can bark");
        }
        public void Feed()
        {
            Console.WriteLine("I lick milk");
        }
        public void Move()
        {
            Console.WriteLine("I digitigrade");
        }
        public void Relax()
        {
            Console.WriteLine("I purr while relaxing");
        }
    }
}
