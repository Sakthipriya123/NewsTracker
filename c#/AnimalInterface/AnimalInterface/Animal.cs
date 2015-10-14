using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public string MakeSound()
        {
            return this.Sound;
        }

        public Animal(string name)
        {
            this.Name = name;
        }
    }
    public class Bear : Animal
    {

        public Bear(string name) : base (name)
        {
            this.Sound = "Roar";
        }
       

    }
    public class Chicken : Animal,IBird
    {

        public Chicken(string name): base(name)
        {
            this.Sound ="Cluck";
            
        }

       
    }
    public class Eagle : Animal
    {

        public Eagle(string name):base(name)
        {
            this.Sound ="Krchh";
            
        }

        }


}
