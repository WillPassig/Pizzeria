using Pizzeria.Domain.Features.Orders;
using Pizzeria.Domain.Features.Toppings;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Pizzeria.Data.Features.Toppings
{
    public class ToppingEntityConfiguration : EntityTypeConfiguration<Topping>
    {
        public ToppingEntityConfiguration()
        {
            ToTable("Toppings");

            HasKey(topping => topping.ID);

            Property(topping => topping.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .IsRequired();

            Property(topping => topping.BasePrice)
                .HasColumnName("BasePrice")
                .IsRequired();
        }
    }
}
