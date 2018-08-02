using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDisplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var cheese = new Food("gouda", "blue");
            
            var notCheese = new Food("steaaakkk", "not blue");

            var fruit = new Food("apple", "red");

            var veggie = new Food("potato", "white");

            notCheese.Cook(40);
            veggie.Cook(25);




            var foodList = new List<Food>();
            foodList.Add(cheese);
            foodList.Add(notCheese);
            foodList.Add(fruit);
            foodList.Add(veggie);

            foreach(var foodItem in foodList)
            {
                Console.WriteLine(foodItem.NameOfFood());
                Console.WriteLine(foodItem.ColorOfFood());
                Console.WriteLine(foodItem.GetTimeCooked());
            }


            Console.ReadLine();
        }
    }
}
