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

            // Setup Chain of Responsibility

            Worker larry = new Cleaner();

            Worker maria = new Caretaker();

            Worker ivan = new Medic();

            ivan.SetSuccessor(larry);
            larry.SetSuccessor(maria);
            // Generate and process request

            //string[] requests = { "clean bear cage", "medical examine komodo dragon Julie, " , "feed animals" };

            // Generate and process purchase requests
            Console.WriteLine();
            String p = "clean bear cage";
            larry.ProcessRequest(p);

            p = "medical examine komodo dragon Julie, ";
            ivan.ProcessRequest(p);
            p = "feed animals";
            maria.ProcessRequest(p);
            

           

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
