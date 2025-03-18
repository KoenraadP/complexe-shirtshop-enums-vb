using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ShirtShop.Entities;

namespace ShirtShop.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirt shirt1 = new Shirt(Guid.NewGuid(), "CoolShirt",
                Fabric.Cotton, Size.M, Color.Blue,
                SleeveLength.LongSleeve, Brand.CalvinKlein,
                true, 99.99M);

            Console.WriteLine(shirt1.Name);

            // verzamel alle properties in een array
            PropertyInfo[] shirtProperties = shirt1.GetType().GetProperties();

            // toon alle properties met hun waarden
            // onder elkaar
            foreach (PropertyInfo property in shirtProperties)
            {
                Console.WriteLine(property.Name + ": " 
                                  + property.GetValue(shirt1));
            }
        }
    }
}
