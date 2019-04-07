using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyBanque
{
    public class Joueur
    {
        private int Cash;

        public int GetCash() => Cash;
        public void SetCash(int cash) => Cash = cash;
        public void AddCash(int cash) => Cash += cash;
    }
}