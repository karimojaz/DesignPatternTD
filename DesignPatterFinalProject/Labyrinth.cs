using System;
using System.Collections.Generic;

namespace DesignPatterFinalProject
{
    public class Labyrinth
    {
        private List<Fighter> fighterList;
        private List<Weapon> weaponList;
        private List<Case> board;

        public Labyrinth()
        {
            fighterList = new List<Fighter>();
            weaponList = new List<Weapon>();
            board = new List<Case>();
        }

        public List<Fighter> FighterList
        {
            get { return fighterList; }
        }

        public List<Weapon> WeaponList
        {
            get { return weaponList; }
        }

        public List<Case> Board
        {
            get { return board; }
        }

        public void labyrinth()
        {
            string[] lines = System.IO.File.ReadAllLines("/Users/karimmouaddel/Projects/DesignPatterFinalProject/DesignPatterFinalProject/bin/Debug/Lab.txt");
            foreach(string l in lines)
            {
                Console.WriteLine(l);
            }
            System.Console.ReadKey();
        }
    }
}
