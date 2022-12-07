using System;

namespace CleanArchTDC.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }

        //Definição de Comportamentos e Validações em um Modelo Rico
    }
}
