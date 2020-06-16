using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    

        /// <summary>

        /// MainApp startup class for Real-World 

        /// Builder Design Pattern.

        /// </summary>

        public class MainApp

    {

        /// <summary>

        /// Entry point into console application.

        /// </summary>

        public static void Main()

        {

            AnimalBuilder builder;



            // Create shop with vehicle builders

            Zoopark zoo = new Zoopark();



            // Construct and display animals

            builder = new ReptilesBuilder();

            zoo.Construct(builder);

            builder.Animal.Show();



            builder = new BirdBuilder();

            zoo.Construct(builder);

            builder.Animal.Show();



            builder = new MammalBuilder();

            zoo.Construct(builder);

            builder.Animal.Show();



            // Wait for user

            Console.ReadKey();

        }

    }


    /*  interface IAnimal
      {
          public void SetTypeOfAnimalByWhatTheyEat(string setTypeOfAnimalByWhatTheyEat);

          public void Region(String region);

          public void TypeOfAnimal(String typeOfAnimal);

          public void Description(string desc);

          public void Quantity(string quantity);
      }*/
    /// <summary>

    /// The 'Director' class

    /// </summary>

    class Zoopark

    {

        // Builder uses a complex series of steps

        public void Construct(AnimalBuilder animalBuilder)

        {

            animalBuilder.TypeOfAnimalByWhatTheyEat();

            animalBuilder.Region();

            animalBuilder.TypeOfAnimal();

            animalBuilder.Description();

            animalBuilder.Quantity();

        }

    }



    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>

    abstract class AnimalBuilder

    {

        protected Animal animal;
        protected Animal animal2;



        // Gets animal instance

        public Animal Animal
        {

            get { return animal; }

        }



        // Abstract build methods

        public abstract void TypeOfAnimalByWhatTheyEat();

        public abstract void Region();

        public abstract void TypeOfAnimal();

        public abstract void Description();

        public abstract void Quantity();
    }



    /// <summary>

    /// The 'ConcreteBuilder1' class

    /// </summary>

    class MammalBuilder : AnimalBuilder

    {
        // private Animal animal2;

        public MammalBuilder()

        {

            animal = new Animal("Sloth");
            animal2 = new Animal("Hippo");

        }



        public override void TypeOfAnimalByWhatTheyEat()

        {

            animal["type"] = "Herbivore";
            animal2["type"] = "Herbivore";

        }



        public override void Region()

        {

            animal["regionOfLiving"] = "South and North America";
            animal2["regionOfLiving"] = "Africa";
        }



        public override void TypeOfAnimal()

        {

            animal["typeOfAnimal"] = "mammal";
            animal2["typeOfAnimal"] = "mammal";


        }



        public override void Description()

        {

            animal["desc"] = " tree-dwelling mammal noted for its slowness of movement. ";
            animal2["desc"] = "0";


        }
        public override void Quantity()

        {

            animal["quantity"] = "4";

        }

    }





    /// <summary>

    /// The 'ConcreteBuilder2' class

    /// </summary>

    class BirdBuilder : AnimalBuilder

    {

        public BirdBuilder()

        {

            animal = new Animal("Great hornbill");


        }



        public override void TypeOfAnimalByWhatTheyEat()

        {

            animal["type"] = "Herbivore";

        }



        public override void Region()

        {

            animal["regionOfLiving"] = "Asia";

        }



        public override void TypeOfAnimal()

        {

            animal["typeOfAnimal"] = "bird";

        }



        public override void Description()

        {

            animal["desc"] = " Its impressive size and colour have made it important in many tribal " +
            "cultures and rituals. The great hornbill is long-lived, living for nearly 50 years in captivity";

        }
        public override void Quantity()

        {

            animal["quantity"] = "6";

        }
    }



    /// <summary>

    /// The 'ConcreteBuilder3' class

    /// </summary>

    class ReptilesBuilder : AnimalBuilder

    {

        public ReptilesBuilder()

        {

            animal = new Animal("Komodo Dragon");

        }



        public override void TypeOfAnimalByWhatTheyEat()

        {

            animal["type"] = "Carnivore";

        }



        public override void Region()

        {

            animal["regionOfLiving"] = "Indonesia";

        }



        public override void TypeOfAnimal()

        {

            animal["typeOfAnimal"] = "reptile";

        }



        public override void Description()

        {

            animal["desc"] = "The Komodo dragon (Varanus komodoensis), " +
            "also known as the Komodo monitor, is a species of lizard found in the Indonesian islands" +
            " of Komodo, Rinca, Flores, and Gili Motang. A member of the monitor lizard family Varanidae," +
            " it is the largest extant species of lizard, growing to a maximum length of 3 metres (10 ft)" +
            " in rare cases and weighing up to approximately 70 kilograms (150 lb).";

        }
        public override void Quantity()

        {

            animal["quantity"] = "2";

        }


    }



    /// <summary>

    /// The 'Product' class

    /// </summary>

    class Animal

    {

        private readonly string _animalKind;

        private Dictionary<string, string> _parts =

          new Dictionary<string, string>();



        // Constructor

        public Animal(string animalType)

        {

            this._animalKind = animalType;

        }



        // Indexer

        public string this[string key]

        {

            get { return _parts[key]; }

            set { _parts[key] = value; }

        }



        public void Show()

        {

            Console.WriteLine("\n---------------------------");

            Console.WriteLine("Animal kind: {0}", _animalKind);

            Console.WriteLine(" Type : {0}", _parts["type"]);

            Console.WriteLine(" Region : {0}", _parts["regionOfLiving"]);

            Console.WriteLine(" Type: {0}", _parts["typeOfAnimal"]);

            Console.WriteLine(" Description : {0}", _parts["desc"]);

            Console.WriteLine(" Quantity : {0}", _parts["quantity"]);

        }

    }

}
