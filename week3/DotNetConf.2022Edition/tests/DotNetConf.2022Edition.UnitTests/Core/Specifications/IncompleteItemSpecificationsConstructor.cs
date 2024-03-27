﻿using DotNetConf._2022Edition.Core.ProjectAggregate;
using DotNetConf._2022Edition.Core.ProjectAggregate.Specifications;
using Xunit;

namespace DotNetConf._2022Edition.UnitTests.Core.Specifications;

public class IncompleteItemsSpecificationConstructor
{
  [Fact]
  public void FilterCollectionToOnlyReturnItemsWithIsDoneFalse()
  {
    var item1 = new ToDoItem();
    var item2 = new ToDoItem();
    var item3 = new ToDoItem();
    item3.MarkComplete();

    var items = new List<ToDoItem>() { item1, item2, item3 };

    var spec = new IncompleteItemsSpec();

    var filteredList = spec.Evaluate(items);

    Assert.Contains(item1, filteredList);
    Assert.Contains(item2, filteredList);
    Assert.DoesNotContain(item3, filteredList);
  }
}
