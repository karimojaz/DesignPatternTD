using System;
namespace DesignPatterFinalProject
{
    public class Weapon : Occupant
    {
        private int damage;

        public Weapon()
        {
            Random random = new Random();
            this.damage = random.Next(1, 10);
        }

        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }

    }
}
