using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graph
{
  public class Graph
  {
    public IEnumerable<GraphNode> Nodes { get; } = new List<GraphNode>();

    public object AddNode(string v)
    {
      return null;
    }

    //public GraphNode AddNode();

    //public void AddEdge(string from, string to);

    //public static List<GraphNode> GetNodes();

    //public static List<GraphEdge> GetNeighbors();

    //public static int Size();


    public int Count => Nodes.Count();
  }
}
