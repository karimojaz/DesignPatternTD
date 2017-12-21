using System;
namespace DesignPatterFinalProject
{
    public class Case
    {
        private Occupant occupant;
        private int coordX;
        private int coordY;

        public Case(Occupant occupant, int coordX, int coordY)
        {
            this.occupant = occupant;
            this.coordX = coordX;
            this.coordY = coordY;
        }

        public Occupant Occupant
        {
            get { return occupant; }
            set { occupant = value; }
        }

        public int CoordX
        {
            get { return coordX; }
        }

        public int CoordY
        {
            get { return coordY; }
        }
    }
}
