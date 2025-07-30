using Microsoft.EntityFrameworkCore;
using SubscriptionBillingAndNotificationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionBillingAndNotificationSystem.Core.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }




}
