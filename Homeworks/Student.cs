using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Student
    {
        private string _name;
        private string _surname;
        private int _clas;
        private double _mark;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            private set => _surname = value;
        }

        public int Clas
        {
            get => _clas;
            private set => _clas = value;
        }

        public double Mark
        {
            get => _mark;
            private set => _mark = value;
        }

        public Student(string name, string surname, int clas, double mark)
        {
            Name = name;
            Surname = surname;
            Clas = clas;
            Mark = mark;
        }
    }
}
