using System;
using DataStructures.Graph;
using Xunit;
namespace DataStructuresTests
{
  public class GraphTests
  {
    [Fact]
    public void Graph_starts_empty()
    {
      //Arrange/Act
      var graph = new Graph();

      //Assert
      Assert.Empty(graph.Nodes);
      Assert.Equal(0, graph.Count);
    }

    [Fact]
    public void AddNode_with_value_returns_new_Graphnode()
    {
      //Arange
      var graph = new Graph();

      //Act
      var result = graph.AddNode("Ian");

      //Assert
      Assert.NotNull(result);
      Assert.Equal("Ian", result.Value);
      Assert.NotEmpty(graph.Nodes);
      Assert.Equal(1, graph.Count);
      Assert.Contains(result, graph.Nodes);
    }

    [Fact]
    public void AddEdge_with_nodes_makes_them_neighbors()
    {
      //Arrange
      var graph = new Graph();
      var node1 = graph.AddNode("Sarah");
      var node2 = graph.AddNode("Wesley");

      //Act
      graph.AddEdge(node1, node2);

      //Assert
      Assert.Contains(node1.Neighbors, edge => edge.Node == node2);
    }
  }
}
