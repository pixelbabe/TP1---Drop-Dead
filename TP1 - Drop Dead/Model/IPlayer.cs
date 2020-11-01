using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Drop_Dead.Model
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Id { get; set; }
        string ToString();
    }
}
