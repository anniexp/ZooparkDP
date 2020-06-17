using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
   

    public class Sloth : IAnimal
    {
        public double AnimalCareExpensesPerAnimalInDolars()
        {
            return 15.45;
        }

        public string AnimalKind()
        {
            return "Sloth";
        }

        public string Description()
        {
         return " tree-dwelling mammal noted for its slowness of movement. ";
        }

        public int Quantity()
        {
            return 4;
        }

        public string Region()
        {
           return "South and North America";
        }

        public string TypeOfAnimal()
        {
            return "mammal";
        }

        public string TypeOfAnimalByWhatTheyEat()
        {
            return "Herbivore";
        }
    }

}
