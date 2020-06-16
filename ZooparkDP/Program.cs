using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    class Program
    {
        static void ListAnimal(IAnimal animal)
        {
           
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Animal kind: {0}", animal.AnimalKind());

            Console.WriteLine(" Type : {0}", animal.TypeOfAnimal());

            Console.WriteLine(" Region : {0}", animal.Region());

            Console.WriteLine(" Type: {0}", animal.TypeOfAnimalByWhatTheyEat());

            Console.WriteLine(" Description : {0}", animal.Description());

            Console.WriteLine(" Quantity : {0}", animal.Quantity());
        }

        static void Main(string[] args)
        {
            ArrayList listOfAnimals = new ArrayList();
            IAnimal animal = AnimalFactory.getAnimal("sloth");
            listOfAnimals.Add(animal);
            ListAnimal(animal);
            IAnimal greatHornbill = AnimalFactory.getAnimal("greatHornbill");
            listOfAnimals.Add(greatHornbill);

            ListAnimal(greatHornbill);

            IAnimal komodo = AnimalFactory.getAnimal("komodo");
            listOfAnimals.Add(komodo);
            ListAnimal(komodo);

            IAnimal lemur = AnimalFactory.getAnimal("lemur");
            listOfAnimals.Add(lemur);
            ListAnimal(lemur);

            IAnimal grizzly = AnimalFactory.getAnimal("grizzly");
            listOfAnimals.Add(grizzly);
            ListAnimal(grizzly);

            /*  foreach (object obj in listOfAnimals)
              {
                  Console.WriteLine(obj);
              }*/
        }
    }
}
