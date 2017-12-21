using System;
using System.Collections.Generic;

namespace DesignPatterFinalProject
{
    public class Fighter : Occupant
    {
        private bool activity;
        private List<Weapon> weaponlist;
        private int lifePt;
        private int damagePt;
        private List<Position> path;


        public Fighter(int damagePt, bool activity)
        {
            lifePt = 100;
            this.activity = activity;
            this.damagePt = damagePt;
            weaponlist = new List<Weapon>();
            path = new List<Position>();
        }

        public int DamagePt
        {
            get{ return damagePt; }
            set{ damagePt = value; }
        }

        public bool Activity
        {
            get { return activity; }
            set { activity = value; }
        }

        public List<Weapon> Weponlist
        {
            get { return weaponlist; }
            set { weaponlist = value; }
        }

        public int LifePt
        {
            get { return lifePt; }
            set { lifePt = value; }
        }

        public List<Position> Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
