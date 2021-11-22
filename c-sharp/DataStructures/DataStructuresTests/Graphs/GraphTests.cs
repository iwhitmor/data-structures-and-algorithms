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
  }
}
