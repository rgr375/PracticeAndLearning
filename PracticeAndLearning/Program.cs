using System;
using PracticeAndLearning.Datastructures;
using PracticeAndLearning.Scenarios;

namespace PracticeAndLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What is it you'd like to try today");
                Console.WriteLine("Press 1 for ImNotAQueueButAStack");
                Console.WriteLine("Press 2 for Demonstrate LinkedList");
                Console.WriteLine("Press 0 to exit");
                Console.WriteLine("------------------------------------------------");
                var response = Console.ReadLine();
                int value;
                if (int.TryParse(response, out value))
                {
                    switch (value)
                    {
                        case 1:
                            ImNotAQueueButAStack();
                            break;
                        case 2:
                            DemonstrateLinkList();
                            break;
                        case 0:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("You didn't pick a valid option");
                            break;
                    }
                } else
                {
                    Console.WriteLine("You didn't pick a number, please in a number");
                }
            }
        }

        private static void ImNotAQueueButAStack()
        {
            var trickQueue = new ImAQueueNot('a');
            trickQueue.Enqueue('b');
            trickQueue.Enqueue('c');

            while (trickQueue.Count > 0)
            {
                Console.WriteLine(trickQueue.Dequeue().ToString());
            }
        }

        private static void DemonstrateLinkList()
        {
            LinkedList n1 = new LinkedList();
            n1.AddLast('a');
            n1.AddLast('b');
            Console.WriteLine(n1.First.Data.ToString());
            n1.AddLast('c');
            Console.WriteLine(n1.First.Data.ToString());
            n1.AddFirst('d');
            Console.WriteLine(n1.First.Data.ToString());
            Console.WriteLine("-----------------------");
            Console.WriteLine($"LinkList Size: {n1.Size()}");
            Console.WriteLine("-----------------------");
            Console.WriteLine(n1.ToString());
        }
    }
}
