using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nea_Technical_Solution
{
    public static class Djikstra // class responsible for keeping track of which arcs were chosen when applying Djikstra's algorithm and their order
    {
        public static List<Arc>orderOfArcs = new List<Arc>();   

        public static void Clear()
        {
            orderOfArcs.Clear();    
        }
    }
}
