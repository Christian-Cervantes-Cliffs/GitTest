using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest.Class
{
    internal class Class1
    {
        public string ID { get; set; }
        public int Age { get; set; }
        public string  Phone { get; set; }

        public Class1(string id, int age, string phone)
        {
            this.ID = id;
            this.Age = age;
            this.Phone = phone;
            
        }

        public void DoSomething()
        {
            Console.WriteLine(this.ID);
        }
        public void DoSomething(List<Class1> cList)
        {
            foreach(Class1 c in cList)
            {
                Console.WriteLine(c.Phone);
            }
        }
    }
}
