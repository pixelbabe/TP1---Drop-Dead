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

            Dice d1 = new Dice(6);

            for (int i = 0; i <= 15; i++)
                Console.WriteLine(d1.Roll_dice());
            

            Console.WriteLine(p1.Name + " " + p1.Id);
            Console.WriteLine(p2.Name + " " + p2.Id);

            for(int i = 0; i < 10; i++)
                Console.WriteLine(IdManager.GetNextID());

            
        }
    }
}
