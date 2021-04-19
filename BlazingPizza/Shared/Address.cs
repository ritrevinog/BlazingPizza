using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlazingPizza.Shared
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Quién recibirá la orden?"), MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Es necesaria Linea 1?"), MaxLength(100)]
        public string Line1 { get; set; }

        [MaxLength(100, ErrorMessage = "No exceder 100 caracteres")]
        public string Line2 { get; set; }

        [Required(ErrorMessage = "Cual es la Ciudad?"), MaxLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Cual es el nombre del Estado del Pais?"), MaxLength(20)]
        public string Region { get; set; }

        [Required(ErrorMessage = "El código postal es requerido"), MaxLength(5)]
        public string PostalCode { get; set; }

    }
}
