using System;

namespace Lagrkomp
{
    class Program
    {

        /// <summary> 
        /// Точка входа в программу 
        /// </summary>
        /// /// <param name="argument">
        /// Параметры командной строки
        /// </param>
        public static void Main(string[] argument)
        {
            string Signal;
            int numbstud;
            int z;//кол-во знаков после запятой 

            /// <summary> 
            /// Точка входа в цикл, который точно выполнится один раз 
            /// после чего пользователь сможет или продолжить, или завершить программу 
            /// </summary>

            do
            {//прошу ввести значения 
                Console.WriteLine("Введите кол-во студентов: ");
                numbstud = int.Parse(Console.ReadLine());
                studentList Vedomost = new studentList(numbstud);
                string name, F;
                double subject1, subject2;
                student stdt;
                Console.WriteLine("Введите кол-во знаков после запятой: ");
                z = int.Parse(Console.ReadLine());
                for (int i = 0; i < numbstud; i++)
                {
                    Console.WriteLine("Введите имя студента: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Введите фамилию студента: ");
                    F = Console.ReadLine();
                    Console.WriteLine("Введите оценку по первой дисциплине: ");
                    //проверяю на коректность
                    subject1 = checkznach();
                    Console.WriteLine("Введите оценку по второй дисциплине: ");
                    //проверяю на коректность
                    subject2 = checkznach();
                    stdt = new student(name, F, subject1, subject2, z);
                    Vedomost.addstudent(stdt, i);
                }
                //ВЫЗЫВАЮ СВОЙ метод для вывода в консоль табицы
                Vedomost.coutconsol();

                //_____________________________Меню__________________________________

                Console.WriteLine("Для завершения программы введите STOP, для продолжения ON, ну, а если хотите сразу поставить максимум нажмите 100 : ");
                Signal = Console.ReadLine();
                if (Signal == "100")
                {
                    Console.WriteLine("Спасибо, хороший выбор");
                    break;
                }
            } while (Signal != "STOP");

        }

        /// <summary>
        /// метод для проверки вводимых значений
        /// </summary>
        /// <returns>значение, которое входит в установленые рамки</returns>

        public static double checkznach()
        {
            double assessment = double.Parse(Console.ReadLine());
            while (assessment > 12 || assessment <= 0)
            {

                if (assessment > 12 || assessment <= 0)
                {
                    Console.WriteLine("ERROR: В этой шкле действует двенадцатибальная система оценивания (дпусимые значения 0<=x<=12). ВВедите другое значение: ");
                    assessment = double.Parse(Console.ReadLine());
                }
            }
            return assessment;
        }

    }
}
