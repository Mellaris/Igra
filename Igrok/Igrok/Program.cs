using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Igrok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game_Character play = new Game_Character();
            play.Info();
            Console.Clear();
            //Player[] pla = new Player[3];
            //pla[0] = new Player("Ваня", 15, 15, "Враг", 10);
            //pla[1] = new Player("Петя", 21, 21, "Враг", 10);
            //pla[2] = new Player("Саша", 5, 15, "Враг", 10);
            play.Perem();
            
        }
    }
    //internal class Player
    //{
    //    public string name_2;
    //    public int a;
    //    public int b;
    //    public string dr_2;
    //    public int kol_2;
    //    public Player(string name_2, int a, int b, string dr_2, int kol_2)
    //    {
    //        this.name_2 = name_2;
    //        this.a = a;
    //        this.b = b;
    //        this.dr_2 = dr_2;
    //        this.kol_2 = kol_2;
    //    }
    //}
}
