using System;

namespace tiplessCashJar.entities
{
  public abstract class EntityBase<TKey> : IEntity<TKey>
  {
    public TKey Id { get; set; }
    public DateTime WhenCreated { get; set; } = DateTime.UtcNow;
    public DateTime? WhenModified { get; set; }
  }
}
