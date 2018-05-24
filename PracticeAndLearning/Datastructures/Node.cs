using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeAndLearning.Datastructures
{
    public class Node
    {
        public char Data;
        public Node Next;

        public Node(char Character, Node NextNode)
        {
            Data = Character;
            Next = NextNode;
        }

        public Node(char Character) : this(Character, null)
        {

        }
    }
}
