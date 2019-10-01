using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wynalda
{
    public class Inventory
    {
        private static Inventory _main; // c# field
        public static Inventory main // c# property
        {
            get // public getter
            {
                if (_main == null) _main = new Inventory(); //lazy instantiation 
                return _main;
            }
            private set //private setter
            {
                _main = value;
            }
        }

        public static void Reset()
        {
            main.hasSword = false;
            main.hasKeyCrystal = false;
        }


        public bool hasSword = false;
        public bool hasKeyCrystal = false;

        public float totalXP = 500;
        public float nextLevelXP = 750;

        private Inventory() { }



    }
}