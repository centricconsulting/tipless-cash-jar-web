using System;

namespace tiplessCashJar.entities
{
  public interface IEntity<TKey>
  {
    TKey Id { get; set; }
    DateTime WhenCreated { get; set; }
    DateTime? WhenModified { get; set; }
  }
}