using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineLibrary
{
    class Tea:Milk
    {
        public Tea()
        {
            ingredientDictionary.Add("teaPowder", 2);
        }
    }
}
