using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.add(56);
            list.add(30);
            list.add(70);
            // list.InsertAtParticularPosition(2,30);
            // list.RemoveFirstNode();
            // list.RemovaLastNode();
            list.Search(30);
            list.Display();
        }
    }
}
