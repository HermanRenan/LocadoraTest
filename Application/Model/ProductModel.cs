using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Application.Model
{
    public class ProductModel : BaseModel
    {
        [Display(Name = "Preço")]
        [Column("Price", TypeName = "decimal")]
        [Required(ErrorMessage = "Favor preencher o campo Preço")]
        public decimal Price { get; set; }
        
        [Display(Name = "Tema")]
        [Required(ErrorMessage = "Favor preencher o campo Tema")]
        public string Theme { get; set; }
        
        [Display(Name = "Data Edição")]        
        public DateTime DateEdit { get; set; }

        [Display(Name = "Data Criação")]        
        public DateTime DateCreate { get; set; }

        [Display(Name = "Data Alocação")]        
        public DateTime DateRent { get; set; }
        
        [Display(Name = "Alugado")]
        public bool Rented { get; set; }        
    }
}
