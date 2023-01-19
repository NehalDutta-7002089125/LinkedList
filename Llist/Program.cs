using System;

namespace Llist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist a = new Linkedlist();
            a.add(70);
            a.AddFirst(30);
            a.AddFirst(56);
            a.show();
        }
    }
}
