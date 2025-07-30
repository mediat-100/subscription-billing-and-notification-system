using System.ComponentModel.DataAnnotations;

namespace SubscriptionBillingAndNotificationSystem.Core.Entities
{
    public class Pricing : BaseEntity 
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        [Range(1, 12)]
        public short Frequency { get; set; }
    }
}
