using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1___Drop_Dead
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Player p1 = new Player("Chris");
            Player p2 = new Player("Chha");
            Player p3 = new Player ("Mathieu");

            Game g = new Game();

            g.AddPlayer(p1);
            g.AddPlayer(p2);
            g.AddPlayer(p3);
            Console.WriteLine("Players Count: " + g.Players.Count);
            Console.WriteLine("Dice Count: " + g.Dice_set.Count);

            for(int i = 0; i < 1; i++){
                do
                {
                    g.Play();
                } while (!g.GetCurrentRound().Finished);
            }

    }
    }
}
