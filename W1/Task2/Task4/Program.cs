using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student//классты ашамыз 
    {
        public string name;//публичный строка етеміз,классты жапқаннан кейінде оны қолдану үшін
        public string id;
        public int year = 1;

        public void incc()//метод,енгізген жылға бір қосып қояды
        {
            year++;
        }

        public Student(string nam, string idd)//конструктор,егер атын,айдиын енгізссек осы конструторға келеді
        {
            name = nam;
            id = idd;
            incc();//методыты шақырады
            print();

        }
        public Student()//конструктор егер дым жазылмаса,онда атын,айдиын өзіміз жазамыз 
        {
            name = Console.ReadLine();
            id = Console.ReadLine();
            year = int.Parse(Console.ReadLine());//Parse жазған симболды санға айналдырады
            year++;
            print();

        }
        public void print()//метод: атын айдиын атын шығарады
        {
            Console.WriteLine("Student's name: " + name);
            Console.WriteLine("Student's id: " + id);
            Console.WriteLine("Year of Study: " + year);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Ali = new Student("Ali", "18BD111222");//егер атын және айдиын жазсақ
            Student Maks = new Student();//егер дым жазбасақ онда конструкторға барады,сол жерде өзіміз жазамыз
        }
    }
}
