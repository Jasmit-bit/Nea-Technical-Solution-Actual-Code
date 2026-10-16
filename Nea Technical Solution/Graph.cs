using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nea_Technical_Solution
{
    public static class Graph
    {
        public static List<Node> NodesInGraph = new List<Node>();

        public static List<Arc> ArcsInGraph = new List<Arc>();
        public static void AddNode(Node node)
        {
            NodesInGraph.Add(node);
        }
        public static void AddArc(Arc arc)
        {
            ArcsInGraph.Add(arc);
        }
        public static void CheckConnections(Node currentNode)// Using depth first here to check if all nodes are accisble and making sure the graph is connected
        {
            currentNode.visited = true;
            foreach (Arc arc in currentNode.ArcsConnectedTo)
            {
                Node otherNode = arc.GetNodeOnOtherSide(currentNode);
                if (!otherNode.visited)
                {
                    CheckConnections(otherNode);
                }
            }
        }

        public static bool CheckIfGraphIsConnected() 
        {
            if (NodesInGraph.Count == 0 || ArcsInGraph.Count == 0)
            {
                return false; // dont want to go through the rest of the steps if the graph has no nodes or arcs
            }

            Node startNode = NodesInGraph[0];
            foreach (Node node in NodesInGraph)
            {
                node.visited = false;
            }

            CheckConnections(startNode);

            foreach (Node node in NodesInGraph)
            {
                if (!node.visited)
                {
                    return false; // all the nodes should have been marked as visited if the graph was connected we still need more nodes
                }
            }
            return true;
        }       

        public static void Clear()
        {
            ArcsInGraph.Clear();
            NodesInGraph.Clear();

        }

        public static Node ConvertNameToNode(string InName) // converts the name of the node to the node object which it relates to
        {
            Node nodeToReturn = null;
            foreach (Node node in NodesInGraph)
            {
                if (node.name == InName)
                {
                    nodeToReturn = node;
                }
            }
            return nodeToReturn;
        }

        public static bool Check(Node node1, Node node2) // checks the graph is not too simple and not too confusing
        {
            foreach(Arc arc in Graph.ArcsInGraph)
            {
                if (arc.nodesConnected.Contains(node1) && arc.nodesConnected.Contains(node2))
                {
                    return false; // No need to have 2 different arcs going the same place
                }
            }
            return true;
        }
         public static bool Complex()//makes sure the graph is complex enough by making sure each node has atleast 2 arcs leaving the node
        {
            foreach (Node node in Graph.NodesInGraph)
            {
                if (node.ArcsConnectedTo.Count < 2)
                {
                    return false;
                }
            }
            return true;
        }

        public static void InitialiseGraph()// creates a new graph
        {
            Graph.Clear();
            Random rnd = new Random();
            MakeNodes(rnd);
            MakeArcs(rnd);
        } 

        public static void MakeNodes(Random rnd)
        {

            List<string> NamesOfCities = new List<string>();
            string filename = "NameOfCities.txt";// add an error catching if the file doesnt exist
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string CityName = sr.ReadLine();
                    NamesOfCities.Add(CityName);
                }
            }
            for (int i = NamesOfCities.Count - 1; i > 0; i--) // just like words with aqa I am shuffling the way the cities are read so we have a new and different city name each time
            {
                int j = rnd.Next(0, i + 1);
                string temp = NamesOfCities[i];
                NamesOfCities[i] = NamesOfCities[j];
                NamesOfCities[j] = temp;
            }
            for (int i = 0; i < 7; i++)
            {
                Node node = new Node(NamesOfCities[i]);
                Graph.AddNode(node);
            }
        }

        public static void MakeArcs(Random rnd)
        {
            List<string> NamesOfRoads = new List<string>();
            const string Filename = "NamesOfRoads.txt";
            using (StreamReader sr = new StreamReader(Filename))
            {
                while (!sr.EndOfStream)
                {
                    NamesOfRoads.Add(sr.ReadLine());
                }
            }
            for (int i = NamesOfRoads.Count - 1; i > 0; i--) // just like words with aqa I am shuffling the way the cities are read so we have a new and different city name each time
            {
                int j = rnd.Next(0, i + 1);
                string temp = NamesOfRoads[i];
                NamesOfRoads[i] = NamesOfRoads[j];
                NamesOfRoads[j] = temp;
            }




            foreach (string Road in NamesOfRoads)
            {
                int IndexOfFirstNode = -1;
                int IndexOfSecondNode = -1;
                do
                {
                    IndexOfFirstNode = rnd.Next(0, Graph.NodesInGraph.Count);
                    IndexOfSecondNode = rnd.Next(0, Graph.NodesInGraph.Count);
                } while (IndexOfFirstNode == IndexOfSecondNode || Graph.NodesInGraph[IndexOfFirstNode].ArcsConnectedTo.Count >= 3 || Graph.NodesInGraph[IndexOfSecondNode].ArcsConnectedTo.Count >= 3 || Graph.Check(Graph.NodesInGraph[IndexOfFirstNode], Graph.NodesInGraph[IndexOfSecondNode]) == false);// if they are not the same node you can proceed but if they are that is an issue so pick a different node
                Node Node1 = Graph.NodesInGraph[IndexOfFirstNode];
                Node Node2 = Graph.NodesInGraph[IndexOfSecondNode];
                int Distance = rnd.Next(1, 240);
                Arc arc = new Arc(Road, Distance, Node1, Node2);
                Graph.AddArc(arc);
                if (Graph.CheckIfGraphIsConnected() == true && Graph.Complex() == true)
                {
                    break;
                }
            }
            foreach (Node node in Graph.NodesInGraph)
            {
                node.visited = false;
            }

        }

        public static void SortArcs()
        {
            List<int> weightOfArcs = new List<int>();
            foreach (Arc arc in ArcsInGraph)
            {
                weightOfArcs.Add(arc.Weight);
            }
            weightOfArcs.Sort();
            List<Arc> sortedArcs = new List<Arc>();
            foreach (int arcWeight in weightOfArcs)
            {
                foreach (Arc arc in ArcsInGraph)
                {
                    if (arcWeight == arc.Weight)
                    {
                        sortedArcs.Add(arc);
                    }
                }
            }
            ArcsInGraph = new List<Arc>(sortedArcs);
        }

        public static int FindShortestPath(Node startingNode, Node finishNode) // apllies djikstra's algorithm to find the shortest distance between the 2 given nodes
        {
            if (startingNode == finishNode)
            {
                MessageBox.Show("You are already at your finishing Node!");
                return -1;
            }

            PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>();

            foreach (Node node in NodesInGraph)
            {
                node.visited = false;
                node.DistanceFromStart = int.MaxValue;
                node.PreviousNode = null;
                node.PreviousArc = null;
            }

            startingNode.DistanceFromStart = 0;
            priorityQueue.Enqueue(startingNode, startingNode.DistanceFromStart);

            while (priorityQueue.Count > 0)
            {
                Node currentNode = priorityQueue.Dequeue();

                if (currentNode.visited)
                {
                    continue; // we have already visited this node so there is no need for us to use it again skip to the next node in the queue
                }

                currentNode.visited = true;

                foreach (Arc arc in currentNode.ArcsConnectedTo)
                {
                    Node connectedNode = arc.GetNodeOnOtherSide(currentNode);
                    int DistanceFromStartNode = currentNode.DistanceFromStart + arc.Weight;

                    if (DistanceFromStartNode < connectedNode.DistanceFromStart)
                    {
                        connectedNode.DistanceFromStart = DistanceFromStartNode;
                        connectedNode.PreviousNode = currentNode;
                        connectedNode.PreviousArc = arc;

                        priorityQueue.Enqueue(connectedNode, connectedNode.DistanceFromStart);
                    }
                }
            }
            List<Node> shortestPath = new List<Node>();
            List<Arc> arcsTaken = new List<Arc>();
            Node pathNode = finishNode; // we are going to use this node to backtrack and see which nodes we picked on the way to achieve the shortest path
            int totalWeight = 0;

            while (pathNode != null)
            {
                shortestPath.Add(pathNode);

                if (pathNode.PreviousArc != null) // backtracking to find out the total weight and the journey taken
                {
                    arcsTaken.Add(pathNode.PreviousArc);
                    totalWeight += pathNode.PreviousArc.Weight;
                }

                pathNode = pathNode.PreviousNode;
            }

            shortestPath.Reverse(); // reversing the backtacked path so it starts from the beggining compared to the finish node
            arcsTaken.Reverse(); // same as top

            for (int i = 0; i < shortestPath.Count - 1; i++)
            {
                Djikstra.orderOfArcs.Add(arcsTaken[i]);
            }// sums up the weight of all the arcs the program took to reach the final destination
            

            return totalWeight;
        } 
    }

}
