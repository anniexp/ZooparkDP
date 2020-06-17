using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP 
{
    class GrizzlyBear : IAnimal
    {
        public double AnimalCareExpensesPerAnimalInDolars()
        {
            return 40.95;
        }

        public string AnimalKind()
        {
            return "Grizzly bear";
        }

        public string Description()
        {
            return "The ring-tailed lemur (Lemur catta) is a large strepsirrhine" +
                " primate and the most recognized lemur due to its long, black and" +
                " white ringed tail. It belongs to Lemuridae, one of five lemur" +
                " families, and is the only member of the Lemur genus.";
        }

        public int Quantity()
        {
            return 2;
        }

        public string Region()
        {
            return "Western North America ";
        }

        public string TypeOfAnimal()
        {
            return "mammal";
        }

        public string TypeOfAnimalByWhatTheyEat()
        {
            return "Omnivore";
        }
    

}
}
