using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nea_Technical_Solution
{
    public class Node
    {
        public string name;
        public int DistanceFromStart;
        public List<Arc> ArcsConnectedTo = new List<Arc>();
        public Node PreviousNode;
        public Node ParentNode;
        public List<Node> ConnectedNodes = new List<Node>();
        public Arc PreviousArc;
        public bool visited;
        public int XCoOrdinate, YCoOrdinate;
        



        public Node(string inName)
        {
            name = inName;
            visited = false;
        }
        public void AddArcToList(Arc inArc)
        {
            ArcsConnectedTo.Add(inArc);
        }
        public void SortArcsByWeight()
        {
            List<int> weightOfArcs = new List<int>();
            foreach (Arc arc in ArcsConnectedTo)
            {
                weightOfArcs.Add(arc.Weight);
            }
            weightOfArcs.Sort();
            List<Arc> sortedArcs = new List<Arc>();
            foreach (int arcWeight in weightOfArcs)
            {
                foreach (Arc arc in ArcsConnectedTo)
                {
                    if (arcWeight == arc.Weight)
                    {
                        sortedArcs.Add(arc);
                    }
                }
            }
            ArcsConnectedTo = new List<Arc>(sortedArcs);
        }


    }

}
