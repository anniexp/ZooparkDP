using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{

    public abstract class AnimalFactory 
    {
        /*protected abstract Animal MakeProduct();
        public Animals CreateProduct()
        {
            return this.MakeProduct();
        }*/
        public AnimalFactory() { }
        public static IAnimal GetAnimal(string key)
        {
            switch (key)
            {
                case "sloth":
                    return new Sloth();
                case "greatHornbill":
                    return new GreatHornbill();
                 case "komodo":
                     return new KomodoDragon();
                 case "lemur":
                    return new RingTailedLemur();
                case "grizzly":
                    return new GrizzlyBear();
                default:
                    throw new Exception("Not valid key provided!");
                    //we can create custom exceptions
            }
        }
    }
    

}
