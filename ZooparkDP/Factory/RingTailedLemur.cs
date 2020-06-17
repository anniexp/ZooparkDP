using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    class RingTailedLemur : IAnimal
    {
        public double AnimalCareExpensesPerAnimalInDolars()
        {
            return 95.9;
        }

        public string AnimalKind()
        {
            return "Ring-tailed lemur";
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
            return 10;
        }

        public string Region()
        {
            return "The island of Madagascar.";
        }

        public string TypeOfAnimal()
        {
            return "mammal";
        }

        public string TypeOfAnimalByWhatTheyEat()
        {
            return "Mainly herbivorous, will sometimes eat insects";
        }
    }
}

