using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

        class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            Student s2 = new Student();
            s1.sname = "Mobeen";
            s2.sname = "Butt";
            Console.WriteLine(s1.sname);
            Console.WriteLine(s2.sname);

            Console.Read();

        }
    }
}
