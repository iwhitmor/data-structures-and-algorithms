using System;
using System.Collections.Generic;
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


      //Act


      //Assert
    }
  }
}
