using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Chuong4
{
    class Test
    {
        // du lieu 
        public string name;
        public int age;
        public string email;


        //constructor 
        public Test()
        {
            Console.WriteLine("hello");
        }
        public Test(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
    }
}
