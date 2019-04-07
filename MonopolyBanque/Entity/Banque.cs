using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyBanque
{
    public class Banque : Joueur
    {

        private Banque()
        {
            // private constructor
        }

        private static Banque instance = null;

        public static Banque getInstance()
        {
                if (instance == null)
                {
                    instance = new Banque();
                }
                return instance;
        }
    }
}