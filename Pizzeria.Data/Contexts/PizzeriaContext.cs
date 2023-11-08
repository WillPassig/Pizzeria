using Pizzeria.Domain.Features.Addresses;
using Pizzeria.Domain.Features.Customers;
using Pizzeria.Domain.Features.Orders;
using Pizzeria.Domain.Features.Pizzas;
using Pizzeria.Domain.Features.Toppings;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Pizzeria.Data.Contexts
{
    public class PizzeriaContext : DbContext
    {
        public PizzeriaContext() : base("Pizzeria") { }

        public PizzeriaContext(string databaseName) : base(databaseName) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                string exceptionMessage = String.Empty;
                foreach (var error in e.EntityValidationErrors)
                {
                    exceptionMessage = string.Format("Entity {0} in state {1} had the following errors:", error.Entry.Entity.GetType().Name, error.Entry.State);
                    foreach (var validationError in error.ValidationErrors)
                    {
                        exceptionMessage += string.Format("\nProperty {0} - {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                throw new Exception(exceptionMessage);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Pizza>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
