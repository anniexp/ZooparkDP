using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooparkDP.Bridge;

namespace ZooparkDP
{
    class Program
    {
        static IAnimal animal;
        static IAnimal grizzly;
        static IAnimal lemur;
        static IAnimal komodo;
        static IAnimal greatHornbill;
       


        public static void ListAnimal(IAnimal animal)
        {
           // SmallCage smallCage = new SmallCage();

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Animal kind: {0}", animal.AnimalKind());

            Console.WriteLine(" Type of animal by biology : {0}", animal.TypeOfAnimal());

            Console.WriteLine(" Region : {0}", animal.Region());

            Console.WriteLine(" Type of animal by what they eat: {0}", animal.TypeOfAnimalByWhatTheyEat());

            Console.WriteLine(" Description : {0}", animal.Description());

            Console.WriteLine(" Quantity : {0}", animal.Quantity());

            if (animal.TypeOfAnimal() == "bird")
            {

                Bridge.Type type = new SmallCage();
                type._ICage = new Bird();
                type.MakeType();

            }
            else if (animal.TypeOfAnimal() == "reptile")
            {
                Bridge.Type type = new SmallCage();
                type._ICage = new Reptile();
                type.MakeType();

            }
            else if (animal.TypeOfAnimal() == "mammal")
            {
                Bridge.Type type = new BigCage();
                type._ICage = new Mammal();
                type.MakeType();


            }
            
        }
        public static void CalculateProfit(double money1, double money2)
        {
           
            double profit;
            profit = money1 + money2 - (animal.Quantity() * animal.AnimalCareExpensesPerAnimalInDolars() +
               grizzly.Quantity() * grizzly.AnimalCareExpensesPerAnimalInDolars() +
               lemur.Quantity() * lemur.AnimalCareExpensesPerAnimalInDolars() +
               komodo.Quantity() * komodo.AnimalCareExpensesPerAnimalInDolars() +
               greatHornbill.Quantity() * greatHornbill.AnimalCareExpensesPerAnimalInDolars())
               - Cashier.SalaryPerWeek() - Caretaker.SalaryPerWeek() - Manager.SalaryPerWeek() -
               Medic.SalaryPerWeek() - Cleaner.SalaryPerWeek();
            Console.WriteLine("Profit per week: {0}", profit);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("List of animals in zoopark: ");
            ArrayList listOfAnimals = new ArrayList();
            animal = AnimalFactory.GetAnimal("sloth");
            listOfAnimals.Add(animal);
            ListAnimal(animal);
            greatHornbill = AnimalFactory.GetAnimal("greatHornbill");
            listOfAnimals.Add(greatHornbill);

            ListAnimal(greatHornbill);

            komodo = AnimalFactory.GetAnimal("komodo");
            listOfAnimals.Add(komodo);
            ListAnimal(komodo);

            lemur = AnimalFactory.GetAnimal("lemur");
            listOfAnimals.Add(lemur);
            ListAnimal(lemur);

            grizzly = AnimalFactory.GetAnimal("grizzly");
            listOfAnimals.Add(grizzly);
            ListAnimal(grizzly);

            int numberOfAnimals = animal.Quantity() + grizzly.Quantity() + lemur.Quantity() + komodo.Quantity() + greatHornbill.Quantity();
            Console.WriteLine();
            Console.WriteLine("Current number of animals in zoo:{0}  ", numberOfAnimals);

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
            string p = "clean bear cage";
            larry.ProcessRequest(p);

            p = "medical examine komodo dragon Julie, ";
            ivan.ProcessRequest(p);
            p = "feed animals";
            maria.ProcessRequest(p);
            p = "ring people in , take their money and give them change and a ticket";
            dimitrii.ProcessRequest(p);
            p = "give answers to customer questions";
            dimitrii.ProcessRequest(p);

            Console.WriteLine();
            // Console.WriteLine("Calculating profit per week: Please enter earned money from tickets for the week: ");
            double ticketForAdult = 16.00;
            double ticketForChild = 7.50;
            Console.WriteLine(" Please enter number of sold tickets for adults for the week: ");
            Console.WriteLine(" Please enter number of  sold tickets for children for the week: ");

            string numOfTicketsForAd = "";
            string numOfTicketsForCh = "";

            while (numOfTicketsForAd != null && numOfTicketsForCh!= null)
            {
                numOfTicketsForAd = Console.ReadLine();
                numOfTicketsForCh = Console.ReadLine();
                bool moneyIsDigit = double.TryParse(numOfTicketsForAd, out _ );
                bool money2isDigit = double.TryParse(numOfTicketsForCh, out _);

                if (numOfTicketsForAd != null && numOfTicketsForCh != null && moneyIsDigit == true && money2isDigit == true && Double.Parse(numOfTicketsForAd) > 0 && Double.Parse(numOfTicketsForCh) > 0)
                    {
                    double money1 = double.Parse(numOfTicketsForAd) * ticketForAdult;
                    double money2 = double.Parse(numOfTicketsForCh) * ticketForChild;
                    Console.WriteLine("{0} $ earned from tickets for adults and {1} $ earned from tickets for children",money1,money2);

                    CalculateProfit(money1, money2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter positive sum of income!");
                    continue;
                    }                
            }
            
            //ConcreteDecorator d1 = new ConcreteDecorator();
            /*  foreach (object obj in listOfAnimals)
              {
                  Console.WriteLine(obj);
              }*/
        }
    }
}
