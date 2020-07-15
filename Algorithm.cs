using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Xml.Schema;

namespace EECE5360FinalProjectApplication
{
    class Algorithm
    {
        public int NumberNodes { get; set; }
        public static int trackNumberofPermutations = 0;
        public static int firstVariable = 0;
        public static int nextVariable = 1;

        //***************************************************************
        public Algorithm()
        {

        }

        public bool permutationFunction(int[] arrayvariable, int startingIndex, int numberofPermutations)  // perform n!
        {

            // Console.WriteLine($" Permutation number { trackNumberofPermutations}");

            if (nextVariable != NumberNodes - 2)
            {
                firstVariable++;
                nextVariable++;
                trackNumberofPermutations++;

            }
            else if (nextVariable == NumberNodes - 2)
            {
                firstVariable = 0;
                nextVariable = 1;
                trackNumberofPermutations++;

            }

            int tempdata = arrayvariable[firstVariable];
            arrayvariable[firstVariable] = arrayvariable[nextVariable];
            arrayvariable[nextVariable] = tempdata;

            if (trackNumberofPermutations == numberofPermutations) // met all the permutations
                return false;
            else
                return true;
        }

        //***************************************************************

        public LinkedList<int>[] getGraph(string getGraph, int NumberNodes)
        {
            var customnewGraph = new LinkedList<int>[NumberNodes];

            if (getGraph == "HamiltonI")
            {

                int[] arrayVariable1 = { 0, 10, 30, 30, 25 };
                int[] arrayVariable2 = { 10, 0, 20, 30, 20 };
                int[] arrayVariable3 = { 30, 20, 0, 15, 25 };
                int[] arrayVariable4 = { 30, 30, 15, 0, 20 };
                int[] arrayVariable5 = { 25, 20, 25, 20, 0 };

                customnewGraph[0] = new LinkedList<int>(arrayVariable1);
                customnewGraph[1] = new LinkedList<int>(arrayVariable2);
                customnewGraph[2] = new LinkedList<int>(arrayVariable3);
                customnewGraph[3] = new LinkedList<int>(arrayVariable4);
                customnewGraph[4] = new LinkedList<int>(arrayVariable5);

            }
            else if (getGraph == "HamiltonII")
            {

                int[] arrayVariable1 = { 0, 30, 15, 35, 10 };
                int[] arrayVariable2 = { 30, 0, 40, 50, 35 };
                int[] arrayVariable3 = { 15, 40, 0, 40, 50 };
                int[] arrayVariable4 = { 35, 50, 40, 0, 30 };
                int[] arrayVariable5 = { 10, 35, 50, 30, 0 };

                customnewGraph[0] = new LinkedList<int>(arrayVariable1);
                customnewGraph[1] = new LinkedList<int>(arrayVariable2);
                customnewGraph[2] = new LinkedList<int>(arrayVariable3);
                customnewGraph[3] = new LinkedList<int>(arrayVariable4);
                customnewGraph[4] = new LinkedList<int>(arrayVariable5);
            }
            else if (getGraph == "HamiltonIII")
            {

                int[] arrayVariable1 = { 0, 30, 15, 30, 10 };
                int[] arrayVariable2 = { 30, 0, 40, 50, 36 };
                int[] arrayVariable3 = { 15, 40, 0, 41, 50 };
                int[] arrayVariable4 = { 30, 50, 41, 0, 35 };
                int[] arrayVariable5 = { 10, 36, 50, 35, 0 };

                customnewGraph[0] = new LinkedList<int>(arrayVariable1);
                customnewGraph[1] = new LinkedList<int>(arrayVariable2);
                customnewGraph[2] = new LinkedList<int>(arrayVariable3);
                customnewGraph[3] = new LinkedList<int>(arrayVariable4);
                customnewGraph[4] = new LinkedList<int>(arrayVariable5);
            }
            else if (getGraph == "10Nodes")
            {

                int[] arrayVariable1 = { 0, 4, 5, 10, 4, 20, 3, 8, 4, 9 };
                int[] arrayVariable2 = { 4, 0, 8, 0, 0, 0, 0, 11, 0, 0 };
                int[] arrayVariable3 = { 5, 8, 0, 7, 0, 4, 0, 0, 2, 0 };
                int[] arrayVariable4 = { 10, 0, 7, 0, 9, 14, 0, 0, 0, 0 };
                int[] arrayVariable5 = { 4, 0, 0, 9, 0, 10, 0, 0, 0, 0 };
                int[] arrayVariable6 = { 20, 0, 4, 14, 10, 0, 2, 0, 0, 0 };
                int[] arrayVariable7 = { 3, 0, 0, 0, 0, 2, 0, 1, 6, 0 };
                int[] arrayVariable8 = { 8, 11, 0, 0, 0, 0, 1, 0, 7, 0 };
                int[] arrayVariable9 = { 4, 0, 2, 0, 0, 0, 6, 7, 0, 0 };
                int[] arrayVariable10 = { 9, 0, 0, 3, 5, 0, 0, 0, 0, 0 };

                customnewGraph[0] = new LinkedList<int>(arrayVariable1);
                customnewGraph[1] = new LinkedList<int>(arrayVariable2);
                customnewGraph[2] = new LinkedList<int>(arrayVariable3);
                customnewGraph[3] = new LinkedList<int>(arrayVariable4);
                customnewGraph[4] = new LinkedList<int>(arrayVariable5);
                customnewGraph[5] = new LinkedList<int>(arrayVariable6);
                customnewGraph[6] = new LinkedList<int>(arrayVariable7);
                customnewGraph[7] = new LinkedList<int>(arrayVariable8);
                customnewGraph[8] = new LinkedList<int>(arrayVariable9);
                customnewGraph[9] = new LinkedList<int>(arrayVariable10);

            }
            else if (getGraph == "1000Nodes")
            {
                int DecimalCostOfPath = 0;
                int firstconnection = 0;

                for (int j = 0; j < NumberNodes; j++)
                {
                    customnewGraph[j] = new LinkedList<int>();

                    for (int i = 0; i < NumberNodes; i++)
                    {

                        if (i == j)
                            DecimalCostOfPath = 0;
                        else
                            DecimalCostOfPath = i + j;
                        customnewGraph[j].AddLast(DecimalCostOfPath);
                        firstconnection++;
                    }
                }
            }

         //   int iterator = 0;
            /*  PRINTING THE GRAPH
                for (int i = 0; i < NumberNodes; i++)
                {
                    iterator = 0;
                    foreach (var item in customnewGraph[i])
                    {
                        Console.WriteLine($" Header Node { i } is connected to node {iterator} with value {item}");
                        iterator++;
                    }
                }

               Console.WriteLine($" \n ********************************************** \n ");
    */
            return customnewGraph;
        }

        //***************************************************************
        public int executeExhaustiveAlgorithm(string GraphSelectVariable, int NumberNodesVariable)
        {

            Console.WriteLine($" \n ************ EXHAUSTIVE ALGORITHM *************** ");

            // internal data structure
            int k = 1;

            string GraphSelect = GraphSelectVariable;
            NumberNodes = NumberNodesVariable;
            var customGraph = new LinkedList<int>[NumberNodes];

            customGraph = getGraph(GraphSelect, NumberNodes);

            var variablePermutations = new int[NumberNodes];

            for (int j = 0; j < NumberNodes; j++)
                variablePermutations[j] = j;

            int numberofPermutations = 1;

            for (int i = NumberNodes - 1; i > 0; i--)
            {
                if (i != 1)
                    numberofPermutations = numberofPermutations * i * (i - 1);

                i--;
            }

            int minimumKeyValue = 10000;
            int sourcenode = 0;
            int TotalDistance = 0;
            int Connections = 1;

            k = sourcenode;

            do
            {
                Connections = 1;
                TotalDistance = 0;
                k = 0;
                for (int i = 0; i < NumberNodes; i++)
                {
                  
                    if (customGraph[k].ElementAt(variablePermutations[i]) != 0)  // we do not include the distance to itself
                    {
                        TotalDistance = TotalDistance + customGraph[k].ElementAt(variablePermutations[i]);
                   //           Console.WriteLine($" \n Current path weight for node {k} is the  {TotalDistance} by adding distance {customGraph[k].ElementAt(variablePermutations[i])} \n");

                        k = variablePermutations[i];
                        Connections++;
                    }
                }
                TotalDistance = TotalDistance + customGraph[k].ElementAt(0);

               //   Console.WriteLine($" \n Current path weight {TotalDistance}  \n");

                if (Connections == NumberNodes)  // NumberNodes+1 , starting at 0
                {
                
                    if (TotalDistance < minimumKeyValue)
                        minimumKeyValue = TotalDistance;
                    else
                        minimumKeyValue = minimumKeyValue;   // static variable
                }

            } while (permutationFunction(variablePermutations, 0, numberofPermutations));

            Console.WriteLine($" Minimum Path of all the permutations is {minimumKeyValue}\n");

            return 0;
        }
        //***************************************************************
        public int minimumNodeNotVisitedMST(double[] Key, bool[] MstSetVisited, int numNodes)
        {

            double minimumDistance = 100000;
            int minimumIndex = 0;

            for (int node = 0; node < numNodes; node++)
            {
                if (MstSetVisited[node] == false && Key[node] <= minimumDistance)  // have not visited the node and minimum distance
                {
                    minimumDistance = Key[node];
                    minimumIndex = node;
                }
            }
            return minimumIndex;
        }
        //***************************************************************

        public int executeMST2XApproximateAlgorithm(string GraphSelectVariable, int NumberNodesVariable)
        {
            Console.WriteLine($" \n ************ MST 2X APPROXIMATE ALGORITHM *************** \n");

            string GraphSelect = GraphSelectVariable;
            NumberNodes = NumberNodesVariable;

            var customGraph = new LinkedList<int>[NumberNodes];

            customGraph = getGraph(GraphSelect, NumberNodes);

            var MST = new int[NumberNodes];
            var Key = new double[NumberNodes];
            var MSTSetvisited = new bool[NumberNodes];

            for (int i = 0; i < NumberNodes; i++)
            {
                Key[i] = 100000000;
                MSTSetvisited[i] = false;
            }

            Key[0] = 0;
            MST[0] = -1;

            for (int count = 0; count < NumberNodes - 1; count++)
            {
                int minimumKeyVertex = minimumNodeNotVisitedMST(Key, MSTSetvisited, NumberNodes);
                MSTSetvisited[minimumKeyVertex] = true;

                for (int nodeIndex = 0; nodeIndex < NumberNodes; nodeIndex++)
                {
                    if (customGraph[minimumKeyVertex].ElementAt(nodeIndex) != 0)
                    {
                        if (MSTSetvisited[nodeIndex] == false && customGraph[minimumKeyVertex].ElementAt(nodeIndex) < Key[nodeIndex])
                        {
                            Key[nodeIndex] = customGraph[minimumKeyVertex].ElementAt(nodeIndex);
                            MST[nodeIndex] = minimumKeyVertex;
                        }

                    }

                }// end of for lop
            } // end of for loop


            double TotalDistance = 0;

            for (int i = 1; i < NumberNodes; i++)
            {
                Console.WriteLine($" {MST[i] } - {i} \t \t \t {customGraph[i].ElementAt(MST[i])}  \n ");
                TotalDistance = TotalDistance + customGraph[i].ElementAt(MST[i]);

            }

            Console.WriteLine($" Distance of the minimum path for the MST is {TotalDistance}");
            Console.WriteLine($" For the 2X approximate TSP Solution it back traverses the same path reliably hence total distance is  {2 * TotalDistance}");

            return 0;
        }
        //***************************************************************

        public int executeSimpleTabuSearch(string GraphSelectVariable, int NumberNodesVariable)
        {
            Console.WriteLine($" \n ************ SIMPLE TABU SEARCH ALGORITHM *************** \n");
            string GraphSelect = GraphSelectVariable;
            NumberNodes = NumberNodesVariable;

            string neighborhoodSelect = "global";   // use local for high number of nodes

            var customGraph = new LinkedList<int>[NumberNodes];

            customGraph = getGraph(GraphSelect, NumberNodes);

            List<int> tabuList = new List<int>();

            int sourceNode = 0;
            int sBest = customGraph[sourceNode].ElementAt(sourceNode);
            int bestCandidate = customGraph[sourceNode].ElementAt(sourceNode);
            int minimumDistance = 10000000;

            tabuList.Add(customGraph[sourceNode].ElementAt(sourceNode));
            int optimiumNodeIndex = 0;
            int totalminimumdistance = 0;
            int TabuListIterator = 0;

            try
            {

                while (tabuList.Count < NumberNodes)
                {
                    int visitingCurrentNode = tabuList.ElementAt(TabuListIterator);

                    LinkedList<int> sNeighborhood = new LinkedList<int>();

                    if (neighborhoodSelect == "global")
                        sNeighborhood = customGraph[visitingCurrentNode];  // define a global neighborhood
                    else if (neighborhoodSelect == "local")
                        sNeighborhood = getLocalNeighborhood(customGraph[visitingCurrentNode], visitingCurrentNode);  // define a local neighborhood

                    bestCandidate = visitingCurrentNode;
                    optimiumNodeIndex = 0;
                    minimumDistance = 100000;
                    foreach (var item in sNeighborhood)
                    {
                        if (!tabuList.Contains(optimiumNodeIndex) && item < minimumDistance && item != 0)  // optimumNodeIndex is just the node index, the function is sequential
                        {
                            minimumDistance = item;
                            bestCandidate = optimiumNodeIndex;
                        }
                        optimiumNodeIndex++;
                    }
                    Console.WriteLine($" Closest neighbor for visiting node is node Index {bestCandidate} with distance value  {minimumDistance}");
                    totalminimumdistance = totalminimumdistance + minimumDistance;

                    if (totalminimumdistance > 100000)
                        throw new NextNodeNotFoundException();

                    sBest = bestCandidate;
                    tabuList.Add(bestCandidate);
                    TabuListIterator++;
                }

            }
            catch (NextNodeNotFoundException)
            {
            }

            try
            {
                if (customGraph[bestCandidate].ElementAt(sourceNode) != 100000)
                {
                    tabuList.Add(0);   // From the last node iterate back to source node
                    totalminimumdistance = totalminimumdistance + customGraph[bestCandidate].ElementAt(sourceNode);
                    Console.WriteLine($" From the last node the distance value to the source node is {customGraph[bestCandidate].ElementAt(sourceNode)}");
                    Console.WriteLine($" Total minium distance is {totalminimumdistance}");
                }
                else
                    throw new SourceNodeNotFoundException();
            }
            catch (SourceNodeNotFoundException)
            {

            }
            return 0;
        }

        //**********************************************
        public LinkedList<int> getLocalNeighborhood(LinkedList<int> customGraphVisitingNode, int visitingCurrentNode)
        {
            LinkedList<int> getLocalNeighborhoodList = new LinkedList<int>();


            if (NumberNodes < 10)
            {
                for (int i = 0; i < NumberNodes; i++)  // localized based on the numbering of the nodes  
                    getLocalNeighborhoodList.AddLast(customGraphVisitingNode.ElementAt(i));
            }
            else
            {
                for (int i = 0; i < NumberNodes / 2; i++)  // localized based on the numbering of the nodes  
                    getLocalNeighborhoodList.AddLast(customGraphVisitingNode.ElementAt(visitingCurrentNode + i));

            }

            return getLocalNeighborhoodList;
        }

        //**********************************************
        // Next algorithm is 2opt search, more advanced is the Lin-Kernighan which is considered to be the best heuristic for TSP
        //**********************************************

        public int executeSimpleTwoOptSearch(string GraphSelectVariable, int NumberNodesVariable)
        {
            Console.WriteLine($" \n ************ SIMPLE 2OPT SEARCH ALGORITHM *************** \n");

            string GraphSelect = GraphSelectVariable;
            NumberNodes = NumberNodesVariable;
            int TotalminimumDistance_original = 0;

            var customGraph = new LinkedList<int>[NumberNodes];
            var TwoOptSearchList = new List<int>();

            customGraph = getGraph(GraphSelect, NumberNodes);

            int sourceNode = 0;
            int TourPathNode = 0;
            TwoOptSearchList.Add(sourceNode);
            // create a random cycle
            for (TourPathNode = 1; TourPathNode < NumberNodes; TourPathNode++)
            {
                TotalminimumDistance_original = TotalminimumDistance_original + customGraph[TourPathNode-1].ElementAt(TourPathNode);
                TwoOptSearchList.Add(TourPathNode);

                Console.WriteLine($"To Node index {TourPathNode} has distance value {customGraph[TourPathNode-1].ElementAt(TourPathNode)}");
            }
            try
            {
                if (customGraph[0].ElementAt(TourPathNode-1) != 0)  //value of the last node
                {
                    TwoOptSearchList.Add(sourceNode);
                    TotalminimumDistance_original = TotalminimumDistance_original + customGraph[0].ElementAt(TourPathNode-1);
                    Console.WriteLine($" Going back to source node from node {TourPathNode-1} distance value {customGraph[0].ElementAt(TourPathNode-1)}");

                }
                else
                    throw new SourceNodeNotFoundException();
            }
            catch (SourceNodeNotFoundException)
            {

            }

  
            Console.WriteLine($" Minimum Distance for the original tour is {TotalminimumDistance_original} \n ");

            // starting the algorithm with an initial random tour
            int TotalminimumDistance = TotalminimumDistance_original;
            int iterator = 0;
            int minimumKeyValue = TotalminimumDistance_original;

            while(iterator != NumberNodes)
            {
                int startingIndex = 0;
                int EndingIndex = NumberNodes;
                TotalminimumDistance = 0;

                var TwoOptNewTour = new List<int>();
                TwoOptNewTour = Algorithm.OptExecuteEdgeTransfer(TwoOptSearchList, startingIndex, EndingIndex, iterator);

                for ( int k = 0; k < TwoOptNewTour.Count() - 1; k++)
                {
                    TotalminimumDistance = TotalminimumDistance + customGraph[TwoOptNewTour.ElementAt(k)].ElementAt(TwoOptNewTour.ElementAt(k + 1));
                    //Console.WriteLine($"Node Index {TwoOptNewTour.ElementAt(k)}  value of distance is {customGraph[TwoOptNewTour.ElementAt(k)].ElementAt(TwoOptNewTour.ElementAt(k + 1))}   ");
                }
 
                Console.WriteLine($"2Opt Iteration {iterator} Distance Tour is {TotalminimumDistance} ");

                if (TotalminimumDistance < minimumKeyValue)
                    minimumKeyValue = TotalminimumDistance;

                iterator++;

            } 

            Console.WriteLine($"\n Minimum Distance for the new  tour is {minimumKeyValue} \n ");

            return 0;
        }



    //**********************************************
    // OptExecuteEdgeTransfer
    //**********************************************
    public static List<int> OptExecuteEdgeTransfer(List<int> TwoOptSearchList, int startingIndex, int EndingIndex, int iterator)
    {
            var TwoOptSearchNewList = new List<int>();


        //    foreach (var item in TwoOptSearchList)
        //        Console.WriteLine($" Original Path {item} ");


            for (int i = startingIndex; i < EndingIndex - iterator; i++)
                     TwoOptSearchNewList.Add(TwoOptSearchList.ElementAt(i));

            for (int i = EndingIndex - 1; i >= EndingIndex - iterator; i--)
                TwoOptSearchNewList.Add(TwoOptSearchList.ElementAt(i));

            TwoOptSearchNewList.Add(0);  // back to the source node


       //     foreach (var item in TwoOptSearchNewList)
       //         Console.WriteLine($" New Path {item} ");

            return TwoOptSearchNewList; 
    }


    }  // END OF CLASS

    //**********************************************
    // EXCEPTION CLASS FOR SOURCE NODE 
    //**********************************************
    public class SourceNodeNotFoundException : Exception
    {
      public SourceNodeNotFoundException()
        {
            Console.WriteLine($" \n ************ EXCEPTION THROWN ********************* \n ");
            Console.WriteLine($" \n There is no direct path back to the source node must use the MST Greedy Algorithm \n ");
            Console.WriteLine($" \n ************ EXCEPTION THROWN ********************* \n ");
        }
    }
    //**********************************************
    public class NextNodeNotFoundException : Exception
    {
        public NextNodeNotFoundException()
        {
            Console.WriteLine($" \n ************ EXCEPTION THROWN ********************* ");
            Console.WriteLine($" There is no path back to the next node CHANGE ALGORITHM TRY GLOBAL NEIGHBORHOOD ");
            Console.WriteLine($" ************ EXCEPTION THROWN ********************* \n ");
        }
    }
    //**********************************************
}