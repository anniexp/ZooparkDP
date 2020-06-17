using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    class KomodoDragon : IAnimal
    {
        public double AnimalCareExpensesPerAnimalInDolars()
        {
            return 30.60;
        }

        public string AnimalKind()
        {
            return "Komodo dragon";
        }

        public string Description()
        {
            return "The Komodo dragon (Varanus komodoensis), " +
                "also known as the Komodo monitor, is a species of lizard found in the Indonesian islands" +
                " of Komodo, Rinca, Flores, and Gili Motang. A member of the monitor lizard family Varanidae," +
                " it is the largest extant species of lizard, growing to a maximum length of 3 metres (10 ft)" +
                " in rare cases and weighing up to approximately 70 kilograms (150 lb).";

        }

        public int Quantity()
        {
            return 2;
        }

        public string Region()
        {
            return "South and North America";
        }

        public string TypeOfAnimal()
        {
            return "reptile";
        }

        public string TypeOfAnimalByWhatTheyEat()
        {
            return "Carnivore";
        }
    }
}
