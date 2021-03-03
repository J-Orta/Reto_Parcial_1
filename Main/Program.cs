using LinkedList;
using System;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList.LinkedList lista1 = new LinkedList.LinkedList();

            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);

            Iterator it = lista1.getIterator();

            while (it.hasNext())
            {
                Iterator backupIt = new Iterator(it);
                int element = it.next(); 

                if (element == 3)
                {
                    lista1.insert(10, LinkedList.LinkedList.BEFORE, backupIt);
                }

                if (element == 7)
                {
                    lista1.insert(15, LinkedList.LinkedList.AFTER, backupIt);
                }
            }

            lista1.delete(3);

            System.Console.WriteLine("---------------------");

            System.Console.WriteLine("El tamaño es:" + lista1.getSize());

            it = lista1.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                System.Console.WriteLine("Dato: " + element);
            }

            System.Console.WriteLine("---------------------");

            ReverseIterator reverseIterator = lista1.getReverseIterator();

            while (reverseIterator.hasNext())
            {
                int element = reverseIterator.next();

                System.Console.WriteLine("Dato: " + element);
            }

            Console.ReadKey();
        }
    }
}
