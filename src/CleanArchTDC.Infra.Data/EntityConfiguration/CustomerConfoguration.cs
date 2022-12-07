using CleanArchTDC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CleanArchTDC.Infra.Data.EntityConfiguration
{
    public class CustomerConfoguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasDefaultValueSql("NEWID()");
            builder.Property(p => p.Name).HasMaxLength(200).IsRequired();
            builder.Property(p => p.BirthDate).HasColumnType("Date").IsRequired();
            builder.Property(p => p.Gender).HasColumnType("Char").IsRequired();

            builder.HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Maria da Silva",
                    BirthDate = new DateTime(1955, 12, 24),
                    Gender = 'F'
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "José Luiz",
                    BirthDate = new DateTime(1983, 7, 3),
                    Gender = 'M'
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Flávia Maia",
                    BirthDate = new DateTime(2000, 2, 17),
                    Gender = 'F'
                }
            );
        }
    }
}
