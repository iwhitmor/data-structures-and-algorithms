using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graph
{
  public partial class Graph
  {
    private List<GraphNode> nodes = new List<GraphNode>();

    public IEnumerable<GraphNode> Nodes => nodes;

    public int Count => nodes.Count();

    public GraphNode AddNode(string value)
    {

      var newNode = new GraphNode
      {
        Value = value,
      };

      nodes.Add(newNode);

      return newNode;
    }

    public IEnumerable<GraphEdge> GetNeighbors(GraphNode node)
    {
      return node.Neighbors;
    }

    public void AddEdge(GraphNode node1, GraphNode node2)
    {
      node1.Neighbors.Add(new GraphEdge
      {
        Node = node2,
      });
    }

    public IEnumerable<GraphNode> BreadthFirst(GraphNode start)
    {
      yield break;
    }
  }
}
