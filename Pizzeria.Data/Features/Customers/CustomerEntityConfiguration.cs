using Pizzeria.Domain.Features.Customers;
using System.Data.Entity.ModelConfiguration;

namespace Pizzeria.Data.Features.Customers
{
    public class CustomerEntityConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerEntityConfiguration()
        {
            ToTable("Customers");

            HasKey(customer => customer.ID);
            
            HasRequired(customer => customer.Address);

            Property(customer => customer.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .IsRequired();

            Property(customer => customer.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
