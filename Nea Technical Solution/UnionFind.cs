using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public class UnionFind
    {
        public UnionFind()
        {
            foreach(Node node in Graph.NodesInGraph)
            {
                node.ParentNode = node;// by doing this each node is its own parent and its own separate subset 
            }
        }
        public void union(Node FirstNode, Node SecondNode) // merges the sets of the two given nodes into one set
        {
            Node FirstNodeRoot = find(FirstNode);
            Node SecondNodeRoot = find(SecondNode);

            if (FirstNodeRoot != SecondNodeRoot)
            {
                FirstNodeRoot.ParentNode = SecondNodeRoot;
            }
        }

        public  Node find(Node node)
        {
            if (node.ParentNode == node)
            {
                return node;
            }
            else
            {
                // making every node in connected point directly to the parent node I have
                node.ParentNode = find(node.ParentNode);
                return node.ParentNode;
            }
        }



    }



    }

