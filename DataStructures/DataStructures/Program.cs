using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Welcome to Data Structures Programs...");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an Option : \n 1.Create Simple Linked List \n 2.AddInReverse\n 3.InsertBetween\n 4.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.AddInReverseOrder(70);
                        linkedList.AddInReverseOrder(30);
                        linkedList.AddInReverseOrder(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InsertAtParticularPosition(2,99);
                        linkedList.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
