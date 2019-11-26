using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachineLibrary
{
    public class CoffeeMachine
    {
        List<Ingredient> IngredientList = new List<Ingredient>();

        public void StartCoffeeMachine()
        {
            int choice;
            Ingredient milk = new Ingredient();
            milk.IngredientName = "milk";
            milk.IngredientQuantity = 2000;
            milk.Limit = 2000;
            milk.Metrics = "ml";

            Ingredient teaPowder = new Ingredient();
            teaPowder.IngredientName = "teaPowder";
            teaPowder.IngredientQuantity = 10;
            teaPowder.Limit = 10;
            teaPowder.Metrics = "gm";

            Ingredient coffeePowder = new Ingredient();
            coffeePowder.IngredientName = "coffeePowder";
            coffeePowder.IngredientQuantity = 10;
            coffeePowder.Limit = 10;
            coffeePowder.Metrics = "gm";


            IngredientList.Add(milk);
            IngredientList.Add(teaPowder);
            IngredientList.Add(coffeePowder);

            while (true)
            {
                Console.WriteLine("Hey..what you wanna have : \n " +
                                  "1.Milk \n 2.Tea \n 3.Coffee");
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {

                    case 1:
                        Milk hotMilk = new Milk();
                        MakeDrink(hotMilk);
                        break;
                    case 2:
                        Drink tea = new Tea();
                        MakeDrink(tea);
                        break;
                    case 3:
                        Drink coffee = new Coffee();
                        MakeDrink(coffee);
                        break;
                    default:
                        Console.WriteLine("Sry invalid option !");
                        break;

                }
            }
        }



        private void Refill(int i)
        {
            string choice;
            Console.WriteLine("Sry..Do you want to refill (yes/no) !!?");
            choice = Console.ReadLine();
            if (choice == "yes")
            {
                string password;
                Console.WriteLine("Enter the password");
                password = Console.ReadLine();
                if (password == "pass123")
                {
                    Console.WriteLine("How many {0} you want to refill and limit={1} ", IngredientList[i].Metrics, IngredientList[i].Limit);
                    IngredientList[i].IngredientQuantity += Convert.ToInt32(Console.ReadLine());


                }
                else
                {
                    Console.WriteLine("Sorry password is wrong");
                }

            }

        }


        private void MakeDrink(Drink drink)       
        {

            int count = drink.ingredientDictionary.Count;
            foreach (string ingredientName in drink.ingredientDictionary.Keys)
            {
                int requiredQuantity = drink.ingredientDictionary[ingredientName];
                for (int i = 0; i < IngredientList.Count; i++)
                {
                    if (IngredientList[i].IngredientName == ingredientName)
                    {


                        if (IngredientList[i].IngredientQuantity >= requiredQuantity)
                        {

                            IngredientList[i].IngredientQuantity -= requiredQuantity;
                            count--;
                           

                        }

                        else
                        {
                            Refill(i);

                        }

                    }
                }

            }
            if(count==0)
            {
                Console.WriteLine("Great...enjoy your drink !!");
            }
        }


    }


}

