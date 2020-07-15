using System;

namespace EECE5360FinalProjectApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            string GraphSelectVariable = "10Nodes";  // options are HamiltonI, HamiltonII, HamiltonIII, 1000nodes
            int NumberNodesVariable = 10;               // must change number of pins

                Algorithm algorithm = new Algorithm();
                algorithm.executeExhaustiveAlgorithm(GraphSelectVariable, NumberNodesVariable);
                algorithm.executeMST2XApproximateAlgorithm(GraphSelectVariable, NumberNodesVariable);
                algorithm.executeSimpleTabuSearch(GraphSelectVariable, NumberNodesVariable);
                algorithm.executeSimpleTwoOptSearch(GraphSelectVariable, NumberNodesVariable);
        }
    }
} 

