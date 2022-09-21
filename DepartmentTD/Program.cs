using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentTD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department[] depart =
            {
                new Department{Id=1,Name="Art",Location="Akole"},
                new Department{Id=2,Name="Commerce",Location="Jalgav"},
                new Department{Id=3,Name="Science",Location="Parbhani"},
                new Department{Id=4,Name="IT",Location="Satara"},
                new Department{Id=5,Name="ITI",Location="Loni"}

            };
            foreach (Department d in depart)
            {
                Console.WriteLine(d);
            }
        }

    }
}
