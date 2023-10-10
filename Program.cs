using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class chef
    {
        public void MakesChicken()
        {
            Console.WriteLine("the chef Makes Chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("the chef makes Salad");
        }
        public virtual void MakesSpecialDishh() 
        {
            Console.WriteLine("the chef makes special dish");
        }
        internal class ItalianChef:chef 
        {
            public void MakesPasta()
            {
                Console.WriteLine("makes pasta");
            }
            public override void MakesSpecialDishh()
            {
                Console.WriteLine("the chef makes ItalianSpecials ");
            }
        }
        static void Main(string[] args)
        {
           chef chef = new chef();
            chef.MakesSpecialDishh();

            ItalianChef chef1 = new ItalianChef();
            chef1.MakesChicken();
            chef1.MakesPasta();
            chef1.MakesSpecialDishh();

            Console.ReadLine();
        }
    }
}
