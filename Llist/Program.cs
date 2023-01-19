using System;

namespace Llist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist a = new Linkedlist();
            a.add(56);
            
            a.add(70);
            a.AddBTW(1, 30);
            a.remove(0);
            a.show();
        }
    }
}
