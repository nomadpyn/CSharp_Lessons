using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    public class Human
    {
        public string Name { get; set; }
        public string Fname { get;set; }
        public int Age { get; set; }
        public Human(string f, string n,int a)
        {
            this.Name = n;
            this.Fname = f;
            this.Age = a;
        }
        public override string ToString()
        {
            return $"{this.Fname} {this.Name}. Возраст {this.Age}";
        }
    }
}
