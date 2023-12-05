using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel
{
    class Faktoriyelbul
    {
        public int FakBul(int sayi)
        {
            int hesap = 1;
            for (int i = 1; i <= sayi; i++)
            {
                hesap = hesap * i;
            }
            return hesap;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Faktoriyelbul s = new Faktoriyelbul();
            Console.WriteLine("Faktoriyel bul = ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sonuç=" + s.FakBul(sayi));
        }
    }
}
