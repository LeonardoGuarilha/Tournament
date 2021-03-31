using System;

namespace Tournament.Domain.Entities
{
    public class Player : BaseEntity
    {
        public string Name { get; set; }
        public Guid? TeamId { get; set; }
        public Team Team { get; set; }
        
    }
}