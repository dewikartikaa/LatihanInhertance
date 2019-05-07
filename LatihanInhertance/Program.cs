using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInhertance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 30, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Sara", 19, "19506", "sara1232@amikom.ac.id");
            student.GetNameAndAge();


            Console.ReadKey();
        }
    }
}
