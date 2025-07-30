using SubscriptionBillingAndNotificationSystem.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionBillingAndNotificationSystem.Core.Entities
{
    public class Subscription : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid PricingId { get; set; }
        public short Duration { get; set; }
        public DateTime Expiry { get; set; }
        public SubscriptionStatus subscription_status { get; set; }
    }
}
