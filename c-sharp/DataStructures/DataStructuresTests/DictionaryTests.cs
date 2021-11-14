using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DataStructuresTests
{
  public class DictionaryTests
  {

    [Fact]
    public void Can_add_to_dictionary()
    {
      //Arrange
      var d = new Dictionary<int, string>();

      //Act
      d.Add(11, "hello");

      //Assert
      Assert.True(d.ContainsKey(11));


    }

    [Fact]
    public void Can_add_value_to_dictionary()
    {
      //Arrange
      var d = new Dictionary<int, string>();

      //Act
      d.Add(15, "happyFriday");

      //Assert
      Assert.True(d.ContainsValue("happyFriday"));
    }

    [Fact]
    public void Can_get_value_by_asking_for_key()
    {
      //Arrange
      var d = new Dictionary<int, string>();
      d.Add(15, "happyFriday");

      //Act
      bool result = d.TryGetValue(15, out string value);

      //Assert
      Assert.True(result);
      Assert.Equal("happyFriday", value);
    }

    [Fact]
    public void Can_clear_dictionary()
    {
      //Arrange
      var d = new Dictionary<int, string>();
      d.Add(15, "happyFriday");
      d.Add(11, "yay!");
      d.Add(5, "hooray");

      //Act
      d.Clear();

      //Assert
      Assert.Empty(d);
    }
  }
}
