using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa
{
    internal class FootballPlayer : Person
    {
        private int number;
        private double height;

        public FootballPlayer(string name, int number, int age, double height) : base(name, age)
        {
            this.Number = number;
            this.Height = height;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
