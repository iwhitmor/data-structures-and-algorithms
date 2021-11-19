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

    public void AddEdge(string from, string to)
    {

    }

    public static List<GraphNode> GetNodes()
    {

    }

    public static List<GraphEdge> GetNeighbors()
    {

    }

    public static int Size()
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
