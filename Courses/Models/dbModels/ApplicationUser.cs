using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Courses.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
            Reseñas = new HashSet<Reseña>();
        }
        public string Nombre { get; set; }
        [InverseProperty(nameof(Reseña.IdUsuarioNavigation))]
        public virtual ICollection<Reseña> Reseñas { get; set; } 
    }
}
