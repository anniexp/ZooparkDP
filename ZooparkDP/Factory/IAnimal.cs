using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooparkDP
{
    public interface IAnimal
    {
            string AnimalKind();
            string TypeOfAnimalByWhatTheyEat();

            string Region();

            string TypeOfAnimal();

            string Description();

            int Quantity();

        double AnimalCareExpensesPerAnimalInDolars();
     
    }
}
