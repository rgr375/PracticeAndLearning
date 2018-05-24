using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAndLearning.Datastructures
{
    public class LinkedList
    {
        public Node Last = null;
        public Node First = null;

        public Node GetFirst { get { return First; } }


        public void AddLast(char Character)
        {
            Node temp = new Node(Character);
            if (IsEmpty())
            {
                First = temp;
            }
            else
            {
                Node current = First;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = temp;
            }
        }

        public void AddFirst(char Character)
        {
            First = new Node(Character, First);
        }

        public int Size()
        {
            return recSize(First);
        }

        public bool IsEmpty()
        {
            return First == null;
        }

        private int recSize(Node current)
        {
            if (current == null) return 0;
            else return 1 + recSize(current.Next);
        }

        public override string ToString()
        {
            StringBuilder returnVal = new StringBuilder();
            Node current = First;
            while (current != null)
            {
                returnVal.AppendLine(current.Data.ToString());
                current = current.Next;
            }
            return returnVal.ToString();
        }

    }
}
