using System;

namespace tiplessCashJar.entities
{
    public class EntityBase<TKey> : IEntity<TKey>
    {
      public TKey Id { get; set; }
      public DateTime WhenCreated { get; set; }
      public DateTime? WhenModified { get; set; }
    }
}
