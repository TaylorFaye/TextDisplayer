using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDisplayer
{
    class Food
    {
        private string Name;
        private string Color;
        private int timeCooked;
        public static int numberOfFoodGroups = 5;
        public static int NumOfFoodGroups()
        {
            return numberOfFoodGroups;
        }
        public string NameOfFood()
        {
              return this.Name;
        }

        public string ColorOfFood()
        {
            return this.Color;
        }

        private void AddTimeCooked(int seconds)
        {
            this.timeCooked += seconds;
            
        }

        public void Cook(int seconds)
        {
            this.AddTimeCooked(seconds);
        }

        public int GetTimeCooked()
        {
            return this.timeCooked;
        }

        public Food()
        {
            this.timeCooked = 0;
        }

        public Food(string name, string color)
        {
            this.Name = name;
            this.Color = color;
            this.timeCooked = 0;
        }


    }
}
