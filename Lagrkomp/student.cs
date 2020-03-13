using System;
using System.Collections.Generic;
using System.Text;

namespace Lagrkomp
{
    class student
    {
        //поля
        private string name, F;
        private double subject1, subject2;
        private int z;
        //конструктор
        public student (string name, string F, double subject1, double subject2, int z)
        {
            this.name = name;
            this.F = F;
            this.subject1 = subject1;
            this.subject2 = subject2;
            this.z = z;
        }
        //--------------Методы старт-------------------
        public string getname()
        {
            return name;
        }

        public string getF()
        {
            return F;
        }

        public double getsubject1()
        {
            return subject1;
        }

        public double getsubject2()
        {
            return subject2;
        }

        public int getz()
        {
            return z;
        } 
        //--------------Методы end-------------------
    }
}
