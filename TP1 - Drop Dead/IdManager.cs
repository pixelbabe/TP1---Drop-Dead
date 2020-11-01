using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Drop_Dead
{
    public sealed class IdManager
    {
        private static IdManager instance = null;
        private static int currentID = 0;

        private IdManager()
        {
        }

        public static int GetNextID()
        {
            if (instance == null)
            {
                instance = new IdManager();
            }

            return IdManager.currentID++;
        }

    }
}
