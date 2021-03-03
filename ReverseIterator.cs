using System;

public class ReverseIterator
{
    private Node currentNode;

    ReverseIterator(Node currentNode)
    {
        this.currentNode = currentNode;
    }

    public boolean hasNext()
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
