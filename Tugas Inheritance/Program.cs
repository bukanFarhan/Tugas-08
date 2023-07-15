using System;

namespace Tugas_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namePerson = { "Farhan", "SheilaOn7" };
            string[] karirPerson = { "Programer", "Musisi" };
            int[] AgePerson = { 23, 21 };

            Person PersonData = new Person();
            PersonData.Name = namePerson[0];
            PersonData.Age = AgePerson[0];
            PersonData.InfoPerson(karirPerson[0]);

            PersonData.Name = namePerson[1];
            PersonData.Age = AgePerson[1];
            PersonData.InfoPerson(karirPerson[1]);
        }
    }
}
