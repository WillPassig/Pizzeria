using Pizzeria.Domain.Features.Orders;
using System.Data.Entity.ModelConfiguration;

namespace Pizzeria.Data.Features.Orders
{
    public class OrderEntityConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderEntityConfiguration()
        {
            ToTable("Orders");

            HasKey(order => order.ID);

            HasRequired(order => order.Customer);

            Property(order => order.Date)
                .HasColumnName("Date")
                .HasColumnType("datetime")
                .IsRequired();

            Property(order => order.TotalPrice)
                .HasColumnName("TotalPrice")
                .IsRequired();

            Ignore(order => order.Pizzas);
                
        }
    }
}
