using System.Collections.Generic;

namespace DataStructures.Graph
{
    public class GraphNode
    {
      public string Value { get; set; }

    public List<GraphEdge> Neighbors { get; } = new List<GraphEdge>();
    }
}