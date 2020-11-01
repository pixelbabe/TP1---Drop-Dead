using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Drop_Dead.Model
{
    class Player : IPlayer, IObservable
    {
        private string name;
        private int id;
        private int game_score;
        private List<IObserver> observers;

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

        public int Game_score
        {
            get { return game_score; }
            set { game_score = value; }
        }

        public Player(string playerName)
        {
            this.id = IdManager.GetNextID();
            this.name = playerName;

        }

        public override string ToString()
        {
            return $"Player: {Name}, Score : {Game_score}";
        }

        public void AttachObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void detachObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void notifyObserver()
        {
            foreach(IObserver o in observers)
                o.Update();
        }
    }
}
