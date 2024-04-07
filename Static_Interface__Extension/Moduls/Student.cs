using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Interface__Extension.Moduls
{
    internal class Student
    {
        private static int Count = 0;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Id = ++Count;
            Name = char.ToUpper(name[0]) + name.Substring(1);
            Surname = char.ToUpper(surname[0]) + surname.Substring(1);
        }
        public string GetInfo()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}";
        }
    }
}
