using System;
using System.Collections.Generic;
using System.Text;

namespace Lagrkomp
{
    class studentList
    {
        //поля
        private student [] lst;
        //конструктор
        public studentList(int n)
        {
            lst = new student[n];
        }

        public void addstudent(student stdt, int ind)//зауважте, що обєкти классу  student створюються за межами классу  studentList
        {
            lst[ind] = stdt;//тобто обєкти классу student можуть існувати і після знишення обєкта  классу studentList
        }

       
        public double Calculatesubject1()
        {
            double sum = 0;
            for (var i = 0; i < lst.Length; i++)
                sum += lst[i].getsubject1();
            return sum;
        }

        public double Calculatesubject2()
        {
            double sum = 0;
            for (var i = 0; i < lst.Length; i++)
                sum += lst[i].getsubject2();
            return sum;
        }
         
        public void coutconsol()
        {

            Console.WriteLine("|{0,30} | {1,30}  |  {2,30} | {3,30} |  {4,30}  |  {5,30}|", "Студент № ", " Имя", "Фамилия", " Оценка по 1 дисцеплине", "Оценка по 2 дисцеплине", "Средняя оценка студента");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|");
            int i = 0;
            foreach (student pl in lst)
            {
                string result = String.Format("{0:f" + pl.getz() + "}",( pl.getsubject1() + pl.getsubject2())/2);

                Console.WriteLine("|{0,30} | {1,30}  |  {2,30} | {3,30} |  {4,30}  |  {5,30}|", i + 1, pl.getname(), pl.getF(), pl.getsubject1(), pl.getsubject2(), result);
                Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|");
                i++;
            }
            Console.WriteLine("|{0,30} | {1,64}  | {2,30} |  {3,30}  |  {4,30}|", " ", "     Средняя успеваемость студентов этой группы:      ", String.Format("{0:f" + lst[0].getz() + "}", Calculatesubject1() / lst.Length), String.Format("{0:f" + lst[0].getz() + "}", Calculatesubject2() / lst.Length), " ");
            Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|");

        }



    }
}