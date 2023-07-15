using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_Inheritance
{
    class Person
    {
        public string Name = "";
        public string Pekerjaan = "";
        public int Age = 0;

        public void InfoPerson(string Person)
        {
            Console.WriteLine("Nama saya  " + Name);
            Console.WriteLine("Saya berumur " + Age);
            Console.WriteLine("Saya bekerja sebagai " + Pekerjaan);
            Console.WriteLine("");
        }

        public class infoPerson2 : Person
        {
            public void InfoPerson2(string Person2)
            {
                Console.WriteLine("Nama saya " + Name);
                Console.WriteLine("Saya berumur " + Age);
                Console.WriteLine("Saya bekerja sebagai " + Person2);
                Console.WriteLine("");
            }
        }
    }
}
