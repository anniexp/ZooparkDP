using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{

    public abstract class AnimalFactory 
    {
       
        public AnimalFactory() { }
        //with given unique identificational key, the fabric creates objects with the propertiies of the given class
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
