using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    class GreatHornbill : IAnimal
    {
        public double AnimalCareExpensesPerAnimalInDolars()
        {
            return 20.9;
        }

        public string AnimalKind()
        {
            return "Great hornbill";
        }

        public string Description()
        {
            return "Its impressive size and colour have made it important in many tribal " +
                "cultures and rituals. The great hornbill is long-lived, living for nearly 50 years in captivity";

        }

        public int Quantity()
        {
            return 6;
        }

        public string Region()
        {
            return "Asia";
        }

        public string TypeOfAnimal()
        {
            return "bird";
        }

        public string TypeOfAnimalByWhatTheyEat()
        {
            return "Herbivore";
        }
    
}
}
