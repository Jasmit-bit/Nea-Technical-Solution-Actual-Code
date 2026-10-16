using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nea_Technical_Solution
{
    public class Arc
    {
        public string name;
        public int Weight;

        public List<Node> nodesConnected;

        public Arc(string inName, int inWeight, Node Node1, Node Node2)
        {
            name = inName;
            Weight = inWeight;
            nodesConnected = new List<Node> { Node1, Node2 };
            AddArcToNodeList();
        }
        public Arc(int inWeight, Node Node1, Node Node2)
        {
            Weight = inWeight;
            nodesConnected = new List<Node> { Node1, Node2 };
            AddArcToNodeList();
        }
        
        private void AddArcToNodeList() // goes through each node and updates its lists so that it know which arc the node is connected to 
        {
            foreach (Node node in nodesConnected)
            {
                node.AddArcToList(this);
            }
        }

        public Node GetNodeOnOtherSide(Node CurNode) // gets the node on the other side of the arc
        {
            Node otherNode = null;
            foreach (Node node in nodesConnected)
            {
                if (node != CurNode)
                {
                    otherNode = node;
                }
            }
            return otherNode;
        }

    }

}
