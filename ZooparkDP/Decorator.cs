using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    //'Decorator' abstract class
    abstract class Decorator : IAnimal
    {
        IAnimal animal;
        /*  public Decorator(IAnimal animal)
          {
              this.animal = animal;
          }
       /*   public override void ListAnimal(IAnimal animal)
          {
              animal.ListAnimal(animal);
          }*/

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
        public int CageNumber()
        {
            return 2;
        }
        public int NumOfHungry()
        {
            return 2;
        }

        public double AnimalCareExpensesPerAnimalInDolars()
        {
            throw new NotImplementedException();
        }
    }
    //'ConcreteDecorator' class
   /* class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();
        public Borrowable(IAnimal animal)
        : base()
        { }
        public void IsHungry(string name)
        {
            borrowers.Add(name);
            animal.fedAnimals--;
        }
        public void NotHungry(string name)
        {
            borrowers.Remove(name);
            animal.fedAnimals++;
        }
        */
      /*  public override void ListAnimal(IAnimal animal)
        {
            base.ListAnimal( animal);

            Console.WriteLine("\n---------------------------");

            Console.WriteLine("Animal kind: {0}", animal.AnimalKind());

            Console.WriteLine(" Type : {0}", animal.TypeOfAnimal());

            Console.WriteLine(" Region : {0}", animal.Region());

            Console.WriteLine(" Type: {0}", animal.TypeOfAnimalByWhatTheyEat());

            Console.WriteLine(" Description : {0}", animal.Description());

            Console.WriteLine(" Quantity : {0}", animal.Quantity());
           // Console.WriteLine(" Cage number : {0}", animal.CageNumber());
        }*/
    }

