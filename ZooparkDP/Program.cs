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
       public static void ListAnimal(IAnimal animal)
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
            Console.WriteLine("List of animals in zoopark: ");
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

            int numberOfAnimals = animal.Quantity() + grizzly.Quantity() + lemur.Quantity() + komodo.Quantity() + greatHornbill.Quantity();
            Console.WriteLine();
            Console.WriteLine("Current number of animals in zoo:{0} ", numberOfAnimals);
            // Setup Chain of Responsibility

            Worker larry = new Cleaner();

            Worker maria = new Caretaker();

            Worker ivan = new Medic();
            Worker dimitrii = new Manager();
            Worker katya = new Cashier();

            dimitrii.SetSuccessor(ivan);

            ivan.SetSuccessor(larry);
            larry.SetSuccessor(katya);
            katya.SetSuccessor(maria);
            Console.WriteLine();

            Console.WriteLine("List of current tasks to do: ");
            // Generate and process requests
            Console.WriteLine();
            String p = "clean bear cage";
            larry.ProcessRequest(p);

            p = "medical examine komodo dragon Julie, ";
            ivan.ProcessRequest(p);
            p = "feed animals";
            maria.ProcessRequest(p);
            p = "ring people in , take their money and give them change and a ticket";
            dimitrii.ProcessRequest(p);
            p = "give answers to customer questions";
            dimitrii.ProcessRequest(p);

           

            /*foreach (string request in requests)

            {

                ivan.ProcessRequest(request);
*
            }*/
            //ConcreteDecorator d1 = new ConcreteDecorator();
            /*  foreach (object obj in listOfAnimals)
              {
                  Console.WriteLine(obj);
              }*/
        }
    }
}
