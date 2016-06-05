using System;

namespace tiplessCashJar.entities
{
    public class AbandonEntity : EntityBase<Guid>
    {
        public AbandonEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid GiverId { get; set; }
        public Guid RecipientId { get; set; }
        public string BeaconName { get; set; }
    }
}