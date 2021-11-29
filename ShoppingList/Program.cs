using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myShoppingList = new List<string>();

            Console.WriteLine(myShoppingList.Count);

            myShoppingList.Add("milk");
            myShoppingList.Add("potato");
            myShoppingList.Add("apple");
            myShoppingList.Add("coffee");

            Console.WriteLine(myShoppingList.Count);

            Console.WriteLine(myShoppingList[0]);
            Console.WriteLine(myShoppingList[1]);
            Console.WriteLine(myShoppingList[2]);

            Console.WriteLine(myShoppingList.Count);

            foreach (string wish in myShoppingList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
