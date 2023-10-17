using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igrok
{
    internal class Game_Character
    {
        private string name;
        private int x;
        private int y;
        private bool l;
        private bool l_2;
        private string dr;
        private int kol;
        private string name_2;
        private int a;
        private int b;
        private string dr_2;
        private int kol_2;
        private int ur;
        private int lech;
        private int koll;
        private int i = 0;
        public void Info()
        {
            Console.Write("Укажите название персонажа: ");
            name = Console.ReadLine();
            Console.Write("Укажите координаты расположения вашего персонажа: x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите к какому лагерю хотите принадлежать: (Друг или Враг) ");
            dr = Console.ReadLine();
            if (dr == "Друг")
            {
                l = true;
            }
            else if (dr == "Враг")
            {
                l = false;
            }
            Console.WriteLine("Укажите количество ваших жизней: ");
            kol = Convert.ToInt32(Console.ReadLine());
            koll = kol;
        }
        public void Info_2()
        {
            name_2 = "Саша";
            Random rdn = new Random();
            a = rdn.Next(1, 25);
            b = rdn.Next(1, 25);
            dr_2 = "Враг";
            if (dr_2 == "Друг")
            {
                l_2 = true;
            }
            else if (dr_2 == "Враг")
            {
                l_2 = false;
            }
            kol_2 = 10;
        }

        public void Print()
        {
            Console.WriteLine($"Название персонажа: {name}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"Ваш лагерь: {dr}");
            Console.WriteLine($"Количество жизней: {kol}");
        }
        public void Perem()
        {


            Info_2();
            Console.CursorVisible = false; // курсор
            ConsoleKeyInfo k;
            do
            {
                Console.SetCursorPosition(a, b);
                Console.Write("1");
                Console.SetCursorPosition(x, y);
                Console.Write((char)1);
                k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.UpArrow)
                    y--;
                else if (k.Key == ConsoleKey.DownArrow)
                    y++;
                else if (k.Key == ConsoleKey.LeftArrow)
                    x--;
                else if (k.Key == ConsoleKey.RightArrow)
                    x++;

                Console.Clear();
                if (x == a && y == b)
                {
                    Console.WriteLine("Начинается бой!");
                    vibor();
                }
            } while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc
        }

        public void vibor()
        {

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1. Нанести урон; 2. Лечение; 3. Полное восстановление; ");
            int v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                if (l == true && l_2 == false)
                {
                    uron();
                }
                else
                {
                    Console.WriteLine("Вы хотите сменить лагерь? Напишите да или нет");
                    string vi = Console.ReadLine();
                    if (vi == "Да")
                    {
                        lager();
                    }
                    else
                    {
                        Console.WriteLine("Бой невозможен");
                    }
                    
                }
            }
            if (v == 2)
            {
                doc();
            }
            if (v == 3)
            {
                if (i == 0)
                {
                    vost();
                    i++;
                }
                if (i > 0)
                {
                    Console.WriteLine("Вы больше не можете полностью восстановить здоровье");
                    vibor_2();
                }
            }
            if (v == 4)
            {
                lager();
            }

        }
        public void vibor_2()
        {
            Console.ReadKey();
            vibor();
        }
        public void uron()
        {
            Random rd = new Random();
            ur = rd.Next(1, 4);
            Console.WriteLine($"Вы нанесли: {ur} урона вашему врагу");
            kol_2 = kol_2 - ur;
            Console.WriteLine($"У него осталось: {kol_2} здоровья");
            Console.ReadKey();
            ur = rd.Next(1, 4);
            Console.WriteLine($"Вам нанесли: {ur} урона");
            kol = kol - ur;
            Console.WriteLine($"У вас осталось: {kol} здоровья");
            if (kol > 0 && kol_2 > 0)
            {
                vibor_2();
            }
            else del();
        }
        public void doc()
        {
            Random rd = new Random();
            lech = rd.Next(1, 3);
            Console.WriteLine($"Вы получили лечение: {lech}");
            kol = kol + lech;
            Console.WriteLine($"У вас осталось: {kol} здоровья");
            Console.ReadKey();
            //ur = rd.Next(1, 4);
            //Console.WriteLine($"Вам нанесли: {ur} урона");
            //kol = kol - ur;
            //Console.WriteLine($"У вас осталось: {kol} здоровья");
            vibor_2();
        }
        public void vost()
        {
            int vosst = koll - kol;
            kol = kol + vosst;
            Console.WriteLine("Вы полностью восстановили свое здоровье");
            i++;
            vibor_2();
        }
        public void del()
        {
            if ( kol_2 <= 0 ) 
            {
                Console.WriteLine("Вы убили врага!");
            }

            else if ( kol <= 0)
            {
                Console.WriteLine("Вас убили!");
            }
        }
        public bool lager ()
        {
            if (l == true)
            {
                l = false;
                Console.WriteLine("Теперь ваш персонаж - Враг");
            }
            if ( l == false )
            {
                l = true;
                Console.WriteLine("Теперь ваш персонаж - Друг");
            }
            vibor_2() ;
            return l;
        }
    }
}
