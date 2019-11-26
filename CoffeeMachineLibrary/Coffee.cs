using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineLibrary
{
    class Coffee:Milk
    {

     public Coffee()
        {
            ingredientDictionary.Add("coffeePowder",3);
        }
    }
}
