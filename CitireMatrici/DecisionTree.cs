using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitireMatrici
{
    public class DecisionTree
    {
        public int numNodes;
        public int numClasses;
        public List<Node> tree;

        public DecisionTree(int numNodes, int numClasses)
        {
            this.numNodes = numNodes;
            this.numClasses = numClasses;
            this.tree = new List<Node>();
            for (int i = 0; i < numNodes; ++i)
            {
                this.tree.Add(new Node());
            }
        }

    }
}
