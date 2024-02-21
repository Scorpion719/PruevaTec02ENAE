using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruevaTec02ENAE.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Productos = new HashSet<Producto>();
        }

        public int CategoriaId { get; set; }
        [Required(ErrorMessage ="Campo requerido")]
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
