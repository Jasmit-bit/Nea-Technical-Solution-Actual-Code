namespace Nea_Technical_Solution
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<node>
    {
        private List<Tuple<Node, int>> NodesInThePriorityQueue = new List<Tuple<Node, int>>();

        public int Count
        {
            get { return NodesInThePriorityQueue.Count; }
        }

        public void Enqueue(Node nodeToBeInserted, int priority) // adds a node into the priority queue alongside its priority
        {
            NodesInThePriorityQueue.Add(Tuple.Create(nodeToBeInserted, priority));
            int index = Count-1;
            // we have added the node in the heap however now the order may not be correct so we want to check and rearrange the heap soo that we have the correct node at the front
            while (index > 0)
            {
                int parentNodeIndex = (index - 1) / 2;

                if (NodesInThePriorityQueue[index].Item2 >= NodesInThePriorityQueue[parentNodeIndex].Item2)// if the priorities are equal or greater we are done sorting the heap 
                {
                        break;
                }

                Swap(index, parentNodeIndex);
                index = parentNodeIndex;
            }
        }

        public Node Dequeue() // retrives the first item in the queue 
        {
            if (NodesInThePriorityQueue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty theres nothing in here");
            }

            Node result = NodesInThePriorityQueue[0].Item1; // this is the next node in the priority queue so we are going to remove this but we need to re order the heap
            NodesInThePriorityQueue[0] = NodesInThePriorityQueue[Count - 1];
            NodesInThePriorityQueue.RemoveAt(Count - 1);

            int index = 0;

            while (true) // loop responsible for maintainging the order of the heap
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;

                if (leftChildIndex >= Count)
                {
                    break;
                }
                int minIndex = index;

                if (NodesInThePriorityQueue[leftChildIndex].Item2 < NodesInThePriorityQueue[minIndex].Item2)
                {
                    minIndex = leftChildIndex;
                }
                if (rightChildIndex < Count && NodesInThePriorityQueue[rightChildIndex].Item2 < NodesInThePriorityQueue[minIndex].Item2)
                {
                    minIndex = rightChildIndex;
                }
                if (minIndex == index)
                {
                    break;
                }
                Swap(index, minIndex);
                index = minIndex;
            }

            return result;
        }

        private void Swap(int firstIndex, int secondIndex) // swaps the position of the two given nodes in the priority queue
        {
            Tuple<Node, int> TemporaryHolder = NodesInThePriorityQueue[firstIndex];
            NodesInThePriorityQueue[firstIndex] = NodesInThePriorityQueue[secondIndex];
            NodesInThePriorityQueue[secondIndex] = TemporaryHolder;
        }


    }

}
