using System;
using System.Collections.Generic;
using System.Text;

namespace Graph_semestrovay
{
    class Node
    {
        public int Number { get; set; }

        public Node(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
