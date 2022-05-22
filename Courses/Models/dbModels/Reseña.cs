using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Courses.Models.dbModels
{
    public partial class Reseña
    {
        public Reseña()
        {
            Cursos = new HashSet<Curso>();
        }

        [Key]
        public int IdReseña { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(ApplicationUser.Reseñas))]
        public virtual ApplicationUser IdUsuarioNavigation { get; set; }

        [InverseProperty(nameof(Curso.ReseñasNavigation))]
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
