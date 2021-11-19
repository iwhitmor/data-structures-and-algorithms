using System;
using System.Collections.Generic;

namespace DataStructures.Graph
{
  public class Graph
  {
    public List<GraphNode> Nodes;

    public GraphNode AddNode()
    {

    }
  }

  public class GraphNode
  {
    string Value;

    List<GraphEdge> Neighbors;
  }

  internal class GraphEdge
  {
    GraphNode From;
    GraphNode To;
    int Weight;
  }
}
