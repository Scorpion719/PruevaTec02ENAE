using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruevaTec02ENAE.Models
{
    public partial class Producto
    {
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Campo Nombre requerido")]
        [Display(Name ="Nomber Producto")]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "Campo Precio requerido")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "Campo Descripcion requerido")]
        public string? Descripcion { get; set; }
        
        public byte[]? Imagen { get; set; }
        public int? CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
