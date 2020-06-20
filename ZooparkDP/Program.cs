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
        //initialising instances of the interface
        static IAnimal animal;
        static IAnimal grizzly;
        static IAnimal lemur;
        static IAnimal komodo;
        static IAnimal greatHornbill;

        /// <summary>
        /// getting the correcsponding properties for each instance of the interface from the fabric
        /// </summary>
        public static void CreateAnimals()
        {
            Console.WriteLine("List of animals in zoopark: ");

            animal = AnimalFactory.GetAnimal("sloth");
            ListAnimal(animal);

            greatHornbill = AnimalFactory.GetAnimal("greatHornbill");
            ListAnimal(greatHornbill);

            komodo = AnimalFactory.GetAnimal("komodo");
            ListAnimal(komodo);

            lemur = AnimalFactory.GetAnimal("lemur");
            ListAnimal(lemur);

            grizzly = AnimalFactory.GetAnimal("grizzly");
            ListAnimal(grizzly);
        }

        /// <summary>
        /// Printing in console each implementation of the IAnimal
        /// </summary>
        /// <param name="animal"></param>
        public static void ListAnimal(IAnimal animal)
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Animal kind: {0}", animal.AnimalKind());

            Console.WriteLine(" Type of animal by biology : {0}", animal.TypeOfAnimal());

            Console.WriteLine(" Region : {0}", animal.Region());

            Console.WriteLine(" Type of animal by what they eat: {0}", animal.TypeOfAnimalByWhatTheyEat());

            Console.WriteLine(" Description : {0}", animal.Description());

            Console.WriteLine(" Quantity : {0}", animal.Quantity());

            // asiigning type of cage (big/small) depending of type of animal(mammal, bird or reptile)
            if (animal.TypeOfAnimal() == "bird")
            {
                //Abstraction obj = new RefinedAbstraction();
                Bridge.Type type = new SmallCage();
                // Set implementation and call
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
                // Change implemention and call
                Bridge.Type type = new BigCage();
                type._ICage = new Mammal();
                type.MakeType();


            }

        }

        /// <summary>
        /// Setup Chain of Responsibility
        /// </summary>
        public static void TasksAssigning()
        {
            //creating workers
            Worker larry = new Cleaner();
            Worker maria = new Caretaker();
            Worker ivan = new Medic();
            Worker dimitrii = new Manager();
            Worker katya = new Cashier();
            //assigning chain of responsibility
            dimitrii.SetSuccessor(ivan);
            ivan.SetSuccessor(larry);
            larry.SetSuccessor(katya);
            katya.SetSuccessor(maria);
            Console.WriteLine("List of current tasks to do: ");
            Console.WriteLine();

            //Generate and process requests
            string p = "clean bear cage";
            dimitrii.ProcessRequest(p);
            p = "medical examine komodo dragon Julie, ";
            dimitrii.ProcessRequest(p);
            p = "feed animals";
            dimitrii.ProcessRequest(p);
            p = "ring people in , take their money and give them change and a ticket";
            dimitrii.ProcessRequest(p);
            p = "give answers to customer questions";
            dimitrii.ProcessRequest(p);

            Console.WriteLine();
        }

        /// <summary>
        /// Input sold tickets for the week, checks if format is valid and if its valid, proceed to calculating profit of the zoo
        /// </summary>
        public static void InputNumOfSoldTickets(double ticketForAdult, double ticketForChild)
        {

            Console.WriteLine(" Please enter number of sold tickets for adults for the week: ");
            Console.WriteLine(" Please enter number of  sold tickets for children for the week: ");
            //checking id input is in the correct format
            string numOfTicketsForAd = "";
            string numOfTicketsForCh = "";

            // cycle the loop untill input is in correct format, then callculate profit
            while (numOfTicketsForAd != null && numOfTicketsForCh != null)
            {
                numOfTicketsForAd = Console.ReadLine();
                numOfTicketsForCh = Console.ReadLine();
                //Converts the string representation of a number to its 32-bit signed integer equivalent.
                //A return value indicates whether the operation succeeded.
                bool moneyIsDigit = double.TryParse(numOfTicketsForAd, out _);
                bool money2isDigit = double.TryParse(numOfTicketsForCh, out _);
                //validations
                if (numOfTicketsForAd != null && numOfTicketsForCh != null && moneyIsDigit == true && money2isDigit == true && Double.Parse(numOfTicketsForAd) > 0 && Double.Parse(numOfTicketsForCh) > 0)
                {
                    //income from each type of tickets
                    double money1 = double.Parse(numOfTicketsForAd) * ticketForAdult;
                    double money2 = double.Parse(numOfTicketsForCh) * ticketForChild;
                    Console.WriteLine("{0} $ earned from tickets for adults and {1} $ earned from tickets for children", money1, money2);

                    CalculateProfit(money1, money2);
                    break;
                }
                else
                {
                    Console.WriteLine("Enter number of sold tickets for the week by each type!");
                    continue;
                }
            }

        }

        /// <summary>
        ///helping method for calculating pure profit of the facility for the week by getting earned money
        /// </summary>
        /// <param name="money1">$ earned from tickets for adults/param>
        /// <param name="money2">$ earned from tickets for children</param>
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
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Profit per week: {0} $", profit);
            Console.WriteLine("\n---------------------------");
        }

      
        static void Main(string[] args)
        {
            //generate animals in zoopark
            CreateAnimals();
            //calculating how many animals are in the zoopark
            int numberOfAnimals = animal.Quantity() + grizzly.Quantity() + lemur.Quantity() + komodo.Quantity() + greatHornbill.Quantity();
            
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Current number of animals in zoo:{0}  ", numberOfAnimals);
            Console.WriteLine("\n---------------------------");
            // Setup Chain of Responsibility                   
            TasksAssigning();

            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Calculating profit per week: ");
            //setting prices for entrance tickets
            double ticketForAdult = 16.00;
            double ticketForChild = 7.50;
            //Calculate profit of the zoo for the week
            InputNumOfSoldTickets(ticketForAdult, ticketForChild);
            
        }
    }
}
