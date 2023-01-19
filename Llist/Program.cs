using System;

namespace Llist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linkedlist a = new Linkedlist();
            a.add(70);
            
            a.add(56);
            a.AddBTW(1, 30);
            a.show();
        }
    }
}
