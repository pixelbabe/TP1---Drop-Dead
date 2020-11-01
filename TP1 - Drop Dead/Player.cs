using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Drop_Dead
{
    class Player
    {
        private string name;
        private int id;
        private int[][] thrown_score;
        private int total_score;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int[][] Throw_score
        {
            get { return thrown_score; }
            set { thrown_score = value; }
        }

        public int Total_score
        {
            get { return total_score; }
            set { total_score = value; }
        }


        public Player(string playerName)
        {
            this.id = IdManager.GetNextID();
            this.name = playerName;

        }

    }
}
