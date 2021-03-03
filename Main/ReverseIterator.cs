
using System;

namespace LinkedList
{
    public class ReverseIterator
    {
        private Node currentNode;

        public ReverseIterator(Node currentNode)
        {
            this.currentNode = currentNode;
        }

        public Boolean hasNext()
        {
            return currentNode != null;
        }

        public int next()
        {
            int data = currentNode.getData();

            currentNode = currentNode.getPrevious();

            return data;
        }
    }
}


