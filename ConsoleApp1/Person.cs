using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int ålder;

        
        public string Myperson
        {
            get { return name; }
            set { name = value; }
        }

        public int Myperson1
        {
            get { return ålder; }
            set { ålder = value; }
        }

        public Person(string n, int å)
        {

            name = n;
            ålder = å;
        }


    }
}
