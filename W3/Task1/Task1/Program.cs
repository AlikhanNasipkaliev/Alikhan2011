using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_2
{
    enum FSIMode//ақпаратты бөлек жазып алып,аңықтамалық(справочник) ретінде қолдана аламыз
    {
        DirectoryInfo = 1,
        File = 2
    }
    class Lawer
    {
        public DirectoryInfo[] DirCon//папкалар үшін жаңа массив енгіземіз
        {
            get; //осы операция арқылы айнымалыларды оқи аламыз
            set;//осы операция арқылы айнымалыларға мән бере аламыз

        }
        public FileInfo[] FileCon
        {
            get;
            set;

        }
        public int selectedIndex
        {
            get;
            set;
        }
        public void Draw()//ақпаратты көрсету үшін және ақпарттармен операция орындау үшін функция құрамыз
        {
            Console.BackgroundColor = ConsoleColor.Black;//бәрін кетіргенде экранды қара түске боя
            Console.Clear();//Барлық ақпаратты тазартып отырамыз
            for (int i = 0; i < DirCon.Length; i++)
            {
                if (i == selectedIndex)//егерде таңдалған индексті көрсетсек
                {
                    Console.BackgroundColor = ConsoleColor.Red;//сол индексті қызыл түске боя
                }
                else
                    Console.BackgroundColor = ConsoleColor.Black;//басқа папкаларды қара түске бояймыз
                Console.WriteLine(i + 1 + ". " + DirCon[i].Name);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;// файлдарды сары түске бояймыз 
            for (int j = 0; j < FileCon.Length; j++)
            {
                if (j + DirCon.Length == selectedIndex)//егерде таңдалған индексті көрсетсек
                {
                    Console.BackgroundColor = ConsoleColor.Red;//таңдалған файлды қызыл түске бояймыз
                }
                else
                    Console.BackgroundColor = ConsoleColor.Black;//қалғандарын қара түске бояймыз
                Console.WriteLine(j + 1 + DirCon.Length + ". " + FileCon[j].Name);
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo Dir = new DirectoryInfo(@"C:\Users\Admin\Desktop\Alikhan");
            Lawer l = new Lawer// папкаларды,файлдарды,индексті көрсететін класс құрамыз
            {
                DirCon = Dir.GetDirectories(),//DirCon массиві үшін  Dir директорясында папканың адресін көрсетеміз
                FileCon = Dir.GetFiles(),
                selectedIndex = 0
            };
            l.Draw();
            FSIMode Mod = FSIMode.DirectoryInfo;//папкалар үшін жаңа FSI(enum) құрамыз
            Stack<Lawer> contral = new Stack<Lawer>();//жаңа стэк құрамыз
            contral.Push(l);// стэкке class(l) ді енгіземіз
            bool work = false;
            while (!work)
            {
                if (Mod == FSIMode.DirectoryInfo)//егер FSI(enum) папка болса   
                {
                    contral.Peek().Draw();//стэкка Draw функциясын көрсетеміз
                }
                ConsoleKeyInfo key = Console.ReadKey();// басылған консолдың клавиштерін сипаттайды
                switch (key.Key)//
                {  
                    case ConsoleKey.Escape://егер Escape-ты бассақ
                        work = true;//онда консол жұмысын тоқтатады
                        break;
                

                }

            }
        }
    }
}.