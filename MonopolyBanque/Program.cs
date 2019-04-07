using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyBanque
{
    class Program
    {
        static void Main(string[] args)
        {
            Banque banque1 = Banque.getInstance();
            Banque banque2 = Banque.getInstance();

            banque1.SetCash(100000);
            banque2.SetCash(50000);

            banque1.AddCash(10000);

            Joueur nass = new Joueur();
            nass.SetCash(1000);
            nass.AddCash(500);

            Joueur domi = new Joueur();
            domi.SetCash(1000);
            domi.AddCash(1500);

            Console.WriteLine("La banque dispose de " + banque1.GetCash() /* ou banque2.GetCash() */ + "€");
            Console.WriteLine("Nass dispose de " + nass.GetCash() + "€");
            Console.WriteLine("Domi dispose de " + domi.GetCash() + "€");



        }
    }
}
