using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanArchTDC.Application.ViewModels
{
    public class CustomerViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório!")]
        [MinLength(3)]
        [MaxLength(200)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento é Obrigatória!")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório!")]
        [DisplayName("Gênero")]
        public char Gender { get; set; }
    }
}
