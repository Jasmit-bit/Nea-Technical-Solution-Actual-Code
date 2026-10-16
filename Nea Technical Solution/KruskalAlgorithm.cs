using Nea_Technical_Solution;
using System.Collections.Generic;
using System.Windows.Forms;

public class KruskalAlgorithm
{
    public List<Arc> arcSelected = new List<Arc>();
    public UnionFind unionFind = new UnionFind();
    public bool TutorialBeingShown;

    public void RunAlgorithm()
    {
        unionFind = new UnionFind();
        Graph.SortArcs();
        foreach (Node node in Graph.NodesInGraph)
        {
            node.visited = false; // marking each node as not being visited
        }

        foreach (Arc arc in Graph.ArcsInGraph)
        {

            if (CheckForCycle(arc) == false) // addition of this arc to the graph will not cause a cycle
            {
                arcSelected.Add(arc);
                if (TutorialBeingShown == true)
                {
                    MessageBox.Show($"The next arc without causing a loop is the arc connecting {arc.nodesConnected[0].name} and {arc.nodesConnected[1].name}"); arc.nodesConnected[0].visited = true;

                }
                arc.nodesConnected[1].visited = true;
            }
            else
            {
                if (TutorialBeingShown == true)
                {
                    MessageBox.Show($"The next smallest arc is the one connecting {arc.nodesConnected[0].name} and {arc.nodesConnected[1].name} but this would cause a cycle so we are going to skip it and not add it to our tree");

                }

            }
            if (arcSelected.Count == Graph.NodesInGraph.Count - 1) // a simple connected graph will always have one less arc than the number of nodes
            {
                int totalweight = 0;
                foreach (Arc ArcsSelected in arcSelected)
                {
                    totalweight += ArcsSelected.Weight;
                }
                if (TutorialBeingShown == true)
                {
                    MessageBox.Show($"The total weight of the minimum spanning tree is {totalweight}");
                }
                break;
            }

        }
    }
    public bool CheckForCycle(Arc arc)
    {
        Node node1 = arc.nodesConnected[0];// gets the 2 nodes connected by the arc
        Node node2 = arc.nodesConnected[1];

        Node parentOfNode1 = unionFind.find(node1); // retrieves the subsets of each of the arcs 
        Node parentOfNode2 = unionFind.find(node2);

        if (parentOfNode1 == parentOfNode2)
        {
            return true; // cycle found as they both are from the same subset
        }
        else
        {
            unionFind.union(node1, node2); // the 2 nodes are from different sets so we will add the graph, both nodes will now be a part of the same subset
        }
        return false; // no cycle
    }








}