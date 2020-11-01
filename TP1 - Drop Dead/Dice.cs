using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Drop_Dead
{
    class Dice
    {
        private static Random r = new Random();

        private int nb_sides;
        private int current;

        public int Nb_sides
        {
            get { return nb_sides; }
            set { nb_sides = value; }
        }

        public int Current
        {
            get { return current; }
            set { current = value; }
        }

        public Dice(int dice_sides)
        {
            this.nb_sides = dice_sides;
        }

        public int Roll_dice()
        {   
            current = Dice.r.Next() % nb_sides+1;
            return current;
        }
        
    }
}
